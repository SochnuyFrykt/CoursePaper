using System;
using System.IO;
using System.Windows.Forms;

namespace StrWriter
{
    public class StreamWriter1
    {

        public static void Load(DataGridView dataGridView1, string path) //Загрузка данных из файла в таблицу
        {
            string[] dataString = File.ReadAllLines(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, path));//Массив всех строк из файла
            for (int i = 0; i < dataString.Length;)
                for (int k = 0; k < dataString.Length / dataGridView1.Rows[0].Cells.Count; k++)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < dataGridView1.Rows[0].Cells.Count; j++)
                    {
                        dataGridView1.Rows[k].Cells[j].Value = dataString[i]; //Записываем данные в таблицу в цикле
                        i++;
                    }
                }
        }

        public static void Save(DataGridView dataGridView1, string path) //Сохраняет данные из таблицы в файл
        {
            //Создает файл либо перезаписывает текущий
            StreamWriter streamwriter = new StreamWriter(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, path), false);
            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                {
                    streamwriter.WriteLine(dataGridView1.Rows[j].Cells[i].Value); //Записываем данные в файл (В цикле)
                }
            }
            streamwriter.Close();
            MessageBox.Show("Файл успешно сохранен");
        }
    }
}
