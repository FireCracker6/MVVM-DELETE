using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {

        private ContactModel _SelectedPlayer;
        [ObservableProperty]
        public RelayCommand deleteCommand;
        public ContactModel SelectedPlayer { get; set; }
        //{
        //    get
        //    {
        //        return _SelectedPlayer;
        //    }

        //    set
        //    {
        //        if (_SelectedPlayer != value)
        //        {
        //            _SelectedPlayer = value;
        //            Debug.WriteLine(_SelectedPlayer.Text);

        //        }
        //    }
        //}

        private readonly FileService fileService;



        public
            ContactsViewModel()
        {
            fileService = new FileService();
            contacts = fileService.Contacts();
            deleteCommand = new RelayCommand(Remove);
        }

        [ObservableProperty]
        private string pageTitle = "Contacts";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts;



       
        public void Remove()
        {
            Debug.WriteLine("hello");

            if (SelectedPlayer != null)
            {

               contacts.Remove(SelectedPlayer);
                SelectedPlayer = null!;
                //   OnPropertyChanged("Contacts");
                fileService.Remove(SelectedPlayer);
            }
           




        }
    }
    }
