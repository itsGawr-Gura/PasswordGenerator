using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generatePass_Click(object sender, EventArgs e)
        {
            if(login.Text == "")
            {
                MessageBox.Show("Введите логин","Готово", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("Логин и пароль сохранены в файле 'Password.txt'.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private string GeneratePassword(int lenPass, bool remSimilary, bool remSpecSymb)
        {
            string chars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ{}[]()/\\'\"`~,;:.<>";
            if (remSpecSymb)
                chars = chars.Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "").Replace("(", "").Replace(")", "").Replace("/", "").Replace("\\", "").Replace("'", "").Replace("\"", "").Replace("`", "").Replace("~", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace(".", "").Replace("<", "").Replace(">", "");

            if (remSimilary)
                chars = chars.Replace("i", "").Replace("l", "").Replace("1", "").Replace("L", "").Replace("o", "").Replace("0", "").Replace("O", "");

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
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine($"Логин: {login}");
                writer.WriteLine($"Пароль: {password}");
            }
        }
        private bool IsPassDupl(string password)
        {
            string[] files = { "rockyou_1.txt", "rockyou_2.txt", "rockyou_3.txt" }; 
            foreach (string file in files)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains(password))
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла {file}: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
    }
}
