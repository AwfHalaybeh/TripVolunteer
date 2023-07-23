using System;
using System.Collections.Generic;

namespace TripVolunteer.Core.Data;

public partial class KeyValue
{
    public int Id { get; set; }

    public int? CreatedBy { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }

    public virtual ApplicationUser? CreatedByNavigation { get; set; }
}
