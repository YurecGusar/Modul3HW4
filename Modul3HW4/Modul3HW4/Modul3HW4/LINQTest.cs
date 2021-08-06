using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class LINQTest
    {
        public void LINQStart()
        {
            var teamList = new Team();
            var contactList = new List<Contact>();

            contactList.Add(new Contact { Name = "Саша", Phone = "0509174123" });
            contactList.Add(new Contact { Name = "Андрей", Phone = "8805553535" });
            contactList.Add(new Contact { Name = "Дима", Phone = "0677600686" });
            contactList.Add(new Contact { Name = "Юра", Phone = "0959137264" });
            contactList.Add(new Contact { Name = "Самир", Phone = "0679734125" });

            var newContactList1 = contactList.FirstOrDefault(item => item.Name == "Андрей");
            var newContactList2 = contactList.Where(item => item.Name.ToUpper().StartsWith("С"));
            var newContactList3 = contactList.Select(item => item);

            Console.WriteLine($"{newContactList1.Phone} {newContactList1.Name}");

            foreach (var item in newContactList2)
            {
                Console.WriteLine($"{item.Name} {item.Phone}");
            }

            Console.WriteLine();

            foreach (var item in newContactList3)
            {
                Console.WriteLine($"{item.Name} {item.Phone}");
            }
        }
    }
}
