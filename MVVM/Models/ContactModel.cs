using System;
using System.Collections;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Commands;

namespace WPF_APP_CONTACTS_MVVM.MVVM.Models
{
    public partial class ContactModel 
    {

       


       
       
        public Guid ContactId { get; set; } = Guid.NewGuid();
        public string Text { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;

        
    }
}
