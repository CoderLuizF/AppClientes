using Repository;

namespace AppClientes;

class Program
{
    static ClientRepository _clientRepository = new ClientRepository();
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();

            Console.ReadKey();
        }
    }

    static void Menu()
{
    Console.WriteLine("Customer Registration");
    Console.WriteLine("--------------------");
    Console.WriteLine("1- Register Customer");
    Console.WriteLine("2- List Customers");
    Console.WriteLine("3- Edit Customer");
    Console.WriteLine("4- Delete Customer");
    Console.WriteLine("5- Exit");
    Console.WriteLine("--------------------");
}
}
