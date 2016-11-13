using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.Domain;

namespace api.Model
{
    public class Product
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public Price Price {get; set;}
    }
}