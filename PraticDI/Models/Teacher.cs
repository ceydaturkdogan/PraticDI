namespace PraticDI.Models
{
    public class Teacher:ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
