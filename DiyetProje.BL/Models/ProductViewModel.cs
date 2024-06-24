using DiyetProje.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int PortionUnit { get; set; }
        public string Description { get; set; } /*= "100 kalori ekleyeceğiz"*/
        public byte[]? Picture { get; set; } // öğün takviminde görüneeck.
        public int CategoryId { get; set; }

        // Relational properties
        public CategoryViewModel Category { get; set; }
        public List<UserMealProductViewModel> UserMealProducts { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
        public override bool Equals(object? obj)
        {
            if (obj is ProductViewModel)
            {
                return this.Id == ((ProductViewModel)obj).Id;
            }
            return base.Equals(obj);
        }
    }
}
