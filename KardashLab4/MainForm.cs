namespace KardashLab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Table.SetupDataGridView(mainDataGridView);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new();
            inputForm.ShowDialog();
        }

        private void deleteConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(deleteNumberTextBox.Text))
                {
                    if (int.TryParse(deleteNumberTextBox.Text, out int index))
                    {
                        Table.DeleteRow(index - 1);
                    }
                    else
                    {
                        MessageBox.Show("Номер рядка для видалення має бути числом");
                    }
                }
                else
                {
                    MessageBox.Show("Введіть номер рядка для видалення");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Число має бути у проміжку від 1 до номера останнього рядка", "Помилка вводу");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка");
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                Table.ImportFromCSV();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("" +
                    "Текстовий файл має мати формат CSV з 6 комами у кожному рядку",
                    "Помилка вводу");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка");
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                Table.ExportToCSV();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show(exception.Message, "Помилка");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка");
            }
        }

        private void deserializeButton_Click(object sender, EventArgs e)
        {
            Table.ImportFromJson();
        }

        private void serializeButton_Click(object sender, EventArgs e)
        {
            Table.ExportToJson();
        }

        private void searchConfirmButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchCriteriaTextBox1.Text))
                {
                    MessageBox.Show("Введіть ПІП для пошуку", "Помилка вводу");
                }
                else
                {
                    string searchCriteria = searchCriteriaTextBox1.Text;

                    Table.FilterByCell(searchCriteria, 0);
                    Table.PrintTableFiltered();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка");
            }
        }

        private void searchConfirmButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchCriteriaTextBox2.Text))
                {
                    MessageBox.Show("Введіть тему для пошуку", "Помилка вводу");
                }
                else
                {
                    string searchCriteria = searchCriteriaTextBox2.Text;

                    Table.FilterByCell(searchCriteria, 3);
                    Table.PrintTableFiltered();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка");
            }
        }

        private void searchConfirmButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchCriteriaTextBox3.Text))
                {
                    MessageBox.Show("Введіть успішність виконання для пошуку", "Помилка вводу");
                }
                else
                {
                    string searchCriteria = searchCriteriaTextBox3.Text;

                    Table.FilterByCell(searchCriteria, 5);
                    Table.PrintTableFiltered();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка");
            }
        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            Table.PrintTable();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new();
            infoForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}