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
    public partial class FormMain : Form
    {
        int role;
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(int r)
        {
            InitializeComponent();
            role = r;
            switch (role)
            {
                case 1:
                    this.lblStatus.Text = "Вы вошли с учётной записью администратора, которая допускае просмотр и редактирование товаров, категориий, производителей";
                    break;
                case 2:
                    this.lblStatus.Text = "Вы вошли с учётной записью модератора, которая допускает просмотр товаров, категорий, производителей и редактирование товаров";
                    break;
                case 3:
                    this.lblStatus.Text = "Вы вошли с учётной записью менеджера, которая допускае только просмотр товаров";
                    this.categoriesToolStripMenuItem.Visible = false;
                    this.manufacturerToolStripMenuItem.Visible = false;
                    break;
                default:
                    this.lblStatus.Text = "Учётная запись не определена " + role;
                    break;
            }
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoods frmGoods = new FormGoods(role);
            frmGoods.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategories frmCategories = new FormCategories(role);
            frmCategories.ShowDialog();
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManufacturer frmManufacturers = new FormManufacturer(role);
            frmManufacturers.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
