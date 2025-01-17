static class Program {

    static void Main() {
        Logbook logbook = new Logbook();
        
        while(true) {
            logbook.Show();
            
            Console.WriteLine("\n1. Add a task");
            Console.WriteLine("2. Finish a task");
            Console.WriteLine("3. Add a log");
            Console.WriteLine("4. Exit");

            switch (Input.Int()) {
                case 1:
                    logbook.AddTask(Input.Str());
                    break;
                case 2:
                    Console.WriteLine("Enter Task number.");
                    logbook.FinishTask(Input.Int());
                    break;
                case 3:
                    logbook.AddLog(Input.Str());
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
        
    }
}