namespace ToDoList;

public class Menu
{
    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("********************");
        Console.WriteLine("  Lista de Tarefas  ");
        Console.WriteLine("********************");
        Console.WriteLine();
        Console.WriteLine("1. Adicionar tarefa");
        Console.WriteLine("2. Listar tarefas");
        Console.WriteLine("3. Excluir tarefa");
        Console.WriteLine("4. Sair");
        Console.WriteLine();
        Console.Write("Opção: ");
    }
}