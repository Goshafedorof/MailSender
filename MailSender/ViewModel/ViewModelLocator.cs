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

            SimpleIoc.Default.Register<IRecipientsManager, RecipientsManager>();
            SimpleIoc.Default.Register<IRecipientsStore, RecipientsStoreInMemory>();
        }

        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}