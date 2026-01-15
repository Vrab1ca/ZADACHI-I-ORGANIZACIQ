using System;
using System.Drawing;
using System.Text.Json.Serialization;

namespace TaskTracker
{
    public enum Priority { Low, Medium, High }

    public class Task
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; } = DateTime.Today;
        public Priority Priority { get; set; } = Priority.Medium;
        public string ColorHtml { get; set; } = Color.LightYellow.ToArgb().ToString();
        public bool IsCompleted { get; set; }

        [JsonIgnore]
        public Color TaskColor => Color.FromArgb(int.Parse(ColorHtml));
    }
}