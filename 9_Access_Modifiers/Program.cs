using _9_Access_Modifiers.Models;

namespace _9_Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ibrahim = new Employee("Ibrahim", false, 350);

            ibrahim.GetPromotion(ibrahim);
            ibrahim.GetFeedBack(ibrahim);
            
            

            Console.WriteLine(ibrahim.Salary);
        }

        
    }
}
