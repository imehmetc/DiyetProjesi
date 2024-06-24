using AutoMapper;
using DiyetProje.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // Relational properties
        public List<ProductViewModel> Products { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
        public override bool Equals(object? obj)
        {
            if (obj is CategoryViewModel)
            {
                return this.Id == ((CategoryViewModel)obj).Id;
            }
            return base.Equals(obj);
        }
    }
}
