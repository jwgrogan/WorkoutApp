using System;

namespace WorkoutApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the workouot app!");

            while (true)
            {
                Console.WriteLine("0. Enter Username");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Exit");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Enter username");
                        var username = Console.ReadLine();

                        var users = Gym.GetUser(username);

                        foreach (var user in users)
                        {
                            Console.WriteLine($"Welcome! \nUsername: {user.Username} \nEmail address: {user.EmailAddress} \nTotal number of workouts: {user.TotalWorkouts}" +
                                                        $"\nTotal workout time (minutes): { user.TotalDuration} \nWhat would you like to do?");
                            break;
                        }
                        

                        option = Console.ReadLine();
                        switch (option)
                        {

                        }

                        return;


                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Enter username:");
                            var newUsername = Console.ReadLine();
                            Console.WriteLine("Enter email address:");
                            var emailAddress = Console.ReadLine();


                            var newUserTest = Convert.ToString(Gym.GetUser(newUsername));

                            if (newUserTest.Length > 0)
                            {
                                Console.WriteLine("Username already exists; try a different username.");
                               
                            }
                            else
                            {
                                var newUser = Gym.AddUser(newUsername, emailAddress);

                                Console.WriteLine($"Welcome! \nUsername: {newUser.Username} \nEmail address: {newUser.EmailAddress} \nTotal number of workouts: {newUser.TotalWorkouts}" +
                                    $"\nTotal workout time (minutes): { newUser.TotalDuration} \nWhat would you like to do?");
                                break;
                            }
                        }
                        

                       
                        break;



                        


                    case "2":
                        Console.WriteLine("Thank you for visiting the gym!");
                        return;


                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
        }

       
    }
}
