using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Numerics;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
       // private readonly ObservableCollection<ContactModel> _contactList;
  
        private readonly FileService fileService;
        public ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();

        private ObservableCollection<ContactModel> _persons;

        public ObservableCollection<ContactModel> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
        private ContactModel _SelectedPlayer;
        public ContactModel SelectedPlayer
        {
            get
            {
                return _SelectedPlayer;
            }

            set
            {
                if (_SelectedPlayer != value)
                {
                    _SelectedPlayer = value;
                    Debug.WriteLine(_SelectedPlayer.Text);
                 
                }
            }
        }


        public ContactModel SelectedCustomer { get;  set; }

        [ObservableProperty]
        private ObservableObject currentViewModel;
        //[RelayCommand]
        //private void Add()
        //{
        //    var customer = new ContactModel();
        //    _contactList.Add(customer);
        //    SelectedCustomer = customer;
        //    OnPropertyChanged("Customers");
        //}
        [RelayCommand]
        private void GoToAddContact() => CurrentViewModel = new AddContactViewModel();

        [RelayCommand]
        private void GoToContacts()
        {
            CurrentViewModel = new ContactsViewModel();
        }

        
        private bool HasSelectedCustomer() => SelectedCustomer != null;

        [ObservableProperty]
        private string pageTitle = "Contacts";




        public MainViewModel()

        {
            CurrentViewModel = new ContactsViewModel();
           
        }
    


    }
}
