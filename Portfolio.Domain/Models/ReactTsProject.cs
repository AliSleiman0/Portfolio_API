using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    [Table("react_ts_projects")]
    public class ReactTsProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("tech_used")]
        public string TechUsed { get; set; }

        [Url]
        [Column("github_url")]
        public string GithubUrl { get; set; }

        [Url]
        [Column("live_demo_url")]
        public string LiveDemoUrl { get; set; }
    }
}
