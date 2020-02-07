using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.View;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;

namespace MailSender.ViewModel
{
    public class RecipientsViewViewModel : ViewModelBase
    {
        private readonly IRecipientsManager _recipientsManager;

        #region properties
        private ObservableCollection<Recipient> _recipients;

        public ObservableCollection<Recipient> Recipients
        {
            get => _recipients;
            private set => Set(ref _recipients, value);
        }

        private Recipient _selectedRecipient;

        public Recipient SelectedRecipient
        {
            get => _selectedRecipient;
            set => Set(ref _selectedRecipient, value);
        }
        #endregion

        #region commands

        public ICommand LoadRecipientsDataCommand { get; }
        #endregion

        public RecipientsViewViewModel(IRecipientsManager recipientsManager)
        {
            _recipientsManager = recipientsManager;

            LoadRecipientsDataCommand = new RelayCommand(OnLoadRecipientsDataCommandExecuted, CanLoadRecipientsDataCommandExecute);
        }

        private void OnLoadRecipientsDataCommandExecuted()
        {
            Recipients = new ObservableCollection<Recipient>(_recipientsManager.GetAll());
        }

        private bool CanLoadRecipientsDataCommandExecute()
        {
            return true;
        }
    }
}
