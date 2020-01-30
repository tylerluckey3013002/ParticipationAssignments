//Tyler Luckey
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF1
{
    class EntryForm
    {

        public string Name { get; set; }
        public string address { get; set; }
        public int ZipCode { get; set; }


        public EntryForm()
        {
            this.Name = "";
            this.Name = "";
            this.ZipCode = 0;
        }


        public EntryForm(string name, string address, int zipcode)
        {
            this.Name = name;
            this.address = address;
            this.ZipCode = zipcode;
        }

        
        public override String ToString()
        {

            return Name + " "  + address + " " + " " + ZipCode;
        }

    }
}
