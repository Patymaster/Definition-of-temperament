using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApp1
{
    public partial class Test : Form
    {
        public Test(string userName)
        {
            InitializeComponent();
            HideElements();
            name = userName;
        }
        // Підтягуємо масив з запитаннями з класу Questions
        string[] questions = Questions.questions;

        int answer = 5;
        // Створюємо масив для зберігання відповідей користувача
        int[] answers = new int[60];
        int j;
        string name;
        // Кнопка "так"
        private void Yes_Click(object sender, EventArgs e)
        {
            answer = 1;
            Logic();
        }
        // Кнопка "ні"
        private void No_Click(object sender, EventArgs e)
        {
            answer = 2;
            Logic();
        }
        private void Logic()
        {
            answers[j] = answer;
            if (j >= questions.Length-1)
            {
                Calculate();
                Ques.Text = "Вітаємо, " + name;
                Yes.Hide();
                No.Hide();
                ShowElements();
            }
            else
            {
                j++;
                if (j < questions.Length)
                {
                    Question.Text = (questions[j]);
                    Ques.Text = "Питання: "+ (j+1) +"/"+ questions.Length;
                }
            }
        }
        private void Calculate()
        {
            // Задаємо список з номерами запитань, на які потрібно відповісти "так" по шкалі екстраверсії
            int[] yesExtra = new int[] { 1, 3, 9, 11, 14, 17, 19, 22, 25, 27, 30, 35, 38, 41, 43, 46, 49, 53, 57 };
            // Задаємо список з номерами запитань, на які потрібно відповісти "ні" по шкалі екстраверсії
            int[] noExtra = new int[] { 6, 33, 51, 55, 59 };
            // Задаємо список з номерами запитань, на які потрібно відповісти "ні" по шкалі невротизму
            int[] noNevro = new int[] { 2, 5, 7, 10, 13, 15, 18, 21, 23, 26, 29, 31, 34, 37, 39, 42, 45, 47, 50, 52, 54, 56, 58, 60 };
            // Задаємо список з номерами запитань, на які потрібно відповісти "так" по шкалі правдивості
            int[] honestyYes = new int[] { 8, 16, 24, 28, 36, 44 };
            // Задаємо список з номерами запитань, на які потрібно відповісти "ні" по шкалі правдивості
            int[] honestyNo = new int[] { 4, 12, 20, 32, 40, 48 };

            int extraversionScore = 0; //лічильник ектраверсії
            int honestyScore = 0; // лічильник чесності
            int neuroticismScore = 0; // лічильник невротизму
            // Перевіряємо відповіді користувача
            for (int i = 0; i < questions.Length; i++)
            {
                // Якщо номер запитання збігається з номером запитання, на яке потрібно відповісти "так", і користувач відповів "так", то додаємо 1 бал
                if (yesExtra.Contains(i + 1) && answers[i] == 1)
                    extraversionScore++;
                if (honestyYes.Contains(i + 1) && answers[i] == 1)
                    honestyScore++;
                // Якщо номер запитання збігається з номером запитання, на яке потрібно відповісти "ні", і користувач відповів "ні", то додаємо 1 бал
                if (noExtra.Contains(i + 1) && answers[i] == 2)
                    extraversionScore++;
                if (noNevro.Contains(i + 1) && answers[i] == 2)
                    neuroticismScore++;
                if (honestyNo.Contains(i + 1) && answers[i] == 2)
                    honestyScore++;
            }
            // Визначення типів темпераменту та вивід користувачу
            if (extraversionScore < 12 && neuroticismScore <= 14)
                Temp.Text = Temperaments.Flegmatik;
            else if (extraversionScore >= 12 && neuroticismScore <= 14)
                Temp.Text = Temperaments.Sangvinik;
            else if (extraversionScore < 12 && neuroticismScore > 14)
                Temp.Text = Temperaments.Melanholik;
            else if (extraversionScore >= 12 && neuroticismScore > 14)
                Temp.Text = Temperaments.Holerik;
            // визначення правдивості
            if (honestyScore < 4) HonestyTxt.Text = ("Рівень правдивості - правдивий");
            if (honestyScore >= 4 && honestyScore < 6) HonestyTxt.Text = ("Рівень правдивості - сумнівний");
            if (honestyScore > 5) HonestyTxt.Text = ("Рівень правдивості - не доствірний, рекомендуємо пройти тест знову!");
        }
        // Приховати/відкрити елемети вікна
        void HideElements()
        {
            Temp.Hide();
            HonestyTxt.Hide();
            Retry.Hide();
            Exit.Hide();
        }
        void ShowElements()
        {
            Temp.Show();
            Exit.Show();
            Retry.Show();
            HonestyTxt.Show();
        }
        //Закрити вікно
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        //Заново пройти тест
        private void Retry_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        //Можливість рухати вікно
        Point lastPoint;
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
