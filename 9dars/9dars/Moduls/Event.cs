using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Event
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Description { get; set; }
    public List<string> AttendenceMembers { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
}