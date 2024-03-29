﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oběšenec_grafická_verze
{
    internal class HadaneSlovo
    {
        public string VymysleneSlovo = string.Empty;
        public string VratCastecneOdhaleneSlovo = string.Empty;
        private string substring = "_";
        public int PocetNeuspesnychPokusu = 0;
        public int CelkovyPocetPokusu = 12;
        public bool JePismenoVeSlove = false;
        private string[] poleHadanychSlov =
        {
            "kočka",
            "pes",
            "kráva",
            "husa",
            "prase",
            "ovce",
            "nosorožec",
            "lev",
            "žirafa",
            "slon",
            "krokodýl",
            "tygr",
            "kapybara",
            "hroch",
            "opice",
            "žížala",
            "pavouk",
            "chobotnice",
            "žralok",
            "delfín",
            "veverka",
            "medvěd",
            "bažant",
            "sysel",
            "křeček",
        }; //slova, ze kterých se postupně vybírají hádaná slova

        public void VymysliNoveSlovo()
        {
            Random generatorNahodnychCisel = new Random();
            int nahodneCislo = generatorNahodnychCisel.Next(poleHadanychSlov.Length);
            VymysleneSlovo = poleHadanychSlov[nahodneCislo]; //náhodně se vygeneruje hádané slovo z pole

        }

        public void VygenerujCastecneOdhaleneSlovo() //vygeneruje zakryté slovo o stejném počtu znaků.
        {
            for (int k = 0; k < VymysleneSlovo.Length; k++)
            {
                VratCastecneOdhaleneSlovo = VratCastecneOdhaleneSlovo + "_";
            }
        }

        public bool JePismenoObsazeneVeSlove(char hadanePismeno)
        {
            JePismenoVeSlove = false;
            for (int j = 0; j < VymysleneSlovo.Length; j++) // Cyklus kontrolující, zda je zadné písmeno obsaženo v daném slově
            {
                if (hadanePismeno == VymysleneSlovo[j])
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(VratCastecneOdhaleneSlovo);
                    sb[j] = hadanePismeno;
                    VratCastecneOdhaleneSlovo = sb.ToString(); //Pokud se uživatel trefí, tak se dané písmeno doplní do hádaného slova
                    JePismenoVeSlove = true;
                }
            }
            if (!JePismenoVeSlove)
            {
                PocetNeuspesnychPokusu++; //Pokud není písmeno v hádaném slově, tak se navýší počet neúspěsných pokusů o 1
            }
            return JePismenoVeSlove;
        }

        public bool JeSlovoUhodnute()
        {
            return VratCastecneOdhaleneSlovo.Contains(substring); //kontroluje, zda obsahuje slovo ještě substring "_"
        }
    }
}
