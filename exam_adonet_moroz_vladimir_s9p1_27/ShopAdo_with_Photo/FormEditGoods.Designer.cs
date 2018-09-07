namespace ShopAdo_with_Photo
{
    partial class FormEditGood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditGood));
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.lbgoodname = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbcategory = new System.Windows.Forms.Label();
            this.lbcount = new System.Windows.Forms.Label();
            this.lbmanufacturer = new System.Windows.Forms.Label();
            this.txtGoodPrice = new System.Windows.Forms.TextBox();
            this.txtGoodCount = new System.Windows.Forms.TextBox();
            this.cbGoodCategory = new System.Windows.Forms.ComboBox();
            this.cbGoodManufacturer = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCansel = new System.Windows.Forms.Button();
            this.btDelImage = new System.Windows.Forms.Button();
            this.flowPanelPhoto = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(12, 31);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(222, 20);
            this.txtGoodName.TabIndex = 0;
            // 
            // lbgoodname
            // 
            this.lbgoodname.AutoSize = true;
            this.lbgoodname.Location = new System.Drawing.Point(12, 15);
            this.lbgoodname.Name = "lbgoodname";
            this.lbgoodname.Size = new System.Drawing.Size(121, 13);
            this.lbgoodname.TabIndex = 1;
            this.lbgoodname.Text = "Наименование товара";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(12, 63);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(71, 13);
            this.lbprice.TabIndex = 2;
            this.lbprice.Text = "Цена товара";
            // 
            // lbcategory
            // 
            this.lbcategory.AutoSize = true;
            this.lbcategory.Location = new System.Drawing.Point(131, 64);
            this.lbcategory.Name = "lbcategory";
            this.lbcategory.Size = new System.Drawing.Size(60, 13);
            this.lbcategory.TabIndex = 3;
            this.lbcategory.Text = "Категория";
            // 
            // lbcount
            // 
            this.lbcount.AutoSize = true;
            this.lbcount.Location = new System.Drawing.Point(12, 110);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(104, 13);
            this.lbcount.TabIndex = 4;
            this.lbcount.Text = "Количество товара";
            // 
            // lbmanufacturer
            // 
            this.lbmanufacturer.AutoSize = true;
            this.lbmanufacturer.Location = new System.Drawing.Point(131, 110);
            this.lbmanufacturer.Name = "lbmanufacturer";
            this.lbmanufacturer.Size = new System.Drawing.Size(86, 13);
            this.lbmanufacturer.TabIndex = 5;
            this.lbmanufacturer.Text = "Производитель";
            // 
            // txtGoodPrice
            // 
            this.txtGoodPrice.Location = new System.Drawing.Point(12, 80);
            this.txtGoodPrice.Name = "txtGoodPrice";
            this.txtGoodPrice.Size = new System.Drawing.Size(101, 20);
            this.txtGoodPrice.TabIndex = 6;
            // 
            // txtGoodCount
            // 
            this.txtGoodCount.Location = new System.Drawing.Point(12, 126);
            this.txtGoodCount.Name = "txtGoodCount";
            this.txtGoodCount.Size = new System.Drawing.Size(101, 20);
            this.txtGoodCount.TabIndex = 7;
            // 
            // cbGoodCategory
            // 
            this.cbGoodCategory.FormattingEnabled = true;
            this.cbGoodCategory.Location = new System.Drawing.Point(134, 79);
            this.cbGoodCategory.Name = "cbGoodCategory";
            this.cbGoodCategory.Size = new System.Drawing.Size(100, 21);
            this.cbGoodCategory.TabIndex = 8;
            // 
            // cbGoodManufacturer
            // 
            this.cbGoodManufacturer.FormattingEnabled = true;
            this.cbGoodManufacturer.Location = new System.Drawing.Point(134, 126);
            this.cbGoodManufacturer.Name = "cbGoodManufacturer";
            this.cbGoodManufacturer.Size = new System.Drawing.Size(100, 21);
            this.cbGoodManufacturer.TabIndex = 9;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(38, 168);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCansel
            // 
            this.btCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCansel.Location = new System.Drawing.Point(134, 168);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(75, 23);
            this.btCansel.TabIndex = 11;
            this.btCansel.Text = "Cansel";
            this.btCansel.UseVisualStyleBackColor = true;
            // 
            // btDelImage
            // 
            this.btDelImage.Location = new System.Drawing.Point(38, 205);
            this.btDelImage.Name = "btDelImage";
            this.btDelImage.Size = new System.Drawing.Size(171, 23);
            this.btDelImage.TabIndex = 13;
            this.btDelImage.Text = "Del Image";
            this.btDelImage.UseVisualStyleBackColor = true;
            this.btDelImage.Click += new System.EventHandler(this.btDelImage_Click);
            // 
            // flowPanelPhoto
            // 
            this.flowPanelPhoto.AllowDrop = true;
            this.flowPanelPhoto.Location = new System.Drawing.Point(240, 31);
            this.flowPanelPhoto.Name = "flowPanelPhoto";
            this.flowPanelPhoto.Size = new System.Drawing.Size(176, 197);
            this.flowPanelPhoto.TabIndex = 14;
            this.flowPanelPhoto.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowPanelPhoto_DragDrop);
            this.flowPanelPhoto.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowPanelPhoto_DragEnter);
            // 
            // FormEditGood
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 251);
            this.Controls.Add(this.flowPanelPhoto);
            this.Controls.Add(this.btDelImage);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbGoodManufacturer);
            this.Controls.Add(this.cbGoodCategory);
            this.Controls.Add(this.txtGoodCount);
            this.Controls.Add(this.txtGoodPrice);
            this.Controls.Add(this.lbmanufacturer);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.lbcategory);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.lbgoodname);
            this.Controls.Add(this.txtGoodName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditGood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditGood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.Label lbgoodname;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbcategory;
        private System.Windows.Forms.Label lbcount;
        private System.Windows.Forms.Label lbmanufacturer;
        private System.Windows.Forms.TextBox txtGoodPrice;
        private System.Windows.Forms.TextBox txtGoodCount;
        private System.Windows.Forms.ComboBox cbGoodCategory;
        private System.Windows.Forms.ComboBox cbGoodManufacturer;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCansel;
        private System.Windows.Forms.Button btDelImage;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPhoto;
    }
}