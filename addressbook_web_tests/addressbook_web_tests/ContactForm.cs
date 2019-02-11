using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    public class ContactForm
    {
        private string firstnameput;
        private string lastnameput = "";



        public ContactForm(string firstnameput)
        {
            this.firstnameput = firstnameput;
        }

               
        public string Firstnameput
        {
            get
            {
                return firstnameput;
            }
            set
            {
                firstnameput = value;
            }
        }

        public string Lastnameput
        {
            get
            {
                return lastnameput;
            }
            set
            {
                lastnameput = value;
            }
        }      
    }
}
