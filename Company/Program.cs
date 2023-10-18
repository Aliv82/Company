using System.Threading.Channels;

class company
{
    static void Main(string[] args)
    {
        employee E2 = new employee("javat", "javati", "1", "46151376", DateTime.Now, true);
        Console.WriteLine("_________________________________");
        employee E3 = new employee("hassan", "mamadi", "", "15437254", DateTime.Now, false);
        Console.WriteLine("_________________________________");
        Console.WriteLine("please insert your employee \nName\nFamily\nAccountNumber\nhierd or not?(true or false)  ");
        employee E1 = new employee(Console.ReadLine(), Console.ReadLine(), "2", Console.ReadLine(), DateTime.Now, Convert.ToBoolean(Console.ReadLine()));
        
        
        
        Console.ReadKey();
    }



    class employee : HR
    {
        public employee(string name, string family, string id, string accountnumber, DateTime hireTime, bool hire) : base(name, family, id, accountnumber, hireTime, hire)
        {
        }
    }

    class HR
    {
        public String Name;
        public string Family;
        public string ID;
        public string AcountNumber;
        public DateTime HireTime;
        public bool Hire;


        public HR(string name, string family, string id, string accountnumber, DateTime hireTime, bool hire)
        {
            Name = name;
            Family = family;
            ID = id;
            AcountNumber = accountnumber;
            HireTime = hireTime;
            Hire = hire;

            if (hire)
            {
                hireTime = DateTime.Now;
                Console.WriteLine("name : " + name + "\nfamily : " + family + "\nID : " + id + "\nAccountNumber : " + accountnumber + "\nHireTime : " + hireTime);
           
            }
            else
            {
                hireTime = new DateTime();
                Console.WriteLine("you are not our employee");
            }

        }
        public List<string> LIemployee = new List<string>();

        public void HireEmployee(employee employee)
        {
            LIemployee.Add(employee.Name + employee.Family + employee.ID + employee.AcountNumber + employee.HireTime);
        }
        public void Fireemployee(employee employee)
        {
            LIemployee.Remove(employee.Name + employee.Family + employee.ID + employee.AcountNumber + employee.HireTime);

        }

    }
    class Bank 
    {
        public Bank(employee employee) 
        {
            float salary = 100;
            
        }
    }

}
