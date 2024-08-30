using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizExam
{
    public partial class Login : Form
    {
        private string filePath = "D:\\VS Studio\\QuizExam\\QuizFolder\\users.json";

        public Login()
        {
            InitializeComponent();
        }
        private void BAccept_Click(object sender, EventArgs e)
        {
            string enteredUsername = TBLogin.Text;
            string enteredPassword = TBPassword.Text;

            List<User> users = LoadUsers();

            // Проверка существования пользователя с введенным логином
            if (IsUsernameExists(enteredUsername))
            {
                // Получение пользователя из списка
                User user = users.First(u => u.Username == enteredUsername);

                // Хеширование введенного пароля с использованием соли из базы данных
                string enteredPasswordHash = HashPassword(enteredPassword, user.Salt);

                // Сравнение хешей паролей
                if (enteredPasswordHash == user.PasswordHash)
                {
                   PersonalAcc personalAcc = new PersonalAcc(user.Username, user.IsAdmin);
                    personalAcc.Show();
                    Close();
                }
                else
                {
                    LErrorPassword.Text = "Неверный пароль";
                    LErrorPassword.ForeColor = Color.Red;
                }
            }
            else
            {
                LErrorLogin.Text = "Пользователь с таким логином не найден.";
                LErrorLogin.ForeColor = Color.Red;
            }
        }

        private bool IsUsernameExists(string username)
        {
            List<User> users = LoadUsers();
            return users.Any(user => user.Username == username);
        }

        private List<User> LoadUsers()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            return new List<User>();
        }

        private string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        private void BExit_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }
    }
}
