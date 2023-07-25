using System;
using System.Collections.Generic;

namespace TripVolunteer.Core.Data;

public partial class Trip
{
    public int Id { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? TripName { get; set; }

    public string? Description { get; set; }

    public string? ImagePath { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int? Capacity { get; set; }

    public DateTime? ReservationDeadLine { get; set; }

    public decimal? Price { get; set; }

    public string? Longitude { get; set; }

    public string? Latitude { get; set; }

    public virtual ApplicationUser? CreatedByNavigation { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
