﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Spiel_Des_Lebens
{
   internal class EventListConverter
   {
      private string id;
      private List<int> possibleValues;
      private List<int> exeptedValues;

      public EventListConverter() { }

      public List<Event> convertLoadEventToEvent(List<loadEvent> eList)
      {
         List<Event> events = new List<Event>();
         foreach (loadEvent e in eList)
         {
            this.id = e.id;
            List<Timing> timings = new List<Timing>();
            foreach (loadTiming lt in e.requirements.timings)
            {
               timings.Add(evaluateTimings(lt));
            }

            Requirement r = new Requirement(timings, Converter.convertLoadStatToStat(e.requirements.stats_min), Converter.convertLoadStatToStat(e.requirements.stats_max));

            List<Option> oList = new List<Option>();
            foreach (loadOption o in e.options)
            {
               oList.Add(Converter.convertLoadOptionToOption(o));
            }


            events.Add(new Event(e.id, e.title, e.text, e.info, e.priority, r, oList));

         }
         return events;
      }

      private Timing evaluateTimings(loadTiming lTiming)
      {
         List<string> path = lTiming.path;
         List<string> profession = lTiming.profession;
         List<string> phase = lTiming.phase;

         int[] ePaths = evaluatePaths(path);
         int[] eProfessions = evaluateProfessions(profession);
         int[] ePhases = evaluatePhaseList(phase, ePaths);

         return new Timing(ePaths.ToList(), eProfessions.ToList(), ePhases.ToList());

      }

      private int[] evaluatePaths(List<string> paths)
      {
         if (paths != null)
         {
            if (paths.IndexOf("*") != -1)
            {
               int length = Enum.GetNames(typeof(Data.Path)).Length;
               int[] newPaths = new int[length];

               for (int i = 0; i < length; i++)
               {
                  newPaths[i] = i;
               }

               return newPaths;

            }
            else
            {
               List<int> parsedPaths = new List<int>();
               foreach (string path in paths)
               {
                  try
                  {
                     parsedPaths.Add(int.Parse(path));
                  }
                  catch (Exception ex)
                  {
                     // throw new Error(ex.Message.ToString());
                     throw new Error("EventListConverter: Error parsing path in event " + this.id);
                  }
               }
               return parsedPaths.ToArray();
            }
         }
         else
         {
            throw new Error("Path is empty (Event_ID: " + this.id + ")");
         }
      }

      private int[] evaluateProfessions(List<string> paths)
      {
         if (paths != null)
         {
            if (paths.IndexOf("*") != -1)
            {
               int length = Enum.GetNames(typeof(Data.Profession)).Length;
               int[] newProfessions = new int[length];

               for (int i = 0; i < length; i++)
               {
                  newProfessions[i] = i;
               }

               return newProfessions;

            }
            else
            {
               List<int> parsedProfessions = new List<int>();
               foreach (string path in paths)
               {
                  try
                  {
                     parsedProfessions.Add(int.Parse(path));
                  }
                  catch (Exception ex)
                  {
                     throw new Error(ex.Message);
                  }
               }
               return parsedProfessions.ToArray();
            }
         }
         else
         {
            throw new Error("Profession is empty (Event_ID: " + this.id + ")");
         }
      }
      private int[] evaluatePhaseList(List<string> phases, int[] paths)
      {
         possibleValues = new List<int>();
         exeptedValues = new List<int>();

         if (phases != null)
         {
            if (phases.IndexOf("*") != -1)
            {
               int length = getGreatestPhaseCount(paths);
               return fillList(length).ToArray();

            }
            else
            {
               foreach (string phase in phases)
               {
                  evaluatePhase(phase, paths);
               }
               return compareLists(possibleValues, exeptedValues).ToArray();
            }
         }
         throw new Error("No Phases given (Event_ID: " + this.id + ")");
      }

      private void evaluatePhase(string phase, int[] paths)
      {
         int bracketCount = 0;

         for (int i = 0; i < phase.Length; i++)
         {
            if (phase[i] == '(')
            {
               bracketCount++;
            }
            else if (phase[i] == ')')
            {
               bracketCount--;
            }
         }
         if (bracketCount != 0)
         {
            throw new Error("Unequal count of brackets in phase '" + phase + "' (Event_ID: " + this.id + ")");
         }
         int exMarkIdx = phase.IndexOf('!');
         int moduloIdx = phase.IndexOf('%');

         if (exMarkIdx != -1 && moduloIdx != -1)
         {
            //% before !
            if (moduloIdx < exMarkIdx)
            {
               possibleValues.AddRange(moduloCheck(phase, paths));
               exeptedValues.AddRange(exMarkCheck(phase, paths));
            }
            else
            {
               possibleValues.AddRange(fillList(getGreatestPhaseCount(paths)));
               exeptedValues.AddRange(exMarkCheck(phase, paths));
            }
         }
         else if (exMarkIdx != -1 && moduloIdx == -1)
         {
            possibleValues.AddRange(fillList(getGreatestPhaseCount(paths)));
            exeptedValues.AddRange(exMarkCheck(phase, paths));
         }
         else if (moduloIdx != -1 && exMarkIdx == -1)
         {
            possibleValues.AddRange(moduloCheck(phase, paths));
         }
         else
         {
            if (Int32.TryParse(phase, out int res))
            {
               possibleValues.Add(Int32.Parse(phase));
            }
         }

      }

      private List<int> compareLists(List<int> pList, List<int> eList)
      {
         List<int> comparedList = new List<int>();
         foreach (int pVal in pList)
         {
            if (eList.IndexOf(pVal) == -1)
            {
               comparedList.Add(pVal);
            }
         }
         return comparedList;
      }


      private List<int> fillList(int length)
      {
         List<int> list = new List<int>();
         for (int i = 1; i < length + 1; i++)
         {
            list.Add(i);
         }
         return list;
      }


      private List<int> exMarkCheck(string phase, int[] paths)
      {
         int exMarkIdx = phase.IndexOf('!');
         List<int> exMarkCheck = new List<int>();


         if (exMarkIdx != -1)
         {
            if (exMarkIdx == 0)
            {
               throw new Error("Char ! in phase '" + phase + "' at wrong position(" + exMarkIdx + "). * is missing infront of !. (Event_ID: " + this.id + ")");
            }
            else if (exMarkIdx == phase.Length)
            {
               throw new Error("Char ! in phase '" + phase + "' at wrong position(" + exMarkIdx + "). something is missing behind !. (Event_ID: " + this.id + ")");
            }
            else if (phase[exMarkIdx - 1] != '*' && phase[exMarkIdx - 1] != ')')
            {
               throw new Error("Wrong char infront  of ! at pos: " + exMarkIdx + " in phase '" + phase + "'. (Event_ID: " + this.id + ")");
            }
            else if (phase[exMarkIdx + 1] != '(')
            {
               if (exMarkIdx + 2 < phase.Length && Int32.TryParse(phase.Substring(exMarkIdx + 1, 2), out int res1))
               {
                  exMarkCheck.Add(Int32.Parse(phase.Substring(exMarkIdx + 1, 2)));
               }
               else if (Int32.TryParse(phase.Substring(exMarkIdx + 1, 1), out int res2))
               {
                  exMarkCheck.Add(Int32.Parse(phase.Substring(exMarkIdx + 1, 1)));
               }
               else
               {
                  throw new Error("Char ! in phase '" + phase + "' at wrong position(" + exMarkIdx + "). something is missing or wrong behind !. (Event_ID: " + this.id + ")");
               }
            }
            else if (phase[exMarkIdx + 1] == '(')
            {
               //!(*%2)
               if (exMarkIdx + 5 < phase.Length)
               {
                  if (phase[exMarkIdx + 5] != ')')
                  {
                     throw new Error("Wrong Char (not ')') at idx: " + exMarkIdx + 5 + " in phase '" + phase + "'. (Event_ID: " + this.id + ")");
                  }
                  else
                  {
                     exMarkCheck = moduloCheck(phase.Substring(exMarkIdx + 1, 5), paths);
                  }
               }
            }
         }
         return exMarkCheck;
      }

      private List<int> moduloCheck(string phase, int[] paths)
      {
         List<int> moduloCheck = new List<int>();
         int moduloIdx = phase.IndexOf('%');
         if (moduloIdx != -1)
         {

            if (phase[moduloIdx + 1] != '2' && phase[moduloIdx + 1] != '3')
            {
               throw new Error("Wrong char after % in phase '" + phase + "' (only 2,3 possible) (Event_ID: " + this.id + ")");
            }
            else if (moduloIdx == 0)
            {
               throw new Error("Char % in phase '" + phase + "' at wrong position(0). * is missing infront of %. (Event_ID: " + this.id + ")");
            }
            else if (moduloIdx == phase.Length)
            {
               throw new Error("Char % in phase '" + phase + "' at wrong position(" + moduloIdx + "). something is missing behind %. (Event_ID: " + this.id + ")");
            }
            else if (moduloIdx >= 1 && phase[moduloIdx - 1] != '*')
            {
               throw new Error("Wrong char infront of % in phase '" + phase + "' at idx: " + moduloIdx + " (Event_ID: " + this.id + ")");
            }
            else
            {
               int length = getGreatestPhaseCount(paths);
               int moduloValue = Int32.Parse(phase[moduloIdx + 1].ToString());
               for (int i = 1; i < length + 1; i++)
               {
                  if (i % moduloValue == 0)
                  {
                     moduloCheck.Add(i);
                  }
               }
               return moduloCheck;
            }
         }
         else
         {
            return moduloCheck;
         }

      }


      private int getGreatestPhaseCount(int[] paths)
      {
         int greatestCount = 0;
         foreach (int path in paths)
         {
            int count = (int)((3 * 12) / Data.phaseL[path]);
            if (count > greatestCount) greatestCount = count;
         }
         return greatestCount;
      }

   }
}

