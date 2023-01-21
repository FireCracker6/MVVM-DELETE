using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;

namespace WPF_APP_CONTACTS_MVVM.Services
{
    public class FileService
    {


        public FileService()

        {
            ReadFromFile();
        }

        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contacts.json";
        private List<ContactModel> contacts;
      

        private void ReadFromFile()
        {
            try
            {

                using var sr = new StreamReader(filePath);
                contacts = JsonConvert.DeserializeObject<List<ContactModel>>(sr.ReadToEnd())!;
            }
            catch { contacts = new List<ContactModel>(); }
        }

        private void SaveToFile()
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(JsonConvert.SerializeObject(contacts));


        }

        public void AddToList(ContactModel contact)
        {


            contacts.Add(contact);
            SaveToFile();



        }
        public void Remove(ContactModel contact)
        {

           // var itemRemove = contacts.Where(item => contact.ContactId == contextRemove).First();
            contacts.Remove(contact);
            SaveToFile();


        }



        public ObservableCollection<ContactModel> Contacts()
        {
            var items = new ObservableCollection<ContactModel>();
            foreach (var contact in contacts)
            {
                items.Add(contact);
            }
            return items;
        }
    }
}
