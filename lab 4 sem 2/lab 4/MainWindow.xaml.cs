using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string leftop = ""; // Лівий опернд
        string operation = ""; // Знак операції
        string rightop = ""; // Правий операнд
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
             void Button_Click(object sender, RoutedEventArgs e)
            {
                // Отримуємо текст кнопки
                string s = (string)((Button)e.OriginalSource).Content;
                // Додаємо його в текстове поле
                textBlock.Text += s;
                int num;
                // Конвертуємо його в число
                bool result = Int32.TryParse(s, out num);
                // Якщо текст - число
                if (result)
                {
                    // Якщо операція не задана
                    if (operation == "")
                    {
                        // Додаємо до лівого операнду
                        leftop += s;
                    }
                    else
                    {
                        // Інакше до правого операнду
                        rightop += s;
                    }
                }
                //Якщо число не було введено
                else
                {
                    // Якшо '=' то виводимо результат
                    if (s == "=")
                    {
                        Update_RightOp();
                        textBlock.Text += rightop;
                        operation = "";
                    }
                    // Якщо 'CLEAR' то очищаємо всі поля 
                    else if (s == "CLEAR")
                    {
                        leftop = "";
                        rightop = "";
                        operation = "";
                        textBlock.Text = "";
                    }
                    // Отримуємо операцію
                    else
                    {
                        //Якщо правий операнд уже присутній то присвоюємо значення лівому
                        // операнду, а правий очищуємо
                        if (rightop != "")
                        {
                            Update_RightOp();
                            leftop = rightop;
                            rightop = "";
                        }
                        operation = s;
                    }
                }
            }
            // Обновлюємо значення первого операнду
             void Update_RightOp()
            {
                int num1 = Int32.Parse(leftop);
                int num2 = Int32.Parse(rightop);
                // Виконання операції
                switch (operation)
                {
                    case "+":
                        rightop = (num1 + num2).ToString();
                        break;
                    case "-":
                        rightop = (num1 - num2).ToString();
                        break;
                    case "*":
                        rightop = (num1 * num2).ToString();
                        break;
                    case "/":
                        rightop = (num1 / num2).ToString();
                        break;
                }
            }
        }
    }
    }

