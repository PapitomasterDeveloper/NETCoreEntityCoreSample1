using System;

namespace ConsoleApp.SQLite
{
    public class Program
    {
        public static void Main()
        {
            // New instance of BloggingContext from DbContext
            using (var db = new BloggingContext())
            {
                // From Blogs table, add a new Blog instance Collection
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
        }
    }
}