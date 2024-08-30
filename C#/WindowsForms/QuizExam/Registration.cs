using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Web;
using System.IO;

namespace QuizExam
{
    public partial class Registration : Form
    {
        private string filePath = "D:\\VS Studio\\QuizExam\\QuizFolder\\users.json";
        public Registration()
        {
            InitializeComponent();
        }
        
        private void BAccept_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath) || File.ReadAllText(filePath) == string.Empty){
                File.WriteAllText(filePath, "[]");
            }
            if (TBLogin.Text.Length == 0 || TBLogin.Text.Length <= 3)
            {
                LLoginError.Text = "Поле логина пустое/меньше 3х символов";
                LLoginError.ForeColor = Color.Red;
            }
            else if (TBPassword.Text.Length == 0 || TBPassword.Text.Length <= 3)
            {
                LPassError.Text = "Поле пароля пустое/меньше 3х символов";
                LPassError.ForeColor = Color.Red;
            }
            else if (IsUsernameExists(TBLogin.Text))
            {
                LLoginError.Text = "Такой логин уже существует";
                LLoginError.ForeColor = Color.Red;
            }else if(DateTimePick.Value >= DateTime.Now)
            {
                LDateError.Text = "Некорректно выставлена дата рождения";
                LDateError.ForeColor = Color.Red;
            }
            else
            {
                string username = TBLogin.Text;
                string password = TBPassword.Text;
                DateTime birthday = DateTimePick.Value;

                string salt = GenerateSalt();
                string passwordHash = HashPassword(password, salt);

                User newUser = new User()
                {
                    Username = username,
                    PasswordHash = passwordHash,
                    Salt = salt,
                    Birthday = birthday,
                    IsAdmin = false
                };

                List<User> users = LoadUsers();
                users.Add(newUser);
                SaveUsers(users);

                MessageBox.Show("Регистрация прошла успешно.");
                PersonalAcc personalAcc = new PersonalAcc(newUser.Username, newUser.IsAdmin);
                personalAcc.Show();
                Close();

            }
        }
        // Метод проверки занятости логина
        private bool IsUsernameExists(string username)
        {
            List<User> users = LoadUsers();
            return users.Any(user => user.Username == username);
        }
        // Метод для генерации соли
        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Метод для хеширования пароля
        private string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                // Соединяем пароль и соль, затем хешируем
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);

                // Возвращаем хеш в виде строки
                return Convert.ToBase64String(hashBytes);
            }
        }
        // Метод для загрузки списка пользователей из файла JSON
        private List<User> LoadUsers()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            return new List<User>();
        }

        // Метод для сохранения списка пользователей в файл JSON
        private void SaveUsers(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }
    }
}
