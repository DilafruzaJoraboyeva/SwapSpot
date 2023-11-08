﻿using SwapSpot.Domain.Entities.Users;

namespace SwapSpot.Service.DTOs.Messages;

public class MessageForResultDto
{
    public long Id { get; set; }
    public long To { get; set; }
    public User User { get; set; }

    public string Subject { get; set; }
    public string Body { get; set; }
}