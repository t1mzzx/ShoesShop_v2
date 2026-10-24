namespace ShoesShop_v2
{
    partial class FormProducts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblCount = new Label();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            panelFilter = new Panel();
            cmbCategory = new ComboBox();
            cmbSort = new ComboBox();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFilter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 246, 231);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Чудо_Обувь;
            pictureBox1.Location = new Point(10, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(70, 20);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 6;
            label2.Text = "Магазин обуви";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCount.Location = new Point(620, 13);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(116, 18);
            lblCount.TabIndex = 1;
            lblCount.Text = "Выведено: 0 из 0";
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            flowLayoutPanelProducts.Location = new Point(0, 115);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(800, 335);
            flowLayoutPanelProducts.TabIndex = 1;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.Controls.Add(lblCount);
            panelFilter.Controls.Add(cmbCategory);
            panelFilter.Controls.Add(cmbSort);
            panelFilter.Controls.Add(txtSearch);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 65);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(800, 50);
            panelFilter.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(420, 10);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(180, 23);
            cmbCategory.TabIndex = 5;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(225, 10);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(180, 23);
            cmbSort.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по названию...";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 3;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(panelFilter);
            Controls.Add(panel1);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин обуви — Каталог товаров";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCount;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private TextBox txtSearch;
        private Panel panelFilter;
        private Label label2;
        private ComboBox cmbCategory;
        private ComboBox cmbSort;
    }
}
