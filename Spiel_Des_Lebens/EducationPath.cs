﻿using System;

namespace Spiel_Des_Lebens
{
    internal class EducationPath
    {
        private int phaseLength;
        private Data.Path path;
        private Data.Profession profession;
        private Phase phase;

        public EducationPath(Data.Path path, Data.Profession profession)
        {
            setPath(path);
            setProfession(profession);
            phaseLength = Data.phaseL[(int)path];
            phase = new Phase(phaseLength);
        }

        private void setPath(Data.Path path)
        {
            this.path = path;
        }

        private void setProfession(Data.Profession profession )
        {
            this.profession = profession;
        }

        public String getProfession()
        {
            return Data.career[(int)path,(int)profession];
        }

        public Phase getPhase()
        {
            return phase;
        }
    }
}
