using System;
using System.Collections.Generic;

namespace Uppgift8
{
    //11
     abstract class PersonCreator
    {
        protected List<Person> _people;

        public PersonCreator()
        {
            _people = new List<Person>();
        }

        public void CreatePeople()
        {
            while (true)
            {
                Console.WriteLine("Enter a name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter an age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a height");
                double height = Convert.ToDouble(Console.ReadLine());

                Person person = new Person()
                {
                    Name = name,
                    Age = age,
                    Height = height
                };
                _people.Add(person);

                Console.WriteLine("Press Esc to stop creating persons. Press any other key to create another person.");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            StorePeople();
        }

        protected  abstract  void StorePeople();
    }
}
