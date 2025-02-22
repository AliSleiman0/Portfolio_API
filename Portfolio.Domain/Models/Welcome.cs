using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    [Table("welcome")]
    public class Welcome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("img_src")]
        public string ImgSrc { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Column("subtitle")]
        public string Subtitle { get; set; }

        // For example, store as a comma-separated list or JSON string.
        [Column("skills")]
        public string Skills { get; set; }
    }
}
