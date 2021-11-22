using System;

namespace Uppgift8
{
    //11
    class Program
    {
        static void Main(string[] args)
        {
            //// Uncomment the lines below when you've completed your implementations
            PersonCreator consolePersonCreator = new PersonList(); // Your code from part A here
            consolePersonCreator.CreatePeople();

            PersonCreator filePersonCreator = new ToFile(); // Your code from part B here
            filePersonCreator.CreatePeople();
        }
    }
}
