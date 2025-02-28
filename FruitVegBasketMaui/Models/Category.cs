using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public short ParentId { get; set; }

        public bool IsMainCategory => ParentId == 0;
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class CartItem : ObservableObject
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        public int _quantity;

        public decimal Amount => Price * Quantity;
    }

    public class Order
    {
        public long Id { get; set; }
        public IEnumerable<CartItem> Items { get; set; } = Enumerable.Empty<CartItem>();
        public DateTime Date { get; set; } = DateTime.Now;

        public decimal TotalAmount => Items.Sum(i => i.Amount);
        public OrderStatus Status { get; set; } = OrderStatus.Placed;

        public Color Color => _orderStatusColorsMap[Status];

        private static readonly IReadOnlyDictionary<OrderStatus, Color> _orderStatusColorsMap =
            new Dictionary<OrderStatus, Color>
            {
                [OrderStatus.Placed] = Colors.Yellow,
                [OrderStatus.Confirmed] = Colors.Blue,
                [OrderStatus.Delivered] = Colors.Green,
                [OrderStatus.Cancelled] = Colors.Red,
            };
    }

    public enum OrderStatus
    {
        Placed = 0,
        Confirmed = 1,
        Delivered = 2,
        Cancelled = 3
    }
}