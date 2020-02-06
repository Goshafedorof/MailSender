using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;

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
        }

        public MainWindowViewModel MainWindow => ServiceLocator.Current.GetInstance<MainWindowViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}