using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylib
{
    public class ContactList
    {

        List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public List<Contact> DisplayContacts()
        {
            return contacts;
        }
        public Contact DisplayContact(string CellNo)
        {
            Contact contact = null;
            foreach (Contact c in contacts)
            {
                if (c.CellNo.Equals(CellNo))
                {
                    contact = c;
                }
            }
            return contact;
        }
        public bool EditContact(int ContactNo, string ContactName, string CellNo)
        {
            Contact contact = null;
            foreach (Contact c in contacts)
            {
                if (c.ContactNo == ContactNo)
                {
                    contact = c;
                    break;
                }
            }
            if (contact != null)
            {
                contacts.Remove(contact);
                contact.ContactNo = ContactNo;
                contact.ContactName = ContactName;
                contact.CellNo = CellNo;
                contacts.Add(contact);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
