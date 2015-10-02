using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItlGmHelper
{
    class Passage
    {

        public int numOfStraights;
        public int roomFreq, roomSpread;

        public void SetupRollMods(int freq, int leng)
        {
            roomFreq = freq;
            roomSpread = leng;

        }



        public string PassageChk()
        {
            if (numOfStraights < 3)
            {
                string _dir = "The passage " + AllHall();
                return _dir;
            }
            else
            {
                string _dir = "The passage " + NoStraight();
                return _dir;
            }
        }//end method Passage

        public string AllHall()
        {
            
            Encounter e = new Encounter();
            Randomizer r = new Randomizer();
            string _dir;
            

            //**************************************************************************************************************************************
            //***********************************          CONTROL DENSITY OF ROOMS HERE AND BELOW          ****************************************
            //**************************************************************************************************************************************
            int rand = r.RandNumber(1, 45 + roomFreq); //NOT WORKING

            if (rand < 14) { _dir = "continues straight for " + Feet() + " The passage is " + PassWidth(); } //1-13
            else if (rand < 15) { _dir = "comes to a T. The right continues for " + Feet() + " and the left continues for " + Feet() + " These passages are " + PassWidth(); }//14
            else if (rand < 16) { _dir = "comes to a 4-way intersection. The right continues for " + Feet() + ",  the left continues for " + Feet() + " and the hallway continues straight for " + Feet() + " These passages are " + PassWidth(); } //15
            else if (rand < 18) { _dir = "continues straight for " + Feet() + ". It also branches left and then continues for " + Feet() + " These passages are " + PassWidth(); } // 16-17
            else if (rand < 23) { _dir = "turns left and then continues for " + Feet() + " The passage is " + PassWidth(); } //18-22
            else if (rand < 25) { _dir = "continues straight for " + Feet() + ". It also branches right and then continues for " + Feet() + " These passages are " + PassWidth(); }//23-24
            else if (rand < 29) { _dir = "turns right and then continues for " + Feet() + " The passage is " + PassWidth(); }//25-28
            else if (rand < 38) { _dir = "ends at a room." + " The passage is " + PassWidth(); }//29-37
            else if (rand < 40) { _dir = "ends at a door." + " The passage is " + PassWidth() + AfterDoor(); }//38-39
            else if (rand < 42) { _dir = "reveals a wandering monster.  The passage is " + PassWidth(); }//40-41
            else if (rand < 43) { _dir = "reveals " + Stairs() + " The passage is " + PassWidth(); } //42
            else if (rand < 44) { _dir = "terminates at a dead end." + SecretDoor() + " The passage is " + PassWidth(); } //43
            else { _dir = "ends at a room." + " The passage is " + PassWidth(); } //44 and above            

            if (_dir.Contains("straight"))
            {
                numOfStraights++;
            }
            return _dir;

        }//end method AllHall


        public string NoStraight()
        {
            //roomFreq = 0;
            Encounter e = new Encounter();
            Randomizer r = new Randomizer();
            string _dir;           

            //**************************************************************************************************************************************
            //***********************************          CONTROL DENSITY OF ROOMS HERE AND ABOVE          ****************************************
            //**************************************************************************************************************************************
            int rand = r.RandNumber(1, 25 + roomFreq); //NOT WORKING

            if (rand < 9) { _dir = "turns left and then continues for " + Feet() + " The passage is " + PassWidth();} //1-8
            else if (rand < 17) {_dir = "ends at a room." + " The passage is " + PassWidth();} //9-16
            else if (rand < 20) { _dir = "ends at a door." + " The passage is " + PassWidth() + AfterDoor(); } //17-19
            else if (rand < 23) { _dir = "reveals " + e.Wandering() + ".  The passage is " + PassWidth(); } //20-22
            else if (rand < 24) { _dir = "terminates at a dead end." + SecretDoor() + " The passage is " + PassWidth();} //23
            else {_dir = "ends at a room." + " The passage is " + PassWidth();} //24 and >
            numOfStraights = 0;
            return _dir;

        }//end method NoStraight


        public string Feet()
        {
            //roomSpread = 0;
            Randomizer r = new Randomizer();            
            string _ft;
            
            //**************************************************************************************************************************************
            //***********************************    HERE IS WHERE YOU CAN ADJUST HOW SPREAD OUT THE MAP IS ****************************************
            //**************************************************************************************************************************************
            int ft = r.RandNumber(1, 5 + roomSpread) * 10;
            _ft = ft.ToString() + " ft.";
            return _ft;
        }



        public string SecretDoor()
        {
            Randomizer r = new Randomizer();
            int sdoor = r.RandNumber(1, 8);
            if (sdoor < 2)
            {
                return "There is a secret door located " + DoorLoc() + AfterDoor();
            }
            else return "";
        }


        public string DoorLoc() //Table 19
        {
            string _dloc;
            List<string> l = new List<string>();

            l.Add("to the left. ");
            l.Add("to the left. ");
            l.Add("to the left. ");
            l.Add("to the right. ");
            l.Add("to the right. ");
            l.Add("to the right. ");
            l.Add("straight ahead. ");
            l.Add("straight ahead. ");
            l.Add("straight ahead. ");
            l.Add("straight ahead. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _dloc = value.ToString();
            return _dloc;
        }



        public string AfterDoor()
        {
            string _beyond;
            List<string> l = new List<string>();

            l.Add("After the door you find another side door to the left, and one straight ahead. ");
            l.Add("After the door you find another side door to the left, and one straight ahead. ");
            l.Add("After the door you find another side door to the right, and one straight ahead. ");
            l.Add("After the door you find another side door to the right, and one straight ahead. ");
            l.Add("After the door the passage continues straight for " + Feet());
            l.Add("After the door the passage continues straight for " + Feet());
            l.Add("After the door the passage continues straight for " + Feet());
            l.Add("After the door the passage continues straight for " + Feet());
            l.Add("After the door the passage continues straight for " + Feet());
            l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");
            //l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");
            l.Add("After the door there is a room.");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _beyond = value.ToString();
            return _beyond;
        }

        public string Stairs()
        {
            string _stairs;
            List<string> l = new List<string>();

            l.Add("stairs that descend 1 level then the passage continues. ");
            l.Add("stairs that descend 1 level then the passage continues. ");
            l.Add("stairs that descend 1 level then the passage continues. ");
            l.Add("stairs that descend 1 level then the passage continues. ");
            l.Add("stairs that descend 1 level then the passage continues. ");
            l.Add("stairs that descends 2 levels then the passage continues. ");
            l.Add("stairs that descends 3 levels then the passage continues. ");
            l.Add("stairs that ascend 1 level then the passage continues. ");
            l.Add("stairs that ascend 1 level then the passage continues. ");
            l.Add("stairs that ascend to a dead end. ");
            l.Add("stairs that descend to a dead end. ");
            l.Add("stairs that descend 1 level into a room. ");
            l.Add("stairs that descend 1 level into a room. ");
            l.Add("stairs that descend 1 level into a room. ");
            l.Add("a chimney that rises up 1 level. The passage continues. ");
            l.Add("a chimney that rises up 2 levels. The passage continues. ");
            l.Add("a chimney that drops down 2 levels. The passage continues. ");
            l.Add("a trap door that drops down 1 level. The passage continues. ");
            l.Add("a trap door that drops down 1 level. The passage continues. ");
            l.Add("a trap door that drops down 2 levels. The passage continues. ");



            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _stairs = value.ToString();
            return _stairs;
        }


        public string PassWidth() //table 22 passage width
        {
            string _pwidth;
            List<string> l = new List<string>();

            l.Add("5 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("10 ft wide. ");
            l.Add("20 ft wide. ");
            l.Add("20 ft wide. ");
            l.Add("20 ft wide. ");
            l.Add("20 ft wide. ");
            l.Add("30 ft wide. ");
            l.Add(SpecialPassage());

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);

            var value = l[rand];
            _pwidth = value.ToString();
            return _pwidth;
        }

        public string SpecialPassage() //table 23
        {
            string _turn;
            List<string> l = new List<string>();

            l.Add("40 ft wide. ");
            l.Add("40 ft wide. ");
            l.Add("40 ft wide. ");
            l.Add("40 ft wide. ");
            l.Add("40 ft wide with a row of columns.");
            l.Add("40 ft wide with a row of columns.");
            l.Add("40 ft wide with a row of columns.");

            l.Add("50 ft wide. ");
            l.Add("50 ft wide. ");
            l.Add("50 ft wide. ");
            l.Add("50 ft wide with a row of columns.");
            l.Add("50 ft wide with a row of columns.");

            l.Add("50 ft wide with a stream with a bridge. ");
            l.Add("60 ft wide with a stream with a bridge. ");
            l.Add("70 ft wide with a stream with a bridge. ");
            l.Add("50 ft wide with a stream. ");

            l.Add("70 ft wide with a river and boat on your side. ");
            l.Add("80 ft wide with a river and boat on the other side. ");
            l.Add("90 ft wide with a river and boat on your side. ");
            l.Add("80 ft wide with a river. ");

            l.Add("60 ft wide with a huge chasm 100 ft deep. ");
            l.Add("60 ft wide with a huge chasm 100 ft deep with a rope bridge. ");
            l.Add("60 ft wide with a huge chasm 100 ft deep with a narrow spot. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);

            var value = l[rand];
            _turn = value.ToString();
            return _turn;
        }

    }
}
