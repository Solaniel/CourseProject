using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltraDB.Entities
{
   public class GameGenre : BaseEntity
    {
        [Required]
        public int GameOrganizationId { get; set; }

        [Required]
        public int GameNumber { get; set; }

        [Required]
        public int GenreNumber { get; set; }
    }
}
