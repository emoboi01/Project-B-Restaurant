namespace Restaurant
{
    class UserLogout
    {
        public UserLogout()
        {

        }
        public void Logout()
        {
            Console.WriteLine("\n=== Logout ===");
            Console.Write("Do you want to logout? Y/N: ");
            string userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "Y":
                    UserLogin.userLoggedIn = false;
                    // !! Maybe move these small lines of code for the json to a new class in the DataAccess folder !!
                    string filePath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Environment.CurrentDirectory, @"DataSources/CurrentUser.json"));
                    string jsonContent = File.ReadAllText(filePath);
                    jsonContent = string.Empty;
                    File.WriteAllText(filePath, jsonContent);
                    // !!

                    string logoutSuccesDot = "...";
                    foreach (char c in logoutSuccesDot)
                    {
                        Console.Write(c);
                        Thread.Sleep(50);
                    }
                    Thread.Sleep(1000);
                    string logoutSuccesDot2 = " ...";
                    foreach (char c in logoutSuccesDot2)
                    {
                        Console.Write(c);
                        Thread.Sleep(50);
                    }
                    Thread.Sleep(1000);
                    string logoutSuccessfull = " Succesfully logged out.\n";
                    foreach (char c in logoutSuccessfull)
                    {
                        Console.Write(c);
                        Thread.Sleep(50);
                    }
                    MainMenu.Main();
                    break;

                case "N":
                    MainMenu.Main();
                    break;

                default:
                    Console.Write("\nInvalid input. Please typ \"Y\" or \"N\": ");
                    break;
            }
        }
    }
}