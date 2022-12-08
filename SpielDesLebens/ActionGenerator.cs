// @author: Kevin Kern, Maximilian Koch, Lars Lehmann

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SpielDesLebens
{
    internal class ActionGenerator
    {
        private readonly List<Action> actions;
        private List<Action> oldActions = new List<Action>();
        private int seed;

        public ActionGenerator()
        {
            actions = LoadActions();
        }

        private List<Action> LoadActions()
        {
            // saves all actions from JSON to LoadActions in a list, saves all LoadActions as Actions
            string filename = "..//..//..//data//actions.json";
            if (File.Exists(filename))
            {
                List<LoadAction> loadActions = JsonConvert.DeserializeObject<List<LoadAction>>(File.ReadAllText(filename));
                return ActionListConverter.ConvertLoadActionsToActions(loadActions);
            }
            else
            {
                throw new Error("Actiongenerator: File not found");
            }

        }

        public List<Action> GetActions()
        {
            List<Action> nextActions = new List<Action>();
            while (nextActions.Count < 4)
            {
                Action action = RandomAction();
                if (!nextActions.Contains(action) && !oldActions.Contains(action))
                {
                    nextActions.Add(action);
                }
            }
            oldActions = nextActions;
            return nextActions;
        }

        private Action RandomAction()
        {
            seed = DateTime.Now.Millisecond;
            Random random = new Random(seed);
            int actionIndex = random.Next(actions.Count);
            return actions[actionIndex];
        }

        // for Debugging only !!!
        public List<Action> GetActionsDebug()
        {
            return actions;
        }
    }
}
