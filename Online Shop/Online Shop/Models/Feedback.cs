using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class Feedback
    {
        [Required]
        public int FeedbackId { get; set; }
        [Required, MaxLength(30)]
        public string Titile { get; set; }
        [Required, MaxLength(300)]
        public string Description { get; set; }
    }
}
