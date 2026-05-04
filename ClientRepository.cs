using Cadastro;

namespace Repository;

public class ClientRepository
{
    public List<Cliente> clients = new List<Cliente>();
    
    public void RegisterClient()
    {
        Console.Clear();

        Console.Write("Client name: ");
        var name = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Birth date: ");
        var birthDate = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Discount: ");
        var discount = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var client = new Cliente
        {
            Id = clients.Count + 1,
            Name = name,
            BirthDate = birthDate,
            Discount = discount,
            RegistrationDate = DateTime.Now,
        };
        clients.Add(client);

        Console.WriteLine("Client registered! [Enter]");
        PrintClient(client);
        Console.ReadKey();
    }

    public void PrintClient(Cliente client)
    {
        Console.WriteLine("ID.............:" + client.Id);
        Console.WriteLine("Name.............:" + client.Name);
        Console.WriteLine("Discount.............:" + client.Discount.ToString("0.00"));
        Console.WriteLine("Birth Date.............:" + client.BirthDate);
        Console.WriteLine("Registration Date.............:" + client.RegistrationDate);
        Console.WriteLine("---------------------------------------------------");
    }

    public void ShowClients()
    {
        Console.Clear();
        
        foreach(var client in clients)
        {
            PrintClient(client);
        }
        
        Console.ReadKey();
    }

}