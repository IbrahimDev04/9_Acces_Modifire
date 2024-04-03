namespace _9_Access_Modifiers.Models
{
    internal class Employee : Manage
    {
        private string _name;
        private bool _isSuccesful;
        private double _salary;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsSuccesful
        {
            get { return _isSuccesful;}
            set { _isSuccesful = value;}
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Employee(string name, bool isSuccesful, double salary)
        {
            _name = name;
            _isSuccesful = isSuccesful;
            _salary = salary;
        }

        
        
    }
}
