using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Services;
using MailSender.lib.Services.Interfaces;
using MailSender.lib.Services.Interfaces.Store;
using MailSender.lib.Services.Interfaces.Store.InMemory;

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
            SimpleIoc.Default.Register<IServersManager, ServersManager>();
            SimpleIoc.Default.Register<IServersStore, ServersStoreInMemory>();
            SimpleIoc.Default.Register<ISendersManager, SendersManager>();
            SimpleIoc.Default.Register<ISendersStore, SendersStoreInMemory>();
        }

        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}