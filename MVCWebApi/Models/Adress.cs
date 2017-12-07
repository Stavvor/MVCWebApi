﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    
    public class Adress : EntityModel
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; } //TODO regex jak chcemy byc fancy xd
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }

        public virtual Client Client { get; set; }
      
    }
}
