using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public string UserName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CompleteBut_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Name);
            string name = NameStr.Text; 
            bool containsSpecialCharsOrDigits;

            containsSpecialCharsOrDigits = ContainsSpecialCharsOrDigits(name);
            if (containsSpecialCharsOrDigits)
            {
                NevirnoTxt.Text = "Ім'я містить цифри або спеціальні символи. Будь ласка, спробуйте ще раз.";
            }
            else
            {
                UserName = name;
                NevirnoTxt.Text = " ";
                this.Hide();
                Test test = new Test(UserName);
                test.Show();
            }
        }
        static bool ContainsSpecialCharsOrDigits(string input)
        {
            string pattern = @"[0-9!@#$%^&*]|[\(\)_]";
            return Regex.IsMatch(input, pattern);
        }

    }
}
