using DiyetProje.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.DAL.Entities
{
    public class Meal : BaseEntity
    {
        public string MealName { get; set; }
        public string Description { get; set; }

        // Relational properties
        public List<UserMealProduct> UserMealProducts { get; set; }

        public override string ToString()
        {
            return MealName;
        }
    }
}
