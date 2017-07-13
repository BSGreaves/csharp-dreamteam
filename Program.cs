using System;
using System.Collections.Generic;

// Your job is to pick 5 of your teammates in your cohort and build a class for each one. 
// Each teammate should have the following properties/methods. Build one for yourself, as well.
// Specialty property - This holds the technology that the person enjoys the most.
// FirstName property
// LastName property
// FullName property - This property is a readonly property that returns the first and last name concatenated.
// Work() method - This will write a comical message to the console that describes the work they will do on a group project, based on their speciality.
// Once you're done, you should have 6 different types in total, each with the properties and methods above.

// Create two groups (i.e. List) that will hold three teammates each. These two lists represent one team that will be the server side team, and one that will be the client side team.
// Instantiate one instance of each of your teammates.
// Put your teammates into the appropriate team.

// Write two foreach loops that iterate over each List and makes each of the teammates do their work.

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
           List <TeamMate> ClientSide = new List <TeamMate>();
           List <TeamMate> ServerSide = new List <TeamMate>();
           Mitchell MitchellBlom = new Mitchell ();
           Anessa AnessaOrtner = new Anessa();
           Ben BenGreaves = new Ben();
           Dwayne DwaynePate = new Dwayne();
           Izzy IsabelRamos = new Izzy();
           Geoff GeoffWebb = new Geoff();
           ClientSide.Add(IsabelRamos);
           ClientSide.Add(DwaynePate);
           ClientSide.Add(GeoffWebb);
           ServerSide.Add(AnessaOrtner);
           ServerSide.Add(BenGreaves);
           ServerSide.Add(MitchellBlom);
           foreach(TeamMate member in ServerSide)
           {
               member.Work();
           }
           foreach(TeamMate member in ClientSide)
           {
               member.Work();
           }
        }
    }

    interface TeamMate 
    {
        string Speciality { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName();
        void Work();
    }
    class Mitchell : TeamMate
    {
        public string Speciality { get; set; } = "Motivating the team";
        public string FirstName { get; set; } = "Mitchell";
        public string LastName { get; set; } = "Blom";

        public string FullName ()
        {
            return $"{FirstName} {LastName}";
        }

        public void Work () 
        {
            Console.WriteLine("Mitchell keeps the team organized, motivated, and on task.");
        }
        public Mitchell () {}
    }

    class Ben : TeamMate
    {
        public string Speciality { get; set; } = "Planning and Structure";
        public string FirstName { get; set; } = "Ben";
        public string LastName { get; set; } = "Greaves";

        public string FullName ()
        {
            return $"{FirstName} {LastName}";
        }

        public void Work () 
        {
            Console.WriteLine("Ben grumbles at the team about how they're not following the plan.");
        }
        public Ben () {}
    }
    class Anessa : TeamMate
    {
        public string Speciality { get; set; } = "Complex logic";
        public string FirstName { get; set; } = "Anessa";
        public string LastName { get; set; } = "Ortner";

        public string FullName ()
        {
            return $"{FirstName} {LastName}";
        }

        public void Work () 
        {
            Console.WriteLine("Anessa finds the hardest part of the project and launches herself into it, finishing an hour later.");
        }
        public Anessa () {}
    }
    class Dwayne : TeamMate
    {
        public string Speciality { get; set; } = "Dilligent coding";
        public string FirstName { get; set; } = "Dwayne";
        public string LastName { get; set; } = "Pate";

        public string FullName ()
        {
            return $"{FirstName} {LastName}";
        }

        public void Work () 
        {
            Console.WriteLine("Dwayne moves through his tasks, tackling them reliably and efficiently.");
        }
        public Dwayne () {}
    }
    class Izzy : TeamMate
    {
        public string Speciality { get; set; } = "Design";
        public string FirstName { get; set; } = "Isabel";
        public string LastName { get; set; } = "Ramos";

        public string FullName ()
        {
            return $"{FirstName} {LastName}";
        }

        public void Work () 
        {
            Console.WriteLine("Isabel focuses on the look and feel of the project, bringing the UI/UX plan to life.");
        }
        public Izzy () {}
    }
    class Geoff : TeamMate
    {
        public string Speciality { get; set; } = "Jack of all trades";
        public string FirstName { get; set; } = "Geoff";
        public string LastName { get; set; } = "Webb";

        public string FullName ()
        {
            return $"{FirstName} {LastName}";
        }

        public void Work () 
        {
            Console.WriteLine("Geoff takes on all the tasks assigned to him, and knocks them out with improvements.");
        }
        public Geoff () {}
    }
    
}
