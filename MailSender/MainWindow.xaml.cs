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
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_SendEmail_Click(object sender, RoutedEventArgs e)
        {
            // Список email'ов кому мы отправляем письмо
            List<string> listStrMails = new List<string> { "g0shafedorof@yandex.ru" };

            string strPassword = passwordBox_PasswordOwnMail.Password;

            foreach (string mail in listStrMails)
            {
                // Используем using, чтобы гарантированно удалить объект MailMessage после использования
                using (MailMessage mm = new MailMessage("goshafedorof@mail.ru", mail))
                {
                    // Формируем письмо
                    mm.Subject = "Привет из C#";        // Заголовок письма
                    mm.Body = "Hello, world!";          // Тело письма
                    mm.IsBodyHtml = false;              // Не используем html в теле письма

                    // Авторизуемся на smtp-сервере и отправляем письмо
                    // Оператор using гарантирует вызов метода Dispose, даже если при вызове
                    // методов в объекте происходит исключение.

                    using (SmtpClient sc = new SmtpClient("smtp.mail.ru", 25))
                    {
                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential("goshafedorof@mail.ru", strPassword);

                        try
                        {
                            sc.Send(mm);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" Невозможно отправить письмо " + ex.ToString());
                        }
                    }
                }
            }
            MessageBox.Show("Работа завершена.");
        }
    }
}
