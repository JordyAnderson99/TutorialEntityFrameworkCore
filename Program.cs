using System;

namespace TutorialEntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Contexto())
            {

                var std = new Estudiante()
                {
                    Name = "Bill"
                };

                context.Estudiante.Add(std);
                context.SaveChanges();
            }
        }
    }
}
