﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Course_paper.DocsFolder
{
	internal class GenerateFileAcceptanceEmployee
	{
		private FileInfo fileInfo;

		public GenerateFileAcceptanceEmployee(string fileName)
		{
			if (File.Exists(fileName))
			{
				fileInfo = new FileInfo(fileName);
			}
			else throw new Exception("Файл не найден");
		}

		internal bool Process(Dictionary<string, string> items)
		{
			Word.Application app = null;
			try
			{
				app = new Word.Application();
				Object file = fileInfo.FullName;
				Object missing = Type.Missing;
				app.Documents.Open(file);
				foreach (var item in items)
				{
					Word.Find find = app.Selection.Find;
					find.Text = item.Key;
					find.Replacement.Text = item.Value;

					Object wrap = Word.WdFindWrap.wdFindContinue;
					Object replace = Word.WdReplace.wdReplaceAll;

					find.Execute(FindText: Type.Missing,
						MatchCase: false,
						MatchWholeWord: false,
						MatchWildcards: false,
						MatchSoundsLike: false,
						MatchAllWordForms: false,
						Forward: true,
						Wrap: wrap,
						Format: false,
						ReplaceWith: missing,
						Replace: replace);
				}
				Object newFileName = Path.Combine(fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss") + fileInfo.Name);
				app.ActiveDocument.SaveAs2(newFileName);
				app.ActiveDocument.Close();
				app.Quit();
				return true;
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
			finally
			{
				if (app != null)
					app.Quit();
			}
			return false;
		}
	}
}
