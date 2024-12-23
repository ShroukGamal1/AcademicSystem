﻿using Academic.Core.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academic.Core.Entities
{
    public class Branch : BaseEntity
    {
        public string Phone { get; set; }
        public string Telephone { get; set; }

        [ForeignKey("Supervisor")]
        public int? SupervisorId { get; set; }
        public Supervisor Supervisor { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; private set; } = new HashSet<ApplicationUser>();
        public ICollection<Student> Students { get; private set; } = new HashSet<Student>();
    }
}
