using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<AddressModel> Addresses { get; set; }
    }
}
