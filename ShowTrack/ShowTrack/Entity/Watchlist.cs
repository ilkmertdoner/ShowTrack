using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShowTrack.Entity
{
    public class WatchList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string ImdbId { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}
