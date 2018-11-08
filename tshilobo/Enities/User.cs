﻿using System;
using System.Collections.Generic;

namespace tshilobo.Enities
{
    public partial class User
    {
        public User()
        {
            ChurchChurchLeader = new HashSet<Church>();
            ChurchCreator = new HashSet<Church>();
            Theme = new HashSet<Theme>();
            UserClaim = new HashSet<UserClaim>();
            UserLogin = new HashSet<UserLogin>();
            UserRole = new HashSet<UserRole>();
            UserToken = new HashSet<UserToken>();
        }

        public string UserId { get; set; }
        public int AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string UserName { get; set; }
        public string Discriminator { get; set; }
        public string DisplayName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? TitleId { get; set; }
        public int GenderId { get; set; }
        public int ChurchId { get; set; }
        public bool BelongsToAchurch { get; set; }

        public Gender Gender { get; set; }
        public ICollection<Church> ChurchChurchLeader { get; set; }
        public ICollection<Church> ChurchCreator { get; set; }
        public ICollection<Theme> Theme { get; set; }
        public ICollection<UserClaim> UserClaim { get; set; }
        public ICollection<UserLogin> UserLogin { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
        public ICollection<UserToken> UserToken { get; set; }
    }
}
