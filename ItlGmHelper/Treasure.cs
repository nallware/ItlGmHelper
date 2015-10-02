using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItlGmHelper
{
    class Treasure
    {

        public string TreasureRoll()
        {
            string tre;
            tre = TreasureAmount() + TreasureContainer() + TreasureHide() + TreasureWards();
            return tre;
        }



        public string TreasureContainer() //Table 9  ==> goto table 12
        { //if container, optional ==> goto table 10 and/or 11
            string _tcont;
            List<string> l = new List<string>();

            l.Add("Treasure container: bags.");
            l.Add("Treasure container: sacks.");
            l.Add("Treasure container: coffers.");
            l.Add("Treasure container: chests.");
            l.Add("Treasure container: large chests.");
            l.Add("Treasure container: pottery jars.");
            l.Add("Treasure container: metal urns.");
            l.Add("Treasure container: stone containers.");
            l.Add("Treasure container: iron trunks.");
            l.Add("Treasure is loose.");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _tcont = value.ToString();
            return _tcont;
        }


        public string TreasureWards() //table 10
        {
            string _wards;
            List<string> l = new List<string>();

            l.Add("Treasure warded by: a blade scything across inside. ");
            l.Add("Treasure warded by: a blade scything across inside. ");
            l.Add("Treasure warded by: contact poison on container. ");
            l.Add("Treasure warded by: contact poison on container. ");
            l.Add("Treasure warded by: contact poison on treasure. ");
            l.Add("Treasure warded by: contact poison on treasure. ");
            l.Add("Treasure warded by: gas released by opening container. ");
            l.Add("Treasure warded by: a grenade. ");
            l.Add("Treasure warded by: poisoned needles in lock. ");
            l.Add("Treasure warded by: poisoned needles in lock. ");
            l.Add("Treasure warded by: poisoned needles in handles. ");
            l.Add("Treasure warded by: a poisonous insect or reptile living inside container. ");
            l.Add("Treasure warded by: spears released from walls when container opened. ");
            l.Add("Treasure warded by: spring darts firing from front of container. ");
            l.Add("Treasure warded by: spring darts firing from top of container. ");
            l.Add("Treasure warded by: spring darts firing up from inside bottom of container. ");
            l.Add("Treasure warded by: a stone block dropping in front of container. ");
            l.Add("Treasure warded by: a petard. ");
            l.Add("Treasure warded by: a trapdoor opening in front of container. ");
            l.Add("Treasure warded by: a trapdoor opening 6 ft in front of container. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _wards = value.ToString();
            return _wards;
        }



        public string TreasureHide()  //table 11
        {
            string _hide;
            List<string> l = new List<string>();

            l.Add("Treasure hidden behind a loose wall stone. ");
            l.Add("Treasure hidden behind a loose wall stone. ");
            l.Add("Treasure hidden by an Illusion to change the appearance or hide it. ");
            l.Add("Treasure hidden by an Illusion to change the appearance or hide it. ");
            l.Add("Treasure hidden by an Invisibility spell. ");
            l.Add("Treasure hidden by an Invisibility spell. ");
            l.Add("Treasure hidden by an Invisibility spell. ");
            l.Add("Treasure hidden in a nearby secret room. ");
            l.Add("Treasure hidden in a nearby secret room. ");
            l.Add("Treasure hidden in a nearby secret room. ");
            l.Add("Treasure hidden in a nearby secret room. ");
            l.Add("Treasure contained in an ordinary container in plain view. ");
            l.Add("Treasure inside or under trash or dung heap. ");
            l.Add("Treasure hidden by a non-magical disguise. ");
            l.Add("Treasure in a secret space under container. ");
            l.Add("Treasure in a secret compartment in container. ");
            l.Add("Treasure in a secret compartment in container. ");
            l.Add("Treasure under a loose flooring stone. ");
            l.Add("Treasure under a loose flooring stone. ");
            l.Add("Treasure under a loose flooring stone. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _hide = value.ToString();
            return _hide;
        }



        public string TreasureAmount()  //table 12
        {
            string _amt;
            Randomizer r = new Randomizer();
            List<string> l = new List<string>();
            //guarded by monster == x2, multiples for difficulty
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 16) * 100 + "ep. ");
            l.Add("The treasure contains " + r.RandNumber(2, 16) * 100 + "ep. ");
            l.Add("The treasure contains " + r.RandNumber(2, 16) * 100 + "ep. ");
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. ");
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. ");
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 10 + "pp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 10 + "pp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "cp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 100 + "sp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 16) * 100 + "ep. ");
            l.Add("The treasure contains " + r.RandNumber(2, 16) * 100 + "ep. ");
            l.Add("The treasure contains " + r.RandNumber(2, 16) * 100 + "ep. ");
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. ");
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. ");
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 10 + "pp. ");
            l.Add("The treasure contains " + r.RandNumber(2, 20) * 10 + "pp. ");
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. "+Gem()+".");//gem
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Gem() + ".");//gem
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Gem() + ".");//gem
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Gem() + ".");//gem
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Potion() + ".");//potion
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Potion() + ".");//potion
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Potion() + ".");//potion
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + LesserMagic() + ".");//lesser
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + LesserMagic() + ".");//lesser            
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Gem()+" "+Potion()+".");//gem and potion
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Gem() + " " + LesserMagic() + ".");//gem and lesser
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Potion() + " " + LesserMagic() + ".");//potion and lesser
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Gem() + " " + Gem() + ".");//2 gems
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + LesserMagic() + " " + LesserMagic() + ".");//2 lesser
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + Potion() + " " + Potion() + ".");//potionX2
            l.Add("The treasure contains " + r.RandNumber(1, 4) * 100 + "gp. " + GreaterMagic() + ".");//greater

            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _amt = value.ToString();
            return _amt;
        }


        public string Gem()
        {
            string gem;
            Randomizer r = new Randomizer();
            Form1 f1 = new Form1();
            List<string> l = new List<string>();
            l.Add("and a " + f1.gem1 + " worth " + f1.gem1val);
            l.Add("and a " + f1.gem2 + " worth " + f1.gem2val);
            l.Add("and a " + f1.gem3 + " worth " + f1.gem3val);
            l.Add("and a " + f1.gem4 + " worth " + f1.gem4val);
            l.Add("and a " + f1.gem5 + " worth " + f1.gem5val);
            l.Add("and a " + f1.gem6 + " worth " + f1.gem6val);

            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            gem = value.ToString();
            return gem;
        }
                    

        public string Potion()
        {
            string gem;
            Randomizer r = new Randomizer();
            Form1 f1 = new Form1();
            List<string> l = new List<string>();
            l.Add("and (" + f1.potion1val + ") "+ f1.potion1);
            l.Add("and (" + f1.potion2val + ") " + f1.potion2);
            l.Add("and (" + f1.potion3val + ") " + f1.potion3);
            l.Add("and (" + f1.potion4val + ") " + f1.potion4);
            l.Add("and (" + f1.potion5val + ") " + f1.potion5);
            l.Add("and (" + f1.potion6val + ") " + f1.potion6);
            
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            gem = value.ToString();
            return gem;
        }
        

        public string LesserMagic()
        {
            string lesser;
            Randomizer r = new Randomizer();
            Form1 f1 = new Form1();
            List<string> l = new List<string>();
            l.Add("and (" + f1.lesser1val + ") " + f1.lesser1);
            l.Add("and (" + f1.lesser2val + ") " + f1.lesser2);
            l.Add("and (" + f1.lesser3val + ") " + f1.lesser3);
            l.Add("and (" + f1.lesser4val + ") " + f1.lesser4);
            l.Add("and (" + f1.lesser5val + ") " + f1.lesser5);
            l.Add("and (" + f1.lesser6val + ") " + f1.lesser6);

            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            lesser = value.ToString();
            return lesser;
        }

        public string GreaterMagic()
        {
            string greater;
            Randomizer r = new Randomizer();
            Form1 f1 = new Form1();
            List<string> l = new List<string>();
            l.Add("and (" + f1.greater1val + ") " + f1.greater1 + ".");
            l.Add("and (" + f1.greater2val + ") " + f1.greater2 + ".");
            l.Add("and (" + f1.greater3val + ") " + f1.greater3 + ".");
            l.Add("and (" + f1.greater4val + ") " + f1.greater4 + ".");
            l.Add("and (" + f1.greater5val + ") " + f1.greater5 + ".");
            l.Add("and (" + f1.greater6val + ") " + f1.greater6 + ".");

            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            greater = value.ToString();
            return greater;
        }



        public string Trap()
        {
            Randomizer r = new Randomizer();
            int die1 = r.RandNumber(1, 6);
            int die2 = r.RandNumber(1, 6) + r.RandNumber(1, 6);
            int die3 = r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6);
            int die4 = r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6);
            int die5 = r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6);
            int die6 = r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6) + r.RandNumber(1, 6);

            string _trap;
            List<string> l = new List<string>();

            l.Add("The trap is acid spray which deals " + die2 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a crossbow bolt which deals " + die3 + " damage to those failing a save of ." + DxRoll() + ". ");
            l.Add("The trap involves a collapsing bridge.  The fall causes " + die3 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap involves an illusory bridge.  The fall causes " + die4 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap causes heavy caltrops to drop from ceiling dealing " + die1 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap involves a ceiling block which drops behind characters.  This does no harm, but those failing a DX roll of " + DxRoll() + " are trapped. ");
            l.Add("The trap involves a ceiling block which drops in front of and behind players. This does no harm, but those failing a DX roll of " + DxRoll() + " are trapped. ");
            l.Add("The trap involves a ceiling block which drops in front of characters.  This does no harm, but those failing a DX roll of " + DxRoll() + " are trapped. ");
            l.Add("The trap is a ceiling block which drops on the characters dealing " + die4 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a ceiling block that seals characters failing a save of " + DxRoll() + " in room or area");
            l.Add("The trap is an elevator room" + Elevator() + ". ");
            l.Add("The trap is an elevator " + Elevator() + " then deactivates for " + die1 + " hours. ");
            l.Add("The trap is a one-way elevator room " + Elevator());
            l.Add("The trap is a falling door that does " + die2 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a set of flame jets that does " + die4 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a flooding room that kills characters failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a blinding gas that leaves any character failing a save of " + DxRoll() + " blind for " + die2 + " turns. ");
            l.Add("The trap is fear gas that leaves any character failing a save of " + DxRoll() + " afraid and unable to fight for " + die2 + " turns. ");
            l.Add("The trap is a flammable gas that ignites and does " + die3 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a sleep gas that leaves any character failing a save of " + DxRoll() + " asleep for " + die2 + " turns. ");
            l.Add("The trap is a lethargy gas.  Any character failing a save of " + DxRoll() + " has their MA reduced by half for " + die4 + " turns. ");
            l.Add("The trap is a greased chute " + Elevator() + " and does " + die2 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a magical lightning bolt that does " + die4 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a swinging log that does " + die4 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is an obscuring fog which lasts for " + die2 + " turns. ");
            l.Add("The trap consists of an oil filled pit with dropping lit torch that does " + die5 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a pit triggered by false door that does " + die1 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a pit with dropping ceiling block that does " + die6 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a pit with locking trap door that does " + die2 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a 10 ft pit that does " + die1 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a poisoned bolt-crossbow that does " + die5 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap consists of poisoned caltrops that do " + die3 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a poisoned ballista that does " + die5 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a poisoned spike pit that does " + die3 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a portcullis that drops behind the characters. ");
            l.Add("The trap consists of portcullises which drop in front of and behind characters, trapping them. ");
            l.Add("The trap is a portcullis which drops in front of players. ");
            l.Add("The trap consists of a rolling stone ball which is the height and width of the corridor that does " + die6 + " crushing damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a scything ankle high that does " + die3 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a scything neck high that does " + die4 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap consists of a sliding room that changes facing or location. ");
            l.Add("The trap is a ballista that does " + die4 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a swinging spiked log that does " + die5 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a spiked pit that does " + die2 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap is a spring-loaded piledriver disguised as a door that does " + die5 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap consists of stairs which descend one level and fold flat into a sliding chute and do " + die1 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap consists of collapsing stairs which descend one level and do " + die1 + " damage to those failing a save of " + DxRoll() + ". ");
            l.Add("The trap consists of a magic teleporter that teleports one character to a random room on the same level. ");
            l.Add("The trap is a trip wire which trips the first character failing a save of " + DxRoll() + ". ");
            l.Add("wire-neck high that does " + die2 + " damage to those failing a save of " + DxRoll() + ". ");


            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _trap = value.ToString();
            return _trap;

        }


        public string DxRoll()
        {
            Passage p = new Passage();
            string _roll;
            List<string> l = new List<string>();

            l.Add("3 dice vs. DX.");
            l.Add("3 dice vs. DX.");
            l.Add("3 dice vs. DX.");
            l.Add("3 dice vs. DX.");
            l.Add("3 dice vs. DX.");
            l.Add("3 dice vs. DX.");
            l.Add("3 dice vs. DX.");
            l.Add("3 dice vs. DX.");
            l.Add("4 dice vs. DX.");
            l.Add("4 dice vs. DX.");
            l.Add("4 dice vs. DX.");
            l.Add("5 dice vs. DX.");
            l.Add("5 dice vs. DX.");
            l.Add("6 dice vs. DX.");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _roll = value.ToString();
            return _roll;
        }

        public string Elevator()
        {
            string _el;
            List<string> l = new List<string>();

            l.Add("that descend 1 level. ");
            l.Add("that descend 1 level. ");
            l.Add("that descend 1 level. ");
            l.Add("that descend 1 level. ");
            l.Add("that descend 1 level. ");
            l.Add("that descends 2 levels. ");
            l.Add("that descends 3 levels. ");
            l.Add("that ascend 1 level. ");
            l.Add("that ascend 1 level. ");
            l.Add("that descend 1 level. ");
            l.Add("that descend 1 level. ");
            l.Add("that descend 1 level. ");
            l.Add("that rises up 1 level. ");
            l.Add("that rises up 2 levels. ");
            l.Add("that drops down 2 levels. ");
            l.Add("that drops down 1 level. ");
            l.Add("that drops down 1 level. ");
            l.Add("that drops down 2 levels. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _el = value.ToString();
            return _el;
        }



        public string PersTreasure(string level)
        {
            int x;
            if (level == "Low") { x = 1; }
            else if (level == "Medium") { x = 2; }
            else { x = 5; }


            Randomizer r = new Randomizer();
            int d1 = r.RandNumber(1, 6)*x;
            int d2 = r.RandNumber(1, 10)*x;
            int d3 = r.RandNumber(1, 20)*x;
            int d4 = r.RandNumber(1, 100)*x;

            string copper = Convert.ToString(d4) + " copper coins";
            string silver = Convert.ToString(d3) + " silver coins";
            string gold = Convert.ToString(d2) + " gold coins";
            string platinum = Convert.ToString(d1) + " platinum coins";


            if (level == "Low")
            {

                string _roll;
                List<string> l = new List<string>();

                l.Add(copper);
                l.Add(copper);
                l.Add(copper);
                l.Add(copper+" and "+silver);
                l.Add(copper + " and " + silver);
                l.Add(copper + " and " + silver);
                l.Add(copper + " and " + silver);
                l.Add(copper + ", " + silver+" and " +gold);
                l.Add(copper + ", " + silver + " and " + gold);
                l.Add(copper + ", " + silver + " and " + gold);
                l.Add(copper + ", " + silver + ", " + gold+" and "+Gem());
                l.Add(copper + ", " + silver + ", " + gold + " and " + Potion());
                l.Add(copper + ", " + silver + ", " + gold + " and " + LesserMagic());



                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                _roll = value.ToString();
                return _roll;
            }

            else if (level == "Medium")
            {

                string _roll;
                List<string> l = new List<string>();

                l.Add(silver);
                l.Add(silver);
                l.Add(silver);
                l.Add(silver);
                l.Add(silver + " and " + gold);
                l.Add(silver + " and " + gold);
                l.Add(silver + " and " + gold);
                l.Add(silver + ", " + gold+" and "+platinum);
                l.Add(gold + ", " + platinum + " and " + Gem());
                l.Add(gold + ", " + platinum + " and " + Potion());
                l.Add(gold + ", " + platinum + " and " + LesserMagic());


                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                _roll = value.ToString();
                return _roll;
            }

            else 
            {

                string _roll;
                List<string> l = new List<string>();


                l.Add(gold);
                l.Add(gold);
                l.Add(gold);
                l.Add(gold);
                l.Add(gold + " and " + platinum);
                l.Add(gold + " and " + platinum);
                l.Add(gold + " and " + gold);
                l.Add(gold + ", " + platinum + ", " + Gem()+" and "+Potion());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + Potion());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + Potion());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + Potion());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + LesserMagic());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + LesserMagic());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + LesserMagic());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + GreaterMagic());
                l.Add(gold + ", " + platinum + ", " + Gem() + " and " + GreaterMagic());
                l.Add(gold + ", " + platinum + ", " + Gem() + ", " + Potion() + ", "+LesserMagic()+" and "+ GreaterMagic());

                int rand = r.RandNumber(1, l.Count);
                var value = l[rand];
                _roll = value.ToString();
                return _roll;
            }



            
        }

    }
}
