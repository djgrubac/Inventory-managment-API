﻿using System;
namespace WebAPI.Models
{
	public class Products
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int StockQuantity { get; set; }
    }
}