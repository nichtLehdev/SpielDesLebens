using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class ActionListConverter
    {
        public static List<Action> convertLoadActionsToActions(List<loadAction> loadActions)
        {
            List<Action> actions = new List<Action>();
            foreach(loadAction la in loadActions)
            {
                actions.Add(new Action(la.id, la.title, la.info, Converter.convertLoadOptionToOption(la.result)));
            }
            return actions;
        }
    }
}
