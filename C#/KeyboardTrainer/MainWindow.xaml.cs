using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace KeyboardTrainer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<Button, Brush> originalButtonColors = new Dictionary<Button, Brush>();
        private DateTime _sessionStartTime;
        private int _totalErrors;
        private int _totalCharacterEntered;
        public MainWindow()
        {
            InitializeComponent();
            SaveOriginalButtonColors();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            var button = KeyboardGrid.Children.Cast<Button>().FirstOrDefault(b => b.Content.ToString() == e.Key.ToString());
            if (button != null)
            {
                button.Background = Brushes.LightGreen;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            var button = KeyboardGrid.Children.Cast<Button>().FirstOrDefault(b => b.Content.ToString() == e.Key.ToString());
            if (button != null)
            {
                ResetButtonBackground(button);
            }
        }

        private string GenerateRandomString(int difficultyLevel, bool register)
        {
            int length = 10;
            string characters = "abcdefghijklmnopqrstuvwxyz";
            if (register)
            {
                characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                length = 15;
            }
            if (difficultyLevel > 1)
            {
                characters += "1234567890";
                length = 20;
            }
            if (difficultyLevel > 2)
            {
                characters += "!@#$%^&*()";
                length = 25;
            }

            var random = new Random();
            var randomString = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                randomString.Append(characters[random.Next(characters.Length)]);
            }

            return randomString.ToString();
        }

        private void SaveOriginalButtonColors()
        {
            foreach (Button button in KeyboardGrid.Children)
            {
                originalButtonColors[button] = button.Background;
            }
        }

        private void ResetButtonBackground(Button button)
        {
            if (originalButtonColors.ContainsKey(button))
            {
                button.Background = originalButtonColors[button];
            }
        }

        private void StartSession_Click(object sender, RoutedEventArgs e)
        {
            _totalErrors = 0;
            _totalCharacterEntered = 0;
            Speed.Text = $"Скорость: {_totalCharacterEntered} сим/мин";
            Fails.Text = $"Ошибки: {_totalErrors}";
            UserInput.Clear();
            UserInput.Focus();

            RandomString.Text = GenerateRandomString((int)DifficultySlider.Value, CheckBoxRegister.IsChecked ?? false);
            _sessionStartTime = DateTime.Now;
        }

        private void StopSession_Click(object sender, RoutedEventArgs e)
        {
            var timeSpan = DateTime.Now - _sessionStartTime;
            var minutes = timeSpan.TotalMinutes;
            if(minutes > 0)
            {
                var speed = _totalCharacterEntered / minutes;
                Speed.Text = $"Скорость: {speed} сим/мин";
            }
            Fails.Text = $"Ошибки: {_totalErrors}";
        }

        private void UserInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            var userInput = ((TextBox)sender).Text;
            if(!string.IsNullOrEmpty(userInput))
            {
                _totalCharacterEntered = userInput.Length;
                var errors = CalculateErrors(userInput, RandomString.Text);
                _totalErrors += errors;
                Fails.Text = $"Ошибки: {errors}";

                UpdateTypingSpeed();

                if(userInput.Equals(RandomString.Text) || userInput.Length > RandomString.Text.Length)
                {
                    RandomString.Text = GenerateRandomString((int)(DifficultySlider.Value), CheckBoxRegister.IsChecked ?? false);
                    UserInput.Clear();
                }
            }
        }
        private void UpdateTypingSpeed()
        {
            var timeSpan = DateTime.Now - _sessionStartTime;
            var minutes = timeSpan.TotalMinutes;
            if (minutes > 0)
            {
                var speed = _totalCharacterEntered / minutes;
                Speed.Text = $"Скорость: {speed:F2} сим/мин";
            }
        }
        private int CalculateErrors(string userInput, string text)
        {
            var errors = 0;
            for(int i = 0; i < userInput.Length; i++)
            {
                if(i >= text.Length || userInput[i] != text[i])
                {
                    errors++;
                }
            }
            _totalErrors = errors;
            return errors;
        }
    }
}
