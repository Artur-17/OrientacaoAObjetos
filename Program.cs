using System;
using Balta.ContentContext;

namespace Balta
{
    class Program 
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));
           
            
            var courses = new List<Course>();

            var courseOOP    = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSharp = new Course("Fundamentos C#", "csharp");
            var courseDOTNET = new Course("Fundamentos dotnet", "dotnet");

            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseCSharp);

            var careers = new List<Career>();
            
            var careerDotNET = new Career("Especialista .NET", "especialista=dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem3 = new CareerItem(3, "Aprenda OOP", "", courseCSharp);
            var careerItem2 = new CareerItem(2, "Aprenda C#", "", courseDOTNET);

            careerDotNET.Items.Add(careerItem);
            careerDotNET.Items.Add(careerItem3);
            careerDotNET.Items.Add(careerItem2);
            careers.Add(careerDotNET);
            
            foreach (var career in careers)            
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x=> x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                     Console.WriteLine(item.Course?.Title );
                     Console.WriteLine(item.Course?.Level );
                }
            }

            
        }
    }
}