using ToDoList;

Menu.ShowMenu();

var menuOption = Console.ReadLine();
var taskManager = new TaskManager();

switch (menuOption)
{
    case "1":
        Console.Clear();
        Console.Write("Qual sua tarefa: ");
        var task = Console.ReadLine();
        taskManager.AddTask(task);
        break;
    case "2":
        taskManager.ListTasks();
        break;
    case "3":
        taskManager.ListTasks();
        Console.Write("Qual tarefa deseja excluir (id): ");
        var idTask = int.Parse(Console.ReadLine());
        taskManager.ExcludeTask(idTask);
        break;
    case "4":
        Environment.Exit(0);
        break;
    default:
        Menu.ShowMenu();
        break;
}
