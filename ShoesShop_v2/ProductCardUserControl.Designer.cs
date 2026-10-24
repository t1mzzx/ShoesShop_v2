namespace ShoesShop_v2
{
    partial class ProductCardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picImage = new PictureBox();
            lblTitle = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblComposition = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(10, 10);
            picImage.Name = "picImage";
            picImage.Size = new Size(120, 120);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(140, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(593, 18);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Производство | Наименование";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(140, 40);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(458, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Категория: ";
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(140, 65);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(458, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Количество: ";
            // 
            // lblComposition
            // 
            lblComposition.Location = new Point(140, 90);
            lblComposition.Name = "lblComposition";
            lblComposition.Size = new Size(458, 40);
            lblComposition.TabIndex = 4;
            lblComposition.Text = "Состав: ";
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPrice.Location = new Point(613, 40);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(120, 90);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "0,00 ₽";
            // 
            // ProductCardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(lblComposition);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Controls.Add(picImage);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ProductCardUserControl";
            Size = new Size(748, 138);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImage;
        private Label lblTitle;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblComposition;
        private Label lblPrice;
    }
}
