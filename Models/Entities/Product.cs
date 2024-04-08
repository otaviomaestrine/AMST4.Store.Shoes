using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4.Store.Shoes.Models.Entities
{
    public class Product
    {
        public Guid Id {get;set;}

        public string Brand {get;set;}

        public string description {get;set;}

        public Guid ColorID {get;set;}

        public Guid SizeId {get;set;}
        
        public double Price {get;set;}

        public double Stock {get;set;}

        public bool IsActive {get;set;}

       

        

        

    }
}