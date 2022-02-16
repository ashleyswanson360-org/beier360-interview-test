using System;

namespace InterviewApp.Models
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.Empty;

        public string Text { get; set; } = "";

        public string Description { get; set; } = "";
    }
}