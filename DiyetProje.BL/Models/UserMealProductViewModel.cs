using DiyetProje.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Models
{
    public class UserMealProductViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int MealId { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relational properties
        public UserViewModel User { get; set; }
        public ProductViewModel Product { get; set; }
        public MealViewModel Meal { get; set; }
    }
}
