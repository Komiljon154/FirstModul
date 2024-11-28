using System.Collections.Generic;
using System;

public class Event
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public DateTime DateTime { get; set; }
    public string Discription { get; set; }
    public List<string> Attends { get; set; } = new List<string>();
    public List<string> Tags { get; set; } = new List<string>();
}






