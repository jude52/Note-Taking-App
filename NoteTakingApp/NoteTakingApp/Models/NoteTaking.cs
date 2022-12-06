using System;
using Microsoft.AspNetCore.Components;

namespace NoteTakingApp.Models
{
    public class NoteTaking
    {
        [Parameter]
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string? Message { get; set; }

    }
}



