using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class ContactsData
    {
        private string firstname;
        private string lastname;
        private string middlename ="";
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string home = "";
        private string mobile = "";
        private string fax = "";
        private string work = "";
        private string email = "";
        private string email2 = "";




        public ContactsData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public ContactsData(string firstname, string lastname, string middlename, string nickname,
            string title, string company, string address, string home, string mobile, string fax, string work, string email,
            string email2)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.middlename = middlename;
            this.nickname = nickname;
            this.title = title;
            this.company = company;
            this.address = address;
            this.home = home;
            this.mobile = mobile;
            this.fax = fax;
            this.work = work;
            this.email = email;
            this.email2 = email2;  
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
    }
}
