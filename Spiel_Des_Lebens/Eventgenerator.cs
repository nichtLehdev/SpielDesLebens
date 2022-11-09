using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;
using System;

namespace Spiel_Des_Lebens
{
    internal class Eventgenerator
    {
        private List<Event> events = new List<Event>();

        public Eventgenerator(EducationPath.Path path, EducationPath.Profession profession)
        {
            loadEvents(path, profession);
        }

        private void loadEvents(EducationPath.Path path, EducationPath.Profession profession)
        {
            // saves all events from JSON to events in List (filter by path and profession), leaves phases
           // string filename = "events.json";
            //if (File.Exists(filename))
           // {
             ///   var testevents = JObject.Parse(File.ReadAllText(filename))["events"];
                ///var results = from testevent in testevents
                   //        where (int)testevents["requirements"]["path"] == (int)path && (int)testevents["requirements"]["profession"] == (int)profession
                      //        select testevents;
                //Console.Write(results);

//            }
  //          else 
    //        { 
      //          throw new Error("Eventgenerator: File not found");
        //    }

        }

        public Event nextEvent(Stats stats, Phase phase)
        {
            // returns next Event
            return null; // delete!!!!!
        }
    }
}

