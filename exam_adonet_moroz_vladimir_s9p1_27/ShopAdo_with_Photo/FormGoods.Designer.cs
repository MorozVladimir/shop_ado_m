namespace ShopAdo_with_Photo
{
    partial class FormGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoods));
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.flpGoods = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGoods
            // 
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Location = new System.Drawing.Point(151, 15);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoods.Size = new System.Drawing.Size(595, 309);
            this.dgvGoods.TabIndex = 0;
            this.dgvGoods.CurrentCellChanged += new System.EventHandler(this.dgvGoods_CurrentCellChanged);
            this.dgvGoods.DoubleClick += new System.EventHandler(this.dgvGoods_DoubleClick);
            this.dgvGoods.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvGoods_MouseClick);
            this.dgvGoods.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvGoods_MouseDoubleClick);
            // 
            // flpGoods
            // 
            this.flpGoods.AllowDrop = true;
            this.flpGoods.Location = new System.Drawing.Point(13, 15);
            this.flpGoods.Name = "flpGoods";
            this.flpGoods.Size = new System.Drawing.Size(132, 309);
            this.flpGoods.TabIndex = 1;
            // 
            // FormGoods
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 336);
            this.Controls.Add(this.flpGoods);
            this.Controls.Add(this.dgvGoods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGoods";
            this.Text = "Goods";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.FlowLayoutPanel flpGoods;
    }
}