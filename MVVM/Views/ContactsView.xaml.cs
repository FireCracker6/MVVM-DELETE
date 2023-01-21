using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Commands;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.Views
{
    /// <summary>
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {

        private readonly ObservableCollection<ContactModel> _contactList;
        private List<ContactModel> contacts = new List<ContactModel>();
        private readonly FileService fileService;

        public IList<ContactModel> Customers { get; } 
        public ObservableCollection<ContactModel> Selection { get; } = new ObservableCollection<ContactModel>();

        public ContactModel SelectedCustomer { get; set; }
        private ObservableCollection<ContactModel> _persons;
        private ObservableCollection<ContactModel> _Players;
        private ContactModel _SelectedPlayer;
        public ContactModel SelectedPlayer { get; set; }
        
       

        public ContactsView()

        {
            InitializeComponent();
         

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            var button = e.OriginalSource as Button;
            var context = button?.DataContext;
           Guid context1 = (Guid)context;
           Guid contextRemove = context1;
           Debug.WriteLine(context1);
             Debug.WriteLine(context);
            foreach(ContactModel contact in contacts)
            {
                Debug.WriteLine(contact.Text);
          //  var c =  contacts.Find(x => contact.ContactId == context1);
            //    Debug.WriteLine(c);
           
            }
            var b = contacts.Find(x => x.ContactId == context1);
            Debug.WriteLine(b);
            // if (SelectedPlayer.ContactId == context1)
              //  contacts.Remove((ContactModel)contacts.Where(x => x.ContactId == context1));
            // var contactSelected = contacts.Find(x => x.ContactId == context1);
            // Debug.WriteLine(contactSelected);

            if (context != null)
              //  contacts.Remove((ContactModel)Selection.Where(x => x.ContactId == context1));
                // contacts.Remove(SelectedPlayer);
                // SelectedCustomer = null!;
                // fileService.Remove(itemRemove);
                //    Debug.WriteLine(_SelectedPlayer.Text);
                RaisePropertyChanged("Contacts");
           
           


        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }


}
