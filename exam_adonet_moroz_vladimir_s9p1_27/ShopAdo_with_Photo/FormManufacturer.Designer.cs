namespace ShopAdo_with_Photo
{
    partial class FormManufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManufacturer));
            this.dgvManufacturer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManufacturer
            // 
            this.dgvManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturer.Location = new System.Drawing.Point(13, 13);
            this.dgvManufacturer.Name = "dgvManufacturer";
            this.dgvManufacturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManufacturer.Size = new System.Drawing.Size(188, 315);
            this.dgvManufacturer.TabIndex = 0;
            this.dgvManufacturer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManufacturer_CellContentDoubleClick);
            this.dgvManufacturer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvManufacturer_MouseClick);
            this.dgvManufacturer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvManufacturer_MouseDoubleClick);
            // 
            // FormManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 340);
            this.Controls.Add(this.dgvManufacturer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManufacturer";
            this.Text = "Manufacturer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManufacturer;
    }
}