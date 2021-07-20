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
    public partial class AddressForm : Form
    {
        ISaveAddress _parent;
        public AddressForm(ISaveAddress parent)
        {
        
            InitializeComponent();
            _parent = parent;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                streetName = streetNameText.Text,
                townName = townNameText.Text
            };
            _parent.SaveAddress(address);
            this.Close();
        }
    }
}
