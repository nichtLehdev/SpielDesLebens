﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Spiel_Des_Lebens
{
    internal class ActionGenerator
    {

        public List<Action> loadActions()
        {
            // saves all events from JSON to events in list saves all loadEvents as events
            string filename = "..//..//..//data//actions.json";
            if (File.Exists(filename))
            {
                List<Action> loadActions = JsonConvert.DeserializeObject<List<Action>>(File.ReadAllText(filename));

                
                return loadActions;
            }
            else
            {
                throw new Error("Eventgenerator: File not found");
            }

        }
    }
}
