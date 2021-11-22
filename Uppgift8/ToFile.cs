using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uppgift8
{
    //11
     class ToFile : PersonCreator
    {
        protected override void StorePeople()
        {
            foreach (var item in _people)
            {
                File.WriteAllText("person.txt", "Name= " + item.Name + "," + "Age= " + item.Age + ","+ "Hegiht= " +  item.Height);
            }
        }
    }
}
