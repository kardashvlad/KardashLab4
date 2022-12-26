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
                        MessageBox.Show("����� ����� ��� ��������� �� ���� ������");
                    }
                }
                else
                {
                    MessageBox.Show("������ ����� ����� ��� ���������");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("����� �� ���� � ������� �� 1 �� ������ ���������� �����", "������� �����");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "�������");
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
                    "��������� ���� �� ���� ������ CSV � 6 ������ � ������� �����",
                    "������� �����");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "�������");
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
                MessageBox.Show(exception.Message, "�������");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "�������");
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
                    MessageBox.Show("������ ϲ� ��� ������", "������� �����");
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
                MessageBox.Show(exception.Message, "�������");
            }
        }

        private void searchConfirmButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchCriteriaTextBox2.Text))
                {
                    MessageBox.Show("������ ���� ��� ������", "������� �����");
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
                MessageBox.Show(exception.Message, "�������");
            }
        }

        private void searchConfirmButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchCriteriaTextBox3.Text))
                {
                    MessageBox.Show("������ �������� ��������� ��� ������", "������� �����");
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
                MessageBox.Show(exception.Message, "�������");
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