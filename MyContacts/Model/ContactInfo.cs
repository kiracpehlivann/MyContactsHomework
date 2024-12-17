using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Model
{
    public class ContactInfo
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
