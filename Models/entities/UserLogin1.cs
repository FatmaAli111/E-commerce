using System;
using System.Collections.Generic;

namespace EEcomercEE.entities;

public partial class UserLogin1
{
    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;

    public string? ProviderDisplayName { get; set; }

    public string? UserId { get; set; }
}
