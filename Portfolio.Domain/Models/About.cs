using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    [Table("about")]
    public class About
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_p")]
        public string FirstP { get; set; }

        [Column("second_p")]
        public string SecondP { get; set; }

        [Column("third_p")]
        public string ThirdP { get; set; }

        [Column("fourth_p")]
        public string FourthP { get; set; }
    }
}
