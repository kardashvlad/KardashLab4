using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KardashLab4
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        void CheckInput()
        {
            if (
                string.IsNullOrWhiteSpace(PipTextBox.Text) ||
                string.IsNullOrWhiteSpace(AgeTextBox.Text) ||
                string.IsNullOrWhiteSpace(RoleTextBox.Text) ||
                string.IsNullOrWhiteSpace(ThemeTextBox.Text) ||
                string.IsNullOrWhiteSpace(WorkTimeTextbox.Text) ||
                string.IsNullOrWhiteSpace(PerformanceTextbox.Text) ||
                string.IsNullOrWhiteSpace(MaterialsTextBox.Text)
                )
            {
                throw new Exception("Всі поля мають бути заповнені");
            }
            if (
                PipTextBox.Text.Contains(',') ||
                AgeTextBox.Text.Contains(',') ||
                RoleTextBox.Text.Contains(',') ||
                ThemeTextBox.Text.Contains(',') ||
                WorkTimeTextbox.Text.Contains(',') ||
                PerformanceTextbox.Text.Contains(',') ||
                MaterialsTextBox.Text.Contains(',')
                )
            {
                throw new Exception("Не використовуйте кому");
            }
        }
        private void AddConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();
                Member member = new
                    (
                    new MemberInfo(
                        PipTextBox.Text,
                        AgeTextBox.Text,
                        RoleTextBox.Text
                    ),
                    ThemeTextBox.Text,
                    WorkTimeTextbox.Text,
                    PerformanceTextbox.Text,
                    MaterialsTextBox.Text
                    );
                Table.AddRow(member.GetStringData());
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка вводу");
            }
        }

        private void AddCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
