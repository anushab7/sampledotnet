using MongoDB.Driver;
using System;

namespace ConsoleApp2
{
    class Student
    {
        public int Id { get; set; }

        public string Name  { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                //var conn = "mongodb+srv://systemuser_dev:ZwDjihzJzjRf44wgPMWJ@cluster0.kyanl.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
                var conn = "mongodb://systemuser_dev:ZwDjihzJzjRf44wgPMWJ@mclaren-shared-mongodb-4-4:27017";

                var database = new MongoClient(conn).GetDatabase("McLarenDev");
                var collection = database.GetCollection<Student>("Logs");

                collection.InsertOne(new Student() { Id = 3, Name = "Prasad" });
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
