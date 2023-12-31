﻿using SwapSpot.Domain.Commons;
using SwapSpot.Domain.Entities.Users;

namespace SwapSpot.Domain.Entities.Addresses;

public class Address : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Floor { get; set; }
    public string Home { get; set; }
}
