using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekdox.Prime.Data.Entities.Internal
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }



        // Created
        public string CreatedByUserId { get; set; }

        public virtual ApplicationUser CreatedByUser { get; set; }

        [Display(Name = "Date Registered")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;



        // Modified
        public string ModifiedByUserId { get; set; }

        public virtual ApplicationUser ModifiedByUser { get; set; }

        [Display(Name = "Date Modified")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateModified { get; set; } = DateTime.UtcNow;



        // Deleted
        public byte DeleteLevel { get; set; }
        public string DeletedByUserId { get; set; }

        public virtual ApplicationUser DeletedByUser { get; set; }

        [Display(Name = "Date Deleted")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateDeleted { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<string> { }
}
