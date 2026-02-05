using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShowTrack.Entity
{
    public class MailLog
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string VerificationCode { get; set; }

        [Required]
        public string Message { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}
