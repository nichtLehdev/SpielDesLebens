// @author: Kevin Kern, Maximilian Koch, Lars Lehmann
// Generates a list of actions for the player to choose from. The list contains 4 actions. The actions are loaded from a JSON file.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SpielDesLebens
{
    internal class ActionGenerator
    {
        private readonly List<Action> _actions;
        private List<Action> _oldActions = new List<Action>();
        private int _seed;

        public ActionGenerator()
        {
            _actions = LoadActions();
        }

        // Saves all actions from JSON to LoadActions in a list, saves all LoadActions as Actions.
        private List<Action> LoadActions()
        {
            if (File.Exists(Data.filenameActions))
            {
                List<LoadAction> loadActions = JsonConvert.DeserializeObject<List<LoadAction>>(File.ReadAllText(Data.filenameActions));
                return ActionListConverter.ConvertLoadActionsToActions(loadActions);
            }
            else
            {
                throw new Error("ActionGenerator: File not found");
            }

        }

        public List<Action> GetActions()
        {
            List<Action> nextActions = new List<Action>();
            while (nextActions.Count < 4)
            {
                Action action = RandomAction();
                if (!nextActions.Contains(action) && !_oldActions.Contains(action))
                {
                    nextActions.Add(action);
                }
            }
            _oldActions = nextActions;
            return nextActions;
        }

        private Action RandomAction()
        {
            _seed = DateTime.Now.Millisecond;
            Random random = new Random(_seed);
            int actionIndex = random.Next(_actions.Count);
            return _actions[actionIndex];
        }

        // For Debugging only !!!
#if DEBUG
        public List<Action> GetActionsDebug()
        {
            return _actions;
        }
#endif
    }
}
