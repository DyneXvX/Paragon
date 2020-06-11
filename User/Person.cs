using System.Collections.Generic;

namespace Paragon
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person(string firstName)
        :this()
        {
            FirstName = firstName;
        }

        public Person(string firstName, string lastName)
            : this(firstName)
        {
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            Age = age;
        }

        public string Name(string name)
        {
            
            var lower = name.ToLower();
            List<string> namesList = new List<string>{"cindy", "dan"};
            foreach (var user in namesList)
            {
                if (lower == "justin")
                {
                    FirstName = "Master";
                    return FirstName;
                }
                if(lower == user)
                {
                    FirstName = name;
                    return char.ToUpper(FirstName[0]) + FirstName.Substring(1);
                }

            }
            return "noAccess";
        }
    }
}