using DiyetProje.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public byte[]? Picture { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }

        public bool IsAdministrator { get; set; } = false;

        // Relational properties
        public List<UserMealProductViewModel> UserMealProducts { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
