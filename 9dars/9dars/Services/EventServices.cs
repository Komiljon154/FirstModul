using System.Collections.Generic;
using System;
using System.Xml.Linq;



public class EventService
{
    private List<Event> ListedEvents;

    public EventService()
    {
        ListedEvents = new List<Event>();
        DataSeed();
    }


    public Event AddedEvent(Event addingEvent)
    {
        addingEvent.Id = Guid.NewGuid();
        ListedEvents.Add(addingEvent);
        return addingEvent;
    }


    public Event GetByID(Guid eventID)
    {
        foreach (var check in ListedEvents)
        {
            if (check.Id == eventID)
            {
                return check;
            }
        }
        return null;
    }


    public bool DeletedEvent(Guid eventID)
    {
        var removingEvent = GetByID(eventID);

        if (removingEvent is null)
        {
            return false;
        }

        ListedEvents.Remove(removingEvent);
        return true;
    }


    public bool UpdatedEvent(Guid eventId, Event newEvent)
    {
        var checkEvent = GetByID(eventId);

        if (checkEvent is null)
        {
            return false;
        }

        ListedEvents[ListedEvents.IndexOf(checkEvent)] = newEvent;
        return true;
    }


    public List<Event> GetAllEvents()
    {
        return ListedEvents;
    }



   



    public List<Event> GetEventsByLocation(string location)
    {
        var collectEvents = new List<Event>();

        foreach (var eveent in ListedEvents)
        {
            if (eveent.Location == location)
            {
                collectEvents.Add(eveent);
            }
        }
        return collectEvents;
    }



    public Event GetPopularEvent()
    {
        var maxAmount = 0;
        var responceEvent = new Event();

        foreach (var eveent in ListedEvents)
        {
            if (eveent.AttendenceMembers.Count > maxAmount)
            {
                maxAmount = eveent.AttendenceMembers.Count;
                responceEvent = eveent;
            }
        }
        return responceEvent;
    }



    public Event GetMaxTaggedEvent()
    {
        var maxAmount = 0;
        var responceEvent = new Event();

        foreach (var eveent in ListedEvents)
        {
            if (eveent.Tags.Count > maxAmount)
            {
                maxAmount = eveent.Tags.Count;
                responceEvent = eveent;
            }
        }
        return responceEvent;
    }


    public void DataSeed()
    {

        var firstMember = new List<string>();
        firstMember.Add("Komiljon,");
        firstMember.Add("Aziz,");
        firstMember.Add("Lola,");
        firstMember.Add("Behruz,");
        firstMember.Add("Dilnoza,");
        firstMember.Add("Umid,");
        firstMember.Add("Ubaydullo.");

        var firstTagList = new List<string>();
        firstTagList.Add("Dam olishga bordik,");
        firstTagList.Add("Futbol o'ynadik,");
        firstTagList.Add("Yig'ilib dars qildik");


        var firstEvent = new Event()
        {
            Id = Guid.NewGuid(),
            Name = "Tug'ulgan kun",
            Location = "Chorsu",
            Date = DateTime.Now,
            Description = "Tug'ulgan kunga hamma keldi",
            AttendenceMembers = firstMember,
            Tags = firstTagList,
        };


        var secondMember = new List<string>();
        secondMember.Add("Kamoliddin,");
        secondMember.Add("Shahobiddin,");
        secondMember.Add("Mubina,");
        secondMember.Add("Daler,");
        secondMember.Add("Dovud,");
        

        var secondTagList = new List<string>();
        secondTagList.Add("Sayohat qildik,");
        secondTagList.Add("Dam oldik,");
        secondTagList.Add("Tadbirga bordik");


        var secondEvent = new Event()
        {
            Id = Guid.NewGuid(),
            Name = "Tug'ulgan Kun",
            Location = "Sergili",
            Date = DateTime.Now,
            Description = "Zo'r bo'ldi",
            AttendenceMembers = secondMember,
            Tags = secondTagList,
        };

        ListedEvents.Add(firstEvent);
        ListedEvents.Add(secondEvent);
    }
}