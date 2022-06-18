using System;

namespace Atlimus.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}