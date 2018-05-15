using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltraDB.Entities
{
    public class Organization : BaseEntity
    {
        [Required]
        public int OrganizationId { get; set; }
        
        [Required, StringLength(50)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
    }
}
