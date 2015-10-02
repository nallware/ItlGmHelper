using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItlGmHelper
{
    class RoomChamber
    {
        public string Chamber() //chamber or cavern
        {
            Randomizer r = new Randomizer();
            Encounter e = new Encounter();
            Dressing d = new Dressing();
            string _rm;
            int check = r.RandNumber(1, 22);
            if (check < 18)
            {
                //stoneworked chamber
                _rm = "The room you've found is a stoneworked chamber. It is " + ChamberSize() + NumberOfExits() + d.RoomDress() + RoomContents();


                return _rm;
            }
            else if (check < 22)
            {
                //natural cavern
                _rm = "The room you've found is a natural cavern. It is " + CavernSize() + NumberOfExits() + d.RoomDress() + RoomContents();
                return _rm;
            }
            else
            {
                //special room
                _rm = "The room you've found is " + SpecialRoom() + NumberOfExits() + d.RoomDress() + RoomContents();
                return _rm;
            }

        }


        public string ChamberSize()
        {
            string _room;
            List<string> l = new List<string>();
            l.Add("10 x 10 ft. ");
            l.Add("20 x 20 ft. ");
            l.Add("20 x 20 ft. ");
            l.Add("20 x 20 ft. ");
            l.Add("30 x 30 ft. ");
            l.Add("30 x 30 ft. ");
            l.Add("30 x 30 ft. ");
            l.Add("40 x 40 ft. ");
            l.Add("40 x 40 ft. ");
            l.Add("40 x 40 ft. ");
            l.Add("10 x 20 ft. ");
            l.Add("20 x 30 ft. ");
            l.Add("20 x 30 ft. ");
            l.Add("20 x 40 ft. ");
            l.Add("20 x 40 ft. ");
            l.Add("30 x 40 ft. ");
            l.Add("30 x 40 ft. ");
            l.Add("30 x 40 ft. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _room = value.ToString();
            return _room;
        }

        public string CavernSize()
        {
            string _cave;
            List<string> l = new List<string>();

            l.Add(" 10 x 20 ft. ");
            l.Add(" 20 x 20 ft. ");
            l.Add(" 20 x 20 ft. ");
            l.Add(" 30 x 30 ft. ");
            l.Add(" 30 x 30 ft. ");
            l.Add(" 40 x 40 ft. ");
            l.Add(" 40 x 40 ft. ");
            l.Add(" 20 x 30 ft. ");
            l.Add(" 20 x 30 ft. ");
            l.Add(" 20 x 40 ft. ");
            l.Add(" 20 x 40 ft. ");
            l.Add(" 20 x 40 ft. ");
            l.Add(" 40 x 50 ft. ");
            l.Add(" 40 x 50 ft. ");
            l.Add(" 40 x 60 ft. ");
            l.Add(" 40 x 60 ft. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _cave = value.ToString();
            return _cave;
        }



        public string SpecialRoom()
        {
            string _special;
            List<string> l = new List<string>();

            l.Add("a " + CaveSize());
            l.Add("circular " + SpecialRoomSize());
            l.Add("circular " + SpecialRoomSize());
            l.Add("circular " + SpecialRoomSize());
            l.Add("circular " + SpecialRoomSize());
            l.Add("circular " + SpecialRoomSize());
            l.Add("hexagonal " + SpecialRoomSize());
            l.Add("hexagonal " + SpecialRoomSize());
            l.Add("octagonal " + SpecialRoomSize());
            l.Add("octagonal " + SpecialRoomSize());
            l.Add("oval " + SpecialRoomSize());
            l.Add("oval " + SpecialRoomSize());
            l.Add("oddly shaped " + SpecialRoomSize());
            l.Add("oddly shaped " + SpecialRoomSize());
            l.Add("trapezoidal " + SpecialRoomSize());
            l.Add("trapezoidal " + SpecialRoomSize());
            l.Add("trapezoidal " + SpecialRoomSize());
            l.Add("triangular " + SpecialRoomSize());
            l.Add("triangular " + SpecialRoomSize());
            l.Add("triangular " + SpecialRoomSize());

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _special = value.ToString();
            return _special;
        }


        public string CaveSize()
        {
            string _cave;
            List<string> l = new List<string>();

            l.Add("40x60 ft. cave ");
            l.Add("40x60 ft. cave ");
            l.Add("40x60 ft. cave ");
            l.Add("40x60 ft. cave ");
            l.Add("40x60 ft. cave ");
            l.Add("50x75 ft. cave ");
            l.Add("50x75 ft. cave ");
            l.Add("30x30 ft and 60x60 ft. double cave ");
            l.Add("30x30 ft and 60x60 ft. double cave ");
            l.Add("30x50 ft and 80x100 ft. double cave ");
            l.Add("30x50 ft and 80x100 ft. double cave ");
            l.Add("100x125 ft. cave ");
            l.Add("100x125 ft. cave ");
            l.Add("100x125 ft. cave ");
            l.Add("125x150 ft. cave ");
            l.Add("125x150 ft. cave ");
            l.Add("150x200 ft. cave ");
            l.Add("150x200 ft. cave ");
            l.Add("300x400 ft. cave ");
            l.Add("300x400 ft. cave ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _cave = value.ToString();
            return _cave;
        }


        public string Pool()
        {
            Encounter e = new Encounter();
            string _pool;
            List<string> l = new List<string>();

            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add(". ");
            l.Add("that contains a pool. ");
            l.Add("that contains a pool. ");
            l.Add("that contains a pool with an encounter . ");
            l.Add("that contains a pool with an encounter . ");
            l.Add("that contains a pool with an encounter and a treasure. ");
            l.Add("that contains a pool with an encounter and a treasure. ");
            l.Add("that contains a pool with an encounter and a treasure. ");
            l.Add("that contains a magic pool that " + MagicPool());

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _pool = value.ToString();
            return _pool;
        }



        public string SpecialRoomSize()
        {
            Randomizer r = new Randomizer();
            int dist = r.RandNumber(3, 15);

            string _size;
            List<string> l = new List<string>();

            l.Add("and is " + (dist + 1 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 1 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 1 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 2 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 2 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 2 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 5 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 5 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 6 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 6 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 4 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 4 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 3 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 3 * 10) + " ft. across. ");
            l.Add("and is " + (dist + 3 * 10) + " ft. across. ");

            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _size = value.ToString();
            return _size;
        }


        public string MagicPool()
        {
            string _mpool;
            List<string> l = new List<string>();

            l.Add("turns gold pieces into platinum pieces one time. ");
            l.Add("turns gold pieces into platinum pieces one time. ");
            l.Add("turns gold pieces into platinum pieces one time. ");
            l.Add("turns gold pieces into platinum pieces one time. ");
            l.Add("turns gold pieces into lead one time. ");
            l.Add("turns gold pieces into lead one time. ");
            l.Add("turns gold pieces into lead one time. ");
            l.Add("turns gold pieces into lead one time. ");
            l.Add("causes all characters to lose 1ST. Only one time/character checked separately. ");
            l.Add("causes all characters to gain 1ST. Only one time/character checked separately. ");
            l.Add("causes all characters to lose 1DX. Only one time/character checked separately. ");
            l.Add("causes all characters to gain 1DX. Only one time/character checked separately. ");
            l.Add("causes all characters to lose 1IQ. Only one time/character checked separately. ");
            l.Add("causes all characters to gain 1IQ. Only one time/character checked separately. ");
            l.Add("speaks-grant 1 wish to any evil characters and damage all others. ");
            l.Add("speaks-grant 1 wish to any good characters and damage all others. ");
            l.Add("magically teleports.  It will teleports characters many miles away. ");
            l.Add("magically teleports.  It will teleports characters back to the surface. ");
            l.Add("magically teleports.  It will teleports characters elsewhere on this level. ");
            l.Add("magically teleports.  It will teleports characters one level down. ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _mpool = value.ToString();
            return _mpool;
        }

        public string NumberOfExits() //Table 5 ==> Proceed to table 6
        {
            string _exits;
            List<string> l = new List<string>();

            l.Add("The room has an exit located on the " + ExitLocation() + " ");
            l.Add("The room has exits located on the " + ExitLocation() + " and " + ExitLocation() + " ");
            l.Add("The room has exits located on the " + ExitLocation() + ", " + ExitLocation() + " and " + ExitLocation() + " ");
            l.Add("The room has exits located on the opposite wall, " + ExitLocation() + ", " + ExitLocation() + " and " + ExitLocation() + " ");
            l.Add("The room has exits located on the " + ExitLocation() + " and " + ExitLocation() + " ");
            l.Add("The room has an exit located on the " + ExitLocation() + " ");
            l.Add("The room has no exits ");
            l.Add("The room has no exits ");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _exits = value.ToString();
            return _exits;
        }

        public string ExitLocation() //Table 6 ==> if passage goto table 7, if door goto table 20
        {
            string _location;
            List<string> l = new List<string>();

            l.Add("left wall");
            l.Add("opposite wall");
            l.Add("right wall");
            l.Add("left wall");
            l.Add("opposite wall");
            l.Add("right wall");
            l.Add("same wall");

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _location = value.ToString();
            return _location;
        }


        public string RoomContents()  //Table 8 Chamber or Room Contents  ==> goto table 9
        {
            Passage p = new Passage();
            Treasure t = new Treasure();
            Encounter e = new Encounter();
            string _cont;
            List<string> l = new List<string>();

            l.Add("The room is mostly empty. ");//needs dressing
            l.Add("The room is mostly empty. ");
            l.Add("The room is mostly empty. ");
            l.Add("The room is mostly empty. ");
            l.Add("The room is mostly empty. ");
            l.Add("The room is mostly empty. ");
            l.Add("The room is mostly empty. ");
            l.Add("The room contains an encounter. ");
            l.Add("The room contains an encounter. ");
            l.Add("The room contains an encounter. ");
            l.Add("The room contains an encounter. ");
            l.Add("The room contains an encounter and treasure. ");
            l.Add("The room contains an encounter and treasure. ");
            l.Add("The room contains an encounter and treasure. ");
            l.Add("The room contains an encounter and treasure. ");
            l.Add("The room contains an encounter and treasure. ");
            l.Add("The room contains an encounter and treasure. "); 
            l.Add("The room contains " + p.Stairs());
            l.Add("The room contains a trap. " + t.Trap());
            l.Add("The room contains only treasure. "); ////////////////////  TREASURE!!!!

            Randomizer r = new Randomizer();
            int rand = r.RandNumber(1, l.Count);
            var value = l[rand];
            _cont = value.ToString();
            return _cont;
        }

    }
}
