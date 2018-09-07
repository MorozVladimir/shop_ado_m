using CodeFirstFromDatabase.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAdo_with_Photo
{
    public partial class FormEditGood : Form
    {
        int role;
        Good good;
        ShopAdoContext context;
        public FormEditGood(Good good, ShopAdoContext context, int r)
        {
            InitializeComponent();
            role = r;
            this.good = good;
            this.context = context;
            txtGoodName.DataBindings.Add("Text", good, "GoodName");
            txtGoodPrice.DataBindings.Add("Text", good, "Price");
            txtGoodCount.DataBindings.Add("Text", good, "GoodCount");

            flowPanelPhoto.Controls.Clear();
            flowPanelPhoto.Update();

            var q = context.Photos.Local.Where(g => g.GoodId == (good as Good).GoodId).ToList();
            foreach(var item in q)
            {
                Image img = Image.FromFile(item.PhotoPath);
                PictureBox p = new PictureBox();
                p.Width = 120;
                p.Height = 100;
                p.Image = ResizeImage.FixedSize(img, p.Width, p.Height, true); ;
                flowPanelPhoto.Controls.Add(p);
            }

            cbGoodManufacturer.DisplayMember = "ManufacturerName";
            cbGoodManufacturer.ValueMember = "ManufacturerId";
            cbGoodManufacturer.DataSource = context.Manufacturers.ToList();
            cbGoodManufacturer.DataBindings.Add("SelectedValue", good, "ManufacturerId", true, DataSourceUpdateMode.OnPropertyChanged);

            cbGoodCategory.DisplayMember = "CategoryName";
            cbGoodCategory.ValueMember = "CategoryId";
            cbGoodCategory.DataSource = context.Categories.ToList();
            cbGoodCategory.DataBindings.Add("SelectedValue", good, "CategoryId", true, DataSourceUpdateMode.OnPropertyChanged);
        }



        private void btDelImage_Click(object sender, EventArgs e)
        {
            context.Photos.Local.Remove(context.Photos.Local.Where(p => p.GoodId == (good as Good).GoodId).FirstOrDefault());
            flowPanelPhoto.Controls.Clear();
            var qry = context.Photos.Local.Where(p => p.GoodId == (good as Good).GoodId).ToList();
            foreach (var item in qry)
            {
                Image img = Image.FromFile(item.PhotoPath);
                PictureBox p = new PictureBox();
                p.Width = 120;
                p.Height = 100;
                p.Image = ResizeImage.FixedSize(img, p.Width, p.Height, true); ;
                flowPanelPhoto.Controls.Add(p);
            }
        }

        private void flowPanelPhoto_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                string ext = Path.GetExtension(FileList[0]);
                string fullpath = Path.Combine("foto", Guid.NewGuid().ToString() + "." + ext);

                File.Copy(FileList[0], fullpath);

                Image img = Image.FromFile(fullpath);
                PictureBox p = new PictureBox();
                p.Width = 120;
                p.Height = 100;

                p.Image = ResizeImage.FixedSize(img, p.Width, p.Height, true); ;

                flowPanelPhoto.Controls.Add(p);

                context.Photos.Local.Add(new Photo()
                {
                    GoodId = (good as Good).GoodId,
                    PhotoPath = fullpath
                });
            }
        }

        private void flowPanelPhoto_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
