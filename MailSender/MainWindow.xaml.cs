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
            string password = passwordBox_OutgoingMail.Password;

            EmailSendService service = new EmailSendService(Data.SMTP_MAIL, Data.SMTP_PORT, Data.OUTGOING_MAIL, password);

            foreach (string mail in Data.Mails)
                try
                {
                    service.SendTo(mail, textBox_Text.Text, textBox_Title.Text);
                    MessageBox.Show(
                        $"Сообщение на адрес {mail} доставлено!", 
                        "Сообщение доставлено",
                        MessageBoxButton.OK, 
                        MessageBoxImage.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(
                        $"Ошибка отправления:{Environment.NewLine}\"{exc}\"", 
                        "Ошибка!", 
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
        }
    }
}
