using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
        }
       




        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateName()
        {
            FIO FIO = new FIO();



            string firstName = "";
            string lastName = "";
            string otchestvo = "";

            if (checkBox2.Checked == true)
            {
              

                string maleName = FIO.GenMName();
                string maleSur = FIO.GenMSur();
                string maleNOtch = FIO.GenMSur();

                textBox1.Text = maleName;
                textBox5.Text = maleSur;
                textBox4.Text = maleNOtch;

            }
            else if (checkBox1.Checked == true)
            {
               

                string femaName = FIO.GenFName();
                string femaSur = FIO.GenFSur();
                string femaNOtch = FIO.GenFSur();

                textBox1.Text = femaName;
                textBox5.Text = femaSur;
                textBox4.Text = femaNOtch;
            }
            else
            {
                MessageBox.Show("Вам нужно выбрать пол");

            }

        }
            private void button1_Click(object sender, EventArgs e)
        {
            
            UpdateName();
            Random random = new Random();
            int minLoginLength = 6;
            int maxLoginLength = 12;
            
            // Диапазон длины пароля
            int minPasswordLength = 10;
            int maxPasswordLength = 20;



            string loginCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int loginLength = random.Next(minLoginLength, maxLoginLength + 1); // Длина логина в указанном диапазоне
            string generatedLogin = "";
            for (int i = 0; i < loginLength; i++)
            {
                int randomIndex1 = random.Next(loginCharacters.Length);
                char randomlog = loginCharacters[randomIndex1];
                generatedLogin += randomlog;
            }

            // Генерация пароля
            string passwordCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789=+-_)(}{[]!@#$*?/.";
            int passwordLength = random.Next(minPasswordLength, maxPasswordLength + 1); // Длина пароля в указанном диапазоне
            string generatedPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomIndex2 = random.Next(passwordCharacters.Length);
                char randomCharacter = passwordCharacters[randomIndex2];
                generatedPassword += randomCharacter;
            }


            if (checkBox2.Checked == true)
            {
                textBox3.Text = generatedLogin;
            textBox2.Text = generatedPassword;
            }
            else if (checkBox1.Checked == true)
            {
                textBox3.Text = generatedLogin;
                textBox2.Text = generatedPassword;
            }
        }
          

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
       
        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }

}
