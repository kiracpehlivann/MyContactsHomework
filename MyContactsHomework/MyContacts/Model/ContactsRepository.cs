using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Model
{
    public class ContactsRepository
    {
         static List<ContactInfo> contacts = new List<ContactInfo>() { 
                    new ContactInfo {Id=1, NameSurname="Hüseyin Şimşek", Email="huseyinsimsek@gmail", PhoneNumber="053357252"}
                    };
        static int maxId = 2;
        public ContactsRepository()
        {
            
        }

        public ObservableCollection<ContactInfo> GetContacts() {
            return new ObservableCollection<ContactInfo>( contacts);

        }

        public void AddContact(ContactInfo contact)
        {
            contact.Id = maxId++;
            contacts.Add(contact);
        }

        public ContactInfo GetContact(int id)
        {
            return contacts.FirstOrDefault( c => c.Id==id ) ;
        }

        public void UpdateContact(ContactInfo updatedContact)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == updatedContact.Id);
            if (contact != null)
            {
                contact.NameSurname = updatedContact = updatedContact.NameSurname;
                contact.PhoneNumber = updatedContact.PhoneNumber;
                contact.Email = updatedContact.Email;
            }
        }

    }
}
