using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift8
{
    //11
     class PersonList : PersonCreator
    {
        protected override void StorePeople()
        {
            
            string format = "{0, -19}{1, 5}{2,-7}";
           
            Console.WriteLine(string.Format(format, "Name" , "Age" , "Height"));
            foreach (var item in _people)
            {
                Console.WriteLine(format, item.Name, item.Age, item.Height);
            }
        }
    }
}
