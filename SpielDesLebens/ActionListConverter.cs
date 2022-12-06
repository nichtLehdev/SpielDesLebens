using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class ActionListConverter
    {
        public static List<Action> ConvertLoadActionsToActions(List<LoadAction> loadActions)
        {
            List<Action> actions = new List<Action>();
            foreach (LoadAction a in loadActions)
            {
                actions.Add(new Action(a.id, a.title, a.info, Converter.ConvertLoadOptionToOption(a.result)));
            }
            return actions;
        }
    }
}
