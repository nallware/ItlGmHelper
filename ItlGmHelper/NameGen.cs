using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItlGmHelper
{
    class NameGen
    {

        public string _dwarfname, _elfname, _hobbitname, namey;
        public string _inn, _city, _wild;
        Randomizer r = new Randomizer();

        public string RandNameGen()
        {
            int n1 = r.RandNumber(1, 100);

            //cvccvc
            if (n1 < 60)//start with consonant
            {
                string c1, c2, c3, c4;
                string v1, v2;
                c1 = GetConsonant();
                c2 = GetConsonant();
                c3 = GetConsonant();
                c4 = GetConsonant();
                v1 = GetVowel();
                v2 = GetVowel();
                string name;
                c1 = c1.ToUpper();
                name = c1 + v1 + c2 + c3 + v2 + c4;
                return name;

            }

            //vccvcv
            else //starts with vowel
            {
                string c1, c2, c3, c4;
                string v1, v2, v3;
                c1 = GetConsonant();
                c2 = GetConsonant();
                c3 = GetConsonant();
                c4 = GetConsonant();
                v1 = GetVowel();
                v2 = GetVowel();
                v3 = GetVowel();
                string name;
                v1 = v1.ToUpper();
                name = v1 + c2 + c3 + v2 + c4 + v3;
                return name;
            }
        }

        public string GetConsonant()
        {
            string con;
            int n2 = r.RandNumber(1, 60921);
            if (n2 < 1492) { con = "b"; }
            else if (n2 < 4274) { con = "c"; }
            else if (n2 < 8527) { con = "d"; }
            else if (n2 < 10755) { con = "f"; }
            else if (n2 < 12770) { con = "g"; }
            else if (n2 < 18864) { con = "h"; }
            else if (n2 < 19017) { con = "j"; }
            else if (n2 < 19789) { con = "k"; }
            else if (n2 < 23814) { con = "l"; }
            else if (n2 < 26220) { con = "m"; }
            else if (n2 < 32969) { con = "n"; }
            else if (n2 < 34898) { con = "p"; }
            else if (n2 < 34993) { con = "q"; }
            else if (n2 < 40980) { con = "r"; }
            else if (n2 < 47307) { con = "s"; }
            else if (n2 < 56363) { con = "t"; }
            else if (n2 < 57350) { con = "v"; }
            else if (n2 < 59710) { con = "w"; }
            else if (n2 < 59860) { con = "x"; }
            else if (n2 < 60847) { con = "y"; }
            else { con = "z"; }
            return con;
        }


        public string GetVowel()
        {
            string vow;
            int n3 = r.RandNumber(1, 39087);
            if (n3 < 8167) { vow = "a"; }
            else if (n3 < 20869) { vow = "e"; }
            else if (n3 < 27835) { vow = "i"; }
            else if (n3 < 35342) { vow = "o"; }
            else if (n3 < 38100) { vow = "u"; }
            else { vow = "y"; }
            return vow;
        }






        public string GenDwarfName()
        {
            string _first, _last;
            int d1 = r.RandNumber(1, 37);
            int d2 = r.RandNumber(1, 17);

            if (d1 == 1) { _first = "Az"; }
            else if (d1 == 2) { _first = "Bal"; }
            else if (d1 == 3) { _first = "Bif"; }
            else if (d1 == 4) { _first = "Bof"; }
            else if (d1 == 5) { _first = "Bom"; }
            else if (d1 == 6) { _first = "Bor"; }
            else if (d1 == 7) { _first = "Dain"; }
            else if (d1 == 8) { _first = "Dis"; }
            else if (d1 == 9) { _first = "Dor"; }
            else if (d1 == 10) { _first = "Dur"; }
            else if (d1 == 11) { _first = "Dwa"; }
            else if (d1 == 12) { _first = "Far"; }
            else if (d1 == 13) { _first = "Fi"; }
            else if (d1 == 14) { _first = "Floi"; }
            else if (d1 == 15) { _first = "Fre"; }
            else if (d1 == 16) { _first = "Fror"; }
            else if (d1 == 17) { _first = "Fun"; }
            else if (d1 == 18) { _first = "Gam"; }
            else if (d1 == 19) { _first = "Gim"; }
            else if (d1 == 20) { _first = "Glo"; }
            else if (d1 == 21) { _first = "Gro"; }
            else if (d1 == 22) { _first = "Gror"; }
            else if (d1 == 23) { _first = "Ibun"; }
            else if (d1 == 24) { _first = "Khim"; }
            else if (d1 == 25) { _first = "Ki"; }
            else if (d1 == 26) { _first = "Lo"; }
            else if (d1 == 27) { _first = "Mim"; }
            else if (d1 == 28) { _first = "Na"; }
            else if (d1 == 29) { _first = "Nar"; }
            else if (d1 == 30) { _first = "No"; }
            else if (d1 == 31) { _first = "Oin"; }
            else if (d1 == 32) { _first = "Ori"; }
            else if (d1 == 33) { _first = "Tel"; }
            else if (d1 == 34) { _first = "Tho"; }
            else if (d1 == 35) { _first = "Thra"; }
            else if (d1 == 36) { _first = "Thro"; }
            else { _first = "Zir"; }

            if (d2 == 1) { _last = "ag"; }
            else if (d2 == 2) { _last = "ak"; }
            else if (d2 == 3) { _last = "bur"; }
            else if (d2 == 4) { _last = "char"; }
            else if (d2 == 5) { _last = "din"; }
            else if (d2 == 6) { _last = "hal"; }
            else if (d2 == 7) { _last = "i"; }
            else if (d2 == 8) { _last = "il"; }
            else if (d2 == 9) { _last = "in"; }
            else if (d2 == 10) { _last = "li"; }
            else if (d2 == 11) { _last = "lin"; }
            else if (d2 == 12) { _last = "ni"; }
            else if (d2 == 13) { _last = "ri"; }
            else if (d2 == 14) { _last = "rin"; }
            else if (d2 == 15) { _last = "ur"; }
            else if (d2 == 16) { _last = "or"; }
            else { _last = "vi"; }

            _dwarfname = _first + _last;

            return _dwarfname;
        }


        public string GenElfName()
        {
            string _first, _middle, _last;
            int d1 = r.RandNumber(1, 29);
            int d2 = r.RandNumber(1, 25);
            int d3 = r.RandNumber(1, 64);

            if (d1 == 1) { _first = "Aeg"; }
            else if (d1 == 2) { _first = "Am"; }
            else if (d1 == 3) { _first = "An"; }
            else if (d1 == 4) { _first = "Ar"; }
            else if (d1 == 5) { _first = "Be"; }
            else if (d1 == 6) { _first = "Ca"; }
            else if (d1 == 7) { _first = "Ce"; }
            else if (d1 == 8) { _first = "Cir"; }
            else if (d1 == 9) { _first = "Cu"; }
            else if (d1 == 10) { _first = "Dae"; }
            else if (d1 == 11) { _first = "Den"; }
            else if (d1 == 12) { _first = "Ear"; }
            else if (d1 == 13) { _first = "Ec"; }
            else if (d1 == 14) { _first = "Ed"; }
            else if (d1 == 15) { _first = "El"; }
            else if (d1 == 16) { _first = "En"; }
            else if (d1 == 17) { _first = "Eol"; }
            else if (d1 == 18) { _first = "Er"; }
            else if (d1 == 19) { _first = "Fea"; }
            else if (d1 == 20) { _first = "Fin"; }
            else if (d1 == 21) { _first = "Gal"; }
            else if (d1 == 22) { _first = "Gil"; }
            else if (d1 == 23) { _first = "Glor"; }
            else if (d1 == 24) { _first = "Gui"; }
            else if (d1 == 25) { _first = "Gwin"; }
            else if (d1 == 26) { _first = "Ing"; }
            else if (d1 == 27) { _first = "Ir"; }
            else if (d1 == 28) { _first = "Le"; }
            else { _first = "Thran"; }

            if (d2 == 1) { _middle = "a"; }
            else if (d2 == 2) { _middle = "ad"; }
            else if (d2 == 3) { _middle = "ai"; }
            else if (d2 == 4) { _middle = "an"; }
            else if (d2 == 5) { _middle = "ar"; }
            else if (d2 == 6) { _middle = "e"; }
            else if (d2 == 7) { _middle = "ed"; }
            else if (d2 == 8) { _middle = "em"; }
            else if (d2 == 9) { _middle = "en"; }
            else if (d2 == 10) { _middle = "erd"; }
            else if (d2 == 11) { _middle = "es"; }
            else if (d2 == 12) { _middle = "i"; }
            else if (d2 == 13) { _middle = "ion"; }
            else if (d2 == 14) { _middle = "le"; }
            else if (d2 == 15) { _middle = "la"; }
            else if (d2 == 16) { _middle = "o"; }
            else if (d2 == 17) { _middle = "ur"; }
            else { _middle = ""; }


            if (d3 == 1) { _last = "bor"; }
            else if (d3 == 2) { _last = "il"; }
            else if (d3 == 3) { _last = "ad"; }
            else if (d3 == 4) { _last = "born"; }
            else if (d3 == 5) { _last = "brian"; }
            else if (d3 == 6) { _last = "brim"; }
            else if (d3 == 7) { _last = "del"; }
            else if (d3 == 8) { _last = "fin"; }
            else if (d3 == 9) { _last = "gorm"; }
            else if (d3 == 10) { _last = "hel"; }
            else if (d3 == 11) { _last = "hil"; }
            else if (d3 == 12) { _last = "hon"; }
            else if (d3 == 13) { _last = "ie"; }
            else if (d3 == 14) { _last = "ion"; }
            else if (d3 == 15) { _last = "las"; }
            else if (d3 == 16) { _last = "mak"; }
            else if (d3 == 17) { _last = "me"; }
            else if (d3 == 18) { _last = "mire"; }
            else if (d3 == 19) { _last = "nas"; }
            else if (d3 == 20) { _last = "re"; }
            else if (d3 == 21) { _last = "riel"; }
            else if (d3 == 22) { _last = "thil"; }
            else if (d3 == 23) { _last = "thir"; }
            else if (d3 == 24) { _last = "thor"; }
            else if (d3 == 25) { _last = "tor"; }
            else if (d3 == 26) { _last = "we"; }
            else if (d3 == 27) { _last = "duil"; }
            else if (d3 == 28) { _last = "dan"; }
            else if (d3 == 29) { _last = "dir"; }
            else if (d3 == 30) { _last = "dis"; }
            else if (d3 == 31) { _last = "dor"; }
            else if (d3 == 32) { _last = "dui"; }
            else if (d3 == 33) { _last = "fin"; }
            else if (d3 == 34) { _last = "gal"; }
            else if (d3 == 35) { _last = "go"; }
            else if (d3 == 36) { _last = "gol"; }
            else if (d3 == 37) { _last = "gon"; }
            else if (d3 == 38) { _last = "grod"; }
            else if (d3 == 39) { _last = "leg"; }
            else if (d3 == 40) { _last = "lin"; }
            else if (d3 == 41) { _last = "lor"; }
            else if (d3 == 42) { _last = "mi"; }
            else if (d3 == 43) { _last = "mir"; }
            else if (d3 == 44) { _last = "mo"; }
            else if (d3 == 45) { _last = "nael"; }
            else if (d3 == 46) { _last = "nor"; }
            else if (d3 == 47) { _last = "ra"; }
            else if (d3 == 48) { _last = "ran"; }
            else if (d3 == 49) { _last = "ras"; }
            else if (d3 == 50) { _last = "rod"; }
            else if (d3 == 51) { _last = "ron"; }
            else if (d3 == 52) { _last = "roth"; }
            else if (d3 == 53) { _last = "ru"; }
            else if (d3 == 54) { _last = "thel"; }
            else if (d3 == 55) { _last = "we"; }
            else if (d3 == 56) { _last = "wen"; }
            else if (d3 == 57) { _last = "wing"; }
            else if (d3 == 58) { _last = "mith"; }
            else if (d3 == 59) { _last = "dil"; }
            else if (d3 == 60) { _last = "dan"; }
            else if (d3 == 61) { _last = "hir"; }
            else if (d3 == 62) { _last = "rond"; }
            else if (d3 == 63) { _last = "ed"; }
            else { _last = "ros"; }

            _elfname = _first + _middle + _last;
            return _elfname;
        }


        public string GenHobbitName()
        {
            string _1first, _1middle, _1last;
            string _2first, _2last;
            int d1 = r.RandNumber(1, 64);
            int d2 = r.RandNumber(1, 29);
            int d3 = r.RandNumber(1, 64);
            int d4 = r.RandNumber(1, 30);
            int d5 = r.RandNumber(1, 30);



            if (d1 == 1) { _1first = "Ad"; }
            else if (d1 == 2) { _1first = "Al"; }
            else if (d1 == 3) { _1first = "Am"; }
            else if (d1 == 4) { _1first = "An"; }
            else if (d1 == 5) { _1first = "As"; }
            else if (d1 == 6) { _1first = "Be"; }
            else if (d1 == 7) { _1first = "Bel"; }
            else if (d1 == 8) { _1first = "Cam"; }
            else if (d1 == 9) { _1first = "Cel"; }
            else if (d1 == 10) { _1first = "Chi"; }
            else if (d1 == 11) { _1first = "Cor"; }
            else if (d1 == 12) { _1first = "Dai"; }
            else if (d1 == 13) { _1first = "Di"; }
            else if (d1 == 14) { _1first = "Dia"; }
            else if (d1 == 15) { _1first = "Don"; }
            else if (d1 == 16) { _1first = "Dor"; }
            else if (d1 == 17) { _1first = "Dru"; }
            else if (d1 == 18) { _1first = "Eg"; }
            else if (d1 == 19) { _1first = "El"; }
            else if (d1 == 20) { _1first = "Es"; }
            else if (d1 == 21) { _1first = "Fir"; }
            else if (d1 == 22) { _1first = "Gil"; }
            else if (d1 == 23) { _1first = "Gol"; }
            else if (d1 == 24) { _1first = "Ha"; }
            else if (d1 == 25) { _1first = "Hil"; }
            else if (d1 == 26) { _1first = "Ivy"; }
            else if (d1 == 27) { _1first = "Jess"; }
            else if (d1 == 28) { _1first = "La"; }
            else if (d1 == 29) { _1first = "Lau"; }
            else if (d1 == 30) { _1first = "Lav"; }
            else if (d1 == 31) { _1first = "Li"; }
            else if (d1 == 32) { _1first = "Lin"; }
            else if (d1 == 33) { _1first = "Lob"; }
            else if (d1 == 34) { _1first = "Mal"; }
            else if (d1 == 35) { _1first = "Mar"; }
            else if (d1 == 36) { _1first = "May"; }
            else if (d1 == 37) { _1first = "Mel"; }
            else if (d1 == 38) { _1first = "Men"; }
            else if (d1 == 39) { _1first = "Mim"; }
            else if (d1 == 40) { _1first = "Mir"; }
            else if (d1 == 41) { _1first = "Myr"; }
            else if (d1 == 42) { _1first = "Ni"; }
            else if (d1 == 43) { _1first = "Nor"; }
            else if (d1 == 44) { _1first = "Pan"; }
            else if (d1 == 45) { _1first = "Pe"; }
            else if (d1 == 46) { _1first = "Per"; }
            else if (d1 == 47) { _1first = "Pim"; }
            else if (d1 == 48) { _1first = "Pop"; }
            else if (d1 == 49) { _1first = "Prim"; }
            else if (d1 == 50) { _1first = "Pris"; }
            else if (d1 == 51) { _1first = "Ro"; }
            else if (d1 == 52) { _1first = "Rose"; }
            else if (d1 == 53) { _1first = "Ros"; }
            else if (d1 == 54) { _1first = "Ru"; }
            else if (d1 == 55) { _1first = "Sal"; }
            else if (d1 == 56) { _1first = "Saph"; }
            else if (d1 == 57) { _1first = "Tan"; }
            else if (d1 == 58) { _1first = "Ad"; }
            else if (d1 == 59) { _1first = "And"; }
            else if (d1 == 60) { _1first = "An"; }
            else if (d1 == 61) { _1first = "Bal"; }
            else if (d1 == 62) { _1first = "Bil"; }
            else if (d1 == 63) { _1first = "Ban"; }
            else { _1first = "Bas"; }


            if (d2 == 1) { _1middle = "a"; }
            else if (d2 == 2) { _1middle = "al"; }
            else if (d2 == 3) { _1middle = "an"; }
            else if (d2 == 4) { _1middle = "bel"; }
            else if (d2 == 5) { _1middle = "di"; }
            else if (d2 == 6) { _1middle = "do"; }
            else if (d2 == 7) { _1middle = "don"; }
            else if (d2 == 8) { _1middle = "dri"; }
            else if (d2 == 9) { _1middle = "e"; }
            else if (d2 == 10) { _1middle = "el"; }
            else if (d2 == 11) { _1middle = "en"; }
            else if (d2 == 12) { _1middle = "fri"; }
            else if (d2 == 13) { _1middle = "gel"; }
            else if (d2 == 14) { _1middle = "gil"; }
            else if (d2 == 15) { _1middle = "i"; }
            else if (d2 == 16) { _1middle = "il"; }
            else if (d2 == 17) { _1middle = "ir"; }
            else if (d2 == 18) { _1middle = "lan"; }
            else if (d2 == 19) { _1middle = "ma"; }
            else if (d2 == 20) { _1middle = "man"; }
            else if (d2 == 21) { _1middle = "mir"; }
            else if (d2 == 22) { _1middle = "mun"; }
            else if (d2 == 23) { _1middle = "per"; }
            else if (d2 == 24) { _1middle = "pho"; }
            else if (d2 == 25) { _1middle = "rel"; }
            else if (d2 == 26) { _1middle = "sa"; }
            else if (d2 == 27) { _1middle = "tell"; }
            else if (d2 == 28) { _1middle = "tak"; }
            else { _1middle = "vin"; }


            if (d3 == 1) { _1last = "a"; }
            else if (d3 == 2) { _1last = "ard"; }
            else if (d3 == 3) { _1last = "arl"; }
            else if (d3 == 4) { _1last = "ba"; }
            else if (d3 == 5) { _1last = "bert"; }
            else if (d3 == 6) { _1last = "bo"; }
            else if (d3 == 7) { _1last = "bras"; }
            else if (d3 == 8) { _1last = "by"; }
            else if (d3 == 9) { _1last = "ca"; }
            else if (d3 == 10) { _1last = "da"; }
            else if (d3 == 11) { _1last = "del"; }
            else if (d3 == 12) { _1last = "der"; }
            else if (d3 == 13) { _1last = "dine"; }
            else if (d3 == 14) { _1last = "gar"; }
            else if (d3 == 15) { _1last = "gard"; }
            else if (d3 == 16) { _1last = "gold"; }
            else if (d3 == 17) { _1last = "grim"; }
            else if (d3 == 18) { _1last = "ia"; }
            else if (d3 == 19) { _1last = "ie"; }
            else if (d3 == 20) { _1last = "iel"; }
            else if (d3 == 21) { _1last = "lia"; }
            else if (d3 == 22) { _1last = "locks"; }
            else if (d3 == 23) { _1last = "ly"; }
            else if (d3 == 24) { _1last = "mine"; }
            else if (d3 == 25) { _1last = "mond"; }
            else if (d3 == 26) { _1last = "na"; }
            else if (d3 == 27) { _1last = "nel"; }
            else if (d3 == 28) { _1last = "nna"; }
            else if (d3 == 29) { _1last = "nor"; }
            else if (d3 == 30) { _1last = "ony"; }
            else if (d3 == 31) { _1last = "osa"; }
            else if (d3 == 32) { _1last = "ot"; }
            else if (d3 == 33) { _1last = "py"; }
            else if (d3 == 34) { _1last = "ra"; }
            else if (d3 == 35) { _1last = "ranth"; }
            else if (d3 == 36) { _1last = "rose"; }
            else if (d3 == 37) { _1last = "rylla"; }
            else if (d3 == 38) { _1last = "sa"; }
            else if (d3 == 39) { _1last = "sey"; }
            else if (d3 == 40) { _1last = "so"; }
            else if (d3 == 41) { _1last = "son"; }
            else if (d3 == 42) { _1last = "sy"; }
            else if (d3 == 43) { _1last = "ta"; }
            else if (d3 == 44) { _1last = "tha"; }
            else if (d3 == 45) { _1last = "thyst"; }
            else if (d3 == 46) { _1last = "tine"; }
            else if (d3 == 47) { _1last = "tle"; }
            else if (d3 == 48) { _1last = "ula"; }
            else if (d3 == 49) { _1last = "va"; }
            else if (d3 == 50) { _1last = "via"; }
            else if (d3 == 51) { _1last = "wan"; }
            else if (d3 == 52) { _1last = "wise"; }
            else if (d3 == 53) { _1last = "pin"; }
            else if (d3 == 54) { _1last = "ri"; }
            else if (d3 == 55) { _1last = "gal"; }
            else if (d3 == 56) { _1last = "nco"; }
            else if (d3 == 57) { _1last = "ffo"; }
            else if (d3 == 58) { _1last = "rl"; }
            else if (d3 == 59) { _1last = "man"; }
            else if (d3 == 60) { _1last = "bo"; }
            else if (d3 == 61) { _1last = "wise"; }
            else if (d3 == 62) { _1last = "gar"; }
            else if (d3 == 63) { _1last = "stred"; }
            else { _1last = "bras"; }


            if (d4 == 1) { _2first = "Brandy"; }
            else if (d4 == 2) { _2first = "Horn"; }
            else if (d4 == 3) { _2first = "Bag"; }
            else if (d4 == 4) { _2first = "Good"; }
            else if (d4 == 5) { _2first = "Sack"; }
            else if (d4 == 6) { _2first = "Fair"; }
            else if (d4 == 7) { _2first = "Brown"; }
            else if (d4 == 8) { _2first = "Long"; }
            else if (d4 == 9) { _2first = "Bucket"; }
            else if (d4 == 10) { _2first = "Brace"; }
            else if (d4 == 11) { _2first = "Gold"; }
            else if (d4 == 12) { _2first = "Clay"; }
            else if (d4 == 13) { _2first = "Grub"; }
            else if (d4 == 14) { _2first = "Head"; }
            else if (d4 == 15) { _2first = "Light"; }
            else if (d4 == 16) { _2first = "Dark"; }
            else if (d4 == 17) { _2first = "Cotton"; }
            else if (d4 == 18) { _2first = "Brock"; }
            else if (d4 == 19) { _2first = "Brook"; }
            else if (d4 == 20) { _2first = "Bustle"; }
            else if (d4 == 21) { _2first = "Dig"; }
            else if (d4 == 22) { _2first = "Hard"; }
            else if (d4 == 23) { _2first = "Stout"; }
            else if (d4 == 24) { _2first = "Ale"; }
            else if (d4 == 25) { _2first = "Dink"; }
            else if (d4 == 26) { _2first = "Fall"; }
            else if (d4 == 27) { _2first = "Stream"; }
            else if (d4 == 28) { _2first = "Proud"; }
            else { _2first = "Bog"; }




            if (d5 == 1) { _2last = "last"; }
            else if (d5 == 2) { _2last = "buck"; }
            else if (d5 == 3) { _2last = "ner"; }
            else if (d5 == 4) { _2last = "gee"; }
            else if (d5 == 5) { _2last = "blower"; }
            else if (d5 == 6) { _2last = "gins"; }
            else if (d5 == 7) { _2last = "child"; }
            else if (d5 == 8) { _2last = "bairn"; }
            else if (d5 == 9) { _2last = "bain"; }
            else if (d5 == 10) { _2last = "fin"; }
            else if (d5 == 11) { _2last = "body"; }
            else if (d5 == 12) { _2last = "gle"; }
            else if (d5 == 13) { _2last = "rows"; }
            else if (d5 == 14) { _2last = "hill"; }
            else if (d5 == 15) { _2last = "lock"; }
            else if (d5 == 16) { _2last = "worthy"; }
            else if (d5 == 17) { _2last = "girdle"; }
            else if (d5 == 18) { _2last = "feet"; }
            else if (d5 == 19) { _2last = "foot"; }
            else if (d5 == 20) { _2last = "enough"; }
            else if (d5 == 21) { _2last = "hanger"; }
            else if (d5 == 22) { _2last = "string"; }
            else if (d5 == 23) { _2last = "house"; }
            else if (d5 == 24) { _2last = "leaf"; }
            else if (d5 == 25) { _2last = "ripple"; }
            else if (d5 == 26) { _2last = "gapper"; }
            else if (d5 == 27) { _2last = "moffin"; }
            else if (d5 == 28) { _2last = "tackle"; }
            else { _2last = "vinner"; }

            string _hobbit1name = _1first + _1middle + _1last;
            string _hobbit2name = _2first + _2last;
            _hobbitname = _hobbit1name + " " + _hobbit2name;
            return _hobbitname;
        }



        public string GenInn()
        {
            string _1first, _1last, _suffix;
            int d1 = r.RandNumber(1, 64);
            int d2 = r.RandNumber(1, 10);
            int d3 = r.RandNumber(1, 64);

            if (d1 == 1) { _1first = "Dark"; }
            else if (d1 == 2) { _1first = "Golden"; }
            else if (d1 == 3) { _1first = "Shiny"; }
            else if (d1 == 4) { _1first = "Copper"; }
            else if (d1 == 5) { _1first = "Silver"; }
            else if (d1 == 6) { _1first = "Mithril"; }
            else if (d1 == 7) { _1first = "Olde"; }
            else if (d1 == 8) { _1first = "Welcome"; }
            else if (d1 == 9) { _1first = "Lucky"; }
            else if (d1 == 10) { _1first = "Bloody"; }
            else if (d1 == 11) { _1first = "Thirsty"; }
            else if (d1 == 12) { _1first = "Sleepy"; }
            else if (d1 == 13) { _1first = "Warm"; }
            else if (d1 == 14) { _1first = "Honorable"; }
            else if (d1 == 15) { _1first = "Windy"; }
            else if (d1 == 16) { _1first = "Splendid"; }
            else if (d1 == 17) { _1first = "White"; }
            else if (d1 == 18) { _1first = "Windy"; }
            else if (d1 == 19) { _1first = "Clever"; }
            else if (d1 == 20) { _1first = "Treasured"; }
            else if (d1 == 21) { _1first = "Ruby"; }
            else if (d1 == 22) { _1first = "Emerald"; }
            else if (d1 == 23) { _1first = "Wet"; }
            else if (d1 == 24) { _1first = "Thirsty"; }
            else if (d1 == 25) { _1first = "Big"; }
            else if (d1 == 26) { _1first = "Randy"; }
            else if (d1 == 27) { _1first = "Happy"; }
            else if (d1 == 28) { _1first = "Blue"; }
            else if (d1 == 29) { _1first = "Red"; }
            else if (d1 == 30) { _1first = "Wooden"; }
            else if (d1 == 31) { _1first = "Vulgar"; }
            else if (d1 == 32) { _1first = "Green"; }
            else if (d1 == 33) { _1first = "Yellow"; }
            else if (d1 == 34) { _1first = "Cowardly"; }
            else if (d1 == 35) { _1first = "Pleasant"; }
            else if (d1 == 36) { _1first = "Delightful"; }
            else if (d1 == 37) { _1first = "Great"; }
            else if (d1 == 38) { _1first = "Agreeable"; }
            else if (d1 == 39) { _1first = "Hot"; }
            else if (d1 == 40) { _1first = "Special"; }
            else if (d1 == 41) { _1first = "Cordial"; }
            else if (d1 == 42) { _1first = "Friendly"; }
            else if (d1 == 43) { _1first = "Bloody"; }
            else if (d1 == 44) { _1first = "Joyful"; }
            else if (d1 == 45) { _1first = "Jolly"; }
            else if (d1 == 46) { _1first = "Merry"; }
            else if (d1 == 47) { _1first = "Fair"; }
            else if (d1 == 48) { _1first = "Sweet"; }
            else if (d1 == 49) { _1first = "Worn"; }
            else if (d1 == 50) { _1first = "Weary"; }
            else if (d1 == 51) { _1first = "Cold"; }
            else if (d1 == 52) { _1first = "Tremendous"; }
            else if (d1 == 53) { _1first = "Talented"; }
            else if (d1 == 54) { _1first = "Charming"; }
            else if (d1 == 55) { _1first = "Ancient"; }
            else if (d1 == 56) { _1first = "Arrogant"; }
            else if (d1 == 57) { _1first = "Brave"; }
            else if (d1 == 58) { _1first = "Broken"; }
            else if (d1 == 59) { _1first = "Dusty"; }
            else if (d1 == 60) { _1first = "Eager"; }
            else if (d1 == 61) { _1first = "Fat"; }
            else if (d1 == 62) { _1first = "Mighty"; }
            else if (d1 == 63) { _1first = "Salty"; }
            else { _1first = "Wooden"; }


            if (d3 == 1) { _1last = "Elf"; }
            else if (d3 == 2) { _1last = "Orc"; }
            else if (d3 == 3) { _1last = "Dwarf"; }
            else if (d3 == 4) { _1last = "Goblin"; }
            else if (d3 == 5) { _1last = "Dragon"; }
            else if (d3 == 6) { _1last = "Unicorn"; }
            else if (d3 == 7) { _1last = "Prootwaddle"; }
            else if (d3 == 8) { _1last = "Bowl"; }
            else if (d3 == 9) { _1last = "Cup"; }
            else if (d3 == 10) { _1last = "Glen"; }
            else if (d3 == 11) { _1last = "River"; }
            else if (d3 == 12) { _1last = "Mountain"; }
            else if (d3 == 13) { _1last = "Pine"; }
            else if (d3 == 14) { _1last = "Rock"; }
            else if (d3 == 15) { _1last = "Elf"; }
            else if (d3 == 16) { _1last = "Plate"; }
            else if (d3 == 17) { _1last = "Knife"; }
            else if (d3 == 18) { _1last = "Fork"; }
            else if (d3 == 19) { _1last = "Bed"; }
            else if (d3 == 20) { _1last = "Porch"; }
            else if (d3 == 21) { _1last = "Glade"; }
            else if (d3 == 22) { _1last = "Stream"; }
            else if (d3 == 23) { _1last = "Pond"; }
            else if (d3 == 24) { _1last = "Bandit"; }
            else if (d3 == 25) { _1last = "Troll"; }
            else if (d3 == 26) { _1last = "Vagabond"; }
            else if (d3 == 27) { _1last = "Calf"; }
            else if (d3 == 28) { _1last = "Woman"; }
            else if (d3 == 29) { _1last = "Lady"; }
            else if (d3 == 30) { _1last = "Baron"; }
            else if (d3 == 31) { _1last = "King"; }
            else if (d3 == 32) { _1last = "Baroness"; }
            else if (d3 == 33) { _1last = "Duke"; }
            else if (d3 == 34) { _1last = "Dutchess"; }
            else if (d3 == 35) { _1last = "Queen"; }
            else if (d3 == 36) { _1last = "Sword"; }
            else if (d3 == 37) { _1last = "Axe"; }
            else if (d3 == 38) { _1last = "Knife"; }
            else if (d3 == 39) { _1last = "Dagger"; }
            else if (d3 == 40) { _1last = "Bow"; }
            else if (d3 == 41) { _1last = "Shield"; }
            else if (d3 == 42) { _1last = "Helm"; }
            else if (d3 == 43) { _1last = "Horse"; }
            else if (d3 == 44) { _1last = "Bull"; }
            else if (d3 == 45) { _1last = "Wagon"; }
            else if (d3 == 46) { _1last = "Road"; }
            else if (d3 == 47) { _1last = "Path"; }
            else if (d3 == 48) { _1last = "Trail"; }
            else if (d3 == 49) { _1last = "Vixen"; }
            else if (d3 == 50) { _1last = "Rogue"; }
            else if (d3 == 51) { _1last = "Pot"; }
            else if (d3 == 52) { _1last = "Hearth"; }
            else if (d3 == 53) { _1last = "Spoon"; }
            else if (d3 == 54) { _1last = "Spear"; }
            else if (d3 == 55) { _1last = "Axe"; }
            else if (d3 == 56) { _1last = "Hammer"; }
            else if (d3 == 57) { _1last = "Shovel"; }
            else if (d3 == 58) { _1last = "Spade"; }
            else if (d3 == 59) { _1last = "Hoe"; }
            else if (d3 == 60) { _1last = "Biscuit"; }
            else if (d3 == 61) { _1last = "Ale"; }
            else if (d3 == 62) { _1last = "Beer"; }
            else if (d3 == 63) { _1last = "Wine"; }
            else { _1last = "Whiskey"; }

            if (d2 == 1) { _suffix = "Inn"; }
            else if (d2 == 2) { _suffix = "Tavern"; }
            else if (d2 == 3) { _suffix = "House"; }
            else if (d2 == 4) { _suffix = "Bar"; }
            else if (d2 == 5) { _suffix = "Lodge"; }
            else if (d2 == 6) { _suffix = "Alehouse"; }
            else if (d2 == 7) { _suffix = "Pub"; }
            else if (d2 == 8) { _suffix = "Inn"; }
            else if (d2 == 9) { _suffix = "Tavern"; }
            else { _suffix = "Lodge"; }


            string _inn = _1first + " " + _1last + " " + _suffix;
            return _inn;
        }


        public string GenCity()
        {
            string _1first, _1last;
            int d1 = r.RandNumber(1, 231);
            int d2 = r.RandNumber(1, 10);
            int d3 = r.RandNumber(1, 64);

            if (d1 == 1) { _1first = "Abing"; }
            else if (d1 == 2) { _1first = "Amble"; }
            else if (d1 == 3) { _1first = "Alder"; }
            else if (d1 == 4) { _1first = "And"; }
            else if (d1 == 5) { _1first = "Ames"; }
            else if (d1 == 6) { _1first = "Ash"; }
            else if (d1 == 7) { _1first = "Ax"; }
            else if (d1 == 8) { _1first = "Ban"; }
            else if (d1 == 9) { _1first = "Barn"; }
            else if (d1 == 10) { _1first = "Bar"; }
            else if (d1 == 11) { _1first = "Beck"; }
            else if (d1 == 12) { _1first = "Bed"; }
            else if (d1 == 13) { _1first = "Berk"; }
            else if (d1 == 14) { _1first = "Biggle"; }
            else if (d1 == 15) { _1first = "Birch"; }
            else if (d1 == 16) { _1first = "Black"; }
            else if (d1 == 17) { _1first = "Bog"; }
            else if (d1 == 18) { _1first = "Borough"; }
            else if (d1 == 19) { _1first = "Brent"; }
            else if (d1 == 20) { _1first = "Brier"; }
            else if (d1 == 21) { _1first = "Brix"; }
            else if (d1 == 22) { _1first = "Brom"; }
            else if (d1 == 23) { _1first = "Buck"; }
            else if (d1 == 24) { _1first = "Calling"; }
            else if (d1 == 25) { _1first = "Cairn"; }
            else if (d1 == 26) { _1first = "Castle"; }
            else if (d1 == 27) { _1first = "Chat"; }
            else if (d1 == 28) { _1first = "Chester"; }
            else if (d1 == 29) { _1first = "Dart"; }
            else if (d1 == 30) { _1first = "Daven"; }
            else if (d1 == 31) { _1first = "Dews"; }
            else if (d1 == 32) { _1first = "Dun"; }
            else if (d1 == 33) { _1first = "Dur"; }
            else if (d1 == 34) { _1first = "Earl"; }
            else if (d1 == 35) { _1first = "Easing"; }
            else if (d1 == 36) { _1first = "East"; }
            else if (d1 == 37) { _1first = "West"; }
            else if (d1 == 38) { _1first = "North"; }
            else if (d1 == 39) { _1first = "South"; }
            else if (d1 == 40) { _1first = "Eden"; }
            else if (d1 == 41) { _1first = "Eves"; }
            else if (d1 == 42) { _1first = "Ex"; }
            else if (d1 == 43) { _1first = "Fair"; }
            else if (d1 == 44) { _1first = "Faken"; }
            else if (d1 == 45) { _1first = "Fal"; }
            else if (d1 == 46) { _1first = "Far"; }
            else if (d1 == 47) { _1first = "Faver"; }
            else if (d1 == 48) { _1first = "Feather"; }
            else if (d1 == 49) { _1first = "Felix"; }
            else if (d1 == 50) { _1first = "Ferry"; }
            else if (d1 == 51) { _1first = "Finch"; }
            else if (d1 == 52) { _1first = "Fleet"; }
            else if (d1 == 53) { _1first = "Folk"; }
            else if (d1 == 54) { _1first = "Ford"; }
            else if (d1 == 55) { _1first = "Frod"; }
            else if (d1 == 56) { _1first = "Gains"; }
            else if (d1 == 57) { _1first = "Gates"; }
            else if (d1 == 58) { _1first = "Glaston"; }
            else if (d1 == 59) { _1first = "Grant"; }
            else if (d1 == 60) { _1first = "Grave"; }
            else if (d1 == 61) { _1first = "Grims"; }
            else if (d1 == 62) { _1first = "Guild"; }
            else if (d1 == 63) { _1first = "Had"; }
            else if (d1 == 64) { _1first = "Hale"; }
            else if (d1 == 65) { _1first = "Harp"; }
            else if (d1 == 66) { _1first = "Hartle"; }
            else if (d1 == 67) { _1first = "Hast"; }
            else if (d1 == 68) { _1first = "Haver"; }
            else if (d1 == 69) { _1first = "Heath"; }
            else if (d1 == 70) { _1first = "Hedge"; }
            else if (d1 == 71) { _1first = "Hay"; }
            else if (d1 == 72) { _1first = "Hex"; }
            else if (d1 == 73) { _1first = "High"; }
            else if (d1 == 74) { _1first = "Hols"; }
            else if (d1 == 75) { _1first = "Holt"; }
            else if (d1 == 76) { _1first = "Horn"; }
            else if (d1 == 77) { _1first = "How"; }
            else if (d1 == 78) { _1first = "Il"; }
            else if (d1 == 79) { _1first = "Ilk"; }
            else if (d1 == 80) { _1first = "Imming"; }
            else if (d1 == 81) { _1first = "Ingle"; }
            else if (d1 == 82) { _1first = "Ips"; }
            else if (d1 == 83) { _1first = "Ivy"; }
            else if (d1 == 84) { _1first = "Keigh"; }
            else if (d1 == 85) { _1first = "Kemp"; }
            else if (d1 == 86) { _1first = "Kenil"; }
            else if (d1 == 87) { _1first = "Ketter"; }
            else if (d1 == 88) { _1first = "Kids"; }
            else if (d1 == 89) { _1first = "Kimber"; }
            else if (d1 == 90) { _1first = "Kings"; }
            else if (d1 == 91) { _1first = "Kirk"; }
            else if (d1 == 92) { _1first = "Lang"; }
            else if (d1 == 93) { _1first = "Led"; }
            else if (d1 == 94) { _1first = "Leigh"; }
            else if (d1 == 95) { _1first = "Ley"; }
            else if (d1 == 96) { _1first = "Little"; }
            else if (d1 == 97) { _1first = "Long"; }
            else if (d1 == 98) { _1first = "Lyn"; }
            else if (d1 == 99) { _1first = "Mag"; }
            else if (d1 == 100) { _1first = "Mar"; }
            else if (d1 == 101) { _1first = "Malt"; }
            else if (d1 == 102) { _1first = "Mans"; }
            else if (d1 == 103) { _1first = "Market"; }
            else if (d1 == 104) { _1first = "Marys"; }
            else if (d1 == 105) { _1first = "Melt"; }
            else if (d1 == 106) { _1first = "Middle"; }
            else if (d1 == 107) { _1first = "More"; }
            else if (d1 == 108) { _1first = "Nails"; }
            else if (d1 == 109) { _1first = "Nant"; }
            else if (d1 == 110) { _1first = "Need"; }
            else if (d1 == 111) { _1first = "New"; }
            else if (d1 == 112) { _1first = "Oak"; }
            else if (d1 == 113) { _1first = "Old"; }
            else if (d1 == 114) { _1first = "Orms"; }
            else if (d1 == 115) { _1first = "Paige"; }
            else if (d1 == 116) { _1first = "Patch"; }
            else if (d1 == 117) { _1first = "Peters"; }
            else if (d1 == 118) { _1first = "Poole"; }
            else if (d1 == 119) { _1first = "Port"; }
            else if (d1 == 120) { _1first = "Rad"; }
            else if (d1 == 121) { _1first = "Rams"; }
            else if (d1 == 122) { _1first = "Red"; }
            else if (d1 == 123) { _1first = "Rich"; }
            else if (d1 == 124) { _1first = "Ring"; }
            else if (d1 == 125) { _1first = "Roch"; }
            else if (d1 == 126) { _1first = "Roth"; }
            else if (d1 == 127) { _1first = "Row"; }
            else if (d1 == 128) { _1first = "Rush"; }
            else if (d1 == 129) { _1first = "Rye"; }
            else if (d1 == 130) { _1first = "Saff"; }
            else if (d1 == 131) { _1first = "Sal"; }
            else if (d1 == 132) { _1first = "Sand"; }
            else if (d1 == 133) { _1first = "Salt"; }
            else if (d1 == 134) { _1first = "Sax"; }
            else if (d1 == 135) { _1first = "Sea"; }
            else if (d1 == 136) { _1first = "Sed"; }
            else if (d1 == 137) { _1first = "Sel"; }
            else if (d1 == 138) { _1first = "Seven"; }
            else if (d1 == 139) { _1first = "Shaft"; }
            else if (d1 == 140) { _1first = "Shank"; }
            else if (d1 == 141) { _1first = "Sheff"; }
            else if (d1 == 142) { _1first = "Shep"; }
            else if (d1 == 143) { _1first = "Ship"; }
            else if (d1 == 144) { _1first = "Shire"; }
            else if (d1 == 145) { _1first = "Shrews"; }
            else if (d1 == 146) { _1first = "Shore"; }
            else if (d1 == 147) { _1first = "Sid"; }
            else if (d1 == 148) { _1first = "Sils"; }
            else if (d1 == 149) { _1first = "Skip"; }
            else if (d1 == 150) { _1first = "Slough"; }
            else if (d1 == 151) { _1first = "Smeth"; }
            else if (d1 == 152) { _1first = "Snod"; }
            else if (d1 == 153) { _1first = "Staff"; }
            else if (d1 == 154) { _1first = "Stam"; }
            else if (d1 == 155) { _1first = "Stave"; }
            else if (d1 == 156) { _1first = "Stock"; }
            else if (d1 == 157) { _1first = "Stony"; }
            else if (d1 == 158) { _1first = "Sutt"; }
            else if (d1 == 159) { _1first = "Swaff"; }
            else if (d1 == 160) { _1first = "Swan"; }
            else if (d1 == 161) { _1first = "Tad"; }
            else if (d1 == 162) { _1first = "Tam"; }
            else if (d1 == 163) { _1first = "Tels"; }
            else if (d1 == 164) { _1first = "Ten"; }
            else if (d1 == 165) { _1first = "Thame"; }
            else if (d1 == 166) { _1first = "Thatch"; }
            else if (d1 == 167) { _1first = "Thet"; }
            else if (d1 == 168) { _1first = "Thorn"; }
            else if (d1 == 169) { _1first = "Thorpe"; }
            else if (d1 == 170) { _1first = "Tip"; }
            else if (d1 == 171) { _1first = "Tiver"; }
            else if (d1 == 172) { _1first = "Tod"; }
            else if (d1 == 173) { _1first = "Tis"; }
            else if (d1 == 174) { _1first = "Tor"; }
            else if (d1 == 175) { _1first = "Tow"; }
            else if (d1 == 176) { _1first = "Trow"; }
            else if (d1 == 177) { _1first = "Uck"; }
            else if (d1 == 178) { _1first = "Ulver"; }
            else if (d1 == 179) { _1first = "Upping"; }
            else if (d1 == 180) { _1first = "Up"; }
            else if (d1 == 181) { _1first = "Uttox"; }
            else if (d1 == 182) { _1first = "Ux"; }
            else if (d1 == 183) { _1first = "Vent"; }
            else if (d1 == 184) { _1first = "Ver"; }
            else if (d1 == 185) { _1first = "Vir"; }
            else if (d1 == 186) { _1first = "Vith"; }
            else if (d1 == 187) { _1first = "Wade"; }
            else if (d1 == 188) { _1first = "Wad"; }
            else if (d1 == 189) { _1first = "Wain"; }
            else if (d1 == 190) { _1first = "Wall"; }
            else if (d1 == 191) { _1first = "Walt"; }
            else if (d1 == 192) { _1first = "Want"; }
            else if (d1 == 193) { _1first = "Ware"; }
            else if (d1 == 194) { _1first = "War"; }
            else if (d1 == 195) { _1first = "Watch"; }
            else if (d1 == 196) { _1first = "Wat"; }
            else if (d1 == 197) { _1first = "Wath"; }
            else if (d1 == 198) { _1first = "Well"; }
            else if (d1 == 199) { _1first = "Welling"; }
            else if (d1 == 200) { _1first = "Wern"; }
            else if (d1 == 201) { _1first = "Wemb"; }
            else if (d1 == 202) { _1first = "Wend"; }
            else if (d1 == 203) { _1first = "Weth"; }
            else if (d1 == 204) { _1first = "Whit"; }
            else if (d1 == 205) { _1first = "Wey"; }
            else if (d1 == 206) { _1first = "White"; }
            else if (d1 == 207) { _1first = "Wick"; }
            else if (d1 == 208) { _1first = "Wid"; }
            else if (d1 == 209) { _1first = "Wig"; }
            else if (d1 == 210) { _1first = "Will"; }
            else if (d1 == 211) { _1first = "Wimbel"; }
            else if (d1 == 212) { _1first = "Winch"; }
            else if (d1 == 213) { _1first = "Wind"; }
            else if (d1 == 214) { _1first = "Wink"; }
            else if (d1 == 215) { _1first = "Wolver"; }
            else if (d1 == 216) { _1first = "Wool"; }
            else if (d1 == 217) { _1first = "Wrag"; }
            else if (d1 == 218) { _1first = "Yarm"; }
            else if (d1 == 219) { _1first = "Yar"; }
            else if (d1 == 220) { _1first = "Yate"; }
            else if (d1 == 221) { _1first = "Yeo"; }
            else if (d1 == 222) { _1first = "Basil"; }
            else if (d1 == 223) { _1first = "Brack"; }
            else if (d1 == 224) { _1first = "Wel"; }
            else if (d1 == 225) { _1first = "Somer"; }
            else if (d1 == 226) { _1first = "York"; }
            else if (d1 == 227) { _1first = "Glouce"; }
            else if (d1 == 228) { _1first = "Tyne"; }
            else if (d1 == 229) { _1first = "Nor"; }
            else if (d1 == 230) { _1first = "Lon"; }
            else { _1first = "Derby"; }


            if (d3 == 1) { _1last = "don"; }
            else if (d3 == 2) { _1last = "ton"; }
            else if (d3 == 3) { _1last = "ell"; }
            else if (d3 == 4) { _1last = "cester"; }
            else if (d3 == 5) { _1last = "burgh"; }
            else if (d3 == 6) { _1last = "shot"; }
            else if (d3 == 7) { _1last = "ley"; }
            else if (d3 == 8) { _1last = "wick"; }
            else if (d3 == 9) { _1last = "ger"; }
            else if (d3 == 10) { _1last = "cher"; }
            else if (d3 == 11) { _1last = "cham"; }
            else if (d3 == 12) { _1last = "ard"; }
            else if (d3 == 13) { _1last = "side"; }
            else if (d3 == 14) { _1last = "sham"; }
            else if (d3 == 15) { _1last = "bury"; }
            else if (d3 == 16) { _1last = "hill"; }
            else if (d3 == 17) { _1last = "over"; }
            else if (d3 == 18) { _1last = "by"; }
            else if (d3 == 19) { _1last = "sey"; }
            else if (d3 == 20) { _1last = "del"; }
            else if (d3 == 21) { _1last = "bourne"; }
            else if (d3 == 22) { _1last = "burton"; }
            else if (d3 == 23) { _1last = "skern"; }
            else if (d3 == 24) { _1last = "stone"; }
            else if (d3 == 25) { _1last = "church"; }
            else if (d3 == 26) { _1last = "ford"; }
            else if (d3 == 27) { _1last = "bridge"; }
            else if (d3 == 28) { _1last = "minster"; }
            else if (d3 == 29) { _1last = "well"; }
            else if (d3 == 30) { _1last = "king"; }
            else if (d3 == 31) { _1last = "sley"; }
            else if (d3 == 32) { _1last = "staple"; }
            else if (d3 == 33) { _1last = "row"; }
            else if (d3 == 34) { _1last = "stoke"; }
            else if (d3 == 35) { _1last = "try"; }
            else if (d3 == 36) { _1last = "frey"; }
            else if (d3 == 37) { _1last = "worth"; }
            else if (d3 == 38) { _1last = "cles"; }
            else if (d3 == 39) { _1last = "ham"; }
            else if (d3 == 40) { _1last = "dale"; }
            else if (d3 == 41) { _1last = "per"; }
            else if (d3 == 42) { _1last = "sted"; }
            else if (d3 == 43) { _1last = "ulph"; }
            else if (d3 == 44) { _1last = "wade"; }
            else if (d3 == 45) { _1last = "cay"; }
            else if (d3 == 46) { _1last = "wood"; }
            else if (d3 == 47) { _1last = "head"; }
            else if (d3 == 48) { _1last = "land"; }
            else if (d3 == 49) { _1last = "water"; }
            else if (d3 == 50) { _1last = "min"; }
            else if (d3 == 51) { _1last = "nor"; }
            else if (d3 == 52) { _1last = "chester"; }
            else if (d3 == 53) { _1last = "mouth"; }
            else if (d3 == 54) { _1last = "lade"; }
            else if (d3 == 55) { _1last = "field"; }
            else if (d3 == 56) { _1last = "house"; }
            else if (d3 == 57) { _1last = "grove"; }
            else if (d3 == 58) { _1last = "yard"; }
            else if (d3 == 59) { _1last = "leigh"; }
            else if (d3 == 60) { _1last = "well"; }
            else if (d3 == 61) { _1last = "gay"; }
            else if (d3 == 62) { _1last = "nock"; }
            else if (d3 == 63) { _1last = "ville"; }
            else { _1last = "hunt"; }


            string _city = _1first + _1last;
            return _city;
        }

        public string GenWild()
        {
            _wild = "";

            return _wild;
        }


        public string GenRandSylName()
        {
            Randomizer r = new Randomizer();
            string _wild;
            int _syls;
            _syls = r.RandNumber(1, 5);
            if (_syls == 1) { _wild = SylFront() + GetVowel(); }
            else if (_syls == 2) { _wild = SylFront() + SylEnd(); }
            else if (_syls == 3) { _wild = SylFront() + SylMid() + SylEnd(); }
            else if (_syls == 4) { _wild = SylFront() + SylMid() + SylMid() + SylEnd(); }
            else if (_syls == 5) { _wild = SylFront() + SylMid() + SylEnd(); }
            else { _wild = SylFront() + SylEnd(); }

            return _wild;
        }

        public string GenOrcName()
        {
            string name = SylFront()+"'"+SylMid()+SylEnd();
            return name;
        }

        public string GenGoblinName()
        {
            string name;
            int d1 = r.RandNumber(1, 3);

                if (d1==1)
                {
                    name = RandNameGen() + SylMid() + "-" + SylEnd();
                }
                else if (d1==2)
                {
                    name = RandNameGen() + "-"+ SylMid()  + SylEnd();
                }
                else 
                {
                    name = SylFront() + RandNameGen() + "-" + SylEnd();
                }
            return name;
        }


        public string GenStrangeName()
        {            
            string rd = RandNameGen();
            string mid = SylMid();
            string end = SylEnd();
            string front = SylFront();
            int rr = r.RandNumber(1, 5);

            while (rr > 0)
            {
                List<string> l = new List<string>();
                l.Add(mid);
                l.Add(end);
                l.Add(front);
                l.Add(rd);              

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                string nam = value.ToString();
                namey = namey + nam;
                rr--;                
            }
            return namey;
        }






        public string SylFront()
        {
            string _syl;
            List<string> l = new List<string>();

            l.Add("cham");
            l.Add("chan");
            l.Add("jisk");
            l.Add("lis");
            l.Add("frich");
            l.Add("isk");
            l.Add("lass");
            l.Add("mind");
            l.Add("sond");
            l.Add("sund");
            l.Add("ass");
            l.Add("chad");
            l.Add("lirt");
            l.Add("und");
            l.Add("mar");
            l.Add("taith");
            l.Add("kach");
            l.Add("chak");
            l.Add("kank");
            l.Add("kjar");
            l.Add("rak");
            l.Add("kan");
            l.Add("kaj");
            l.Add("tach");
            l.Add("rskal");
            l.Add("kjol");
            l.Add("jok");
            l.Add("jor");
            l.Add("jad");
            l.Add("kot");
            l.Add("kon");
            l.Add("knir");
            l.Add("kror");
            l.Add("kol");
            l.Add("tul");
            l.Add("rhaok");
            l.Add("rhak");
            l.Add("krol");
            l.Add("jan");
            l.Add("kag");
            l.Add("ryr");
            l.Add("aw");
            l.Add("al");
            l.Add("yes");
            l.Add("il");
            l.Add("ay");
            l.Add("en");
            l.Add("tom");
            l.Add("oj");
            l.Add("im");
            l.Add("ol");
            l.Add("aj");
            l.Add("an");
            l.Add("as");
            l.Add(GetVowel() + "cham");
            l.Add(GetVowel() + "chan");
            l.Add(GetVowel() + "jisk");
            l.Add(GetVowel() + "lis");
            l.Add(GetVowel() + "frich");
            l.Add(GetConsonant() + "isk");
            l.Add(GetVowel() + "lass");
            l.Add(GetVowel() + "mind");
            l.Add(GetVowel() + "sond");
            l.Add(GetVowel() + "sund");
            l.Add(GetConsonant() + "ass");
            l.Add(GetVowel() + "chad");
            l.Add(GetVowel() + "lirt");
            l.Add(GetConsonant() + "und");
            l.Add(GetVowel() + "mar");
            l.Add(GetVowel() + "taith");
            l.Add(GetVowel() + "kach");
            l.Add(GetVowel() + "chak");
            l.Add(GetVowel() + "kank");
            l.Add(GetVowel() + "kjar");
            l.Add(GetVowel() + "rak");
            l.Add(GetVowel() + "kan");
            l.Add(GetVowel() + "kaj");
            l.Add(GetVowel() + "tach");
            l.Add(GetVowel() + "rskal");
            l.Add(GetVowel() + "kjol");
            l.Add(GetVowel() + "jok");
            l.Add(GetVowel() + "jor");
            l.Add(GetVowel() + "jad");
            l.Add(GetVowel() + "kot");
            l.Add(GetVowel() + "kon");
            l.Add(GetVowel() + "knir");
            l.Add(GetVowel() + "kror");
            l.Add(GetVowel() + "kol");
            l.Add(GetVowel() + "tul");
            l.Add(GetVowel() + "rhaok");
            l.Add(GetVowel() + "rhak");
            l.Add(GetVowel() + "krol");
            l.Add(GetVowel() + "jan");
            l.Add(GetVowel() + "kag");
            l.Add(GetVowel() + "ryr");
            l.Add(GetConsonant() + "aw");
            l.Add(GetConsonant() + "al");
            l.Add(GetConsonant() + "yes");
            l.Add(GetConsonant() + "il");
            l.Add(GetConsonant() + "ay");
            l.Add(GetConsonant() + "en");
            l.Add(GetVowel() + "tom");
            l.Add(GetConsonant() + "oj");
            l.Add(GetConsonant() + "im");
            l.Add(GetConsonant() + "ol");
            l.Add(GetConsonant() + "aj");
            l.Add(GetConsonant() + "an");
            l.Add(GetConsonant() + "as");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _syl = value.ToString();
            return _syl;
        }


            public string SylMid()
        {
            string _syl;
            List<string> l = new List<string>();

            l.Add("an");
            l.Add("ya");
            l.Add("la");
            l.Add("sta");
            l.Add("sda");
            l.Add("sya");
            l.Add("st");
            l.Add("nya");
            l.Add("is");
                        l.Add("al");
                        l.Add("ow");
                        l.Add("ish");
                        l.Add("ul");
                        l.Add("el");
                        l.Add("ar");
                        l.Add("iel");
                            l.Add("on");
                        l.Add("us");
                        l.Add("un");
                        l.Add("ar");
                        l.Add("as");
                        l.Add("en");
                        l.Add("ir");
                        l.Add("ur");
                        l.Add("at");
                        l.Add("ol");
                        l.Add("al");
                        l.Add("an");
                        l.Add("in");
                        l.Add("or");
                        l.Add("an");
                        l.Add("ar");
                        l.Add("och");
                        l.Add("un");
                        l.Add("mar");
                        l.Add("yk");
                        l.Add("ja");
                        l.Add("arn");
                        l.Add("ir");
                        l.Add("ros");
                        l.Add("ror");
                        l.Add("aj");
                        l.Add("ch");
                        l.Add("etz");
                        l.Add("etzl");
                        l.Add("tz");
                        l.Add("kal");
                        l.Add("gahn");
                        l.Add("kab");
                        l.Add("aj");
                        l.Add("izl");
                        l.Add("ts");
                        l.Add("jaj");
                        l.Add("lan");
                        l.Add("kach");
                        l.Add("chaj");
                        l.Add("qaq");
                        l.Add("jol");
                        l.Add("ix");
                        l.Add("az");
                        l.Add("biq");
                        l.Add("nam");
                            l.Add("aw");
                        l.Add("al");
                        l.Add("yes");
                        l.Add("il");
                        l.Add("ay");
                        l.Add("en");
                        l.Add("tom");
                        l.Add("oj");
                        l.Add("im");
                        l.Add("ol");
                        l.Add("aj");
                        l.Add("an");
                        l.Add("as");
                        l.Add("aj");
                        l.Add("am");
                        l.Add("al");
                        l.Add("aqa");
                        l.Add("ende");
                        l.Add("elja");
                        l.Add("ich");
                        l.Add("ak");
                        l.Add("ix");
                        l.Add("in");
                        l.Add("ak");
                        l.Add("al");
                        l.Add("il");
                        l.Add("ek");
                        l.Add("ij");
                        l.Add("os");
                        l.Add("al");
                        l.Add("im");
                        l.Add("yi");
                        l.Add("shu");
                        l.Add("a");
                        l.Add("be");
                        l.Add("na");
                        l.Add("chi");
                        l.Add("cha");
                        l.Add("cho");
                        l.Add("ksa");
                        l.Add("yi");
                        l.Add("shu");
                            l.Add("us");
                        l.Add("ash");
                        l.Add("eni");
                        l.Add("akra");
                        l.Add("nai");
                        l.Add("ral");
                        l.Add("ect");
                        l.Add("are");
                        l.Add("el");
                        l.Add("urru");
                        l.Add("aja");
                        l.Add("al");
                        l.Add("uz");
                        l.Add("ict");
                        l.Add("arja");
                        l.Add("ichi");
                        l.Add("ural");
                        l.Add("iru");
                        l.Add("aki");
                        l.Add("esh");
                            l.Add("tys");
                        l.Add("eus");
                        l.Add("yn");
                        l.Add("of");
                        l.Add("es");
                        l.Add("en");
                        l.Add("ath");
                        l.Add("elth");
                        l.Add("al");
                        l.Add("ell");
                        l.Add("ka");
                        l.Add("ith");
                        l.Add("yrrl");
                        l.Add("is");
                        l.Add("isl");
                        l.Add("yr");
                        l.Add("ast");
                        l.Add("iy");
                        l.Add("us");
                        l.Add("yn");
                        l.Add("en");
                        l.Add("ens");
                        l.Add("ra");
                        l.Add("rg");
                        l.Add("le");
                        l.Add("en");
                        l.Add("ith");
                        l.Add("ast");
                        l.Add("zon");
                        l.Add("in");
                        l.Add("yn");
                        l.Add("ys");
                
            
            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _syl = value.ToString();
            return _syl;
        }
                  
      
        public string SylEnd()
        {
            string _syl;
            List<string> l = new List<string>();
                        
            l.Add("lis");
            l.Add("il");
            l.Add("jask");
            l.Add("ast");
            l.Add("ista");
            l.Add("adar");
            l.Add("irra");
            l.Add("im");
            l.Add("ossa");
            l.Add("assa");
            l.Add("osia");
            l.Add("ilsa");
            l.Add("an");
            l.Add("ya");
            l.Add("la");
            l.Add("sta");
            l.Add("sda");
            l.Add("sya");
            l.Add("st");
            l.Add("nya");
            l.Add("ch");
            l.Add("ch't");
            l.Add("sh");
            l.Add("cal");
            l.Add("val");
            l.Add("ell");
            l.Add("har");
            l.Add("shar");
            l.Add("shal");
            l.Add("rel");
            l.Add("laen");
            l.Add("ral");
            l.Add("jh't");
            l.Add("alr");
            l.Add("ch");
            l.Add("ch't");
            l.Add("av");

            l.Add("aren");
                        l.Add("aeish");
                        l.Add("aith");
                        l.Add("even");
                        l.Add("adur");
                        l.Add("ulash");
                        l.Add("alith");
                        l.Add("atar");
                        l.Add("aia");
                        l.Add("erin");
                        l.Add("aera");
                        l.Add("ael");
                        l.Add("ira");
                        l.Add("iel");
                        l.Add("ahur");
                        l.Add("ishul");
                        l.Add("ethr");
                        l.Add("qil");
                        l.Add("mal");
                        l.Add("er");
                        l.Add("eal");
                        l.Add("far");
                        l.Add("fil");
                        l.Add("fir");
                        l.Add("ing");
                        l.Add("ind");
                        l.Add("il");
                        l.Add("lam");
                        l.Add("quel");
                        l.Add("quar");
                        l.Add("quan");
                        l.Add("qar");
                        l.Add("pal");
                        l.Add("mal");
                        l.Add("yar");
                        l.Add("um");
                        l.Add("ard");
                        l.Add("enn");
                        l.Add("ey");
                            l.Add("uard");
                        l.Add("wen");
                        l.Add("arn");
                        l.Add("on");
                        l.Add("il");
                        l.Add("ie");
                        l.Add("on");
                        l.Add("iel");
                        l.Add("rion");
                        l.Add("rian");
                        l.Add("an");
                        l.Add("ista");
                        l.Add("rion");
                        l.Add("rian");
                        l.Add("cil");
                        l.Add("mol");
                        l.Add("yon");
                        l.Add("mund");
                        l.Add("ard");
                        l.Add("arn");
                        l.Add("karr");
                        l.Add("chim");
                        l.Add("kos");
                        l.Add("rir");
                        l.Add("arl");
                        l.Add("kni");
                        l.Add("var");
                        l.Add("an");
                        l.Add("in");
                        l.Add("ir");
                        l.Add("a");
                        l.Add("i");
                        l.Add("as");
                        l.Add("th");
                        l.Add("dd");
                        l.Add("jj");
                        l.Add("sh");
                        l.Add("rr");
                        l.Add("mk");
                        l.Add("n");
                        l.Add("rk");
                        l.Add("y");
                        l.Add("jj");
                        l.Add("th");
                        l.Add("syth");
                        l.Add("sith");
                        l.Add("srr");
                        l.Add("sen");
                        l.Add("yth");
                        l.Add("ssen");
                        l.Add("then");
                        l.Add("fen");
                        l.Add("ssth");
                        l.Add("kel");
                        l.Add("syn");
                        l.Add("est");
                        l.Add("bess");
                        l.Add("inth");
                        l.Add("nen");
                        l.Add("tin");
                        l.Add("cor");
                        l.Add("sv");
                        l.Add("iss");
                        l.Add("ith");
                        l.Add("sen");
                        l.Add("slar");
                        l.Add("ssil");
                        l.Add("sthen");
                        l.Add("svis");
                        l.Add("s");
                        l.Add("ss");
                        l.Add("s");
                        l.Add("ss");
                        l.Add("us");
                        l.Add("yn");
                        l.Add("en");
                        l.Add("ens");
                        l.Add("ra");
                        l.Add("rg");
                        l.Add("le");
                        l.Add("en");
                        l.Add("ith");
                        l.Add("ast");
                        l.Add("zon");
                        l.Add("in");
                        l.Add("yn");
                        l.Add("ys");


            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _syl = value.ToString();
            return _syl;
        }

                        

                        

                        

                        

                        

                        

                        










        
    
    
    
    
    
    }
}
