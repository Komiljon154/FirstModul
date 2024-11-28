using Lesson9_CRUD_posts.Models;
using System;

namespace Lesson9_CRUD_posts
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartFrontEndEvent();
        }
        public static void StartFrontEndEvent()
        {
            var eventService = new EventService();
            while (true)
            {
                Console.WriteLine("1. Add Event : ");
                Console.WriteLine("2. Update Event : ");
                Console.WriteLine("3. Delete event : ");
                Console.WriteLine("4. Get all Eventc: ");
                Console.WriteLine("5. Get one Event :");
                Console.WriteLine("6. Get events by location :");
                Console.WriteLine("7. Get max tagged Event :");
                Console.WriteLine("8. Add person to Event : ");
                Console.Write("Choose --> : ");
                var choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    var evenT = new Event();
                    Console.Write("Enter Title :");
                    evenT.Title = Console.ReadLine();
                    Console.Write("Enter Location : ");
                    evenT.Location = Console.ReadLine();
                    evenT.DateTime = DateTime.Now;
                    Console.Write("Enter Discription : ");
                    evenT.Discription = Console.ReadLine();
                    Console.Write("ENter Attends count : ");
                    var countAttends = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countAttends; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Attend :");
                        var attend = Console.ReadLine();
                        evenT.Attends.Add(attend);
                    }
                    Console.Write("Enter Tags count : ");
                    var countTags = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countTags; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Tag :");
                        var tag = Console.ReadLine();
                        evenT.Tags.Add(tag);
                    }
                    eventService.AddEvent(even);
                    Console.WriteLine("Event Added . . . ");
                }
                else if (choose == 2)
                {
                    var evenT = new Event();
                    Console.Write("Enter Id : ");
                    evenT.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Title :");
                    evenT.Title = Console.ReadLine();
                    Console.Write("Enter Location : ");
                    evenT.Location = Console.ReadLine();
                    evenT.DateTime = DateTime.Now;
                    Console.Write("Enter Discription : ");
                    evenT.Discription = Console.ReadLine();
                    Console.Write("ENter Attends count : ");
                    var countAttends = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countAttends; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Attend :");
                        var attend = Console.ReadLine();
                        evenT.Attends.Add(attend);
                    }
                    Console.Write("Enter Tags count : ");
                    var countTags = int.Parse(Console.ReadLine());
                    for (var i = 0; i < countTags; ++i)
                    {
                        Console.Write($"Enter {i + 1} - Tag :");
                        var tag = Console.ReadLine();
                        evenT.Tags.Add(tag);
                    }
                    var result = eventService.UpdateEvent(evenT);
                    if (result)
                    {
                        Console.WriteLine("Updated . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Eror . . . ");
                    }
                }
                else if (choose == 3)
                {
                    Console.Write("Enter Delete event Id");
                    var id = Guid.Parse(Console.ReadLine());
                    var result = eventService.DeleteEvent(id);
                    if (result)
                    {
                        Console.WriteLine("Deleted . . . ");
                    }
                    else
                    {
                        Console.WriteLine("Eror . . . ");
                    }
                }
                else if (choose == 4)
                {
                    var eventAll = eventService.GetAllEvent();
                    foreach (var eventt in eventAll)
                    {
                        Console.WriteLine($"ID  :          {eventt.Id}");
                        Console.WriteLine($"Title  :       {eventt.Title}");
                        Console.WriteLine($"Location  :    {eventt.Location}");
                        Console.WriteLine($"Date Time  :   {eventt.DateTime}");
                        Console.WriteLine($"Diccription  : {eventt.Discription}");

                    }
                }
                else if (choose == 5)
                {
                    Console.Write("Enter id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var eventt = eventService.GetById(id);
                    if (eventt != null)
                    {
                        Console.WriteLine($"ID :          {eventt.Id}");
                        Console.WriteLine($"Title :       {eventt.Title}");
                        Console.WriteLine($"Location :    {eventt.Location}");
                        Console.WriteLine($"Date Time :   {eventt.DateTime}");
                        Console.WriteLine($"Diccription : {eventt.Discription}");
                        foreach (var attend in eventt.Attends)
                        {
                            Console.Write($"{attend} , ");
                        }
                        foreach (var tag in eventt.Tags)
                        {
                            Console.Write($"{tag} , ");
                        }
                    }

                }
                else if (choose == 6)
                {
                    Console.Write("Enter location >> ");
                    var eventLocation = Console.ReadLine();
                    var allEventsList = eventService.GetEventsByLocation(eventLocation);
                    foreach (var evenT in allEventsList)
                    {
                        Console.WriteLine($"ID :          {evenT.Id}");
                        Console.WriteLine($"Title :       {evenT.Title}");
                        Console.WriteLine($"Location :    {evenT.Location}");
                        Console.WriteLine($"Discription : {evenT.DateTime}");
                    }

                }
                else if (choose == 7)
                {
                    Console.WriteLine("The event id with the most tags : ");
                    var id = eventService.GetMaxTaggedEvent();
                    Console.WriteLine(id);
                }
                else if (choose == 8)
                {
                    Console.Write("Enter Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var eventt = eventService.GetById(id);
                    Console.Write("Enter add person name :");
                    var name = Console.ReadLine();
                    eventt.Attends.Add(name);
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}