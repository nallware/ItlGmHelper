using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItlGmHelper
{
    class NpcGen
    {
        public int _st, _dx, _iq, _ma;
        public string _name, _race, _age, _gender, _type, _weapons, _armor, _equipment, _talents, _spells, _looks, _treasure, _background;
        
            //string _variable;
            //List<string> l = new List<string>();

            //l.Add("Items to randomize");

            //Randomizer r = new Randomizer();
            //int rand = r.RandNumber(1, l.Count);
            //var value = l[rand];
            //_variable = value.ToString();
            //return _variable;


        public string[] NpcBuilder(string lv)
        {
            
           
            _race = NpcRace();
            _name = NpcName();
            _age = NpcAge();
            _gender = NpcGender();
            _type = NpcType();

            var stats = NpcStats(lv, _type);
            _st = stats.Item1;
            _dx = stats.Item2;
            _iq = stats.Item3;

            string _str = Convert.ToString(_st);
            string _dex = Convert.ToString(_dx);
            string _int = Convert.ToString(_iq);
            
            _weapons = NpcWeapons(_st, _type);
            //_armor = NpcArmor(_dx);
            _talents = NpcTalents(_iq, _type);           
            _equipment = NpcEquipment();
            _looks = NpcLooks();
            _treasure = "";
            _background = NpcBackground();
            string _mov = Convert.ToString(_ma);

            string[] npc = new string[] { _name, _race, _age, _gender, _type, _str, _dex, _int, _weapons, _armor, _talents, _equipment, _looks, _treasure, _background, _mov};
                        
            return npc;


        }
        
        
        public string NpcName()
        {
            NameGen ng = new NameGen();
            string name;

            if (_race == "Human") { name = ng.GenRandSylName(); }
            else if (_race == "Orc") { name = ng.GenOrcName(); }
            else if (_race == "Dwarf") { name = ng.GenDwarfName(); }
            else if (_race == "Elf") { name = ng.GenElfName(); }
            else if (_race == "Goblin") { name = ng.GenGoblinName(); }
            else if (_race == "Hobgoblin") { name = ng.GenGoblinName(); }
            else if (_race == "Halfling") { name = ng.GenHobbitName(); }
            else { name = ng.GenStrangeName(); }


            
            
            //dependent on race           
            
            return name;
        }

        public string NpcRace()
        {
            Randomizer r = new Randomizer();
            int die1 = r.RandNumber(1, 6);
            int die2 = r.RandNumber(1, 6);
            int die3 = r.RandNumber(1, 6);
            int die4 = r.RandNumber(1, 6);

            int roll1 = die1 + die2 + die3;
            if (roll1 == 3) 
            {
                if (die4 == 1) { _race = "Giant"; _ma = 10; }
                else if (die4 == 2) { _race = "Gargoyle"; _ma = 10; }
                else if (die4 == 3) { _race = "Reptile Man"; _ma = 10; }
                else if (die4 == 2) { _race = "Hobgoblin"; _ma = 10; }
                else if (die4 == 2) 
                {
                    if (die1 < 4) { _race = "Prootwaddle"; _ma = 10; }
                    else { _race = "Merman"; _ma = 10; }
                }
                else if (die4 == 2) { _race = "Centaur"; _ma = 12; }
            }
            else if (roll1 < 6) { _race = "Elf"; _ma = 12; }
            else if (roll1 < 8) { _race = "Goblin"; _ma = 10; }
            else if (roll1 < 10) { _race = "Dwarf"; _ma = 10; }
            else if (roll1 < 13) { _race = "Human"; _ma = 10; }
            else if (roll1 < 15) { _race = "Orc"; _ma = 10; }
            else if (roll1 < 17) { _race = "Halfling"; _ma = 10; }
            else if (roll1 == 17) { _race = "Half-Elf"; _ma = 10; }
            else if (roll1 == 18) { _race = "Half-Orc"; _ma = 10; }
            
            return _race;
        }

        public string NpcAge()
        {
            //dependent on race
            Randomizer r = new Randomizer();
            string age;
            int d1 = r.RandNumber(1, 30);
            int temp = 15 + d1;
            if (_race == "Elf") { age = Convert.ToString(temp * 3); }
            else if (_race == "Gargoyle") { age = Convert.ToString(temp +5); }
            else if (_race == "Giant") { age = Convert.ToString(temp + 10); }
            else if (_race == "Dwarf") { age = Convert.ToString(temp *2); }
            else if (_race == "Goblin") { age = Convert.ToString(temp + 2); }
            else if (_race == "Orc") { age = Convert.ToString(temp -4); }
            else if (_race == "Hobgoblin") { age = Convert.ToString(temp -6); }
            else if (_race == "Reptile Man") { age = Convert.ToString(temp +12); }
            else if (_race == "Half-Elf") { age = Convert.ToString(temp +20); }
            else { age = Convert.ToString(temp); }
            return age;
        }

        public string NpcGender()
        {
            Randomizer r = new Randomizer();
            int die1 = r.RandNumber(1, 100);
            string gender;
            if (die1 < 60) { gender = "Male"; }
            else { gender = "Female"; }
            return gender;
        }

        public string NpcType()
        {
            Randomizer r = new Randomizer();
            int h = r.RandNumber(1, 6);
            string type = "";

            //HERO OR WIZARD?
            //Roll one die. On a 1 or 2, you're a wizard. Otherwise, you're a hero.
            if (h < 3)
            {
                type = HeroType();
            }

            else
            {
                type = WizardType();
                
            }

            return type;
        }

        public string HeroType()
        {
            //GENERAL CHARACTER TYPE (HEROES) - roll 3 dice.
            Randomizer r = new Randomizer();
            string hero;

            int d1 = r.RandNumber(1, 6);
            int d2 = r.RandNumber(1, 6);
            int d3 = r.RandNumber(1, 6);
            int diceroll = d1 + d2 + d3;

            if (diceroll > 5) { hero = "Priest"; }
            else if (diceroll > 7) { hero = "Rogue"; }
            else if (diceroll > 9) { hero = "Thief"; }
            else if (diceroll > 10) { hero = "Woodsman"; }
            else if (diceroll > 14)
            {
                int f = r.RandNumber(1, 6);
                if (f < 3) { hero = "Human Tank"; }
                else if (f == 3)
                {
                    if (_gender == "Male") { hero = "Barbarian"; }
                    else { hero = "Amazon"; }
                }
                else if (f == 4) { hero = "Mercenary"; }
                else if (f == 5) { hero = "Blademaster"; }
                else { hero = "Leader"; }
            }
            else if (diceroll > 16) { hero = "Scholar"; }
            else if (diceroll > 17) { hero = "Spy"; }
            else if (diceroll > 18) { hero = "Merchant"; }
            else { hero = "Gadgeteer"; }
            return hero;
        }

        public string WizardType()
        {
            string wizard;
            Randomizer r = new Randomizer();

            int d1 = r.RandNumber(1, 6);
            int d2 = r.RandNumber(1, 6);
            int roll = d1 + d2;

            if (roll < 6) { wizard = "Martial Wizard"; }
            else if (roll < 8) { wizard = "Wizardly Thief"; }
            else if (roll < 10) { wizard = "Townsman Wizard"; }
            else if (roll < 11) { wizard = "Adept"; }
            else { wizard = "Apprentice"; }
            return wizard;
        }


        public Tuple<int, int, int> NpcStats(string _level, string type)
        {
            int statTotal;
            Randomizer r = new Randomizer();

            if (_level == "Low")
            {
                statTotal = r.RandNumber(32, 35);

                if (type == "Martial Wizard")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 8;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det <5) { _st = _st + 1; }
                        else if (det <9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }

                    _armor = "No Armor";

                }
                else if (type == "Wizardly Thief")
                {
                    _st = 9;
                    _dx = 11;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Townsman Wizard")
                {
                    _st = 9;
                    _dx = 9;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Adept")
                {
                    _st = 9;
                    _dx = 10;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _iq = _iq + 3;
                    _armor = "No Armor";
                }
                else if (type == "Apprentice")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 8;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 7) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Priest")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Rogue")
                {
                    _st = 8;
                    _dx = 11;
                    _iq = 8;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Thief")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Woodsman")
                {
                    _st = 9;
                    _dx = 9;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Human Tank")
                {
                    _st = 12;
                    _dx = 11;
                    _iq = 7;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                        if (_iq > 10)
                        {
                            int tNum;
                            tNum = _iq - 10;
                            _iq = _iq - tNum;
                            _st = _st + tNum;
                        }
                        _armor = NpcFighterArmor(_dx);
                    }

                }
                else if (type == "Barbarian")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 8;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx-2);
                }
                else if (type == "Amazon")
                {
                    _st = 9;
                    _dx = 11;
                    _iq = 8;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx-2);
                }
                else if (type == "Mercenary")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Blademaster")
                {
                    _st = 9;
                    _dx = 11;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 7) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Leader")
                {
                    _st = 8;
                    _dx = 10;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 5) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Scholar")
                {
                    _st = 8;
                    _dx = 8;
                    _iq = 13;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 5) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }
                else if (type == "Spy")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Merchant")
                {
                    _st = 11;
                    _dx = 8;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 7) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else //Gadgeteer
                {
                    _st = 8;
                    _dx = 9;
                    _iq = 12;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 6) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                

            }
            else if (_level == "Medium")
            {
                statTotal = r.RandNumber(36, 40);

                if (type == "Martial Wizard")
                {
                    _st = 12;
                    _dx = 10;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";

                }
                else if (type == "Wizardly Thief")
                {
                    _st = 10;
                    _dx = 12;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Townsman Wizard")
                {
                    _st = 11;
                    _dx = 10;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Adept")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 12;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _iq = _iq + 3;
                    _armor = "No Armor";
                }
                else if (type == "Apprentice")
                {
                    _st = 12;
                    _dx = 10;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 7) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Priest")
                {
                    _st = 12;
                    _dx = 10;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Rogue")
                {
                    _st = 10;
                    _dx = 12;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Thief")
                {
                    _st = 10;
                    _dx = 12;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Woodsman")
                {
                    _st = 11;
                    _dx = 11;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Human Tank")
                {
                    _st = 13;
                    _dx = 11;
                    _iq = 8;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                        if (_iq > 10)
                        {
                            int tNum;
                            tNum = _iq - 10;
                            _iq = _iq - tNum;
                            _st = _st + tNum;
                        }
                        _armor = NpcFighterArmor(_dx);
                    }

                }
                else if (type == "Barbarian")
                {
                    _st = 12;
                    _dx = 10;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx-2);
                }
                else if (type == "Amazon")
                {
                    _st = 9;
                    _dx = 13;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx-2);
                }
                else if (type == "Mercenary")
                {
                    _st = 11;
                    _dx = 11;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Blademaster")
                {
                    _st = 10;
                    _dx = 12;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 7) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Leader")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 12;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 5) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Scholar")
                {
                    _st = 8;
                    _dx = 8;
                    _iq = 16;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 5) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }
                else if (type == "Spy")
                {
                    _st = 11;
                    _dx = 10;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Merchant")
                {
                    _st = 10;
                    _dx = 9;
                    _iq = 13;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 7) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else //Gadgeteer
                {
                    _st = 9;
                    _dx = 10;
                    _iq = 13;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 6) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }

            }
            else
            {
                statTotal = r.RandNumber(41, 46);

                if (type == "Martial Wizard")
                {
                    _st = 13;
                    _dx = 12;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";

                }
                else if (type == "Wizardly Thief")
                {
                    _st = 12;
                    _dx = 13;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Townsman Wizard")
                {
                    _st = 12;
                    _dx = 12;
                    _iq = 12;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Adept")
                {
                    _st = 10;
                    _dx = 10;
                    _iq = 16;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _iq = _iq + 3;
                    _armor = "No Armor";
                }
                else if (type == "Apprentice")
                {
                    _st = 14;
                    _dx = 12;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 7) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }

                else if (type == "Priest")
                {
                    _st = 11;
                    _dx = 12;
                    _iq = 12;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Rogue")
                {
                    _st = 11;
                    _dx = 12;
                    _iq = 13;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Thief")
                {
                    _st = 11;
                    _dx = 14;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Woodsman")
                {
                    _st = 14;
                    _dx = 11;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Human Tank")
                {
                    _st = 16;
                    _dx = 11;
                    _iq = 9;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                        if (_iq > 10)
                        {
                            int tNum;
                            tNum = _iq - 10;
                            _iq = _iq - tNum;
                            _st = _st + tNum;
                        }
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Barbarian")
                {
                    _st = 13;
                    _dx = 12;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx-2);
                }
                else if (type == "Amazon")
                {
                    _st = 12;
                    _dx = 14;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx-2);
                }
                else if (type == "Mercenary")
                {
                    _st = 13;
                    _dx = 13;
                    _iq = 10;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 5) { _st = _st + 1; }
                        else if (det < 9) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Blademaster")
                {
                    _st = 12;
                    _dx = 13;
                    _iq = 11;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 7) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Leader")
                {
                    _st = 10;
                    _dx = 12;
                    _iq = 14;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 5) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Scholar")
                {
                    _st = 9;
                    _dx = 10;
                    _iq = 17;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 5) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = "No Armor";
                }
                else if (type == "Spy")
                {
                    _st = 12;
                    _dx = 12;
                    _iq = 12;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 8) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else if (type == "Merchant")
                {
                    _st = 11;
                    _dx = 10;
                    _iq = 15;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 4) { _st = _st + 1; }
                        else if (det < 7) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }
                else //Gadgeteer
                {
                    _st = 11;
                    _dx = 11;
                    _iq = 14;
                    int sub = _st + _dx + _iq;
                    statTotal = statTotal - sub;
                    while (statTotal > 0)
                    {
                        int det = r.RandNumber(1, 10);
                        if (det < 3) { _st = _st + 1; }
                        else if (det < 6) { _dx = _dx + 1; }
                        else { _iq = _iq + 1; }
                        statTotal--;
                    }
                    _armor = NpcFighterArmor(_dx);
                }

            }

            return Tuple.Create(_st, _dx, _iq);
        }





        public string NpcTalents(int iq, string type)
        {
            //dependent on type

            if (type == "Martial Wizard")
            {
                _talents = "Horsemanship "+NpcSpells(iq, 2);
            }
            else if (type == "Wizardly Thief")
            {
                _talents = "Thief " + NpcSpells(iq, 4);
            }
            else if (type == "Townsman Wizard")
            {
                _talents = "Literacy " + NpcSpells(iq, 1);
            }
            else if (type == "Adept")
            {
                _talents = "Literacy " + NpcSpells(iq, 1);
            }
            else if (type == "Apprentice")
            {
                _talents = "Literacy " + NpcSpells(iq, 1);
            }
            else if (type == "Priest")
            {
                _talents = "Priest, Physicker " + OtherTalents(iq, 2);
            }
            else if (type == "Rogue")
            {
                _talents = "Charisma, Bard, Recognize Value " + OtherTalents(iq, 3);
            }
            else if (type == "Thief")
            {
                _talents = "Thief, Silent Movement, Assess Value " + OtherTalents(iq, 3);
            }
            else if (type == "Woodsman")
            {
                _talents = "Alertness, Naturalist, Tracking "+OtherTalents(iq, 3);
            }
            else if (type == "Human Tank")
            {
                _talents = OtherTalents(iq, 0);
            }
            else if (type == "Barbarian")
            {   
                _talents = "Horsemanship, Alertness " +OtherTalents(iq, 2);
            }
            else if (type == "Amazon")
            {                
                _talents = "Sex Appeal, Thrown Weapons "+OtherTalents(iq, 2);
            }
            else if (type == "Mercenary")
            {
                _talents = "Horsemanship, Alertness "+OtherTalents(iq, 2);
            }
            else if (type == "Blademaster")
            {
                _talents = "Fencing, Two Weapons, Courtly Graces " + OtherTalents(iq, 3);
            }
            else if (type == "Leader")
            {
                _talents = "Literacy, Tactics, Diplomacy "+OtherTalents(iq, 3);
            }
            else if (type == "Scholar")
            {
                _iq = iq + 3;
                iq = _iq;
                _talents = "Naturalist, Expert Naturalist, Literacy, Scholar "+OtherTalents(iq, 4);
            }
            else if (type == "Spy")
            {
                _talents = "Literacy, Mimic, Spying "+OtherTalents(iq, 3);
            }
            else if (type == "Merchant")
            {
                _talents = "Literacy, Assess Value, Business Sense "+ OtherTalents(iq, 3);
            }
            else //Gadgeteer
            {
                _talents = "Mechanician, Detect Traps, Remove Traps "+OtherTalents(iq, 0);
            }


            return _talents;
        }

        public string WizardWeapons()
        {
            Randomizer r = new Randomizer();
            int d1 = r.RandNumber(1,7);
            if (d1<5) {_weapons = "Staff";}
            else {_weapons = "Dagger";}
            return _weapons;
        }


        public string FighterWeapons(int st)
        {
            Randomizer r = new Randomizer();
            int w = 0;
            int num = r.RandNumber(2,5);

            if (st < 9)
            {                
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    
                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();
            
                    _weapons = _weapons +", "+ wpn;
                    w++;
                }
                
            }
            else if (st < 10)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    
                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
                
            }
            else if (st < 11)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    
                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }

            else if (st < 12)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    l.Add("Shortsword");
                    l.Add("Mace");
                    l.Add("Small Ax");
                    l.Add("Longbow");
                    l.Add("Spear");
                    l.Add("Quarterstaff");
                    l.Add("Boomerang");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }

            else if (st < 13)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    l.Add("Shortsword");
                    l.Add("Mace");
                    l.Add("Small Ax");
                    l.Add("Longbow");
                    l.Add("Spear");
                    l.Add("Quarterstaff");
                    l.Add("Boomerang");
                    l.Add("Broadsword");
                    l.Add("Military Pick");
                    l.Add("Light Crossbow");
                    l.Add("Pike");
                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }

            else if (st < 14)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    l.Add("Shortsword");
                    l.Add("Mace");
                    l.Add("Small Ax");
                    l.Add("Longbow");
                    l.Add("Spear");
                    l.Add("Quarterstaff");
                    l.Add("Boomerang");
                    l.Add("Broadsword");
                    l.Add("Military Pick");
                    l.Add("Light Crossbow");
                    l.Add("Pike");
                    l.Add("Bastard Sword");
                    l.Add("Morningstar");
                    l.Add("Halberd");
                    l.Add("Calvary Lance");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }


            else if (st < 14)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    l.Add("Shortsword");
                    l.Add("Mace");
                    l.Add("Small Ax");
                    l.Add("Longbow");
                    l.Add("Spear");
                    l.Add("Quarterstaff");
                    l.Add("Boomerang");
                    l.Add("Broadsword");
                    l.Add("Military Pick");
                    l.Add("Light Crossbow");
                    l.Add("Pike");
                    l.Add("Bastard Sword");
                    l.Add("Morningstar");
                    l.Add("Halberd");
                    l.Add("Calvary Lance");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }


            else if (st < 15)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    l.Add("Shortsword");
                    l.Add("Mace");
                    l.Add("Small Ax");
                    l.Add("Longbow");
                    l.Add("Spear");
                    l.Add("Quarterstaff");
                    l.Add("Boomerang");
                    l.Add("Broadsword");
                    l.Add("Military Pick");
                    l.Add("Light Crossbow");
                    l.Add("Pike");
                    l.Add("Bastard Sword");
                    l.Add("Morningstar");
                    l.Add("Halberd");
                    l.Add("Calvary Lance");
                    l.Add("2-Handed Sword");
                    l.Add("Great Hammer");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }

            else if (st < 16)
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    l.Add("Shortsword");
                    l.Add("Mace");
                    l.Add("Small Ax");
                    l.Add("Longbow");
                    l.Add("Spear");
                    l.Add("Quarterstaff");
                    l.Add("Boomerang");
                    l.Add("Broadsword");
                    l.Add("Military Pick");
                    l.Add("Light Crossbow");
                    l.Add("Pike");
                    l.Add("Bastard Sword");
                    l.Add("Morningstar");
                    l.Add("Halberd");
                    l.Add("Calvary Lance");
                    l.Add("2-Handed Sword");
                    l.Add("Great Hammer");
                    l.Add("Battle Axe");
                    l.Add("Heavy Crossbow");
                    l.Add("Pike Ax");



                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }


            else
            {
                while (w < num)
                {
                    string wpn;
                    List<string> l = new List<string>();
                    l.Add("Dagger");
                    l.Add("Club");
                    l.Add("Sling");
                    l.Add("Cestus");
                    l.Add("Whip");
                    l.Add("Lasso");
                    l.Add("Nunchuks");
                    l.Add("Blowgun");
                    l.Add("Sha-ken");
                    l.Add("Arquebus");
                    l.Add("Blunderbus");
                    l.Add("Rapier");
                    l.Add("Hatchet");
                    l.Add("Small Bow");
                    l.Add("Javelin");
                    l.Add("Bola");
                    l.Add("Horse Bow");
                    l.Add("Cutlass");
                    l.Add("Hammer");
                    l.Add("Trident");
                    l.Add("Naginata");
                    l.Add("Net");
                    l.Add("Shortsword");
                    l.Add("Mace");
                    l.Add("Small Ax");
                    l.Add("Longbow");
                    l.Add("Spear");
                    l.Add("Quarterstaff");
                    l.Add("Boomerang");
                    l.Add("Broadsword");
                    l.Add("Military Pick");
                    l.Add("Light Crossbow");
                    l.Add("Pike");
                    l.Add("Bastard Sword");
                    l.Add("Morningstar");
                    l.Add("Halberd");
                    l.Add("Calvary Lance");
                    l.Add("2-Handed Sword");
                    l.Add("Great Hammer");
                    l.Add("Battle Axe");
                    l.Add("Heavy Crossbow");
                    l.Add("Pike Ax");
                    l.Add("Great Sword");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    wpn = value.ToString();

                    _weapons = _weapons + ", " + wpn;
                    w++;
                }
            }


            return _weapons;
            }


        

     

        public string OtherTalents(int iq, int used)
        {
            Randomizer r = new Randomizer();
            int t = 0;
            

            if (iq < 9)
            {
                int num = r.RandNumber(2, 3);
                while (t < (num))
                {

                    string tal;
                    List<string> l = new List<string>();
                    l.Add("Sex Appeal");
                    l.Add("Thrown Weapons");
                    l.Add("Running");
                    l.Add("Horsemanship");
                    l.Add("Seamanship");
                    l.Add("Boating");
                    l.Add("Farming");
                    l.Add("Literacy");
                    l.Add("Swimming");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    tal = value.ToString();

                    _talents = _talents + ", " + tal;
                    t++;
                }
            }
            else if (iq < 10)
            {
                int num = r.RandNumber(2, 4);
                while (t < (num))
                {
                    string tal;
                    List<string> l = new List<string>();
                    l.Add("Sex Appeal");
                    l.Add("Thrown Weapons");
                    l.Add("Running");
                    l.Add("Horsemanship");
                    l.Add("Seamanship");
                    l.Add("Boating");
                    l.Add("Farming");
                    l.Add("Literacy");
                    l.Add("Swimming");
                    l.Add("Diving");
                    l.Add("Priest");
                    l.Add("Bard");
                    l.Add("Detect Traps");
                    l.Add("Charisma");
                    l.Add("Alertness");
                    l.Add("Acute Hearing");
                    l.Add("Silent Movement");
                    l.Add("Animal Handler");
                    l.Add("Recognize Value");
                    l.Add("Driver");
                    l.Add("Missile Weapons");
                    l.Add("Climbing");
                    l.Add("Warrior");
                    l.Add("Veteran");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    tal = value.ToString();

                    _talents = _talents + ", " + tal;
                    t++;
                }
            }
            else if (iq < 11)
            {
                int num = r.RandNumber(2, 5);
                while (t < (num))
                {
                    string tal;
                    List<string> l = new List<string>();
                    l.Add("Sex Appeal");
                    l.Add("Thrown Weapons");
                    l.Add("Running");
                    l.Add("Horsemanship");
                    l.Add("Seamanship");
                    l.Add("Boating");
                    l.Add("Farming");
                    l.Add("Literacy");
                    l.Add("Swimming");
                    l.Add("Diving");
                    l.Add("Priest");
                    l.Add("Bard");
                    l.Add("Detect Traps");
                    l.Add("Charisma");
                    l.Add("Alertness");
                    l.Add("Acute Hearing");
                    l.Add("Silent Movement");
                    l.Add("Animal Handler");
                    l.Add("Recognize Value");
                    l.Add("Driver");
                    l.Add("Missile Weapons");
                    l.Add("Climbing");
                    l.Add("Warrior");
                    l.Add("Veteran");
                    l.Add("Fencing");
                    l.Add("Remove Traps");
                    l.Add("New Followers");
                    l.Add("Diplomacy");
                    l.Add("Naturalist");
                    l.Add("Tracking");
                    l.Add("Acrobatics");
                    l.Add("Business Sense");
                    l.Add("Armourer");
                    l.Add("Unarmed Combat I");
                    l.Add("Mimic");
                    l.Add("Engineer");
                    l.Add("Thief");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    tal = value.ToString();

                    _talents = _talents + ", " + tal;
                    t++;
                }
            }
            else if (iq < 12)
            {
                int num = r.RandNumber(3, 6);
                while (t < (num))
                {
                    string tal;
                    List<string> l = new List<string>();
                    l.Add("Sex Appeal");
                    l.Add("Thrown Weapons");
                    l.Add("Running");
                    l.Add("Horsemanship");
                    l.Add("Seamanship");
                    l.Add("Boating");
                    l.Add("Farming");
                    l.Add("Literacy");
                    l.Add("Swimming");
                    l.Add("Diving");
                    l.Add("Priest");
                    l.Add("Bard");
                    l.Add("Detect Traps");
                    l.Add("Charisma");
                    l.Add("Alertness");
                    l.Add("Acute Hearing");
                    l.Add("Silent Movement");
                    l.Add("Animal Handler");
                    l.Add("Recognize Value");
                    l.Add("Driver");
                    l.Add("Missile Weapons");
                    l.Add("Climbing");
                    l.Add("Warrior");
                    l.Add("Veteran");
                    l.Add("Fencing");
                    l.Add("Remove Traps");
                    l.Add("New Followers");
                    l.Add("Diplomacy");
                    l.Add("Naturalist");
                    l.Add("Tracking");
                    l.Add("Acrobatics");
                    l.Add("Business Sense");
                    l.Add("Armourer");
                    l.Add("Unarmed Combat I");
                    l.Add("Mimic");
                    l.Add("Engineer");
                    l.Add("Thief");
                    l.Add("Architect/Builder");
                    l.Add("Goldsmith");
                    l.Add("Shipbuilder");
                    l.Add("Two Weapons");
                    l.Add("Courtly Graces");
                    l.Add("Monster Followers I");
                    l.Add("Tactics");
                    l.Add("Physicker");
                    l.Add("Detection of Lies");
                    l.Add("Vet");
                    l.Add("Mechanician");
                    l.Add("Woodsman");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    tal = value.ToString();

                    _talents = _talents + ", " + tal;
                    t++;
                }
            }
            else if (iq < 13)
            {
                int num = r.RandNumber(3, 7);
                while (t < (num))
                {
                    string tal;
                    List<string> l = new List<string>();
                    l.Add("Sex Appeal");
                    l.Add("Thrown Weapons");
                    l.Add("Running");
                    l.Add("Horsemanship");
                    l.Add("Seamanship");
                    l.Add("Boating");
                    l.Add("Farming");
                    l.Add("Literacy");
                    l.Add("Swimming");
                    l.Add("Diving");
                    l.Add("Priest");
                    l.Add("Bard");
                    l.Add("Detect Traps");
                    l.Add("Charisma");
                    l.Add("Alertness");
                    l.Add("Acute Hearing");
                    l.Add("Silent Movement");
                    l.Add("Animal Handler");
                    l.Add("Recognize Value");
                    l.Add("Driver");
                    l.Add("Missile Weapons");
                    l.Add("Climbing");
                    l.Add("Warrior");
                    l.Add("Veteran");
                    l.Add("Fencing");
                    l.Add("Remove Traps");
                    l.Add("New Followers");
                    l.Add("Diplomacy");
                    l.Add("Naturalist");
                    l.Add("Tracking");
                    l.Add("Acrobatics");
                    l.Add("Business Sense");
                    l.Add("Armourer");
                    l.Add("Unarmed Combat I");
                    l.Add("Mimic");
                    l.Add("Engineer");
                    l.Add("Thief");
                    l.Add("Architect/Builder");
                    l.Add("Goldsmith");
                    l.Add("Shipbuilder");
                    l.Add("Two Weapons");
                    l.Add("Courtly Graces");
                    l.Add("Monster Followers I");
                    l.Add("Tactics");
                    l.Add("Physicker");
                    l.Add("Detection of Lies");
                    l.Add("Vet");
                    l.Add("Mechanician");
                    l.Add("Woodsman");
                    l.Add("expert Naturalist");
                    l.Add("Monster Followers II");
                    l.Add("Spying");
                    l.Add("Assess Value");
                    l.Add("Captain");
                    l.Add("Ventriloquist");
                    l.Add("Unarmed Combat II");
                    l.Add("Master Thief");
                    l.Add("Master Armourer");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    tal = value.ToString();

                    _talents = _talents + ", " + tal;
                    t++;
                }
            }
            else if (iq < 14)
            {
                int num = r.RandNumber(4, 8);
                while (t < (num))
                {
                    string tal;
                    List<string> l = new List<string>();
                    l.Add("Sex Appeal");
                    l.Add("Thrown Weapons");
                    l.Add("Running");
                    l.Add("Horsemanship");
                    l.Add("Seamanship");
                    l.Add("Boating");
                    l.Add("Farming");
                    l.Add("Literacy");
                    l.Add("Swimming");
                    l.Add("Diving");
                    l.Add("Priest");
                    l.Add("Bard");
                    l.Add("Detect Traps");
                    l.Add("Charisma");
                    l.Add("Alertness");
                    l.Add("Acute Hearing");
                    l.Add("Silent Movement");
                    l.Add("Animal Handler");
                    l.Add("Recognize Value");
                    l.Add("Driver");
                    l.Add("Missile Weapons");
                    l.Add("Climbing");
                    l.Add("Warrior");
                    l.Add("Veteran");
                    l.Add("Fencing");
                    l.Add("Remove Traps");
                    l.Add("New Followers");
                    l.Add("Diplomacy");
                    l.Add("Naturalist");
                    l.Add("Tracking");
                    l.Add("Acrobatics");
                    l.Add("Business Sense");
                    l.Add("Armourer");
                    l.Add("Unarmed Combat I");
                    l.Add("Mimic");
                    l.Add("Engineer");
                    l.Add("Thief");
                    l.Add("Architect/Builder");
                    l.Add("Goldsmith");
                    l.Add("Shipbuilder");
                    l.Add("Two Weapons");
                    l.Add("Courtly Graces");
                    l.Add("Monster Followers I");
                    l.Add("Tactics");
                    l.Add("Physicker");
                    l.Add("Detection of Lies");
                    l.Add("Vet");
                    l.Add("Mechanician");
                    l.Add("Woodsman");
                    l.Add("expert Naturalist");
                    l.Add("Monster Followers II");
                    l.Add("Spying");
                    l.Add("Assess Value");
                    l.Add("Captain");
                    l.Add("Ventriloquist");
                    l.Add("Unarmed Combat II");
                    l.Add("Master Thief");
                    l.Add("Master Armourer");
                    l.Add("Chemist");
                    l.Add("Master Mechanician");
                    l.Add("Scholar");
                    l.Add("Strategist");
                    l.Add("Mathematician");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    tal = value.ToString();

                    _talents = _talents + ", " + tal;
                    t++;
                }
            }
            else
            {
                int num = r.RandNumber(4, 9);
                while (t < (num))
                {
                    string tal;
                    List<string> l = new List<string>();
                    l.Add("Sex Appeal");
                    l.Add("Thrown Weapons");
                    l.Add("Running");
                    l.Add("Horsemanship");
                    l.Add("Seamanship");
                    l.Add("Boating");
                    l.Add("Farming");
                    l.Add("Literacy");
                    l.Add("Swimming");
                    l.Add("Diving");
                    l.Add("Priest");
                    l.Add("Bard");
                    l.Add("Detect Traps");
                    l.Add("Charisma");
                    l.Add("Alertness");
                    l.Add("Acute Hearing");
                    l.Add("Silent Movement");
                    l.Add("Animal Handler");
                    l.Add("Recognize Value");
                    l.Add("Driver");
                    l.Add("Missile Weapons");
                    l.Add("Climbing");
                    l.Add("Warrior");
                    l.Add("Veteran");
                    l.Add("Fencing");
                    l.Add("Remove Traps");
                    l.Add("New Followers");
                    l.Add("Diplomacy");
                    l.Add("Naturalist");
                    l.Add("Tracking");
                    l.Add("Acrobatics");
                    l.Add("Business Sense");
                    l.Add("Armourer");
                    l.Add("Unarmed Combat I");
                    l.Add("Mimic");
                    l.Add("Engineer");
                    l.Add("Thief");
                    l.Add("Architect/Builder");
                    l.Add("Goldsmith");
                    l.Add("Shipbuilder");
                    l.Add("Two Weapons");
                    l.Add("Courtly Graces");
                    l.Add("Monster Followers I");
                    l.Add("Tactics");
                    l.Add("Physicker");
                    l.Add("Detection of Lies");
                    l.Add("Vet");
                    l.Add("Mechanician");
                    l.Add("Woodsman");
                    l.Add("expert Naturalist");
                    l.Add("Monster Followers II");
                    l.Add("Spying");
                    l.Add("Assess Value");
                    l.Add("Captain");
                    l.Add("Ventriloquist");
                    l.Add("Unarmed Combat II");
                    l.Add("Master Thief");
                    l.Add("Master Armourer");
                    l.Add("Chemist");
                    l.Add("Master Mechanician");
                    l.Add("Scholar");
                    l.Add("Strategist");
                    l.Add("Mathematician");
                    l.Add("Master Physicker");
                    l.Add("Disguise");
                    l.Add("Theologian");
                    l.Add("Unarmed Combat III");
                    l.Add("Unarmed Combat IV");
                    l.Add("Unarmed Combat V");
                    l.Add("Alchemy");
                    l.Add("Master Bard");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    tal = value.ToString();

                    _talents = _talents + ", " + tal;
                    t++;
                }
            }

            return _talents;
        }




        public string NpcSpells(int iq, int used)
        {
            Randomizer r = new Randomizer();
            int s=0;

            if (iq < 9)
            {
                int num = r.RandNumber(4, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");                    

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }

            else if (iq < 10)
            {
                int num = r.RandNumber(4, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }

            }

            else if (iq < 11)
            {
                int num = r.RandNumber(4, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }

            else if (iq < 12)
            {
                int num = r.RandNumber(4, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }

            else if (iq < 13)
            {
                int num = r.RandNumber(5, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else if (iq < 14)
            {
                int num = r.RandNumber(5, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else if (iq < 15)
            {
                int num = r.RandNumber(5, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");
                    l.Add("Lightning");
                    l.Add("Summon Giant");
                    l.Add("4-Hex Illusion");
                    l.Add("Remove Thrown Spell");
                    l.Add("Dispel Illusions");
                    l.Add("Spell Shield");
                    l.Add("Glamor");
                    l.Add("Fresh Air");
                    l.Add("Weapon/Armor Enchantment");
                    l.Add("Telepathy");
                    l.Add("Summon Lesser Demon");
                    l.Add("Explosive Gem");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else if (iq < 16)
            {
                int num = r.RandNumber(6, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");
                    l.Add("Lightning");
                    l.Add("Summon Giant");
                    l.Add("4-Hex Illusion");
                    l.Add("Remove Thrown Spell");
                    l.Add("Dispel Illusions");
                    l.Add("Spell Shield");
                    l.Add("Glamor");
                    l.Add("Fresh Air");
                    l.Add("Weapon/Armor Enchantment");
                    l.Add("Telepathy");
                    l.Add("Summon Lesser Demon");
                    l.Add("Explosive Gem");
                    l.Add("Iron Flesh");
                    l.Add("Teleport");
                    l.Add("Summon Small Dragon");
                    l.Add("Giant Rope");
                    l.Add("7-Hex Shadow");
                    l.Add("7-Hex Image");
                    l.Add("Megahex Avert");
                    l.Add("Calling");
                    l.Add("Hammertouch");
                    l.Add("Unnoticeability");
                    l.Add("Pentagram");
                    l.Add("Create Gate");
                    l.Add("Astral Projection");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else if (iq < 17)
            {
                int num = r.RandNumber(6, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");
                    l.Add("Lightning");
                    l.Add("Summon Giant");
                    l.Add("4-Hex Illusion");
                    l.Add("Remove Thrown Spell");
                    l.Add("Dispel Illusions");
                    l.Add("Spell Shield");
                    l.Add("Glamor");
                    l.Add("Fresh Air");
                    l.Add("Weapon/Armor Enchantment");
                    l.Add("Telepathy");
                    l.Add("Summon Lesser Demon");
                    l.Add("Explosive Gem");
                    l.Add("Iron Flesh");
                    l.Add("Teleport");
                    l.Add("Summon Small Dragon");
                    l.Add("Giant Rope");
                    l.Add("7-Hex Shadow");
                    l.Add("7-Hex Image");
                    l.Add("Megahex Avert");
                    l.Add("Calling");
                    l.Add("Hammertouch");
                    l.Add("Unnoticeability");
                    l.Add("Pentagram");
                    l.Add("Create Gate");
                    l.Add("Astral Projection");
                    l.Add("7-Hex Illusion");
                    l.Add("Summon Dragon");
                    l.Add("Death Spell");
                    l.Add("7-Hex Fire");
                    l.Add("7-Hex Wall");
                    l.Add("Megahex Sleep");
                    l.Add("Trance");
                    l.Add("Long Distance Telepathy");
                    l.Add("Write Scroll");
                    l.Add("Create/Destroy Elemental");
                    l.Add("Staff of Power");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else if (iq < 18)
            {
                int num = r.RandNumber(7, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");
                    l.Add("Lightning");
                    l.Add("Summon Giant");
                    l.Add("4-Hex Illusion");
                    l.Add("Remove Thrown Spell");
                    l.Add("Dispel Illusions");
                    l.Add("Spell Shield");
                    l.Add("Glamor");
                    l.Add("Fresh Air");
                    l.Add("Weapon/Armor Enchantment");
                    l.Add("Telepathy");
                    l.Add("Summon Lesser Demon");
                    l.Add("Explosive Gem");
                    l.Add("Iron Flesh");
                    l.Add("Teleport");
                    l.Add("Summon Small Dragon");
                    l.Add("Giant Rope");
                    l.Add("7-Hex Shadow");
                    l.Add("7-Hex Image");
                    l.Add("Megahex Avert");
                    l.Add("Calling");
                    l.Add("Hammertouch");
                    l.Add("Unnoticeability");
                    l.Add("Pentagram");
                    l.Add("Create Gate");
                    l.Add("Astral Projection");
                    l.Add("7-Hex Illusion");
                    l.Add("Summon Dragon");
                    l.Add("Death Spell");
                    l.Add("7-Hex Fire");
                    l.Add("7-Hex Wall");
                    l.Add("Megahex Sleep");
                    l.Add("Trance");
                    l.Add("Long Distance Telepathy");
                    l.Add("Write Scroll");
                    l.Add("Create/Destroy Elemental");
                    l.Add("Staff of Power");
                    l.Add("Summon Demon");
                    l.Add("Geas");
                    l.Add("Insubstantiality");
                    l.Add("Dissolve Enchantment");
                    l.Add("Remove Cursed Object");
                    l.Add("Expunge");
                    l.Add("Spellsniffer");
                    l.Add("Cleansing");
                    l.Add("The Little Death");
                    l.Add("Blast Trap");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else if (iq < 19)
            {
                int num = r.RandNumber(7, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");
                    l.Add("Lightning");
                    l.Add("Summon Giant");
                    l.Add("4-Hex Illusion");
                    l.Add("Remove Thrown Spell");
                    l.Add("Dispel Illusions");
                    l.Add("Spell Shield");
                    l.Add("Glamor");
                    l.Add("Fresh Air");
                    l.Add("Weapon/Armor Enchantment");
                    l.Add("Telepathy");
                    l.Add("Summon Lesser Demon");
                    l.Add("Explosive Gem");
                    l.Add("Iron Flesh");
                    l.Add("Teleport");
                    l.Add("Summon Small Dragon");
                    l.Add("Giant Rope");
                    l.Add("7-Hex Shadow");
                    l.Add("7-Hex Image");
                    l.Add("Megahex Avert");
                    l.Add("Calling");
                    l.Add("Hammertouch");
                    l.Add("Unnoticeability");
                    l.Add("Pentagram");
                    l.Add("Create Gate");
                    l.Add("Astral Projection");
                    l.Add("7-Hex Illusion");
                    l.Add("Summon Dragon");
                    l.Add("Death Spell");
                    l.Add("7-Hex Fire");
                    l.Add("7-Hex Wall");
                    l.Add("Megahex Sleep");
                    l.Add("Trance");
                    l.Add("Long Distance Telepathy");
                    l.Add("Write Scroll");
                    l.Add("Create/Destroy Elemental");
                    l.Add("Staff of Power");
                    l.Add("Summon Demon");
                    l.Add("Geas");
                    l.Add("Insubstantiality");
                    l.Add("Dissolve Enchantment");
                    l.Add("Remove Cursed Object");
                    l.Add("Expunge");
                    l.Add("Spellsniffer");
                    l.Add("Cleansing");
                    l.Add("The Little Death");
                    l.Add("Blast Trap");
                    l.Add("Shapeshifting");
                    l.Add("Wizard's Wrath");
                    l.Add("Control Gate");
                    l.Add("Lesser Magic Item Creation");
                    l.Add("Megahex Freeze");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else if (iq < 20)
            {
                int num = r.RandNumber(8, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");
                    l.Add("Lightning");
                    l.Add("Summon Giant");
                    l.Add("4-Hex Illusion");
                    l.Add("Remove Thrown Spell");
                    l.Add("Dispel Illusions");
                    l.Add("Spell Shield");
                    l.Add("Glamor");
                    l.Add("Fresh Air");
                    l.Add("Weapon/Armor Enchantment");
                    l.Add("Telepathy");
                    l.Add("Summon Lesser Demon");
                    l.Add("Explosive Gem");
                    l.Add("Iron Flesh");
                    l.Add("Teleport");
                    l.Add("Summon Small Dragon");
                    l.Add("Giant Rope");
                    l.Add("7-Hex Shadow");
                    l.Add("7-Hex Image");
                    l.Add("Megahex Avert");
                    l.Add("Calling");
                    l.Add("Hammertouch");
                    l.Add("Unnoticeability");
                    l.Add("Pentagram");
                    l.Add("Create Gate");
                    l.Add("Astral Projection");
                    l.Add("7-Hex Illusion");
                    l.Add("Summon Dragon");
                    l.Add("Death Spell");
                    l.Add("7-Hex Fire");
                    l.Add("7-Hex Wall");
                    l.Add("Megahex Sleep");
                    l.Add("Trance");
                    l.Add("Long Distance Telepathy");
                    l.Add("Write Scroll");
                    l.Add("Create/Destroy Elemental");
                    l.Add("Staff of Power");
                    l.Add("Summon Demon");
                    l.Add("Geas");
                    l.Add("Insubstantiality");
                    l.Add("Dissolve Enchantment");
                    l.Add("Remove Cursed Object");
                    l.Add("Expunge");
                    l.Add("Spellsniffer");
                    l.Add("Cleansing");
                    l.Add("The Little Death");
                    l.Add("Blast Trap");
                    l.Add("Shapeshifting");
                    l.Add("Wizard's Wrath");
                    l.Add("Control Gate");
                    l.Add("Lesser Magic Item Creation");
                    l.Add("Megahex Freeze");
                    l.Add("Long-Distance Teleport");
                    l.Add("Zombie");
                    l.Add("Revival");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }


            else
            {
                int num = r.RandNumber(8, iq);
                while (s < (num))
                {
                    string spl;
                    List<string> l = new List<string>();
                    l.Add("Staff");
                    l.Add("Magic Fist");
                    l.Add("Blur");
                    l.Add("Slow Movement");
                    l.Add("Drop Weapon");
                    l.Add("Image");
                    l.Add("Detect Magic");
                    l.Add("Light");
                    l.Add("Clumsiness");
                    l.Add("Confusion");
                    l.Add("Avert");
                    l.Add("Aid");
                    l.Add("Summon Wolf");
                    l.Add("Reveal Magic");
                    l.Add("Fire");
                    l.Add("Detect Life");
                    l.Add("Darkness");
                    l.Add("Dark Vision");
                    l.Add("Trip");
                    l.Add("Speed Movement");
                    l.Add("Summon Myrmidon");
                    l.Add("Dazzle");
                    l.Add("Shadow");
                    l.Add("Shock Shield");
                    l.Add("Ward");
                    l.Add("Trailtwister");
                    l.Add("Far Vision");
                    l.Add("Detect Enemies");
                    l.Add("Lock/Knock");
                    l.Add("Sleep");
                    l.Add("Summon Bear");
                    l.Add("Control Animal");
                    l.Add("Illusion");
                    l.Add("Reverse Missiles");
                    l.Add("Rope");
                    l.Add("Create Wall");
                    l.Add("Destroy Creation");
                    l.Add("Silent Movement");
                    l.Add("Persuasiveness");
                    l.Add("Staff to Snake");
                    l.Add("Reveal/Conceal");
                    l.Add("Freeze");
                    l.Add("Fireball");
                    l.Add("Invisibility");
                    l.Add("Blast");
                    l.Add("Mage Sight");
                    l.Add("Break Weapon");
                    l.Add("3-Hex Fire");
                    l.Add("3-Hex Shadow");
                    l.Add("Analyse Magic");
                    l.Add("Magic Rainstorm");
                    l.Add("Drain Strength");
                    l.Add("Repair");
                    l.Add("Eyes Behind");
                    l.Add("Flight");
                    l.Add("Summon Gargoyle");
                    l.Add("Control Person");
                    l.Add("Stone Flesh");
                    l.Add("Slippery Floor");
                    l.Add("Stop");
                    l.Add("4-Hex Image");
                    l.Add("3-Hex Wall");
                    l.Add("Fireproofing");
                    l.Add("Sticky Floor");
                    l.Add("Curse");
                    l.Add("Open Tunnel");
                    l.Add("Telekinesis");
                    l.Add("Control Elemental");
                    l.Add("Lightning");
                    l.Add("Summon Giant");
                    l.Add("4-Hex Illusion");
                    l.Add("Remove Thrown Spell");
                    l.Add("Dispel Illusions");
                    l.Add("Spell Shield");
                    l.Add("Glamor");
                    l.Add("Fresh Air");
                    l.Add("Weapon/Armor Enchantment");
                    l.Add("Telepathy");
                    l.Add("Summon Lesser Demon");
                    l.Add("Explosive Gem");
                    l.Add("Iron Flesh");
                    l.Add("Teleport");
                    l.Add("Summon Small Dragon");
                    l.Add("Giant Rope");
                    l.Add("7-Hex Shadow");
                    l.Add("7-Hex Image");
                    l.Add("Megahex Avert");
                    l.Add("Calling");
                    l.Add("Hammertouch");
                    l.Add("Unnoticeability");
                    l.Add("Pentagram");
                    l.Add("Create Gate");
                    l.Add("Astral Projection");
                    l.Add("7-Hex Illusion");
                    l.Add("Summon Dragon");
                    l.Add("Death Spell");
                    l.Add("7-Hex Fire");
                    l.Add("7-Hex Wall");
                    l.Add("Megahex Sleep");
                    l.Add("Trance");
                    l.Add("Long Distance Telepathy");
                    l.Add("Write Scroll");
                    l.Add("Create/Destroy Elemental");
                    l.Add("Staff of Power");
                    l.Add("Summon Demon");
                    l.Add("Geas");
                    l.Add("Insubstantiality");
                    l.Add("Dissolve Enchantment");
                    l.Add("Remove Cursed Object");
                    l.Add("Expunge");
                    l.Add("Spellsniffer");
                    l.Add("Cleansing");
                    l.Add("The Little Death");
                    l.Add("Blast Trap");
                    l.Add("Shapeshifting");
                    l.Add("Wizard's Wrath");
                    l.Add("Control Gate");
                    l.Add("Lesser Magic Item Creation");
                    l.Add("Megahex Freeze");
                    l.Add("Long-Distance Teleport");
                    l.Add("Zombie");
                    l.Add("Revival");
                    l.Add("Greater Magic Item Creation");
                    l.Add("Possession");

                    int rand = r.RandNumber(1, l.Count);
                    var value = l[rand];
                    spl = value.ToString();

                    _spells = _spells + ", " + spl;
                    s++;
                }
            }
            return _spells;
        }


        public string NpcLooks()
        {
            string appearance;
            Randomizer r = new Randomizer();
            Randomizer r2 = new Randomizer();
            int app = r.RandNumber(1, 6) + r2.RandNumber(1, 6);
            if (app == 2) { appearance = "and would be considered very attractive even by others who are not "+_race+"s"; }
            else if (app ==3) { appearance = "and would be considered irresistably attractive by most other " + _race + "s"; }
            else if (app ==4) { appearance = "and would be considered attractive."; }
            else if (app ==5) { appearance = "and would be considered somewhat attractive."; }
            else if (app ==9) { appearance = "and is slightly unattractive. "; }
            else if (app == 10) { appearance = "and is somewhat ugly."; }
            else if (app == 11) { appearance = "and is very ugly."; }
            else if (app == 12) { appearance = "and is hideously ugly."; }

            else { appearance = "but otherwise looks unremarkable."; }

            string looks = NpcColors()+appearance;

            return looks;
        }

        public string NpcTreasure(string lv)
        {
            Treasure t = new Treasure();

            string treasure = t.PersTreasure(lv);

            return treasure;
        }

        public string NpcBackground()
        {
            string background = NpcPersonality()+NpcStory();

            return background;
        }


        public string NpcPersonality()
        {
            string personality;
            Randomizer r = new Randomizer();
            Randomizer r2 = new Randomizer();
            string reaction, bravery, honesty, friendliness, mood, sensitivity, dominate, greed;
            int rea, bra, hon, fri, app, moo, sen, dom, gre;
            rea = r.RandNumber(1, 6);
            bra = r.RandNumber(1, 6) + r2.RandNumber(1, 6);
            hon = r.RandNumber(1, 6) + r2.RandNumber(1, 6);
            fri = r.RandNumber(1, 6) + r2.RandNumber(1, 6);
           
            moo = r.RandNumber(1, 6) + r2.RandNumber(1, 6);
            sen = r.RandNumber(1, 6) + r2.RandNumber(1, 6);
            dom = r.RandNumber(1, 6) + r2.RandNumber(1, 6);
            gre = r.RandNumber(1, 6) + r2.RandNumber(1, 6);            

            if (rea == 1) { reaction = "hostile"; }
            else if (rea ==2){reaction = "unfriendly";}
            else if (rea == 3) { reaction = "neutral"; }
            else if (rea == 4) { reaction = "neutral"; }
            else if (rea == 5) { reaction = "friendly"; }
            else { reaction = "very friendly"; }

            if (bra < 6) { bravery = "cowardly, "; }
            else if (bra > 8) { bravery = "very brave, "; }
            else { bravery = ""; }

            if (hon < 6) { honesty = "habitual liar, "; }
            else if (hon > 8) { honesty = "painfully truthful, "; }
            else { honesty = ""; }

            if (fri < 6) { friendliness = "hates everyone, "; }
            else if (fri > 8) { friendliness = "gets along well with anyone, "; }
            else { friendliness = ""; }            

            if (moo < 6) { mood = "quiet, shy and withdrawn, "; }
            else if (moo > 8) { mood = "loud, aggressive and extroverted"; }
            else { mood = ""; }

            if (sen < 6) { sensitivity = "completely insensitive, "; }
            else if (sen > 8) { sensitivity = "very empathetic, "; }
            else { sensitivity = ""; }

            if (dom < 6) { dominate = "very agreeable, "; }
            else if (dom > 8) { dominate = "very domineering, "; }
            else { dominate = ""; }

            if (gre < 6) { greed = "very generous, "; }
            else if (gre > 8) { greed = "very greedy, "; }
            else { greed = ""; }
            
          
            string traits = bravery+honesty+friendliness+mood+sensitivity+dominate+greed;
            string other;
            if (traits == ""){other = " otherwise unremarkable.";}
            else {other = ".";}


            personality = " has a general reaction of " +reaction + " and is considered " +traits +other;

            return personality;
        }




        public string NpcFighterArmor(int dx)
        {
            Randomizer r = new Randomizer();
            string armor = "";
            if (dx < 10) 
            {                
                List<string> l = new List<string>();
                l.Add("No Armor");
                l.Add("Shield Only");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
                
            }
            else if (dx < 11)
            {
                List<string> l = new List<string>();
                l.Add("No Armor");
                l.Add("Shield Only");
                l.Add("Cloth Armor");
                l.Add("Cloth Armor and Shield");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else if (dx < 12)
            {
                List<string> l = new List<string>();
                l.Add("No Armor");
                l.Add("Cloth Armor");
                l.Add("Cloth Armor and Shield");
                l.Add("Leather Armor");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else if (dx < 13)
            {
                List<string> l = new List<string>();
                l.Add("No Armor");
                l.Add("Cloth Armor");
                l.Add("Cloth Armor and Shield");
                l.Add("Leather Armor");
                l.Add("Leather Armor and Shield");
                l.Add("Chainmail Armor");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else if (dx < 14)
            {
                List<string> l = new List<string>();                
                l.Add("Cloth Armor");
                l.Add("Cloth Armor and Shield");
                l.Add("Leather Armor");
                l.Add("Leather Armor and Shield");
                l.Add("Chainmail Armor");
                l.Add("Chainmail Armor and Shield");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else if (dx < 15)
            {
                List<string> l = new List<string>();
                l.Add("Leather Armor");
                l.Add("Leather Armor and Shield");
                l.Add("Chainmail Armor");
                l.Add("Chainmail Armor and Shield");
                l.Add("Half-Plate Armor");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else if (dx < 16)
            {
                List<string> l = new List<string>();
                l.Add("Leather Armor and Shield");
                l.Add("Chainmail Armor");
                l.Add("Chainmail Armor and Shield");
                l.Add("Half-Plate Armor");
                l.Add("Half-Plate Armor and Shield");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else if (dx < 17)
            {
                List<string> l = new List<string>(); 
                l.Add("Leather Armor");
                l.Add("Leather Armor and Shield");
                l.Add("Chainmail Armor");
                l.Add("Chainmail Armor and Shield");
                l.Add("Half-Plate Armor");
                l.Add("Half-Plate Armor and Shield");
                l.Add("Plate Armor");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else if (dx < 18)
            {
                List<string> l = new List<string>(); 
                l.Add("Chainmail Armor");
                l.Add("Chainmail Armor and Shield");
                l.Add("Half-Plate Armor");
                l.Add("Half-Plate Armor and Shield");
                l.Add("Plate Armor");
                l.Add("Plate Armor and Shield");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
            else
            {
                List<string> l = new List<string>();              
                l.Add("Chainmail Armor and Shield");
                l.Add("Half-Plate Armor");
                l.Add("Half-Plate Armor and Shield");
                l.Add("Plate Armor");
                l.Add("Plate Armor and Shield");
                l.Add("Fine Plate Armor");
                l.Add("Fine Plate Armor and Shield");
                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                armor = value.ToString();
            }
           
            return armor;
        }

        public string NpcWeapons(int st, string type)
        {
            if (type == "Martial Wizard")
            {
                _weapons = WizardWeapons();
            }
            else if (type == "Wizardly Thief")
            {
                _weapons = "Shortsword, " + WizardWeapons();
            }
            else if (type == "Townsman Wizard")
            {
                _weapons = WizardWeapons();
            }
            else if (type == "Adept")
            {
                _weapons = WizardWeapons();
            }
            else if (type == "Apprentice")
            {
                _weapons = WizardWeapons();
            }
            else if (type == "Priest")
            {
            _weapons = FighterWeapons(st);
            }
            else if (type == "Rogue")
            {
                _weapons = "Shortsword, "+FighterWeapons(st);
            }
            else if (type == "Thief")
            {
                _weapons = "Shortsword, " +FighterWeapons(st);
            }
            else if (type == "Woodsman")
            {
                _weapons = "Hand Ax, " +FighterWeapons(st);
            }
            else if (type == "Human Tank")
            {
                _weapons = "2-Handed Sword, Mace, "+FighterWeapons(st);
            }
            else if (type == "Barbarian")
            {
                _weapons = FighterWeapons(st);
            }
            else if (type == "Amazon")
            {
                _weapons = FighterWeapons(st);
            }
            else if (type == "Mercenary")
            {
                _weapons = FighterWeapons(st);
            }
            else if (type == "Blademaster")
            {
                _weapons = "Longsword, "+FighterWeapons(st);
            }
            else if (type == "Leader")
            {
                _weapons = FighterWeapons(st);
            }
            else if (type == "Scholar")
            {
                _weapons = WizardWeapons();
            }
            else if (type == "Spy")
            {
                _weapons = FighterWeapons(st);
            }
            else if (type == "Merchant")
            {
                _weapons = FighterWeapons(st);
            }
            else //Gadgeteer
            {
                _weapons = "Crossbow, "+FighterWeapons(st);
            }
            return _weapons;
        }

        public string NpcEquipment()
        {
            Randomizer r = new Randomizer();
            string equip;
            int num = r.RandNumber(2, 4);            

            while (num > 0)
            {                
                List<string> l = new List<string>();
                l.Add("Labyrinth kit");
                l.Add("Physicker's chest");
                l.Add("Belt pouch");
                l.Add("Molotail");
                l.Add("Torch");
                l.Add("100-m rope");
                l.Add("10-m rope ladder");
                l.Add("Collapsible 2-m pole");
                l.Add("Crowbar");
                l.Add("Miner's pick");
                l.Add("Backpack");
                l.Add("Rations");
                l.Add("Wine");
                l.Add("Waterskin - 1 liter");
                l.Add("Scroll");
                l.Add("Book");
                l.Add("Wizard's chest");
                l.Add("Lantern");
                l.Add("Clothing");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                equip = value.ToString();

                _equipment = _equipment + ", " + equip;
                num--;
            }

            Dressing d = new Dressing();
            _equipment = _equipment + ", " + d.Belonging() + ", " + d.Clothing() + ", " + d.Belonging() + ", " + d.Belonging();

            return _equipment;
        }



        public string NpcColors()
        {
            Randomizer r = new Randomizer();
            int shade = r.RandNumber(1, 3);
            if (shade == 1)
            {//light

                string colors;
                string hair;
                List<string> l = new List<string>();
                l.Add("light brown");
                l.Add("light chestnut brown");
                l.Add("strawberry blond");
                l.Add("light blond");
                l.Add("golden blond");
                l.Add("medium blond");
                l.Add("white");
                l.Add("golden");
                l.Add("silver");
                l.Add("shining gold");
                l.Add("copper");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                hair = value.ToString();


                string eyes;
                List<string> l2 = new List<string>();
                l2.Add("amber");
                l2.Add("pale blue");
                l2.Add("light grey");
                l2.Add("violet");
                l2.Add("golden");
                l2.Add("silver");
                l2.Add("pale blue");

                int rand2 = r.RandNumber(1, l2.Count);
                var value2 = l2[rand2];
                eyes = value2.ToString();

                string skin;
                List<string> l3 = new List<string>();
                l3.Add("light");
                l3.Add("pale white");
                l3.Add("white");
                l3.Add("fair");
                l3.Add("light");
                l3.Add("white");
                l3.Add("fair");

                int rand3 = r.RandNumber(1, l3.Count);
                var value3 = l3[rand3];
                skin = value3.ToString();

                colors = " has " + hair + " hair, " + eyes + " eyes, and " + skin + " colored skin ";
                return colors;
            }

            else if (shade == 2)
            {//medium
                string colors;
                string hair;
                List<string> l = new List<string>();
                l.Add("brown");
                l.Add("chestnut brown");
                l.Add("medium brown");
                l.Add("natural brown");
                l.Add("auburn");
                l.Add("copper");
                l.Add("red");
                l.Add("dark blond");
                l.Add("grey");
                l.Add("");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                hair = value.ToString();


                string eyes;
                List<string> l2 = new List<string>();
                l2.Add("brown");
                l2.Add("blue");
                l2.Add("grey");
                l2.Add("violet");
                l2.Add("hazel");
                l2.Add("red");
                l2.Add("blue");

                int rand2 = r.RandNumber(1, l2.Count);
                var value2 = l2[rand2];
                eyes = value2.ToString();

                string skin;
                List<string> l3 = new List<string>();
                l3.Add("light brown");
                l3.Add("olive");
                l3.Add("brown");
                l3.Add("tan");
                l3.Add("medium brown");
                l3.Add("tan");
                l3.Add("caramel");

                int rand3 = r.RandNumber(1, l3.Count);
                var value3 = l3[rand3];
                skin = value3.ToString();

                colors = " has " + hair + " hair, " + eyes + " eyes, and " + skin + " colored skin ";
                return colors;
            }
            else
            {//dark
                string colors;
                string hair;
                List<string> l = new List<string>();
                l.Add("brown");
                l.Add("black");
                l.Add("dark brown");
                l.Add("natural black");
                l.Add("deep brunette");
                l.Add("black");
                l.Add("blue-black");
                l.Add("black");
                l.Add("dark grey");
                l.Add("deep brown");

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                hair = value.ToString();


                string eyes;
                List<string> l2 = new List<string>();
                l2.Add("brown");
                l2.Add("dark blue");
                l2.Add("dark grey");
                l2.Add("deep violet");
                l2.Add("deep blue");
                l2.Add("black");
                l2.Add("dark green");

                int rand2 = r.RandNumber(1, l2.Count);
                var value2 = l2[rand2];
                eyes = value2.ToString();

                string skin;
                List<string> l3 = new List<string>();
                l3.Add("dark brown");
                l3.Add("deep olive");
                l3.Add("very dark brown");
                l3.Add("black");
                l3.Add("dark brown");
                l3.Add("very dark brown");
                l3.Add("black");

                int rand3 = r.RandNumber(1, l3.Count);
                var value3 = l3[rand3];
                skin = value3.ToString();
                
                colors = " has " + hair + " hair, " + eyes + " eyes, and " + skin+" colored skin ";
                return colors;
            }
            
        }


        public string NpcStory()
        {
            NameGen ng = new NameGen();
            Dressing d = new Dressing();

            string story, gdr, gdr2, heshe, heshe2;
            string town = ng.GenCity();
            string bar = ng.GenInn();
            string color = d.GeneralColor();
            string job= NpcJobs();
            string food = d.Food();
            string item = d.Belonging().Replace("a ", "").Replace("an ", "");
            string clothes = d.Clothing();
            string spice = d.Spice();


            Randomizer r = new Randomizer();
            int r1 = r.RandNumber(1, 10);
            if (_gender == "Male") { gdr = "his"; gdr2 = "His"; heshe = "he"; heshe2="He";}
            else { gdr = "her"; gdr2 = "Her"; heshe = "she"; heshe2 = "She"; }



            if (r1 ==1)
            {
                story = heshe2+" comes from a the nearby town of "+town+" where "+gdr+" father is a "+job+". "+
                    heshe2+" has been known to frequent the "+ bar+" where "+heshe+ " always orders "+food+". ";
            }
            else if (r1 == 2)
            {
                story = heshe2 + " comes from a wealthy merchant family in the neighboring kingdom of " + town + ". " +
                    gdr2 + " family imports " + spice + " from foreign allies and sells it at a profit.";
            }
            else if (r1 == 3)
            {
                story = heshe2 + " grew up as the proprietor's child at the " + bar + " and was mistreated frequently.  The only thing " +
                    heshe + " was given to eat was " + food + ".  " + heshe2 + " was forced to sell " + gdr + " only spare item of clothing, " + clothes + 
                    ", in order to get the coin to run away.";                    
            }
            else if (r1 == 4)
            {
                story = heshe2 + " grew up on the streets stealing " + item + "s from passersby and living off of rat meat. " +
                    "Since coming into a small bit of wealth " + heshe + " has taken a liking to " + food + " and will order it with every meal.";
            }
            else if (r1 == 5)
            {
                story = heshe2 + " previously worked as a " + job + " but was never very good at it. " + heshe2 + " has a odd habit of always wearing a " + 
                    color + " " + clothes + " when " + heshe + " visits the " + bar + " which is " + gdr + " favorite hangout.";
            }
            else if (r1 == 6)
            {
                story = heshe2 +" is rumored to be from the land of "+town+" but this is unconfirmed due to the enemy status of that kingdom. "+
                    "It is said "+heshe+" often poses as a "+job+" while actually gathering information to report back." +heshe2 +" has been seen "+
                    "carrying documents written in "+color+" ink.";
            }
            else if (r1 == 7)
            {
                story = gdr2 + " favorite past-time is collecting "+item+"s and "+heshe+" will usually pay handsomly for a finely crafted one.";
            }
            else if (r1 == 8)
            {
                story = heshe2+" believes that Enok will lead him to great wealth, but only if he proves "+gdr+" devotion by always wearing a "
                    + color + " " + clothes+". "+heshe2+" also believes that "+heshe+" will someday meet Enok in the city of "+town+".";
            }
            else if (r1 == 9)
            {
                story = "When " +heshe+ " was a child, "+heshe+" lost "+gdr+" pet goat to a wolf and has hated wolves ever since. "+ gdr2 +
                    " father was a busy " + job + " and never found out how disturbed " + heshe + " was.  "+heshe2 + " has hated wild animals since.";
            }
            else
            {
                story = heshe2 + " is a mysterious figure and not much is known about " + gdr + " aside from the fact that" + heshe +
                    " has recently been frequenting the " + bar+ " and associating with "+job+"s.";
            }

            return story;
        }


        public string NpcJobs()
        {
            Randomizer r = new Randomizer();
            string job;

            List<string> l = new List<string>();
            l.Add("farmer");
            l.Add("fisherman");
            l.Add("sailor");
            l.Add("farmhand");
            l.Add("forester");
            l.Add("hunter");
            l.Add("trapper");
            l.Add("town laborer");
            l.Add("shop worker");
            l.Add("armourer");
            l.Add("smith");
            l.Add("master armourer");
            l.Add("merchant");
            l.Add("healer");
            l.Add("scholar");
            l.Add("teacher");
            l.Add("scribe");
            l.Add("sage");
            l.Add("priest");
            l.Add("high priest");
            l.Add("chemist");
            l.Add("builder");
            l.Add("animal trainer");
            l.Add("bird trainer");
            l.Add("minstrel");
            l.Add("entertainer");
            l.Add("translator");
            l.Add("mathematician");
            l.Add("calligrapher");
            l.Add("petty thief");
            l.Add("burglar");
            l.Add("professional thief");
            l.Add("highwayman");
            l.Add("brigand");
            l.Add("mercenary recruit");
            l.Add("mercenary veteran");
            l.Add("mercenary captain");
            l.Add("army recruit");
            l.Add("watch recruit");
            l.Add("army regular");
            l.Add("watch regular");
            l.Add("army sergeant");
            l.Add("watch sergeant");
            l.Add("army officer");
            l.Add("watch officer");
            l.Add("army auxilary");
            l.Add("watch auxilary");
            l.Add("courier");
            l.Add("spy");
            l.Add("tax collector");
            l.Add("fighting-ship crewman");
            l.Add("rogue");
            l.Add("armsmaster");
            l.Add("wizard apprentice");
            l.Add("wizard journeyman");
            l.Add("town wizard");
            l.Add("town wizard extraordinaire");
            l.Add("wizardly thief");
            l.Add("wizardly brigand");
            l.Add("illusionist");
            l.Add("magician");
            l.Add("beekeeper");
            l.Add("butcher");
            l.Add("carpenter");
            l.Add("draper");
            l.Add("tanner");
            l.Add("innkeeper");
            l.Add("baker");
            l.Add("brewer");
            l.Add("cook");
            l.Add("gardener");
            l.Add("joiner");
            l.Add("leatherworker");
            l.Add("potter");
            l.Add("sculptor");
            l.Add("vintner");
            l.Add("wood-carver");
            l.Add("calligrapher");
            l.Add("artist");

            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            job = value.ToString();

            return job;
        }
        

    }//end class
}//end namespace
