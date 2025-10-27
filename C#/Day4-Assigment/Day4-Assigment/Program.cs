//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Day4_Assigment;

EmployeeManagement employeeManagement = new EmployeeManagement("John Doe",15000,"Permanent");
EmployeeManagement employeeManagement1 = new EmployeeManagement("Liam smith",20000, "Contract");
EmployeeManagement employeeManagement2 = new EmployeeManagement("Mary James",15000, "Permanent");
while (true)
{
    Console.WriteLine("Choose a Option \n 1.New Ride\n 2.Exit");

    String StringC = Console.ReadLine();
    if (int.TryParse(StringC, out int c))
    {
        switch (c)
        {
            case 1:

                break;
            case 2:
                Console.WriteLine("Ok");
                
                break;
            default:
                Console.WriteLine("Enter a valid");
                break;

        }

        if (c == 2)
        {
            break;
        }
    }
        UberRide uberRide = new UberRide();
    Console.WriteLine("Enter the details \n Driver Name ");

    string driverName = Console.ReadLine();
    Console.WriteLine("Enter the detail \n passenger Name  ");
    string passengerName = Console.ReadLine();
    Console.WriteLine("Enter the detail \n enter the distance  ");
    string StringdistanceKm = Console.ReadLine();
    

        if (double.TryParse(StringdistanceKm, out double distanceKm))
    {
        uberRide.UberDetails(passengerName, driverName, distanceKm);
    }
    
    while (true)
    {


        Console.WriteLine("choose your Options pls: \n 1.Show Ride Summarry \n 2.Show Your Current Ride Details\n 3.Set Sugre\n 4.exit\n");
        string StringCh = Console.ReadLine();
        if (int.TryParse(StringCh, out int ch))
        {

            switch (ch)
            {
                case 1:
                    UberRide.ShowRideSummary();
                    break;
                case 2:
                    uberRide.ShowRideDetails();
                    break;
                case 3:
                    Console.WriteLine("Enter a Surge ");
                    string SurgeString = Console.ReadLine();
                    if (double.TryParse(SurgeString, out double Surge))
                    {
                        UberRide.SetSurgeMultiplier(Surge);
                    }

                    break;
                case 4:
                    Console.WriteLine("Bie");
                    break;
                default:
                    Console.WriteLine("Enter a Valid Option");
                    break;

            }
            if (ch == 4)
            {
                break;
            }

        }
    }
}