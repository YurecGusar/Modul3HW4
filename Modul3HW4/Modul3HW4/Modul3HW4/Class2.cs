using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class Class2
    {
        private Contact[] _contacts;

        public void RunTask()
        {
            _contacts = GetContacts();
            var linqTestContact1 = _contacts.FirstOrDefault((x) => x.FirstName == "Nastya");
            Console.WriteLine($"{linqTestContact1.FullName} {linqTestContact1.Phone}");
            Console.WriteLine();
            var linqTestContact2 = _contacts.Where((x) => x.LastName.StartsWith("Q"));
            foreach (var item in linqTestContact2)
            {
            Console.WriteLine($"{item.FullName} {item.Phone}");
            }

            Console.WriteLine();
            var linqTestContact3 = _contacts.Where((x) => x.LastName.StartsWith("F")).Select((x) => x.FirstName);

            foreach (var item in linqTestContact3)
            {
                Console.WriteLine(item);
            }
        }

        private Contact[] GetContacts()
        {
            return new Contact[]
           {
                new Contact
                {
                    FirstName = "Yuriy",
                    LastName = "Qwerty",
                    Phone = "099-673-11"
                },
                new Contact
                {
                    FirstName = "Denis",
                    LastName = "Asdfghjf",
                    Phone = "099-854-24"
                },
                new Contact
                {
                    FirstName = "Nastya",
                    LastName = "Qcvdjef",
                    Phone = "099-88-2312"
                },
                new Contact
                {
                    FirstName = "Helen",
                    LastName = "Fascvgkghhmng",
                    Phone = "099-570-11"
                },
                new Contact
                {
                    FirstName = "Volodia",
                    LastName = "Uga",
                    Phone = "099-55-88"
                },
                new Contact
                {
                    FirstName = "Rodion",
                    LastName = "Falam",
                    Phone = "032-673-11"
                }
           };
        }
    }
}
