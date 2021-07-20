using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMiniProj
{
    public partial class PersonForm : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonForm()
        {
            InitializeComponent();
            Adresses.DataSource = addresses;
            Adresses.DisplayMember = nameof(AddressModel.FullAddressView);
      
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addAddress_Click(object sender, EventArgs e)
        {
            // Open address entry form
    
            AddressForm entry = new AddressForm(this);
            entry.Show();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                Name = nameText.Text,
                Surname = surnameText.Text,
                Addresses = addresses.ToList()
            };
        }
    }
}
