using Lesson9_CRUD_posts.Models;
using System.Collections.Generic;
using System;

public class EventService
{
    private List<Event> events;
    public EventService()
    {
        events = new List<Event>();
    }
    public Event AddEvent(Event addingEvent)
    {
        addingEvent.Id = Guid.NewGuid();
        events.Add(addingEvent);
        return addingEvent;
    }

    public Event GetById(Guid eventId)
    {
        foreach (var evenT in events)
        {
            if (evenT.Id == eventId)
            {
                return evenT;
            }
        }

        return null;
    }



    public bool DeleteEvent(Guid eventId)
    {
        bool exists = false;
        foreach (var evenT in events)
        {
            if (evenT.Id == eventId)
            {
                events.Remove(evenT);
                exists = true;
                break;
            }
        }
        return exists;
    }
    public bool UpdateEvent(Event updateEvent)
    {
        bool exists = false;
        for (var i = 0; i < events.Count; i++)
        {
            if (events[i].Id == updateEvent.Id)
            {
                events[i] = updateEvent;
                exists = true;
                break;
            }
        }
        return exists;
    }
    public bool AddPersonToEvent(Guid idPost, string name)
    {
        foreach (var evenT in events)
        {
            if (evenT.Id == idPost)
            {
                evenT.Attends.Add(name);
                return true;
            }
        }
        return false;
    }
    public Guid GetMaxTaggedEvent()
    {
        var count = 0;
        var result = new Event();
        foreach (var evenT in events)
        {
            if (evenT.Tags.Count > count)
            {
                count = evenT.Tags.Count;
            }
        }
        foreach (var evenT in events)
        {
            if (count == evenT.Tags.Count)
            {
                result = evenT;
            }
        }
        return result.Id;
    }
    public List<Event> GetEventsByLocation(string location)
    {
        var collectEvents = new List<Event>();

        foreach (var evenT in events)
        {
            if (evenT.Location == location)
            {
                collectEvents.Add(evenT);
            }
        }
        return collectEvents;
    }


    public List<Event> GetAllEvent()
    {
        return events;
    }
}

