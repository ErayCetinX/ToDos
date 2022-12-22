// Constant variables of users
const string userName = "eray";
const string password = "qweqwe";

// User is logined
bool isLogined = false;

while (isLogined == false)
{
    // Get UserName and Password from Users
    Console.Write("userName: ");
    string InputUserName = Console.ReadLine();

    Console.Write("password: ");
    string InputPassword = Console.ReadLine();


    // Check entered variables with constant varaibles
    if (userName == InputUserName.ToLower())
    {
        if (password == InputPassword.ToLower())
        {
            Console.WriteLine("Successful loign");
            isLogined = true;
        }
        else
        {
            Console.WriteLine("UserName or password wrong please try again");
        }
    }
    else
    {
        Console.WriteLine("UserName or password wrong please try again");
    }
}

if (isLogined == true)
{
    DateTime UserLastView = DateTime.Now;

    // TODO database can be attached and data can come from database
    string[] todos = { "Comment reply", "Privact Nsfw settings", "Image Deep Learning" };
    string[] bugs = { "All inputs disable", "Image bugs", "Like systems are slow" };
    string[] userDetail = { "Eray", "Çetin", "Full Stack Developer", $"Last view {UserLastView.ToString()}", "Founder of WhoollyApp" };
    string[] userTodos = { };

    bool quitLoop = false;

    while (quitLoop == false)
    {

        Console.WriteLine("What do you want to do: \n" +
        "1- Show User details\n" +
        "2- Show all todos\n" +
        "3- Show all bug\n" +
        "4- Show user todo\n" +
        "5- Logout");

        // check wich number
        Console.Write("What is your choose: ");
        int Section = int.Parse(Console.ReadLine());

        switch (Section)
        {
            case 1:
                for (int i = 0; i < userDetail.Length; i++)
                {
                    string elements = userDetail[i];
                    Console.WriteLine($"{i + 1}- {elements}");
                }

                Console.Write("Do you want to exit the app (y/Y): ");
                string Response = Console.ReadLine();

                if (Response.ToLower() == "y")
                {
                    quitLoop = true;
                    return;
                }
                quitLoop = false;
                break;
            case 2:
                bool quitTodos = false;
                while (quitTodos == false)
                {
                    // burada kullanıcıya listeleriz oradan seçeriz ve kullanıcın todoUser'a ekleriz
                    Console.WriteLine("Whoolly's to do");

                    // We used the for loop because we need to get the index number
                    for (int i = 0; i < todos.Length; i++)
                    {
                        string elements = todos[i];

                        Console.WriteLine($"{i + 1}- {elements}\n");

                    }

                    Console.Write($"Whic one will you do (1 - {todos.Length}): ");

                    int Choice = int.Parse(Console.ReadLine());

                    // we have to check if the user has entered wrong number
                    for (int i = 0; i < todos.Length; i += 1)
                    {

                        if (Choice == i + 1)
                        {
                            string elementOfChoice = todos[i];
                            Console.WriteLine(elementOfChoice);

                            userTodos = userTodos.Append(elementOfChoice).ToArray();
                            todos = todos.Where((_, index) => index != i).ToArray();

                            for (int j = 0; j < todos.Length; j++)
                            {
                                string elementsOfNewTodos = todos[j];

                                Console.WriteLine($"{j + 1}- {elementsOfNewTodos}\n");
                            }

                            Console.Write("Do you want see your todos (y/Y): ");
                            string userResponse = Console.ReadLine();

                            if (userResponse.ToLower() == "y")
                            {
                                for (int b = 0; b < userTodos.Length; b++)
                                {
                                    string elementOfUserTodos = userTodos[b];
                                    Console.WriteLine($"{i + 1}- {elementOfUserTodos}");
                                }

                                Console.Write("Do you want to quit (y/Y): ");
                                string quitResponse = Console.ReadLine();

                                if (quitResponse.ToLower() == "y")
                                {
                                    quitTodos = true;
                                }
                            }

                        }
                    }
                }
                break;
            case 3:
                // bugs bastır 
                // ondan sonra hangi bugu kendi todosuna seçmek ister onu sor 
                // en sonda kendi todosunu bastırmak ister mi onu sor kullanıya
                // sonra quit

                bool quitBugLoop = false;

                while (quitBugLoop == false)
                {
                    for (int i = 0; i < bugs.Length; i++)
                    {
                        string element = bugs[i];
                        Console.WriteLine($"{i+1}- {element}");
                    }

                    Console.Write($"Which bug do you want to fix? (1-{bugs.Length})");
                    int bugsChoice = int.Parse(Console.ReadLine());

                    for (int j = 0; j < bugs.Length; j++)
                    {
                        if (bugsChoice == j + 1)
                        {
                            string elmentsOfBugs = bugs[j];

                            userTodos = userTodos.Append(elmentsOfBugs).ToArray();
                            bugs = bugs.Where((_, index) => index != j).ToArray();

                        }
                    }

                    Console.Write("Do you want to exit the app? (y/Y): ");
                    string responseQuit = Console.ReadLine();

                    if(responseQuit.ToLower() == "y")
                    {
                        quitBugLoop = true;
                        quitLoop = true;

                        return;
                    }
                }
                break;
            case 4:
                Console.WriteLine($"{userName}'s todos\n");
                for (int i = 0; i < userTodos.Length; i++)
                {
                    string element = userTodos[i];
                    Console.WriteLine($"{i + 1}- {element}\n");
                }
                break;
            case 5:
                isLogined = false;
                break;
            default:
                Console.WriteLine("Geçersiz giriş\n");
                break;
        }
    }

}

