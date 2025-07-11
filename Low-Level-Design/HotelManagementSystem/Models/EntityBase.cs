﻿namespace HotelManagementSystem.Models;

public abstract class EntityBase
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public void UpdateTimestamps()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}
