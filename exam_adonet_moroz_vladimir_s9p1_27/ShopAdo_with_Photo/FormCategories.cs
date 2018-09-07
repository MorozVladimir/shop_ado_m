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
    public partial class FormCategories : Form
    {
        int role;
        ShopAdoContext context = new ShopAdoContext();
        BindingSource bsCategories = new BindingSource();
        public FormCategories(int r)
        {
            role = r;
            InitializeComponent();
            List<BizCategory> collection = context.Categories.Select(c => new BizCategory
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName
            }).ToList();
            bsCategories.DataSource = collection;
            dgvCategories.DataSource = bsCategories;
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dgvCategories.Columns["CategoryId"].Visible = false;
            dgvCategories.Columns["CategoryName"].HeaderText = "Категория товара";
            dgvCategories.Columns["CategoryName"].Width = 200;
        }

        private void dgvCategories_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (role == 2) { MessageBox.Show("Нет доступа редактирования категорий"); return; }
            var bizcategory = bsCategories.Current as BizCategory;
            var category = context.Categories.Find(bizcategory.CategoryId);
            FormEditCategory edit = new FormEditCategory(category, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Categories.AddOrUpdate(category);
                context.SaveChanges();
            }
        }

        private void dgvCategories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (role == 2) { MessageBox.Show("Нет доступа редактирования категорий"); return; }
            var bizcategory = bsCategories.Current as BizCategory;
            var category = context.Categories.Find(bizcategory.CategoryId);
            FormEditCategory edit = new FormEditCategory(category, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Categories.AddOrUpdate(category);
                context.SaveChanges();
            }
        }

        private void dgvCategories_MouseClick(object sender, MouseEventArgs e)
        {
            if (role == 2) { MessageBox.Show("Нет доступа редактирования категорий"); return; }
            var bizcategory = bsCategories.Current as BizCategory;
            var category = context.Categories.Find(bizcategory.CategoryId);
            FormEditCategory edit = new FormEditCategory(category, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Categories.AddOrUpdate(category);
                context.SaveChanges();
            }

        }
    }
}
