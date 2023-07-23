using System;
using System.Collections.Generic;

namespace TripVolunteer.Core.Data;

public partial class Testimonial
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Value { get; set; }

    public virtual ApplicationUser? User { get; set; }
}
