namespace ToDoList;

public class TaskManager
{
    private List<(string Name, bool Status)> _listOfTasks = new List<(string Name, bool Status)>();
    
    public void AddTask(string name, bool status = false)
    {
        _listOfTasks.Add((name, status));
        Menu.ShowMenu();
    }
    
    public void ListTasks()
    {
        if (_listOfTasks.Count != 0)
        {
            var index = 0;
            foreach (var task in _listOfTasks)
            {
                Console.WriteLine($"[{index}] {task.Name} => {(task.Status ? "Concluída" : "Não Concluida")}");
                index++;
            }
            Console.ReadKey();
            Menu.ShowMenu();
        }
        
        Console.WriteLine("Nenhuma tarefa encontrada!");
        Console.ReadKey();
        Menu.ShowMenu();
    }

    public void ExcludeTask(int idTask)
    {
        _listOfTasks.RemoveAt(idTask);
        Menu.ShowMenu();
    }
}