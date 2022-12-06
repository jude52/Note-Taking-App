using System;
using Microsoft.AspNetCore.Components;

namespace NoteTakingApp.Models
{
    public class PersonModel
    {
        [Parameter]
            public int Id { get; set; }
            public string FirstName { get; set; } = String.Empty;
            public string? LastName { get; set; }
    
    }
}

