using Cadastro;

namespace Repository;

public class ClientRepository
{
    public List<Cliente> clients = new List<Cliente>();

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