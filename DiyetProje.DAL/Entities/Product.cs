using DiyetProje.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.DAL.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int PortionUnit { get; set; }
        public string Description { get; set; } /*= "100 kalori ekleyeceğiz"*/
        public byte[]? Picture { get; set; }
        public int CategoryId { get; set; }

        // Relational properties
        public Category Category { get; set; }
        public List<UserMealProduct> UserMealProducts { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
