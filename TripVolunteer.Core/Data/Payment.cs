using System;
using System.Collections.Generic;

namespace TripVolunteer.Core.Data;

public partial class Payment
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? TripId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public decimal? Amount { get; set; }

    public string? Method { get; set; }

    public virtual Trip? Trip { get; set; }

    public virtual ApplicationUser? User { get; set; }
}
