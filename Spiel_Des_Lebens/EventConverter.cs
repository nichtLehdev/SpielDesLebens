using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Spiel_Des_Lebens.Data;

namespace Spiel_Des_Lebens
{
    internal class EventConverter
    {
        private string id;

        public EventConverter(loadEvent e){
            
        }

        private int[,,] evaluateTimings(Timing lTiming)
        {
            List<string> path = lTiming.path;
            List<string> profession = lTiming.profession;
            List<string> phase = lTiming.phase;

            int[] ePaths = evaluatePaths(path);
            int[] eProfessions = evaluateProfessions(profession);
            int[] ePhases = evaluatePhaseList(phase, ePaths);

            //TODO Convert 1D arrays into 3D array. 
            // Specify construction of 3D array.

            int[,,] timings = new int[0,0,0];

            return timings;

        }

        private int[] evaluatePaths(List<string> paths)
        {
            if(paths != null)
            {
                if(paths.IndexOf("*") != -1)
                {
                    int length = Enum.GetNames(typeof(Data.Path)).Length;
                    int[] newPaths = new int[length];

                    for(int i=0; i<length; i++)
                    {
                        newPaths[i] = i;
                    }

                    return newPaths;
                    
                }
                else
                {
                    List<int> parsedPaths = new List<int>();
                   foreach(string path in paths){
                        try
                        {
                            parsedPaths.Add(int.Parse(path));
                        }
                        catch (Exception ex)
                        {
                            throw new Error(ex.Message);
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
                    int length = Enum.GetNames(typeof(Profession)).Length;
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
            if (phases != null)
            {
                if (phases.IndexOf("*") != -1)
                {
                    int length = getGreatestPhaseCount(paths);
                    int[] newPhases = new int[length];
                    
                    for (int i = 0; i < length; i++)
                    {
                        newPhases[i] = i;
                    }

                    return newPhases;
                }
                else
                {
                    List<int> phaseList = new List<int>();
                    foreach (string phase in phases)
                    {
                        foreach (int p in evaluatePhase(phase, paths))
                        {
                            phaseList.Add(p);
                        }
                    }
                    return phaseList.ToArray();
                }
            }
            throw new Error("No Phases given (Event_ID: " + this.id + ")");
        }
        
        private int[] evaluatePhase(string phase, int[] paths)
        {
            int bracketCount = 0;
            List<int> possiblePhases = new List<int>();
            List<int> exeptedPhases = new List<int>();

            for(int i = 0; i<phase.Length; i++)
            {
                if(phase[i] == '(')
                {
                    bracketCount++;
                }
                else if (phase[i] == ')')
                {
                    bracketCount--;
                }
            }
            if(bracketCount != 0)
            {
                throw new Error("Unequal count of brackets in phase '" + phase + "' (Event_ID: " + this.id + ")");
            }
            int exMarkIdx = phase.IndexOf('!');
            int moduloIdx = phase.IndexOf('%');

            if(exMarkIdx != -1 && moduloIdx != -1) 
            { 
                //% before !
                if(moduloIdx < exMarkIdx)
                {
                    possiblePhases = moduloCheck(phase, paths);
                    exeptedPhases = exMarkCheck(phase, paths);
                }
                else
                {
                    possiblePhases = fillList(getGreatestPhaseCount(paths));
                    exeptedPhases = exMarkCheck(phase, paths);
                }
            }
            else if(exMarkIdx != -1 && moduloIdx == -1)
            {
                possiblePhases = fillList(getGreatestPhaseCount(paths));
                exeptedPhases = exMarkCheck(phase, paths);
            }
            else if(moduloIdx != -1 && exMarkIdx == -1)
            {
                possiblePhases = moduloCheck(phase, paths);
            }
            else
            {
                if(Int32.TryParse(phase, out int res))
                {
                    possiblePhases.Add(Int32.Parse(phase));
                }
            }
            return compareLists(possiblePhases, exeptedPhases).ToArray();
        }

        private List<int> compareLists(List<int> pList, List<int> eList)
        {
            foreach (int pVal in pList)
            {
                foreach (int eVal in eList)
                {
                    if(pVal == eVal)
                    {
                        pList.Remove(eVal);
                    }
                }
            }
            return pList;
        }


        private List<int> fillList(int length)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < length; i++)
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
                        if (phase[exMarkIdx + 5]!= ')')
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

                if (phase[moduloIdx + 1] != 2 && phase[moduloIdx + 1] != 3)
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
                    for (int i = 0; i < length; i++)
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
            foreach(int path in paths)
            {
                int count = (int)((3 * 12) / phaseL[path]);
                if (count > greatestCount) greatestCount = count;
            }
            return greatestCount;
        }


        private Option convertLoadOptionToOption(loadOption lOption)
        {
            return new Option(lOption.id, lOption.title, lOption.text, convertLoadStatToStat(lOption.stats));
        }

        private Stat convertLoadStatToStat(loadStat lStat)
        {
            return new Stat(lStat.mentalHealth, lStat.money, lStat.motivation, lStat.success);
        }

    }
}
