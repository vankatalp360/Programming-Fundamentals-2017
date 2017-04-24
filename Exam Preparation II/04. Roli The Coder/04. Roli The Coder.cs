using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    public class Event
    {
        public int ID { get; set; }
        public string EventName { get; set; }
        public List<string> Participant { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var line = string.Empty;
            var allEvents = new List<Event>();
            var eventsById = new Dictionary<int, Event>();

            while (true)
            {
                line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;
                }

                var token = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var eventId = 0;
                var eventName = string.Empty;
                var participants = new List<string>();

                if (!int.TryParse(token[0], out eventId))
                {
                    continue;
                }

                if (token.Length > 1 && token[1].StartsWith("#"))
                {
                    eventName = token[1].Trim('#');
                }
                else
                {
                    continue;
                }

                if (token.Length > 2)
                {
                    participants = token.Skip(2).ToList();
                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }
                if (eventsById.ContainsKey(eventId))
                {
                    if (eventsById[eventId].EventName == eventName)
                    {
                        var existingEvent = eventsById[eventId];
                        existingEvent.Participant.AddRange(participants);
                    }
                
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    var currentEvent = new Event
                    {
                        ID = eventId,
                        EventName = eventName,
                        Participant = participants
                    };

                    allEvents.Add(currentEvent);
                    eventsById.Add(eventId, currentEvent);
                }
            }

            var sortedEvents = allEvents
                .OrderByDescending(p => p.Participant.Distinct().Count())
                .ThenBy(e => e.EventName).ToList();

            foreach (var ev in sortedEvents)
            {
                var currentParticipant = ev.Participant.Distinct().ToList();
                Console.WriteLine($"{ev.EventName} - {currentParticipant.Count}");
                foreach (var participant in currentParticipant.OrderBy(p => p))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }
}
