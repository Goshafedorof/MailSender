using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties/_fields
        private string _title = "Рассыльщик почты";
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private readonly IRecipientsManager _recipientManager;

        private Recipient _selectedRecipient;
        public Recipient SelectedRecipient
        {
            get => _selectedRecipient;
            set => Set(ref _selectedRecipient, value);
        }

        private ObservableCollection<Recipient> _recipients;
        public ObservableCollection<Recipient> Recipients
        {
            get => _recipients;
            set => Set(ref _recipients, value);
        }

        private ObservableCollection<Server> _servers;
        public ObservableCollection<Server> Servers
        {
            get => _servers;
            set => Set(ref _servers, value);
        }

        private ObservableCollection<Sender> _senders;
        public ObservableCollection<Sender> Senders
        {
            get => _senders;
            set => Set(ref _senders, value);
        }
        #endregion

        #region Commands

        public ICommand LoadRecipientsDataCommand { get; }

        #endregion

        #region CommandsMethods
        private bool CanLoadRecipientsDataCommandExecute()
        {
            return true;
        }

        private void OnLoadRecipientsDataCommandExecuted()
        {
            Recipients = new ObservableCollection<Recipient>(_recipientManager.GetAll());
        }
        #endregion

        public MainWindowViewModel(IRecipientsManager recipientManager, IServersManager serverManager) 
        {
            _recipientManager = recipientManager;

            _servers = new ObservableCollection<Server>(serverManager.GetAll());
            _senders = new ObservableCollection<Sender>();

            #region initCommands
            LoadRecipientsDataCommand = new RelayCommand(OnLoadRecipientsDataCommandExecuted, CanLoadRecipientsDataCommandExecute);

            #endregion
        }
    }
}