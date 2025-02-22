using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    [Table("socials")]
    public class Social
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Url]
        [Column("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [Url]
        [Column("github_url")]
        public string GithubUrl { get; set; }

        [Url]
        [Column("insta_url")]
        public string InstaUrl { get; set; }
    }
}
