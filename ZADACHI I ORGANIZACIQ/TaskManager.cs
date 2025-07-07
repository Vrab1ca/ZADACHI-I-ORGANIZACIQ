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
            if (File.Exists(StorageFile))
                Tasks = JsonSerializer.Deserialize<List<Task>>(File.ReadAllText(StorageFile)) ?? new();
        }

        public void Save() =>
            File.WriteAllText(StorageFile,
                JsonSerializer.Serialize(Tasks, new JsonSerializerOptions { WriteIndented = true }));

        public void Add(Task t) => Tasks.Add(t);
        public void ToggleCompleted(Task t) => t.IsCompleted = !t.IsCompleted;

        public IEnumerable<Task> Filter(bool showDone, bool showPending, Priority? pr = null) =>
            Tasks.Where(t =>
                (showDone || !t.IsCompleted) &&
                (showPending || t.IsCompleted) &&
                (!pr.HasValue || t.Priority == pr));
    }
}