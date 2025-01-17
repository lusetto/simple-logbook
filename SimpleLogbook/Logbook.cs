using System;
using Entry = Pair<System.DateTime, string>;

class Logbook {

    private List<Entry> _tasks = [];
    private List<Entry> _logs = [];

    public void AddTask(string task) {
        _tasks.Insert(0, new Entry(DateTime.Now, task));
    }
    public void FinishTask(int taskNumber) {
        try {
            _tasks.RemoveAt(taskNumber - 1);
        }
        catch {
            return;
        }
    }

    public void AddLog(string log) {
        _logs.Insert(0, new Entry(DateTime.Now, log));
    }
    
    public void Show() {
        Console.WriteLine("--- Tasks:");
        for(int i = 0; i < _tasks.Count; i++) {
            Console.WriteLine($"{i + 1}. {_tasks[i].Second} [{_tasks[i].First}]");
        }

        Console.WriteLine("\n--- Logs:");
        foreach(Entry log in _logs) {
            Console.WriteLine($"[{log.First}] {log.Second}");
        }
    }
}