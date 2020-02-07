using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using MailSender.lib.Services.Interfaces;
using MailSender.lib.Services;

namespace MailSender.ViewModel
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // регистрация ViewModel
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<RecipientsViewViewModel>();
            SimpleIoc.Default.Register<RecipientEditorViewModel>();

            SimpleIoc.Default.Register<IRecipientsManager, RecipientsManager>();
            SimpleIoc.Default.Register<IRecipientsStore, RecipientsStoreInMemory>();
        }

        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();
        public RecipientsViewViewModel RecipientsViewModel => ServiceLocator.Current.GetInstance<RecipientsViewViewModel>();
        public RecipientEditorViewModel RecipientsEditorModel => ServiceLocator.Current.GetInstance<RecipientEditorViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}