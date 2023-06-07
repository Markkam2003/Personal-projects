using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuetRecordingApp.Models
{
    public class Recording
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FilePath { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Guest")]
        public int GuestId { get; set; }
        public User Guest { get; set; }
    }

    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsAnonymous { get; set; }

        public virtual ICollection<Recording> Recordings { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }

    public class Contract
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public string Signer1 { get; set; }

        public string Signer2 { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}


