using System;
using System.Collections.Generic;

namespace BirthdaysEvent.Persistence.Models;

public partial class Member
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public string? Notes { get; set; }

    public string? PhotoUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
