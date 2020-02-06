using GalaSoft.MvvmLight;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() { }

        private string _title = "Рассыльщик почты";

        public string Title
        { 
            get => _title;
            set => Set(ref _title, value);
        }
    }
}