namespace _9_Access_Modifiers.Models
{
    internal class Assistant : Manage
    {

       
        protected void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccesful==true)
            {
                employee.GetPromotion(employee);
            }
        }
    }
}
