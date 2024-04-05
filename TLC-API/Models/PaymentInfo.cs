using System;
using System.Collections.Generic;

namespace TLC_API.Models;

public partial class PaymentInfo
{
    public int PaymentInfoId { get; set; }

    public int UserId { get; set; }

    public string StripeCustomerId { get; set; } = null!;

    public string StripeCardId { get; set; } = null!;

    public string CardLast4 { get; set; } = null!;

    public int CardExpMonth { get; set; }

    public int CardExpYear { get; set; }

    public string CardBrand { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
