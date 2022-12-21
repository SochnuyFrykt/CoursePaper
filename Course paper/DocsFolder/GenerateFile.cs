using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Course_paper.DocsFolder
{

	public class GenerateFile
	{
		public FileInfo fileInfo { get; set; }

		//Запускает процесс формирования документа при нажатии кнопки
		public static void Generate(Button generateButton, string path, Dictionary<string, string> dictionary)
		{
			generateButton.Click += (s, n) =>
			{
				var generate = new GenerateFile(path);
				generate.Process(dictionary);
			};
		}

		public GenerateFile() { }

		//Конструктор
		public GenerateFile(string fileName)
		{
			if (File.Exists(fileName))
				fileInfo = new FileInfo(fileName); //Если файл найден
			else throw new Exception("Файл не найден"); //Выводит ошибку при не нахождении файла
		}

		//Замена атрибутов в файле и создание нового файла 
		public bool Process(Dictionary<string, string> items)
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
				var newFilePath = @"C:\Users\sereb\OneDrive\Рабочий стол\Курсовая работа по ПИ\CoursePaper\Course paper\DocsFolder\DocsTemplate\Generated Documents";
				var fileName = CreateNewNameFile(DateTime.Now.ToString("yyyy MM dd HH:mm:ss"), fileInfo.Name);
				CreateNewFile(app, newFilePath, fileName);
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

		public bool CreateNewFile(Word.Application app, string newFilePath, string fileName)
		{
			if (newFilePath != "" & fileName != "")
			{
				Object newFileName = Path.Combine(newFilePath, fileName);
				app.ActiveDocument.SaveAs2(newFileName);
				app.ActiveDocument.Close();
				return true;
			}
			else return false;
		}

		public string CreateNewNameFile(string first, string second)
		{
			return first + second;
		}
	}
}
