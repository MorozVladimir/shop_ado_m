using CodeFirstFromDatabase.BizLayer;
using CodeFirstFromDatabase.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAdo_with_Photo
{
    public partial class FormGoods : Form
    {
        int role;
        ShopAdoContext context = new ShopAdoContext();
        BindingSource bsGoods = new BindingSource();
        public FormGoods(int r)
        {
            role = r;
            InitializeComponent();
            context.Photos.Load();

            List<BizGood> collection = context.Goods.Select(g => new BizGood
            {
                GoodId = g.GoodId,
                GoodName = g.GoodName,
                CategoryName = g.Category.CategoryName,
                ManufacturerName = g.Manufacturer.ManufacturerName,
                Price = g.Price,
                GoodCount = g.GoodCount
            }).ToList();

            bsGoods.DataSource = collection;
            dgvGoods.DataSource = bsGoods;
            InitDataGridView();
        }

        void InitDataGridView()
        {
            dgvGoods.Columns["GoodId"].Visible = false;
            dgvGoods.Columns["GoodName"].HeaderText = "Наименование товара";
            dgvGoods.Columns["GoodName"].Width = 250;
            dgvGoods.Columns["CategoryName"].HeaderText = "Категория";
            dgvGoods.Columns["ManufacturerName"].HeaderText = "Производитель";
            dgvGoods.Columns["Price"].HeaderText = "Цена";
            dgvGoods.Columns["GoodCount"].HeaderText = "Количество";
        }

        private void dgvGoods_DoubleClick(object sender, EventArgs e)
        {
            if(role == 3) { MessageBox.Show("Нет доступа редактирования товаров"); return; }
            var bizgood = bsGoods.Current as BizGood;
            var good = context.Goods.Find(bizgood.GoodId);
            FormEditGood edit = new FormEditGood(good, context, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Goods.AddOrUpdate(good);
                context.SaveChanges();
            }

            List<BizGood> collection = context.Goods.Select(g => new BizGood
            {
                GoodId = g.GoodId,
                GoodName = g.GoodName,
                CategoryName = g.Category.CategoryName,
                Price = g.Price,
                GoodCount = g.GoodCount
            }).ToList();
            bsGoods.DataSource = collection;
        }

       
        private void dgvGoods_CurrentCellChanged(object sender, EventArgs e)
        {
            var bizgood = bsGoods.Current as BizGood;
            var good = context.Goods.Find(bizgood.GoodId);

            flpGoods.Controls.Clear();
            flpGoods.Update();

            var gry = context.Photos.Local.Where(g => g.GoodId == (good as Good).GoodId).ToList();
            foreach (var item in gry)
            {
                Image img = Image.FromFile(item.PhotoPath);
                PictureBox p = new PictureBox();
                p.Width = 120;
                p.Height = 100;
                p.Image = ResizeImage.FixedSize(img, p.Width, p.Height, true);
                flpGoods.Controls.Add(p);
            }
        }

        private void dgvGoods_MouseClick(object sender, MouseEventArgs e)
        {
            if (role == 3) { MessageBox.Show("Нет доступа редактирования товаров"); return; }
            var bizgood = bsGoods.Current as BizGood;
            var good = context.Goods.Find(bizgood.GoodId);
            FormEditGood edit = new FormEditGood(good, context, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Goods.AddOrUpdate(good);
                context.SaveChanges();
            }

            List<BizGood> collection = context.Goods.Select(g => new BizGood
            {
                GoodId = g.GoodId,
                GoodName = g.GoodName,
                CategoryName = g.Category.CategoryName,
                Price = g.Price,
                GoodCount = g.GoodCount
            }).ToList();
            bsGoods.DataSource = collection;
        }

        private void dgvGoods_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (role == 3) { MessageBox.Show("Нет доступа редактирования товаров"); return; }
            var bizgood = bsGoods.Current as BizGood;
            var good = context.Goods.Find(bizgood.GoodId);
            FormEditGood edit = new FormEditGood(good, context, role);
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                context.Goods.AddOrUpdate(good);
                context.SaveChanges();
            }

            List<BizGood> collection = context.Goods.Select(g => new BizGood
            {
                GoodId = g.GoodId,
                GoodName = g.GoodName,
                CategoryName = g.Category.CategoryName,
                Price = g.Price,
                GoodCount = g.GoodCount
            }).ToList();
            bsGoods.DataSource = collection;
        }
    }
}
