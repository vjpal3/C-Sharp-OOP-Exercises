using System;
using Exercises.Fields;
using Exercises.Property;
using Exercises.Indexers;
using Exercises.Composition;
using Exercises.Casting;
using Exercises.Polymorphism;
using System.Collections.Generic;
using Shape = Exercises.Polymorphism.Shape;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run Code for Polymorphism
            var shapes = new List<Shape> ();
            // Polymorphism at work #1: a Rectangle and Circle
            // can all be used whereever a Shape is expected. No cast is required
            // because an implicit conversion exists from a derived 
            // class to its base class.
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
            
            //Run code for Casting
            // Upcasting
            //Text text = new Text();
            //Shape shape = text;  //Upcasting (implicit), both shape and text are ref. to same object in memory
            //text.Width = 200;
            //shape.Width = 100;
            //Console.WriteLine(text.Width); // 100  

            // Downcasting - Runtime InvalidCastException
            //Shape shape = new Shape();
            //Text text = (Text)shape;  // Runtime InvalidCastException

            //Downcasting
            //Shape shape = new Text();

            // At compile-time, shape is of type Shape; At run-time, shape is of type Text. 
            //So the properties of Text are not visible to shape obj at compile time.
            //Text text = (Text) shape; // Downcasting, may throw an InvalidCastException if conversion is unsuccessful.
            // The properties of Text are visible to shape obj at compile time.
            //Console.WriteLine("FontSize: " + text.FontSize); 

            //Alternatively downcasting can be done this way:
            //Shape shape = new Text();
            // 'as' keyword
            //Text text = shape as Text;// 'as' keyword returns null if conversion is unsuccessful. 
            //If successful, it converts the object to target type.
            //if (shape != null)
            //{
            //    Console.WriteLine("FontSize: " + text.FontSize);
            //}

            // 'is' keyword
            //if(shape is Text)
            //{
            //    var text = (Text) shape;
            //    Console.WriteLine("FontSize: " + text.FontSize);
            //}

            //Run code for Composition
            //var migrator = new DBMigrator(new Logger());
            //var installer = new Installer(new Logger());

            //migrator.Migrate();
            //installer.Install();

            //Run code for Indexers
            //var cookie = new HttpCookie();
            //cookie["name"] = "Vrishali";
            //cookie["profession"] = "Developer";
            //Console.WriteLine(cookie["name"]);
            //Console.WriteLine(cookie["profession"]);

            //Run code for Properties
            //var person = new Person(new DateTime(1983, 01, 01));
            //Console.WriteLine(person.Birthdate); 
            //Console.WriteLine("Age: " + person.Age);

            // Run code for Fields
            //var customer = new Customer(3);
            //customer.orders.Add(new Order());
            //customer.orders.Add(new Order());

            //Console.WriteLine("Customer Orders: " + customer.orders.Count);

            // Run WorkFlowEngine
            //var workflow = new WorkFlow();

            //workflow.Add(new UploadVideo());
            //workflow.Add(new EncodeVideo());

            //var sendMail = new SendMail();
            //workflow.Add(sendMail);
            //workflow.Remove(sendMail);

            //var workFlowEngine = new WorkFlowEngine();
            //workFlowEngine.Run(workflow);

            //Implement Stack
            //var stack = new Stack();
            //try
            //{
            //    //stack.Push(null);   //Throws invalid operation exception
            //    //stack.Pop();          //Throws invalid operation exception
            //    stack.Push(1);
            //    stack.Push(2);
            //    stack.Push(3);
            //    Console.WriteLine(stack.Pop());
            //    Console.WriteLine(stack.Pop());
            //    Console.WriteLine(stack.Pop());
            //    //stack.Clear();
            //    Console.WriteLine(stack.Pop()); //Throws invalid operation exception             
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);              
            //}


            //Design a Stackoverflow Post
            //var post = new StackOverflowPost("What is a NullReferenceException, and how do I fix it?", "The runtime throwing a NullReferenceException always means the same thing: you are trying to use a reference, and the reference is not initialized");

            //post.Upvote();
            //post.Upvote();
            //post.Upvote();
            //post.Downvote();
            //post.Downvote();
            //post.Upvote();
            //post.Downvote();
            //post.Downvote();
            //post.Downvote();
            //post.Downvote();

            //Console.WriteLine("Currrent Vote value: " + post.GetVote());

            //Design a Stopwatch
            //try
            //{
            //    var stopwatch = new Stopwatch();
            //    Console.WriteLine("Stopwatch started:");
            //    stopwatch.Start();
            //    //stopwatch.Start();    //Throws invalid operation exception
            //    System.Threading.Thread.Sleep(3000);
            //    Console.WriteLine("Stopwatch is about to stop");
            //    stopwatch.Stop();
            //    Console.WriteLine("Duration: " + Math.Round(stopwatch.GetDuration().TotalSeconds) + " seconds");

            //    Console.WriteLine();

            //    Console.WriteLine("Stopwatch started:");
            //    stopwatch.Start();
            //    System.Threading.Thread.Sleep(2000);
            //    Console.WriteLine("Stopwatch is about to stop");
            //    stopwatch.Stop();
            //    //stopwatch.Stop();
            //    //Console.WriteLine("Duration: " + Math.Round(stopwatch.GetDuration().TotalSeconds) + " seconds");
            //    Console.WriteLine("{0:F3} seconds", stopwatch.GetDuration().TotalSeconds);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
