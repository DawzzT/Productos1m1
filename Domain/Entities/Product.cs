using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Product
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        [JsonProperty]
        public int Quantity {get; set;}
        [JsonProperty]
        public decimal Price { get; set; }
        [JsonProperty]
        public  DateTime CaducityDate { get; set; }
        [JsonProperty]
        public MeasurementUnit Unit { get; set; }

        public class ProductPriceCompare : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                if (x.Price < y.Price)
                {
                    return -1;
                }
                if (x.Price > y.Price)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
