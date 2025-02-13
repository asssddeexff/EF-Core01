using Assignment.Context;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext Context = new AppDbContext();
            Context.Students.Where(S => S.Id == 0);
           
        }
    }
}
