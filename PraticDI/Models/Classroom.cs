namespace PraticDI.Models
{
    public class Classroom
    {

        readonly ITeacher _teacher;

        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
            _teacher.GetInfo();
        }

    }
}
