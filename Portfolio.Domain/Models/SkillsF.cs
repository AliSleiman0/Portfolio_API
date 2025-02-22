using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    [Table("skills_f")]
    public class SkillsF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("skill_id")]
        public int SkillId { get; set; }

        [Required]
        [Column("skill_name")]
        public string SkillName { get; set; }
    }
}
