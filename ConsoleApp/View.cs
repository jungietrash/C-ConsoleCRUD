// See https://aka.ms/new-console-template for more information
using ConsoleApp;

    Controller ps  = new Controller();

    ps.CreatePerson();


string input = "";
    while(!input.ToLower().Equals("x"))
    {
        Console.WriteLine("1: Create");
        Console.WriteLine("2: Retrieve");
        Console.WriteLine("3: Update");
        Console.WriteLine("4: Delete");
        Console.WriteLine("X: Exit");
        input = Console.ReadLine();

        switch (input)
        {
            case "1":
            string ID = Console.ReadLine();
            string NAME = Console.ReadLine();
            string DESC = Console.ReadLine();

            ps.CreatePerson(new Persons { PersonId = ID, PersonName = NAME, PersonDescription = DESC });
            Console.WriteLine("Successfully Added");
                break;
            case "2":
                foreach (var i in ps.GetAllPeople())
                {
                    Console.WriteLine($"ID   : {i.PersonId}");
                    Console.WriteLine($"Name : {i.PersonName}");
                    Console.WriteLine($"Desc : {i.PersonDescription}");
                    Console.WriteLine("--------------------");
                }
            break;
            case "3":
            Console.WriteLine("What ID?");
            string FindID = Console.ReadLine();

            Console.WriteLine("Replacement ID");
            string ReplacementID = Console.ReadLine();

                ps.setPersonID(FindID, ReplacementID);
                Console.WriteLine("Success Update ID");
                break;
        case "4":
            string DeleteID = Console.ReadLine();

            ps.DeletePerson(DeleteID);
            break;

        default:
                Console.WriteLine();
                break;
        }

    
    }


Console.WriteLine("Thank you for the information!");


