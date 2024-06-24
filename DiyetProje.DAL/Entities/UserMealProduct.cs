using DiyetProje.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.DAL.Entities
{
    public class UserMealProduct : BaseEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int MealId { get; set; }
        public double Amount { get; set; }

        // Relational properties
        public User User { get; set; }
        public Product Product { get; set; }
        public Meal Meal { get; set; }
    }
}
