using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre orientação a objetos", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre Docker", "docker"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            //     Console.WriteLine();
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseDotnet = new Course("Fundamentos .NET", "fundamentos-dotnet");

            // foreach (var course in courses)
            // {
            //     Console.WriteLine(course.Id);
            //     Console.WriteLine(course.Title);
            //     Console.WriteLine(course.Url);
            //     Console.WriteLine();
            // }

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            careers.Add(careerDotnet);

            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseDotnet);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem2);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderByDescending(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title} - {item.Course?.Title} - {item.Course?.Level}");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}
