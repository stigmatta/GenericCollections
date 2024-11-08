

namespace GenericCollections
{
    public class Employee
    {
        public string Password { get; set; }
        public string Login { get; set; }
    }
    public class AccountManagement
    {
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        public AccountManagement(Employee[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
                dict.Add(arr[i].Login, arr[i].Password);
        }

        public void Add(Employee e)
        {
            dict.Add(e.Login, e.Password);
        }

        public void Remove(string login) {
            dict.Remove(login);
        }

        public void Print()
        {
            foreach(var obj in dict)
            {
                Console.WriteLine($"{obj.Key} - {obj.Value}");
            }
        }

        public void ChangeInfo(string str)
        {
            if (dict.ContainsKey(str))
            {
                Console.WriteLine("New password:");
                dict[str] = Console.ReadLine(); 
                Console.WriteLine($"Password successfully changed");
            }
            else
            {
                Console.WriteLine("Employee with the provided login not found.");
            }
        }

        public void PrintPassword(string str)
        {
            if (dict.ContainsKey(str))
            {
                Console.WriteLine($"Password:{dict[str]}");
            }
        }

    }
}
