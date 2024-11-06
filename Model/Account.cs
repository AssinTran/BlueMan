using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public partial class Account
{
    [Key]
    [Required]
    public string Id { get; set; } = null!;

    [Required]
    [Length(0, 20)]
    [DisplayName("Username")]
    public string Username { get; set; } = null!;

    [Required]
    [Length(8, 32)]
    [DisplayName("Password")]
    public string Password { get; set; }

    [Required]
    [Compare(nameof(Password))]
    [NotMapped]
    public string Confirm { get; set; }

    [Required]
    public string? Role { get; set; }

    public bool Accept { get; set; }

    [Required]
    public string UserId { get; set; } = null!;

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; } = null!;
}
