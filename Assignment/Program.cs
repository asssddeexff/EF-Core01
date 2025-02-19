using Assignment.Context;
using Assignment.entities;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext Context = new AppDbContext();
            // Context.Students.Where(S => S.Id == 0);

            //var student = new Student()
            //{

            //    FName = "Ahmed",
            //    LName = "Ali",
            //    Address = "Cairo",
            //    Age = 22,
            //    Dep_ID = 10

            //};

            //Console.WriteLine(Context.Entry(student).State);

            //student.LName = "Omar";

            //Console.WriteLine(Context.Entry(student).State);

            //Context.Add(student);
            //Context.Students.Add(student);
            //Console.WriteLine(Context.Entry(student).State);
            //Context.SaveChanges();


            //student.FName = "Amr";
            //Console.WriteLine(Context.Entry(student).State);
            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(student).State);


            //student.Address = "Alex";
            //Console.WriteLine(Context.Entry(student).State);
            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(student).State);



            // var result = Context.Students.Where(E => E.Id == 1).FirstOrDefault();

            //Console.WriteLine(Context.Entry(result).State);
            //result.FName = "Saad";

            //Console.WriteLine(Context.Entry(result).State);

            //Context.Update(result);

            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(result).State);



            //var Result = Context.Students.Select(E=>E.FName);

            //Console.WriteLine(Context.Entry(result).State);


            //result.FName = "Ali";

            //Console.WriteLine(Context.Entry(result).State);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(result?.FName);
            //Console.WriteLine(result?.Id);



            //var result = Context.Students.FirstOrDefault(E => E.Id == 2);
            //Console.WriteLine(Context.Entry(result).State);
            //Context.Students.Remove(result);
            //Console.WriteLine(Context.Entry(result).State);
            //Context.SaveChanges();




            var department = new Department()
            {
                Name="IS",
                Ins_ID= 1,
                HiringDate= DateTime.Now,


            };



            //Context.Add(department);
            //Context.Departments.Add(department);
            //Console.WriteLine(Context.Entry(department).State);
            //Context.SaveChanges();


            Console.WriteLine(Context.Entry(department).State);

            department.Name = "DS";

            Console.WriteLine(Context.Entry(department).State);

            Context.Add(department);
            Context.Departments.Add(department);
            Console.WriteLine(Context.Entry(department).State);
           


            department.Ins_ID = 3;
                 Console.WriteLine(Context.Entry(department).State);
            Context.SaveChanges();
            Console.WriteLine(Context.Entry(department).State);




            //var Result = Context.Departments.FirstOrDefault(D => D.Ins_ID == 3);
            //Console.WriteLine(Context.Entry(Result).State);
            //Context.Departments.Remove(Result);
            //Console.WriteLine(Context.Entry(Result).State);
            //Context.SaveChanges();



            //var course = new Course()
            //{
            //    Name="C#",
            //    Description="AAA",
            //    Duration=1,
            //    Top_ID=1





            //};





            //Console.WriteLine(Context.Entry(course).State);

            //course.Name = "java";

            //Console.WriteLine(Context.Entry(course).State);

            //Context.Add(course);
            //Context.Courses.Add(course);
            //Console.WriteLine(Context.Entry(course).State);
            //Context.SaveChanges();


            //course.Duration= 4;
            //Console.WriteLine(Context.Entry(course).State);
            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(course).State);


            //course.Description = "LL";
            //Console.WriteLine(Context.Entry(course).State);
            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(course).State);



            //var result = Context.Courses.Where(C => C.Id == 1).FirstOrDefault();

            //Console.WriteLine(Context.Entry(result).State);
            //result.Name = "Python";

            //Console.WriteLine(Context.Entry(result).State);

            //Context.Update(result);

            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(result).State);







            //var result = Context.Courses.FirstOrDefault(C => C.Id == 2);
            //Console.WriteLine(Context.Entry(result).State);
            //Context.Courses.Remove(result);
            //Console.WriteLine(Context.Entry(result).State);
            //Context.SaveChanges();


            var constructor = new Constructor()
            {
                Name="Mohammed",
                Salary=2000,
                Bouns=200,
                Address="Alex",
                HourRate=100,
                Dept_ID=1,


            };
            Console.WriteLine(Context.Entry(constructor).State);
            Context.Add(constructor);
            Context.Constructors.Add(constructor);
            Console.WriteLine(Context.Entry(constructor).State);


            // Console.WriteLine(Context.Entry(constructor).State);

            //constructor.Name = "Omar";

            // Console.WriteLine(Context.Entry(constructor).State);

            // Context.Add(constructor);
            // Context.Constructors.Add(constructor);
            // Console.WriteLine(Context.Entry(constructor).State);
            // Context.SaveChanges();
            // Console.WriteLine(Context.Entry(constructor).State);

            //constructor.Name= "Adel";
            //Console.WriteLine(Context.Entry(constructor).State);

            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(constructor).State);





            //var result = Context.Constructors.Where(C => C.Id == 1).FirstOrDefault();

            //Console.WriteLine(Context.Entry(result).State);
            //result.Name = "Ali";

            //Console.WriteLine(Context.Entry(result).State);

            //Context.Update(result);

            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(result).State);







            var result = Context.Constructors.FirstOrDefault(C => C.Id == 2);
            Console.WriteLine(Context.Entry(result).State);
            Context.Constructors.Remove(result);
            Console.WriteLine(Context.Entry(result).State);
            Context.SaveChanges();



        }
    }
}
