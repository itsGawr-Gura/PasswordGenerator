using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PassGenerate : Form
    {
        public PassGenerate()
        {
            InitializeComponent();
        }

        private void generatePass_Click(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                MessageBox.Show("Введите логин", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Note.Clear();

                string log = login.Text;
                int lenPass = (int)passLenght.Value;
                bool remSimilary = removeSimilar.Checked;
                bool remSpecSymb = removeSpecSymb.Checked;
                string password = GeneratePassword(lenPass, remSimilary, remSpecSymb);
                Note.Text = password;
                string fileName = "Password.txt";
                SavePassword(fileName, log, password);

                MessageBox.Show("Логин и не rockyou пароль сохранены в файле 'Password.txt'.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public string GeneratePassword(int lenPass, bool remSimilary, bool remSpecSymb)
        {
            string chars = "23456789abcdefghjkmnpqrstuvwxyzABCDEFGHJKMNPQRSTUVWXYZ{}[]()/\\'\"`~,;:.<>il1Lo0O";
            if (remSpecSymb)
                chars = chars.Replace("{}[]()/\\'\"`~,;:.<>", "");

            if (remSimilary)
                chars = chars.Replace("il1Lo0O", "");

            Random random = new Random();
            char[] password = new char[lenPass];
            bool duplicate = false;
            string generatedPassword = "";
            do
            {
                for (int i = 0; i < lenPass; i++)
                {
                    password[i] = chars[random.Next(chars.Length)];
                }
                generatedPassword = new string(password);
                duplicate = IsPassDupl(generatedPassword);
            } while (duplicate);

            return generatedPassword;
        }

        private void SavePassword(string fileName, string login, string password)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"Логин: {login}");
                writer.WriteLine($"Пароль: {password}");
            }
        }
        public bool IsPassDupl(string password)
        {
            bool check = false;
            string[] files = { "rockyou_1.txt", "rockyou_2.txt", "rockyou_3.txt", "rockyou_4.txt", "rockyou_5.txt", "rockyou_6.txt" };
            foreach (string file in files)
            {


                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == password)
                        {
                            check = true;
                           break;
                        }
                       
                    }
                }

            }
            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
