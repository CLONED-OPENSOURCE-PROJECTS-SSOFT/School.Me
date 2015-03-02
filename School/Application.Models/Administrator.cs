﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Administrator : DeletableEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string ApplicationUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
