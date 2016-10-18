using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
            GetStyle();
            ApplyAll();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Password == "")
            {
                LoginButton.Text = "Set Password";
            }
        }
        private void GetStyle()
        {
            msmMain.Theme = Properties.Settings.Default.Theme;
            msmMain.Style = Properties.Settings.Default.Style;
        }

        private void ApplyAll()
        {
            // Apply theme
            this.Theme = msmMain.Theme;
            PasswordTextBox.Theme = msmMain.Theme;
            LoginButton.Theme = msmMain.Theme;
            // Apply Style
            this.Style = msmMain.Style;
            PasswordTextBox.Style = msmMain.Style;
            LoginButton.Style = msmMain.Style;
            Refresh();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != "")
            {
                if (Properties.Settings.Default.Password == "")
                {
                    Properties.Settings.Default.Password = PasswordTextBox.Text;
                    this.DialogResult = DialogResult.OK;
                    Properties.Settings.Default.Save();
                }
                if (PasswordTextBox.Text == Properties.Settings.Default.Password)
                {
                    this.DialogResult = DialogResult.OK;
                }
                if (PasswordTextBox.Text != Properties.Settings.Default.Password)
                {
                    int width = Screen.FromControl(this).Bounds.Width;
                    int height = Screen.FromControl(this).Bounds.Height;
                    MessageBox.Show("Password Incorrect", "NotebookPlus+");
                }
            }
        }
    }
}
