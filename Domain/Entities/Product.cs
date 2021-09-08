using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity {get; set;}
        public decimal Price { get; set; }
        public  DateTime CaducityDate { get; set; }
        public MeasurementUnit Unit { get; set; }

    }
}
