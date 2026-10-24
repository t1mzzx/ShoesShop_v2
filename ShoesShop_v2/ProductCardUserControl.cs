using ShoesShop_v2.Models;

namespace ShoesShop_v2;

public partial class ProductCardUserControl : UserControl
{
    public ProductCardUserControl()
    {
        InitializeComponent();
    }

    public void SetData(Product product, decimal finalPrice, int totalQuantity)
    {
        string manufacturer = product.Manufacturer?.ManufacturerName ?? "Не указан";
        lblTitle.Text = $"{manufacturer} | {product.ProductName}";
        lblCategory.Text = $"Категория: {product.Category?.CategoryName ?? "Без категории"}";
        lblComposition.Text = $"Состав: {product.Composition ?? "Не указан"}";

        lblQuantity.Text = totalQuantity > 5 ? "Количество: много" : "Количество: мало";
        lblPrice.Text = $"{finalPrice:N2} ₽";

        if (totalQuantity <= 3)
        {
            this.BackColor = ColorTranslator.FromHtml("#FF8080");
        }
        else
        {
            this.BackColor = Color.White;
        }

        LoadImage(product.Image);
    }

    private void LoadImage(string? imageName)
    {
        if (!string.IsNullOrWhiteSpace(imageName))
        {
            string fileName = Path.GetFileName(imageName);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", fileName);

            if (File.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    picImage.Image = Image.FromStream(stream);
                }
                return;
            }
        }

        picImage.Image = Properties.Resources.picture;
    }
}