﻿using NorthWind.Entities.Abstract;

namespace NorthWind.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
