using System;
using System.Collections.Generic;

namespace TripVolunteer.Core.Data;

public partial class ApplicationUser
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ProfilePicturePath { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual ICollection<KeyValue> KeyValues { get; set; } = new List<KeyValue>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
