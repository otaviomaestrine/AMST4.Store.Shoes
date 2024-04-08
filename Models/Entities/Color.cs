using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4.Store.Shoes.Models.Entities
{
    public class Color
    {
        public Guid Id {get;set;}
        
        public string description {get;set;}

        public DateTime CreatedBy {get;set;}
    }
}