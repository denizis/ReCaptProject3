﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public int CarModelYear { get; set; }
        public  decimal CarDailyPrice { get; set; }
        public string  CarDescription { get; set; }

    }
}
