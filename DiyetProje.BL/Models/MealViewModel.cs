using DiyetProje.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Models
{
    public class MealViewModel
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }

        // Relational properties
        public List<UserMealProductViewModel> UserMealProducts { get; set; }

        public override string ToString()
        {
            return MealName;
        }
        public override bool Equals(object? obj)
        {
            if (obj is MealViewModel)
            {
                return this.Id == ((MealViewModel)obj).Id;
            }
            return base.Equals(obj);
        }
    }
}
