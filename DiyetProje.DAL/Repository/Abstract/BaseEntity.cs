using DiyetProje.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.DAL.Repository.Abstract
{
    public abstract class BaseEntity : IEntity // Interface içindeki kodları miras verirken kod tekrarı olmasın diye "BaseEntity" adında "Abstract" sınıfta tutulur. Oluşturulan yeni Class artık BaseEntity'den miras alır ve IEntity içindeki property'leri implement etmek zorunda kalmadan o property'lere ulaşabilir.
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
