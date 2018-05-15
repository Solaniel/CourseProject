using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltraDB.Entities
{
    public class Game : BaseEntity
    {
        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public int GameNumber { get; set; }

        [Required, StringLength(50)]
        public string GameName { get; set; }


    }
}
