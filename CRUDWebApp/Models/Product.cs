﻿namespace CRUDWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

      public DateTime Created_At { get; set; } = DateTime.Now;

    }
}
