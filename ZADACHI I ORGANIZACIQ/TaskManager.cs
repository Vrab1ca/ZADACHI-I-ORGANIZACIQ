using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TaskTracker
{
    public class TaskManager
    {
        private const string StorageFile = "tasks.json";
        public List<Task> Tasks { get; private set; } = new();

        public void Load()
        {
            if (!File.Exists(StorageFile)) return;
            string json = File.ReadAllText(StorageFile);
            Tasks = JsonSerializer.Deserialize<List<Task>>(json) ?? new();
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(Tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(StorageFile, json);
        }

        public void Add(Task task) => Tasks.Add(task);
        public void ToggleCompleted(Task t) => t.IsCompleted = !t.IsCompleted;

        public IEnumerable<Task> Filter(bool showDone, bool showPending, Priority? pr = null) =>
            Tasks.Where(t =>
                 (showDone || !t.IsCompleted) &&
                 (showPending || t.IsCompleted) &&
                 (!pr.HasValue || t.Priority == pr));
    }
}