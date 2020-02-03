using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        public string Name { get; set; }
        
        public string Address { get; set; }

        public int Zip { get; set; }

        public EntryForm()
        {
            Name = String.Empty;
            Address = String.Empty;
            Zip = 0;
        }
        
        public EntryForm(string name, string address, int zip)
        {
            Name = name;
            Address = address;
            zip = Zip;
        }
        
        public EntryForm(string address, int zip)
        {
            Name = string.Empty;
            Address = address;
            Zip = zip;
        }


        public override string ToString()
        {
            return $"Name: {Name} Address: {Address} Zip: {Zip}";
        }


    }
}
