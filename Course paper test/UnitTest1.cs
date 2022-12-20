using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrWriter;
using System;
using System.IO;
using System.Windows.Forms;
using Course_paper;
using System.Security.Cryptography;

namespace Course_paper_test
{
    [TestClass]
    public class StreamWriter1Test1
    {

        [TestMethod]
        public void SaveTest2()
        {
            StreamWriter filePathArrange = new StreamWriter(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Tables\\testprog.base"), false);
            StreamWriter filePathActual = new StreamWriter(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Tables\\testTest.base"), false);
            DataGridView dgv = new DataGridView();
            dgv.Columns.Add("1", "11");
            dgv.Columns.Add("2", "22");
            dgv.Columns.Add("3", "33");
            dgv.Columns.Add("4", "44");
            dgv.Columns.Add("5", "55");
            for (int i = 0; i < 5; i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < 5; j++)
                {
                    dgv.Rows[i].Cells[j].Value = i + j + 1;
                    filePathActual.WriteLine(i + j + 1);
                }
            }
            filePathArrange.Close();
            filePathActual.Close();

            StreamWriter1.Save(dgv, "Tables\\testprog.base");

            Assert.AreEqual(ComputeMD5Checksum("Tables\\testTest.base"), ComputeMD5Checksum("Tables\\testprog.base"));
        }
        [TestMethod]
        public void LoadTest2()
        {
            StreamWriter filePathArrange = new StreamWriter(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Tables\\testprog1.base"), false);
            StreamWriter filePathMedium = new StreamWriter(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Tables\\testMedium.base"), false);
            StreamWriter filePathActual = new StreamWriter(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Tables\\testTest1.base"), false);
            DataGridView dgv = new DataGridView();
            dgv.Columns.Add("1", "11");
            dgv.Columns.Add("2", "22");
            dgv.Columns.Add("3", "33");
            dgv.Columns.Add("4", "44");
            dgv.Columns.Add("5", "55");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    filePathArrange.WriteLine(i + j + 3);
                    filePathActual.WriteLine(i + j + 3);
                }
            }
            filePathArrange.Close();
            filePathMedium.Close();
            filePathActual.Close();

            StreamWriter1.Load(dgv, "Tables\\testprog1.base");
            StreamWriter1.Save(dgv, "Tables\\testMedium.base");

            Assert.AreEqual(ComputeMD5Checksum("Tables\\testTest1.base"), ComputeMD5Checksum("Tables\\testMedium.base"));
        }
        private string ComputeMD5Checksum(string path)
        {
            using (FileStream fs = File.OpenRead(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, path)))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }
        [TestMethod]
        public void SaveTest1()
        {
            DataGridView dgv = new DataGridView();
            string path = @"D:\test - Copy - Copy.base";
            dgv.Columns.Add("1", "11");
            dgv.Columns.Add("2", "22");
            dgv.Columns.Add("3", "33");
            dgv.Columns.Add("4", "44");
            dgv.Columns.Add("5", "55");
            for (int i = 0; i < 5; i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < 5; j++)
                    dgv.Rows[i].Cells[j].Value = i + j + 1;
            }
            StreamWriter1.Save(dgv, path);
            string a1 = @"D:\test.base";
            using (StreamReader sr1 = new StreamReader(a1))
            using (StreamReader sr2 = new StreamReader(path))
            {
                a1 = sr1.ReadToEnd();
                path = sr2.ReadToEnd();
            }
            Assert.AreEqual(a1, path);
        }
        [TestMethod]
        public void LoadTest1()
        {
            string path = @"D:\temp.base";
            string str1 = "", str2 = "";
            StreamWriter streamwriter = new StreamWriter(path, false);
            for (int j = 0; j < 5; j++)
                for (int i = 0; i < 5; i++)
                {
                    streamwriter.WriteLine(i + j + 1);
                    str2 += i + j + 1;
                }
            streamwriter.Close();
            DataGridView dgv = new DataGridView();
            dgv.Columns.Add("1", "11");
            dgv.Columns.Add("2", "22");
            dgv.Columns.Add("3", "33");
            dgv.Columns.Add("4", "44");
            dgv.Columns.Add("5", "55");
            StreamWriter1.Load(dgv, path);
            streamwriter.Close();
            for (int j = 0; j < dgv.Rows.Count - 1; j++)
                for (int i = 0; i < dgv.Rows[j].Cells.Count; i++)
                    str1 += dgv.Rows[j].Cells[i].Value;
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void LineFullTest()
        {
            DataGridView dgv = new DataGridView();
            dgv.Columns.Add("1", "11");
            dgv.Columns.Add("2", "22");
            dgv.Columns.Add("3", "33");
            dgv.Columns.Add("4", "44");
            dgv.Columns.Add("5", "55");
            Assert.IsFalse(SalaryCalculation.LineFull(0, dgv));
            dgv.Rows.Add();
            for (int i = 0; i < 4; i++)
            {
                dgv.Rows[0].Cells[i].Value = i;
            }
            Assert.IsTrue(SalaryCalculation.LineFull(0, dgv));
        }
        [TestMethod]
        public void ItogTest()
        {

        }
    }
}
