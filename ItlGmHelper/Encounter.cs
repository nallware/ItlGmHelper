using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItlGmHelper
{
    class Encounter
    {
        Form1 f1 = new Form1();
        public int from, to;

        public string Monster()
        {
            string creature;
            Randomizer r = new Randomizer();
            int roll = r.RandNumber(1, 10);
            if (roll < 6) { creature = Easy(); }
            else if (roll < 8) { creature = Moderate(); }
            else if (roll < 10) { creature = Difficult(); }
            else { creature = Wandering(); }
            return creature; 
        }



        public string Easy()
        {
            Form1 f1 = new Form1();
            string easy, creature;
            List<string> l = new List<string>();

            l.Add(f1.easyCreature1);
            l.Add(f1.easyCreature2);
            l.Add(f1.easyCreature3);
            l.Add(f1.easyCreature4);
            l.Add(f1.easyCreature5);
            l.Add(f1.easyCreature6);
            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            creature = value.ToString();
            

            if (rand == 0){from = Convert.ToInt16(f1.easyFrom1); to = Convert.ToInt16(f1.easyTo1);}
            else if (rand == 1) { from = Convert.ToInt16(f1.easyFrom2); to = Convert.ToInt16(f1.easyTo2); }
            else if (rand == 2) { from = Convert.ToInt16(f1.easyFrom3); to = Convert.ToInt16(f1.easyTo3); }
            else if (rand == 3) { from = Convert.ToInt16(f1.easyFrom4); to = Convert.ToInt16(f1.easyTo4); }
            else if (rand == 4) { from = Convert.ToInt16(f1.easyFrom5); to = Convert.ToInt16(f1.easyTo5); }
            else if (rand == 5) { from = Convert.ToInt16(f1.easyFrom6); to = Convert.ToInt16(f1.easyTo6); }
            string num = r.RandNumber(from, to).ToString();
            easy = creature+"("+num+")";
            return easy;
        }



        public string Moderate()
        {
            Form1 f1 = new Form1();
            string mod, creature;
            List<string> l = new List<string>();

            l.Add(f1.modCreature1);
            l.Add(f1.modCreature2);
            l.Add(f1.modCreature3);
            l.Add(f1.modCreature4);
            l.Add(f1.modCreature5);
            l.Add(f1.modCreature6);
            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            creature = value.ToString();


            if (rand == 0) { from = Convert.ToInt16(f1.modFrom1); to = Convert.ToInt16(f1.modTo1); }
            else if (rand == 1) { from = Convert.ToInt16(f1.modFrom2); to = Convert.ToInt16(f1.modTo2); }
            else if (rand == 2) { from = Convert.ToInt16(f1.modFrom3); to = Convert.ToInt16(f1.modTo3); }
            else if (rand == 3) { from = Convert.ToInt16(f1.modFrom4); to = Convert.ToInt16(f1.modTo4); }
            else if (rand == 4) { from = Convert.ToInt16(f1.modFrom5); to = Convert.ToInt16(f1.modTo5); }
            else if (rand == 5) { from = Convert.ToInt16(f1.modFrom6); to = Convert.ToInt16(f1.modTo6); }
            string num = r.RandNumber(from, to).ToString();
            mod = creature + "(" + num + ")";
            return mod;
        }

        public string Difficult()
        {
            Form1 f1 = new Form1();
            string dif, creature;
            List<string> l = new List<string>();

            l.Add(f1.difCreature1);
            l.Add(f1.difCreature2);
            l.Add(f1.difCreature3);
            l.Add(f1.difCreature4);
            l.Add(f1.difCreature5);
            l.Add(f1.difCreature6);
            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            creature = value.ToString();


            if (rand == 0) { from = Convert.ToInt16(f1.difFrom1); to = Convert.ToInt16(f1.difTo1); }
            else if (rand == 1) { from = Convert.ToInt16(f1.difFrom2); to = Convert.ToInt16(f1.difTo2); }
            else if (rand == 2) { from = Convert.ToInt16(f1.difFrom3); to = Convert.ToInt16(f1.difTo3); }
            else if (rand == 3) { from = Convert.ToInt16(f1.difFrom4); to = Convert.ToInt16(f1.difTo4); }
            else if (rand == 4) { from = Convert.ToInt16(f1.difFrom5); to = Convert.ToInt16(f1.difTo5); }
            else if (rand == 5) { from = Convert.ToInt16(f1.difFrom6); to = Convert.ToInt16(f1.difTo6); }
            string num = r.RandNumber(from, to).ToString();
            dif = creature + "(" + num + ")";
            return dif;
        }

        public string Wandering()
        {
            Form1 f1 = new Form1();
            string wan, creature;
            List<string> l = new List<string>();

            l.Add(f1.wanCreature1);
            l.Add(f1.wanCreature2);
            l.Add(f1.wanCreature3);
            l.Add(f1.wanCreature4);
            l.Add(f1.wanCreature5);
            l.Add(f1.wanCreature6);
            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            creature = value.ToString();


            if (rand == 0) { from = Convert.ToInt16(f1.wanFrom1); to = Convert.ToInt16(f1.wanTo1); }
            else if (rand == 1) { from = Convert.ToInt16(f1.wanFrom2); to = Convert.ToInt16(f1.wanTo2); }
            else if (rand == 2) { from = Convert.ToInt16(f1.wanFrom3); to = Convert.ToInt16(f1.wanTo3); }
            else if (rand == 3) { from = Convert.ToInt16(f1.wanFrom4); to = Convert.ToInt16(f1.wanTo4); }
            else if (rand == 4) { from = Convert.ToInt16(f1.wanFrom5); to = Convert.ToInt16(f1.wanTo5); }
            else if (rand == 5) { from = Convert.ToInt16(f1.wanFrom6); to = Convert.ToInt16(f1.wanTo6); }
            string num = r.RandNumber(from, to).ToString();
            wan = creature + "(" + num + ")";
            return wan;
        }


    }


    
    
    

}
