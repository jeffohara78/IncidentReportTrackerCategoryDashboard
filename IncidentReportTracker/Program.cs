/* Jeff O'Hara
 * 5-15-26
 * A C# console application that allows users to create, view, search, and manage incident reports.
 * the application uses two classes: IncidentReport to represent individual reports and IncidentManager to handle the list of reports and related actions.
 */

/* Updates as of 5-27-26
 * The app has JSON read/write, a login manager, and now an added standardized incident category system,
 * along with validated category selection menus to improve data consistency and accuracy. The app can now 
 * search and filter incidents by category, and incident summaries and dashboards including pertinent information
 * have been added for a more professional look
 */


using System;

namespace IncidentReportTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // UPDATE ADDED 05/26/2026:
            // Create the authentication manager first.
            // The user must log in before accessing the incident tracker menu.
            AuthManager authManager = new AuthManager();

            bool loginSuccessful = authManager.Login();

            if (!loginSuccessful)
            {
                return;
            }

            IncidentManager manager = new IncidentManager();

            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add incident report");
                Console.WriteLine("2. View all incident reports");
                Console.WriteLine("3. Search incident reports");
                Console.WriteLine("4. Mark incident as resolved");
                Console.WriteLine("5. Delete incident report");
                Console.WriteLine("6. View incident dashboard");
                Console.WriteLine("7. Filter incidents by category");
                Console.WriteLine("8. Exit");
                Console.Write("\nEnter your choice, such as 1 or 2: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    manager.AddIncident();
                }
                else if (choice == "2")
                {
                    manager.ViewAllIncidents();
                }
                else if (choice == "3")
                {
                    manager.SearchIncident();
                }
                else if (choice == "4")
                {
                    manager.MarkIncidentResolved();
                }
                else if (choice == "5")
                {
                    manager.DeleteIncident();
                }
                else if (choice == "6")
                {
                    manager.ViewIncidentDashboard();
                }
                else if (choice == "7")
                {
                    manager.FilterIncidentsByCategory();
                }
                else if (choice == "8")
                {
                    running = false;
                    Console.WriteLine("Exiting Incident Report Tracker.");
                }
                else
                {
                    Console.WriteLine("Invalid option, please choose 1 through 8.");
                }
            }
        }
    }
}