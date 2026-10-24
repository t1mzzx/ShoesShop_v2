using Microsoft.EntityFrameworkCore;
using ShoesShop_v2.Models;

namespace ShoesShop_v2;

public partial class FormProducts : Form
{
    public FormProducts()
    {
        InitializeComponent();
        this.Load += FormProducts_Load;
    }

    private void FormProducts_Load(object? sender, EventArgs e)
    {
        LoadCatalog();
    }

    private void LoadCatalog()
    {
        using var db = new ShoeStoreContext();

        var today = DateTime.Today;
        var firstDayThisMonth = new DateOnly(today.Year, today.Month, 1);
        var prevMonth = firstDayThisMonth.AddMonths(-1);
        var firstDayPrevMonth = new DateOnly(prevMonth.Year, prevMonth.Month, 1);
        var lastDayPrevMonth = firstDayThisMonth.AddDays(-1);

        var orderedProductIdsInPrevMonth = db.OrderItems
            .Where(oi => oi.Order.OrderDate >= firstDayPrevMonth && oi.Order.OrderDate <= lastDayPrevMonth)
            .Select(oi => oi.StockItem.ProductId)
            .Distinct()
            .ToHashSet();

        var products = db.Products
            .Include(p => p.Category)
            .Include(p => p.Manufacturer)
            .Include(p => p.StockItems)
            .ToList();

        flowLayoutPanelProducts.SuspendLayout();
        flowLayoutPanelProducts.Controls.Clear();

        foreach (var product in products)
        {
            int totalQuantity = product.StockItems.Sum(si => si.QuantityAvailable);

            decimal finalPrice = product.Price;
            if (!orderedProductIdsInPrevMonth.Contains(product.ProductId))
            {
                finalPrice = Math.Round(product.Price * 0.75m, 2);
            }

            var card = new ProductCardUserControl();
            card.SetData(product, finalPrice, totalQuantity);
            flowLayoutPanelProducts.Controls.Add(card);
        }

        flowLayoutPanelProducts.ResumeLayout();
    }
}