using System;
using System.Collections.Generic;

namespace TLC_API.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? LastLogin { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<PaymentInfo> PaymentInfos { get; set; } = new List<PaymentInfo>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
