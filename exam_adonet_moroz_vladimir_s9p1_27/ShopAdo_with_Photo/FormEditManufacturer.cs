using CodeFirstFromDatabase.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAdo_with_Photo
{
    public partial class FormEditManufacturer : Form
    {
        int role;
        Manufacturer manufacturer;
        public FormEditManufacturer(Manufacturer manufacturer, int r)
        {
            InitializeComponent();
            role = r;
            this.manufacturer = manufacturer;
            txtManufacturerName.DataBindings.Add("Text", manufacturer, "ManufacturerName");
        }
    }
}
