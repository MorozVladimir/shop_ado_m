using CodeFirstFromDatabase.BizLayer;
using CodeFirstFromDatabase.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAdo_with_Photo
{
    public partial class FormManufacturer : Form
    {
        int role;
        ShopAdoContext context = new ShopAdoContext();
        BindingSource bsManufacturers = new BindingSource();
        public FormManufacturer(int r)
        {
            role = r;
            InitializeComponent();
            List<BizManufacturer> collection = context.Manufacturers.Select( m => new BizManufacturer
            {
                ManufacturerId = m.ManufacturerId,
                ManufacturerName = m.ManufacturerName
            }).ToList();

            bsManufacturers.DataSource = collection;
            dgvManufacturer.DataSource = bsManufacturers;
            InitDataGridView();
        }

        void InitDataGridView()
        { 
            dgvManufacturer.Columns["ManufacturerId"].Visible = false;
            dgvManufacturer.Columns["ManufacturerName"].HeaderText = "Производитель";
            dgvManufacturer.Columns["ManufacturerName"].Width = 200;
        }

        private void dgvManufacturer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (role == 2) { MessageBox.Show("Нет доступа редактирования производителей"); return; }
            var bizmanufacturer = bsManufacturers.Current as BizManufacturer;
            var manufacturer = context.Manufacturers.Find(bizmanufacturer.ManufacturerId);
            FormEditManufacturer edit = new FormEditManufacturer(manufacturer, role);
            DialogResult dr = edit.ShowDialog();
            if(dr == DialogResult.OK)
            {
                context.Manufacturers.AddOrUpdate(manufacturer);
                context.SaveChanges();
            }
        }

        private void dgvManufacturer_MouseClick(object sender, MouseEventArgs e)
        {
            if (role == 2) { MessageBox.Show("Нет доступа редактирования производителей"); return; }
            var bizmanufacturer = bsManufacturers.Current as BizManufacturer;
            var manufacturer = context.Manufacturers.Find(bizmanufacturer.ManufacturerId);
            FormEditManufacturer edit = new FormEditManufacturer(manufacturer, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Manufacturers.AddOrUpdate(manufacturer);
                context.SaveChanges();
            }
        }

        private void dgvManufacturer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (role == 2) { MessageBox.Show("Нет доступа редактирования производителей"); return; }
            var bizmanufacturer = bsManufacturers.Current as BizManufacturer;
            var manufacturer = context.Manufacturers.Find(bizmanufacturer.ManufacturerId);
            FormEditManufacturer edit = new FormEditManufacturer(manufacturer, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Manufacturers.AddOrUpdate(manufacturer);
                context.SaveChanges();
            }
        }
    }
}
