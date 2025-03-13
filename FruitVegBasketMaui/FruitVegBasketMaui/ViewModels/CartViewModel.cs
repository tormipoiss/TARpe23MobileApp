﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Models;
using System.Collections.ObjectModel;
using FruitVegBasketMaui.Shared.Dtos;

namespace FruitVegBasket.ViewModels
{
    public partial class CartViewModel : ObservableObject
    {
        public ObservableCollection<CartItem> CartItems { get; set; } = new();

        [ObservableProperty]
        private int _count; //The number of products we have in the cart (Not the quantities of those products)

        [ObservableProperty]
        private decimal _totalAmount;

        private void RecalculateTotalAmount() =>
            TotalAmount = CartItems.Sum(c => c.Amount);

        [RelayCommand]
        private void IncreaseCartItemQuantity(Guid cartItemId)
        {
            var item = CartItems.FirstOrDefault(c => c.Id == cartItemId);
            if (item is not null)
            {
                item.Quantity++;
                RecalculateTotalAmount();
            }
        }

        [RelayCommand]
        private void AddToCart(ProductDto product)
        {
            var item = CartItems.FirstOrDefault(c => c.ProductId == product.Id);
            if (item is not null)
            {
                item.Quantity++;
            }
            else
            {
                item = new CartItem
                {
                    Id = Guid.NewGuid(),
                    ProductName = product.Name,
                    ProductId = product.Id,
                    Quantity = 1,
                    Price = product.Price,
                };
                CartItems.Add(item);
                Count = CartItems.Count;
            }
            RecalculateTotalAmount();
        }

        [RelayCommand]
        private void RemoveFromCart(int productId)
        {
            var item = CartItems.FirstOrDefault(c => c.ProductId == productId);
            if (item is not null)
            {
                if (item.Quantity == 1)
                {
                    CartItems.Remove(item);
                    Count = CartItems.Count;
                }
                else
                {
                    item.Quantity--;
                }
            }
            RecalculateTotalAmount();
        }

        private void ClearCart()
        {
            CartItems.Clear();
            Count = 0;
            RecalculateTotalAmount();
        }
    }
}