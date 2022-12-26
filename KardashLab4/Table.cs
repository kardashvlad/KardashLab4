using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardashLab4
{
    internal class Table
    {
        public static void FilterByCell(string searchCriteria, int cellNumber)
        {
            filteredTableData = (
                from memberData in tableData
                where memberData[cellNumber] == searchCriteria
                select memberData
                ).ToList();
        }

        public static void PrintTable()
        {
            dataGridView.Rows.Clear();

            foreach (List<string> memberData in tableData)
            {
                Member member = new(memberData.ToList());
                dataGridView.Rows.Add(member.GetStringData());
            }
        }
        public static void PrintTableFiltered()
        {
            dataGridView.Rows.Clear();

            foreach (List<string> memberData in filteredTableData)
            {
                Member member = new(memberData.ToList());
                dataGridView.Rows.Add(member.GetStringData());
            }
        }
        public static void ImportFromCSV()
        {
            foreach (string line in File.ReadLines(IMPORT_PATH))
            {
                string[] memberData = line.Split(",");
                if (memberData.Length != dataGridView.ColumnCount)
                {
                    throw new ArgumentOutOfRangeException(memberData.Length.ToString());
                }
                tableData.Add(memberData.ToList());
                Member member = new(memberData.ToList());
                dataGridView.Rows.Add(member.GetStringData());
            }
            MessageBox.Show("Імпортовано");
        }

        public static async void ExportToCSV()
        {
            List<string> strings = new();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool rowIsEmpty = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        rowIsEmpty = true;
                        break;
                    }
                }
                if (!rowIsEmpty)
                {
                    var memberData =
                        row.Cells[0].Value + "," +
                        row.Cells[1].Value + "," +
                        row.Cells[2].Value + "," +
                        row.Cells[3].Value + "," +
                        row.Cells[4].Value + "," +
                        row.Cells[5].Value + "," +
                        row.Cells[6].Value;
                    strings.Add(memberData);
                }
            }
            await File.WriteAllLinesAsync(EXPORT_PATH, strings);
            MessageBox.Show("Експортовано у файл output.txt");
        }

        public static async void ImportFromJson()
        {
            var members = await Helper.Deserialize(DESERIALIZE_PATH);
            if (members != null)
            {
                foreach (var member in members)
                {
                    dataGridView.Rows.Add(member.GetStringData());
                    tableData.Add(member.GetStringData().ToList());
                }
                MessageBox.Show("Десеріалізовано");
            }
            else
            {
                MessageBox.Show("Файл не знайдено", "Помилка");
            }
        }

        public static async void ExportToJson()
        {
            List<string> jsonMembers = new();
            jsonMembers.Add("[");
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool rowIsEmpty = true;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        rowIsEmpty = false;
                        break;
                    }
                }

                if (!rowIsEmpty)
                {
                    Member member = new(row);

                    string jsonMember = Helper.Serialize(member);
                    jsonMembers.Add(jsonMember);
                    jsonMembers.Add(",");
                }
            }
            jsonMembers.RemoveAt(jsonMembers.Count - 1);
            jsonMembers.Add("]");

            await File.WriteAllLinesAsync(SERIALIZE_PATH, jsonMembers, Encoding.UTF8);
            MessageBox.Show("Серіалізовано у файл output.json");
        }
        public static void AddRow(string[] row)
        {
            dataGridView.Rows.Add(row);
            tableData.Add(row.ToList());
        }

        public static void DeleteRow(int rowNumber)
        {
            dataGridView.Rows.RemoveAt(rowNumber);
            tableData.RemoveAt(rowNumber);
        }
        public static void SetupDataGridView(DataGridView dataGrid)
        {
            dataGridView = dataGrid;

            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "ПІП";
            dataGridView.Columns[1].Name = "Вік";
            dataGridView.Columns[2].Name = "Посада";
            dataGridView.Columns[3].Name = "Тема";
            dataGridView.Columns[4].Name = "Робочий час";
            dataGridView.Columns[5].Name = "Виконання завдань";
            dataGridView.Columns[6].Name = "Інформаційні матеріали";
        }

        private static readonly List<List<string>> tableData = new();
        private static List<List<string>> filteredTableData = new();
        private static DataGridView dataGridView = new();

        private const string IMPORT_PATH = @".\input.txt";
        private const string EXPORT_PATH = @".\output.txt";
        private const string DESERIALIZE_PATH = @".\input.json";
        private const string SERIALIZE_PATH = @".\output.json";
    }
}
