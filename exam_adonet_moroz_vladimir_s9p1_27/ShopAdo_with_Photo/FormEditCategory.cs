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
    public partial class FormEditCategory : Form
    {
        int role;
        Category category;
        public FormEditCategory(Category category, int r)
        {
            InitializeComponent();
            role = r;
            this.category = category;
            txtCategoryName.DataBindings.Add("text", category, "CategoryName");
        }
    }
}
