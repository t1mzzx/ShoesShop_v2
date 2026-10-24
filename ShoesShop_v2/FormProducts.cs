using Microsoft.EntityFrameworkCore;
using ShoesShop_v2.Models;

namespace ShoesShop_v2;

public partial class FormProducts : Form
{
    private class ProductViewItem
    {
        public Product Product { get; set; } = null!;
        public decimal FinalPrice { get; set; }
        public int TotalQuantity { get; set; }
    }

    private List<ProductViewItem> _allProducts = new();

    public FormProducts()
    {
        InitializeComponent();
        this.Load += FormProducts_Load;

        txtSearch.TextChanged += (s, e) => ApplyFilters();
        cmbSort.SelectedIndexChanged += (s, e) => ApplyFilters();
        cmbCategory.SelectedIndexChanged += (s, e) => ApplyFilters();
    }

    private void FormProducts_Load(object? sender, EventArgs e)
    {
        InitFilterControls();
        LoadCatalog();
    }

    private void InitFilterControls()
    {
        cmbSort.Items.Clear();
        cmbSort.Items.AddRange(new object[]
        {
            "Без сортировки",
            "По возрастанию цены",
            "По убыванию цены"
        });
        cmbSort.SelectedIndex = 0;

        using var db = new ShoeStoreContext();
        var categories = db.Categories.OrderBy(c => c.CategoryName).ToList();

        cmbCategory.Items.Clear();
        cmbCategory.Items.Add("Все категории");
        foreach (var cat in categories)
        {
            cmbCategory.Items.Add(cat.CategoryName);
        }
        cmbCategory.SelectedIndex = 0;
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

        _allProducts = products.Select(p =>
        {
            int totalQty = p.StockItems.Sum(si => si.QuantityAvailable);
            decimal price = p.Price;

            if (!orderedProductIdsInPrevMonth.Contains(p.ProductId))
            {
                price = Math.Round(p.Price * 0.75m, 2);
            }

            return new ProductViewItem
            {
                Product = p,
                FinalPrice = price,
                TotalQuantity = totalQty
            };
        }).ToList();

        ApplyFilters();
    }

    private void ApplyFilters()
    {
        if (_allProducts == null || _allProducts.Count == 0) return;

        var filtered = _allProducts.AsEnumerable();

        string search = txtSearch.Text.Trim().ToLower();
        if (!string.IsNullOrEmpty(search))
        {
            filtered = filtered.Where(p =>
                (p.Product.ProductName != null && p.Product.ProductName.ToLower().Contains(search)) ||
                (p.Product.Manufacturer?.ManufacturerName != null && p.Product.Manufacturer.ManufacturerName.ToLower().Contains(search)) ||
                (p.Product.Category?.CategoryName != null && p.Product.Category.CategoryName.ToLower().Contains(search)) ||
                (p.Product.Composition != null && p.Product.Composition.ToLower().Contains(search))
            );
        }

        if (cmbCategory.SelectedIndex > 0)
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString() ?? "";
            filtered = filtered.Where(p => p.Product.Category?.CategoryName == selectedCategory);
        }

        filtered = cmbSort.SelectedIndex switch
        {
            1 => filtered.OrderBy(p => p.FinalPrice),
            2 => filtered.OrderByDescending(p => p.FinalPrice),
            _ => filtered
        };

        var resultList = filtered.ToList();

        flowLayoutPanelProducts.SuspendLayout();
        flowLayoutPanelProducts.Controls.Clear();

        foreach (var item in resultList)
        {
            var card = new ProductCardUserControl();
            card.SetData(item.Product, item.FinalPrice, item.TotalQuantity);
            flowLayoutPanelProducts.Controls.Add(card);
        }

        flowLayoutPanelProducts.ResumeLayout();

        lblCount.Text = $"Выведено: {resultList.Count} из {_allProducts.Count}";
    }
}