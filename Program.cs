Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Title = "Fila Zero - Sistema de login";

DesenharTela();
ExecutarLogin();

static void DesenharTela()
{
    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("         Fila Zero - Login           ");
    Console.WriteLine("=====================================");
}

static void ExecutarLogin()
{
    Console.Write("Digite seu nome de usuário: ");
    string username = Console.ReadLine();

    Console.Write("Digite sua senha: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string password = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


    if (username == "admin" && password == "senha123")
    {
        Console.WriteLine("\nLogin bem-sucedido! Bem-vindo, admin.");
    }
    else
    {
        Console.WriteLine("\nLogin falhou! Nome de usuário ou senha incorretos.");
    }
}
