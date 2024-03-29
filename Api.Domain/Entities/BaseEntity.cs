﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {   
        [Key]
        public Guid Id { get; set; }

        private DateTime? _createAt;

        public DateTime? CreateAt
        {
            get => _createAt;
            set => _createAt = value ?? DateTime.UtcNow;
        }

        public DateTime? UpdateAt { get; set; }
    }
}
