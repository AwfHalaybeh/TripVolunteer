using System;
using System.Collections.Generic;

namespace TripVolunteer.Core.Data;

public partial class Reservation
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? TripId { get; set; }

    public bool? Approved { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual Trip? Trip { get; set; }

    public virtual ApplicationUser? User { get; set; }
}
