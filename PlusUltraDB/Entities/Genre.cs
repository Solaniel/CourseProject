using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltraDB.Entities
{
    public class Genre : BaseEntity
    {
        [Required]
        public int GenreNumber { get; set; }

        [Required, StringLength(50)]
        
        public string GName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
