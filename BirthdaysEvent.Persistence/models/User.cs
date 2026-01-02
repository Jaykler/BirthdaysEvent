using System;
using System.Collections.Generic;

namespace BirthdaysEvent.Persistence.Models;

public partial class User
{
    public int Id { get; set; }

    public string Provider { get; set; } = null!;

    public string ProviderUserId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Name { get; set; }

    public string? AvatarUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? LastLogin { get; set; }
}
