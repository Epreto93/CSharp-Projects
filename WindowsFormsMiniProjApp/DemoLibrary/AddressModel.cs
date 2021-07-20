using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string streetName { get; set; }
        public string townName { get; set; }

        public string FullAddressView => $"{streetName}  {townName}";



    }
}
