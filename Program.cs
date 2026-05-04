using Repository;

namespace AppClientes;

class Program
{
    static ClientRepository _clientRepository = new ClientRepository();
    static void Main(string[] args)
    {

        _clientRepository.ReadClientData();

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
    
    ChooseOption();
}

    static void ChooseOption()
    {
        Console.Write("Choose an option: ");

        var option = Console.ReadLine();

        switch (int.Parse(option))
        {
            case 1:
                {
                    _clientRepository.RegisterClient();
                    Menu();
                    break;
                }
            case 2:
                {
                    _clientRepository.ShowClients();
                    Menu();
                    break;
                }
            case 3:
                {
                    _clientRepository.EditClient();
                    Menu();
                    break;
                }
            case 4:
                {
                    _clientRepository.DeleteClient();
                    Menu();
                    break;
                }
            case 5:
                {
                    _clientRepository.SaveClientData();
                    Environment.Exit(0);
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option!");
                    
                    break;
                }
        }
    }
}
