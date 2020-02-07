using GalaSoft.MvvmLight;
using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.ViewModel
{
    public class RecipientEditorViewModel : ViewModelBase
    {
        private Recipient _selectedRecipient;

        public Recipient SelectedRecepient
        {
            get => _selectedRecipient;
            private set => Set(ref _selectedRecipient, value);
        }

        public RecipientEditorViewModel() { }



    }
}
