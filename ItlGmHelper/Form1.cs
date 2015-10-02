using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Xml;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.Diagnostics;

/*
 * I have been seeking a way to make this graphical and printable.  Until I learn how to do that, this may have to suffice.
 * The material lists for the generation classes have been taken from Old School Reference and Index Compilation (OSRIC) for the 
 * original AD&D Dungeon Master's guide index tables which I used extensively and was very happy to have rediscovered.
 * In it's final stage, I would like to have something similar to the excellent example located at:
 * http://www.myth-weavers.com/generate_dungeon.php‎ and then populated with my content.
 */


namespace ItlGmHelper
{   
    public partial class Form1 : Form
    {
        public string easyCreature1, easyFrom1, easyTo1, easyCreature2, easyFrom2, easyTo2, easyCreature3, easyFrom3, easyTo3, easyCreature4, easyFrom4, easyTo4, easyCreature5, easyFrom5, easyTo5, easyCreature6, easyFrom6, easyTo6;
        public string modCreature1, modFrom1, modTo1, modCreature2, modFrom2, modTo2, modCreature3, modFrom3, modTo3, modCreature4, modFrom4, modTo4, modCreature5, modFrom5, modTo5, modCreature6, modFrom6, modTo6;
        public string difCreature1, difFrom1, difTo1, difCreature2, difFrom2, difTo2, difCreature3, difFrom3, difTo3, difCreature4, difFrom4, difTo4, difCreature5, difFrom5, difTo5, difCreature6, difFrom6, difTo6;
        public string wanCreature1, wanFrom1, wanTo1, wanCreature2, wanFrom2, wanTo2, wanCreature3, wanFrom3, wanTo3, wanCreature4, wanFrom4, wanTo4, wanCreature5, wanFrom5, wanTo5, wanCreature6, wanFrom6, wanTo6;
        public string gem1, gem1val, gem2, gem2val, gem3, gem3val, gem4, gem4val, gem5, gem5val, gem6, gem6val;
        public string potion1, potion1val, potion2, potion2val, potion3, potion3val, potion4, potion4val, potion5, potion5val, potion6, potion6val;
        public string lesser1, lesser1val, lesser2, lesser2val, lesser3, lesser3val, lesser4, lesser4val, lesser5, lesser5val, lesser6, lesser6val;
        public string greater1, greater1val, greater2, greater2val, greater3, greater3val, greater4, greater4val, greater5, greater5val, greater6, greater6val;
        public string htypeer, result;
        public int totes;
        public int roomSpread, roomFreq;
        public string i1, i2, i3, i4, i5, i6, i7, i8, i9, i10;
        ObservableCollection<string> _opponentList = new ObservableCollection<string>();
        public string _filename;// = @"C:\ITL\FloraFauna.xml";
        public string _base;
        NameGen nm = new NameGen();
        public int points;
        
        public Form1()
        {
            InitializeComponent();

            try
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey("SOFTWARE\\NallWare\\ITL\\ItlGmHelper");
                htypeer = (string)reg.GetValue("CreatureE1", 0);
            }
            catch
            {
            }
        

            if (htypeer == "" || htypeer == null)
            {
                SetInitial();
            }
            else
            {
            LoadAll();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:/ITL");
            if (!dir.Exists)
            {
                dir.Create();
            }

            if (rbHumanoid.Checked)
            {
                lblClass.Text = "Class Type";
                lblDefense.Text = "Armor";
                lblRace.Text = "Race";
                lblWeapon.Text = "Weapon";
                gbTalents.Text = "Talents";
                _filename = @"C:\ITL\Character.xml";
                

                Dictionary<string, string> htype = new Dictionary<string, string>();
                htype.Add("0", "Human Tank");
                htype.Add("1", "Barbarian");
                htype.Add("2", "Leader");
                htype.Add("3", "Amazon");
                htype.Add("4", "Mercenary");
                htype.Add("5", "Blademaster");
                htype.Add("6", "Warrior");
                htype.Add("7", "Fighter");
                htype.Add("8", "Thief");
                htype.Add("9", "Gadgeteer");
                htype.Add("10", "Priest");
                htype.Add("11", "Assassin/Spy");
                htype.Add("12", "Scholar");
                htype.Add("13", "Woodsman");
                htype.Add("14", "Rogue");
                htype.Add("15", "Merchant");
                htype.Add("16", "Martial Wizard");
                htype.Add("17", "Adept");
                htype.Add("18", "Townsman Wizard");
                htype.Add("19", "Wizardly Thief");
                htype.Add("20", "Apprentice");
                cbType.DataSource = new BindingSource(htype, null);
                cbType.DisplayMember = "Value";
                cbType.ValueMember = "Key";

                
                Dictionary<string, string> stype = new Dictionary<string, string>();
                stype.Add("0", "Human");
                stype.Add("1", "Orc");
                stype.Add("2", "Elf");
                stype.Add("3", "Dwarf");
                stype.Add("4", "Goblin");
                stype.Add("5", "Hobgoblin");
                stype.Add("6", "Halfling");
                stype.Add("7", "Prootwaddle");
                stype.Add("8", "Centaur");
                stype.Add("9", "Giant");
                stype.Add("10", "Gargoyle");
                stype.Add("11", "Reptile Man");
                stype.Add("12", "Merman");
                cbSubType.DataSource = new BindingSource(stype, null);
                cbSubType.DisplayMember = "Value";
                cbSubType.ValueMember = "Key";

            }
            else if (rbCreature.Checked)
            {
                lblClass.Text = "Creature Type";
                lblDefense.Text = "Defense";
                lblRace.Text = "Subtype";
                lblWeapon.Text = "Attack";
                gbTalents.Text = "Abilities";
                _filename = @"C:\ITL\Creature.xml";
                

                Dictionary<string, string> htype = new Dictionary<string, string>();
                htype.Add("0", "Creature level 1");
                htype.Add("1", "Creature level 2");
                htype.Add("2", "Creature level 3");
                htype.Add("3", "Creature level 4");
                htype.Add("4", "Creature level 5");
                cbType.DataSource = new BindingSource(htype, null);
                cbType.DisplayMember = "Value";
                cbType.ValueMember = "Key";

                Dictionary<string, string> stype = new Dictionary<string, string>();
                stype.Add("0", "Intelligent Monsters");
                stype.Add("1", "Werewolves and Vampires");
                stype.Add("2", "Undead");
                stype.Add("3", "Reptiles");
                stype.Add("4", "Ghosts Wights and Revenants");
                stype.Add("5", "Magical Creatures");
                stype.Add("6", "Riding Animals");
                stype.Add("7", "Mammals");
                stype.Add("8", "Beasts");
                stype.Add("9", "Giant Insects");
                stype.Add("10", "Snakes & Lizards");
                stype.Add("11", "Aquatic Creatures");
                stype.Add("12", "Plants");
                stype.Add("13", "Nuisance Creatures");
                cbSubType.DataSource = new BindingSource(stype, null);
                cbSubType.DisplayMember = "Value";
                cbSubType.ValueMember = "Key";
            }

            else if (rbNpc.Checked)
            {
                
                lblClass.Text = "Class Type";
                lblDefense.Text = "Armor";
                lblRace.Text = "Race";
                lblWeapon.Text = "Weapon";
                gbTalents.Text = "Talents";
                _filename = @"C:\ITL\Npc.xml";

                Dictionary<string, string> htype = new Dictionary<string, string>();
                htype.Add("0", "Human Tank");
                htype.Add("1", "Barbarian");
                htype.Add("2", "Leader");
                htype.Add("3", "Amazon");
                htype.Add("4", "Mercenary");
                htype.Add("5", "Blademaster");
                htype.Add("6", "Warrior");
                htype.Add("7", "Fighter");
                htype.Add("8", "Thief");
                htype.Add("9", "Gadgeteer");
                htype.Add("10", "Priest");
                htype.Add("11", "Assassin/Spy");
                htype.Add("12", "Scholar");
                htype.Add("13", "Woodsman");
                htype.Add("14", "Rogue");
                htype.Add("15", "Merchant");
                htype.Add("16", "Martial Wizard");
                htype.Add("17", "Adept");
                htype.Add("18", "Townsman Wizard");
                htype.Add("19", "Wizardly Thief");
                htype.Add("20", "Apprentice");
                cbType.DataSource = new BindingSource(htype, null);
                cbType.DisplayMember = "Value";
                cbType.ValueMember = "Key";

                Dictionary<string, string> stype = new Dictionary<string, string>();
                stype.Add("0", "Human");
                stype.Add("1", "Orc");
                stype.Add("2", "Elf");
                stype.Add("3", "Dwarf");
                stype.Add("4", "Goblin");
                stype.Add("5", "Hobgoblin");
                stype.Add("6", "Halfling");
                stype.Add("7", "Prootwaddle");
                stype.Add("8", "Centaur");
                stype.Add("9", "Giant");
                stype.Add("10", "Gargoyle");
                stype.Add("11", "Reptile Man");
                stype.Add("12", "Merman");
                cbSubType.DataSource = new BindingSource(stype, null);
                cbSubType.DisplayMember = "Value";
                cbSubType.ValueMember = "Key";
            }

            OppList(_filename);
            cbNam.DataSource = _opponentList;
        }



        private void btnSetup_Click(object sender, EventArgs e)
        {
            //show setup
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("C:\\ITL\\Results_open_in_excel.txt"))
            {
                Process.Start("C:\\ITL");
            }
            Application.Exit();            
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            tbChaRes.Text = "";
            tbEncRes.Text = "";
            tbPasRes.Text = "";
            tbTreRes.Text = "";            
    
            if (cbRoomFreq.Text == "Few") { roomFreq = 2; }
            else if (cbRoomFreq.Text == "Moderate") { roomFreq = 4; }
            else if (cbRoomFreq.Text == "Average") { roomFreq = 6; }
            else if (cbRoomFreq.Text == "More") { roomFreq = 8; }
            else if (cbRoomFreq.Text == "Many") { roomFreq = 10; }
            else { roomFreq = 0; }

            if (cbHallDist.Text == "Shortest") { roomSpread = 0; }
            else if (cbHallDist.Text == "Short") { roomSpread = 1; }
            else if (cbHallDist.Text == "Moderate") { roomSpread = 2; }
            else if (cbHallDist.Text == "Long") { roomSpread = 3; }
            else if (cbHallDist.Text == "Longest") { roomSpread = 4; }
            else { roomSpread = 0; }

            Passage p = new Passage();
            p.SetupRollMods(roomFreq, roomSpread);



            //main generate methods...//          
            RoomChamber rc = new RoomChamber();
            Encounter en = new Encounter();
            Treasure t = new Treasure();

            tbPasRes.Text = p.PassageChk();

            if (tbPasRes.Text.Contains("wandering monster"))
            {
                tbEncRes.Text = en.Wandering();
            }
            if (tbPasRes.Text.Contains("room"))
            {
                tbChaRes.Text = rc.Chamber();
            }
            if (tbChaRes.Text.Contains("an encounter"))
            {
                tbEncRes.Text = en.Monster();
            }
            if (tbChaRes.Text.Contains("treasure"))
            {
                tbTreRes.Text = t.TreasureRoll();
            }
            
            //####################################################################################################################################
            //####################################################################################################################################

            // #################### need to check reg to see if anything saved, if not popup setup form. #########################################

            //####################################################################################################################################
            //####################################################################################################################################

        }

        private void btnPasRRoll_Click(object sender, EventArgs e)
        {
            //passage re-roll
            Passage ps = new Passage();
            tbPasRes.Text = ps.PassageChk();
        }

        private void btnChaRRoll_Click(object sender, EventArgs e)
        {
            //chamber re-roll
            RoomChamber rc = new RoomChamber();
            tbChaRes.Text = rc.Chamber();            
        }

        private void btnEncRRoll_Click(object sender, EventArgs e)
        {
            //encounter re-roll
            Encounter en = new Encounter();
            tbEncRes.Text = en.Monster();
        }

        private void btnTreRRoll_Click(object sender, EventArgs e)
        {
            //treasure re-roll
            Treasure tr = new Treasure();
            tbTreRes.Text = tr.TreasureRoll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAll();
        }



        public void SetInitial()
        {
            easyCreature1 = "Orcs"; easyFrom1 = "2"; easyTo1 = "7";
            easyCreature2 = "Orcs"; easyFrom2 = "2"; easyTo2 = "7";
            easyCreature3 = "Orcs"; easyFrom3 = "2"; easyTo3 = "7";
            easyCreature4 = "Orcs"; easyFrom4 = "2"; easyTo4 = "7";
            easyCreature5 = "Orcs"; easyFrom5 = "2"; easyTo5 = "7";
            easyCreature6 = "Orcs"; easyFrom6 = "2"; easyTo6 = "7";

            modCreature1 = "Snakes"; modFrom1 = "2"; modTo1 = "13";
            modCreature2 = "Snakes"; modFrom2 = "2"; modTo2 = "13";
            modCreature3 = "Snakes"; modFrom3 = "2"; modTo3 = "13";
            modCreature4 = "Snakes"; modFrom4 = "2"; modTo4 = "13";
            modCreature5 = "Snakes"; modFrom5 = "2"; modTo5 = "13";
            modCreature6 = "Snakes"; modFrom6 = "2"; modTo6 = "13";

            difCreature1 = "Dragons"; difFrom1 = "2"; difTo1 = "3";
            difCreature2 = "Dragons"; difFrom2 = "2"; difTo2 = "3";
            difCreature3 = "Dragons"; difFrom3 = "2"; difTo3 = "3";
            difCreature4 = "Dragons"; difFrom4 = "2"; difTo4 = "3";
            difCreature5 = "Dragons"; difFrom5 = "2"; difTo5 = "3";
            difCreature6 = "Dragons"; difFrom6 = "2"; difTo6 = "3";

            wanCreature1 = "Rats"; wanFrom1 = "10"; wanTo1 = "40";
            wanCreature2 = "Rats"; wanFrom2 = "10"; wanTo2 = "40";
            wanCreature3 = "Rats"; wanFrom3 = "10"; wanTo3 = "40";
            wanCreature4 = "Rats"; wanFrom4 = "10"; wanTo4 = "40";
            wanCreature5 = "Rats"; wanFrom5 = "10"; wanTo5 = "40";
            wanCreature6 = "Rats"; wanFrom6 = "10"; wanTo6 = "40";

            gem1 = "Gem"; gem1val = "100gp";
            gem2 = "Gem"; gem2val = "100gp";
            gem3 = "Gem"; gem3val = "100gp";
            gem4 = "Gem"; gem4val = "100gp";
            gem5 = "Gem"; gem5val = "100gp";
            gem6 = "Gem"; gem6val = "100gp";

            potion1 = "Potion"; potion1val = "1";
            potion2 = "Potion"; potion2val = "1";
            potion3 = "Potion"; potion3val = "1";
            potion4 = "Potion"; potion4val = "1";
            potion5 = "Potion"; potion5val = "1";
            potion6 = "Potion"; potion6val = "1";

            lesser1 = "Lesser Magic Item"; lesser1val = "+1";
            lesser2 = "Lesser Magic Item"; lesser2val = "+1";
            lesser3 = "Lesser Magic Item"; lesser3val = "+1";
            lesser4 = "Lesser Magic Item"; lesser4val = "+1";
            lesser5 = "Lesser Magic Item"; lesser5val = "+1";
            lesser6 = "Lesser Magic Item"; lesser6val = "+1";

            greater1 = "Greater Magic Item"; greater1val = "1";
            greater2 = "Greater Magic Item"; greater2val = "1";
            greater3 = "Greater Magic Item"; greater3val = "1";
            greater4 = "Greater Magic Item"; greater4val = "1";
            greater5 = "Greater Magic Item"; greater5val = "1";
            greater6 = "Greater Magic Item"; greater6val = "1";
        }

        public void LoadAll()
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey("SOFTWARE\\NallWare\\ITL\\ItlGmHelper");
                easyCreature1 = (string)reg.GetValue("CreatureE1", 0);
                easyFrom1 = (string)reg.GetValue("FromE1", 0);
                easyTo1 = (string)reg.GetValue("ToE1", 0);
                easyCreature2 = (string)reg.GetValue("CreatureE2", 0);
                easyFrom2 = (string)reg.GetValue("FromE2", 0);
                easyTo2 = (string)reg.GetValue("ToE2", 0);
                easyCreature3 = (string)reg.GetValue("CreatureE3", 0);
                easyFrom3 = (string)reg.GetValue("FromE3", 0);
                easyTo3 = (string)reg.GetValue("ToE3", 0);
                easyCreature4 = (string)reg.GetValue("CreatureE4", 0);
                easyFrom4 = (string)reg.GetValue("FromE4", 0);
                easyTo4 = (string)reg.GetValue("ToE4", 0);
                easyCreature5 = (string)reg.GetValue("CreatureE5", 0);
                easyFrom5 = (string)reg.GetValue("FromE5", 0);
                easyTo5 = (string)reg.GetValue("ToE5", 0);
                easyCreature6 = (string)reg.GetValue("CreatureE6", 0);
                easyFrom6 = (string)reg.GetValue("FromE6", 0);
                easyTo6 = (string)reg.GetValue("ToE6", 0);

                modCreature1 = (string)reg.GetValue("CreatureM1", 0);
                modFrom1 = (string)reg.GetValue("FromM1", 0);
                modTo1 = (string)reg.GetValue("ToM1", 0);
                modCreature2 = (string)reg.GetValue("CreatureM2", 0);
                modFrom2 = (string)reg.GetValue("FromM2", 0);
                modTo2 = (string)reg.GetValue("ToM2", 0);
                modCreature3 = (string)reg.GetValue("CreatureM3", 0);
                modFrom3 = (string)reg.GetValue("FromM3", 0);
                modTo3 = (string)reg.GetValue("ToM3", 0);
                modCreature4 = (string)reg.GetValue("CreatureM4", 0);
                modFrom4 = (string)reg.GetValue("FromM4", 0);
                modTo4 = (string)reg.GetValue("ToM4", 0);
                modCreature5 = (string)reg.GetValue("CreatureM5", 0);
                modFrom5 = (string)reg.GetValue("FromM5", 0);
                modTo5 = (string)reg.GetValue("ToM5", 0);
                modCreature6 = (string)reg.GetValue("CreatureM6", 0);
                modFrom6 = (string)reg.GetValue("FromM6", 0);
                modTo6 = (string)reg.GetValue("ToM6", 0);

                difCreature1 = (string)reg.GetValue("CreatureD1", 0);
                difFrom1 = (string)reg.GetValue("FromD1", 0);
                difTo1 = (string)reg.GetValue("ToD1", 0);
                difCreature2 = (string)reg.GetValue("CreatureD2", 0);
                difFrom2 = (string)reg.GetValue("FromD2", 0);
                difTo2 = (string)reg.GetValue("ToD2", 0);
                difCreature3 = (string)reg.GetValue("CreatureD3", 0);
                difFrom3 = (string)reg.GetValue("FromD3", 0);
                difTo3 = (string)reg.GetValue("ToD3", 0);
                difCreature4 = (string)reg.GetValue("CreatureD4", 0);
                difFrom4 = (string)reg.GetValue("FromD4", 0);
                difTo4 = (string)reg.GetValue("ToD4", 0);
                difCreature5 = (string)reg.GetValue("CreatureD5", 0);
                difFrom5 = (string)reg.GetValue("FromD5", 0);
                difTo5 = (string)reg.GetValue("ToD5", 0);
                difCreature6 = (string)reg.GetValue("CreatureD6", 0);
                difFrom6 = (string)reg.GetValue("FromD6", 0);
                difTo6 = (string)reg.GetValue("ToD6", 0);

                wanCreature1 = (string)reg.GetValue("CreatureW1", 0);
                wanFrom1 = (string)reg.GetValue("FromW1", 0);
                wanTo1 = (string)reg.GetValue("ToW1", 0);
                wanCreature2 = (string)reg.GetValue("CreatureW2", 0);
                wanFrom2 = (string)reg.GetValue("FromW2", 0);
                wanTo2 = (string)reg.GetValue("ToW2", 0);
                wanCreature3 = (string)reg.GetValue("CreatureW3", 0);
                wanFrom3 = (string)reg.GetValue("FromW3", 0);
                wanTo3 = (string)reg.GetValue("ToW3", 0);
                wanCreature4 = (string)reg.GetValue("CreatureW4", 0);
                wanFrom4 = (string)reg.GetValue("FromW4", 0);
                wanTo4 = (string)reg.GetValue("ToW4", 0);
                wanCreature5 = (string)reg.GetValue("CreatureW5", 0);
                wanFrom5 = (string)reg.GetValue("FromW5", 0);
                wanTo5 = (string)reg.GetValue("ToW5", 0);
                wanCreature6 = (string)reg.GetValue("CreatureW6", 0);
                wanFrom6 = (string)reg.GetValue("FromW6", 0);
                wanTo6 = (string)reg.GetValue("ToW6", 0);

                gem1 = (string)reg.GetValue("Gem1", 0);
                gem1val = (string)reg.GetValue("GemValue1", 0);
                gem2 = (string)reg.GetValue("Gem2", 0);
                gem2val = (string)reg.GetValue("GemValue2", 0);
                gem3 = (string)reg.GetValue("Gem3", 0);
                gem3val = (string)reg.GetValue("GemValue3", 0);
                gem4 = (string)reg.GetValue("Gem4", 0);
                gem4val = (string)reg.GetValue("GemValue4", 0);
                gem5 = (string)reg.GetValue("Gem5", 0);
                gem5val = (string)reg.GetValue("GemValue5", 0);
                gem6 = (string)reg.GetValue("Gem6", 0);
                gem6val = (string)reg.GetValue("GemValue6", 0);


                potion1 = (string)reg.GetValue("Potion1", 0);
                potion1val = (string)reg.GetValue("PotionValue1", 0);
                potion2 = (string)reg.GetValue("Potion2", 0);
                potion2val = (string)reg.GetValue("PotionValue2", 0);
                potion3 = (string)reg.GetValue("Potion3", 0);
                potion3val = (string)reg.GetValue("PotionValue3", 0);
                potion4 = (string)reg.GetValue("Potion4", 0);
                potion4val = (string)reg.GetValue("PotionValue4", 0);
                potion5 = (string)reg.GetValue("Potion5", 0);
                potion5val = (string)reg.GetValue("PotionValue5", 0);
                potion6 = (string)reg.GetValue("Potion6", 0);
                potion6val = (string)reg.GetValue("PotionValue6", 0);

                lesser1 = (string)reg.GetValue("Lesser1", 0);
                lesser1val = (string)reg.GetValue("LesserValue1", 0);
                lesser2 = (string)reg.GetValue("Lesser2", 0);
                lesser2val = (string)reg.GetValue("LesserValue2", 0);
                lesser3 = (string)reg.GetValue("Lesser3", 0);
                lesser3val = (string)reg.GetValue("LesserValue3", 0);
                lesser4 = (string)reg.GetValue("Lesser4", 0);
                lesser4val = (string)reg.GetValue("LesserValue4", 0);
                lesser5 = (string)reg.GetValue("Lesser5", 0);
                lesser5val = (string)reg.GetValue("LesserValue5", 0);
                lesser6 = (string)reg.GetValue("Lesser6", 0);
                lesser6val = (string)reg.GetValue("LesserValue6", 0);

                greater1 = (string)reg.GetValue("Greater1", 0);
                greater1val = (string)reg.GetValue("GreaterValue1", 0);
                greater2 = (string)reg.GetValue("Greater2", 0);
                greater2val = (string)reg.GetValue("GreaterValue2", 0);
                greater3 = (string)reg.GetValue("Greater3", 0);
                greater3val = (string)reg.GetValue("GreaterValue3", 0);
                greater4 = (string)reg.GetValue("Greater4", 0);
                greater4val = (string)reg.GetValue("GreaterValue4", 0);
                greater5 = (string)reg.GetValue("Greater5", 0);
                greater5val = (string)reg.GetValue("GreaterValue5", 0);
                greater6 = (string)reg.GetValue("Greater6", 0);
                greater6val = (string)reg.GetValue("GreaterValue6", 0);
                reg.Close();                
            }
            catch
            {
               
            }
            
        }

        private void btnGenRand_Click(object sender, EventArgs e)
        {
            tbRandom.Text = nm.RandNameGen() + Environment.NewLine + nm.RandNameGen() + Environment.NewLine + nm.RandNameGen() + Environment.NewLine + nm.RandNameGen() + Environment.NewLine + nm.RandNameGen();
        }

        private void btnGenDwarf_Click(object sender, EventArgs e)
        {
            tbDwarf.Text = nm.GenDwarfName() + Environment.NewLine + nm.GenDwarfName() + Environment.NewLine + nm.GenDwarfName() + Environment.NewLine + nm.GenDwarfName() + Environment.NewLine + nm.GenDwarfName();
        }

        private void btnGenElf_Click(object sender, EventArgs e)
        {
            tbElf.Text = nm.GenElfName() + Environment.NewLine + nm.GenElfName() + Environment.NewLine + nm.GenElfName() + Environment.NewLine + nm.GenElfName() + Environment.NewLine + nm.GenElfName();
        }

        private void btnGenHobbit_Click(object sender, EventArgs e)
        {
            tbHobbit.Text = nm.GenHobbitName() + Environment.NewLine + nm.GenHobbitName() + Environment.NewLine + nm.GenHobbitName() + Environment.NewLine + nm.GenHobbitName() + Environment.NewLine + nm.GenHobbitName();
        }

        private void btnGenCity_Click(object sender, EventArgs e)
        {
            tbCity.Text = nm.GenCity() + Environment.NewLine + nm.GenCity() + Environment.NewLine + nm.GenCity() + Environment.NewLine + nm.GenCity() + Environment.NewLine + nm.GenCity();
        }

        private void btnGenInn_Click(object sender, EventArgs e)
        {
            tbInn.Text = nm.GenInn() + Environment.NewLine + nm.GenInn() + Environment.NewLine + nm.GenInn() + Environment.NewLine + nm.GenInn() + Environment.NewLine + nm.GenInn();
        }

        private void btnGenRoomType_Click(object sender, EventArgs e) ///////////////////////////////////////////////
        {
            tbList.Text = Stuff();      
            
        }

        //d.RoomName().Replace("and appears to have been used as ", "");

        public string Stuff()
        {
            Dressing d = new Dressing();
            NameGen n = new NameGen();
            //get items based on radio buttons

            if (rbAttributes.Checked) {i1=d.MagicAttribute(); i2=d.MagicAttribute(); i3=d.MagicAttribute(); i4=d.MagicAttribute(); i5=d.MagicAttribute(); i6=d.MagicAttribute(); i7=d.MagicAttribute(); i8=d.MagicAttribute(); i9=d.MagicAttribute(); i10=d.MagicAttribute();}
            else if (rbClothing.Checked) {i1=d.Clothing(); i2=d.Clothing(); i3=d.Clothing(); i4=d.Clothing(); i5=d.Clothing(); i6=d.Clothing(); i7=d.Clothing(); i8=d.Clothing(); i9=d.Clothing(); i10=d.Clothing();}
            else if (rbFeatures.Checked) {i1=d.RoomFeature(); i2=d.RoomFeature(); i3=d.RoomFeature(); i4=d.RoomFeature(); i5=d.RoomFeature(); i6=d.RoomFeature(); i7=d.RoomFeature(); i8=d.RoomFeature(); i9=d.RoomFeature(); i10=d.RoomFeature();}
            else if (rbFood.Checked) {i1=d.Food(); i2=d.Food(); i3=d.Food(); i4=d.Food(); i5=d.Food(); i6=d.Food(); i7=d.Food(); i8=d.Food(); i9=d.Food(); i10=d.Food();}
            else if (rbGenDeco.Checked) {i1=d.GeneralDeco(); i2=d.GeneralDeco(); i3=d.GeneralDeco(); i4=d.GeneralDeco(); i5=d.GeneralDeco(); i6=d.GeneralDeco(); i7=d.GeneralDeco(); i8=d.GeneralDeco(); i9=d.GeneralDeco(); i10=d.GeneralDeco();}
            else if (rbItem.Checked) {i1=d.Type(); i2=d.Type(); i3=d.Type(); i4=d.Type(); i5=d.Type(); i6=d.Type(); i7=d.Type(); i8=d.Type(); i9=d.Type(); i10=d.Type();}
            else if (rbNoise.Checked) {i1=d.Noise(); i2=d.Noise(); i3=d.Noise(); i4=d.Noise(); i5=d.Noise(); i6=d.Noise(); i7=d.Noise(); i8=d.Noise(); i9=d.Noise(); i10=d.Noise();}
            else if (rbPersBelong.Checked) {i1=d.Belonging(); i2=d.Belonging(); i3=d.Belonging(); i4=d.Belonging(); i5=d.Belonging(); i6=d.Belonging(); i7=d.Belonging(); i8=d.Belonging(); i9=d.Belonging(); i10=d.Belonging();}
            else if (rbRoomName.Checked) {i1=d.RoomName().Replace("and appears to have been used as ", "") ; i2=d.RoomName().Replace("and appears to have been used as ", "") ; i3=d.RoomName().Replace("and appears to have been used as ", "") ; i4=d.RoomName().Replace("and appears to have been used as ", "") ; i5=d.RoomName().Replace("and appears to have been used as ", "") ; i6=d.RoomName().Replace("and appears to have been used as ", "") ; i7=d.RoomName().Replace("and appears to have been used as ", "") ; i8=d.RoomName().Replace("and appears to have been used as ", "") ; i9=d.RoomName().Replace("and appears to have been used as ", "") ; i10=d.RoomName().Replace("and appears to have been used as ", "") ;}
            else if (rbSpices.Checked) {i1=d.Spice(); i2=d.Spice(); i3=d.Spice(); i4=d.Spice(); i5=d.Spice(); i6=d.Spice(); i7=d.Spice(); i8=d.Spice(); i9=d.Spice(); i10=d.Spice();}
            else if (rbTempDeco.Checked) {i1=d.TempleDeco(); i2=d.TempleDeco(); i3=d.TempleDeco(); i4=d.TempleDeco(); i5=d.TempleDeco(); i6=d.TempleDeco(); i7=d.TempleDeco(); i8=d.TempleDeco(); i9=d.TempleDeco(); i10=d.TempleDeco();}
            else if (rbTortDeco.Checked) {i1=d.TortureDeco(); i2=d.TortureDeco(); i3=d.TortureDeco(); i4=d.TortureDeco(); i5=d.TortureDeco(); i6=d.TortureDeco(); i7=d.TortureDeco(); i8=d.TortureDeco(); i9=d.TortureDeco(); i10=d.TortureDeco();}
            else if (rbVial.Checked) {i1=d.VialMatter(); i2=d.VialMatter(); i3=d.VialMatter(); i4=d.VialMatter(); i5=d.VialMatter(); i6=d.VialMatter(); i7=d.VialMatter(); i8=d.VialMatter(); i9=d.VialMatter(); i10=d.VialMatter();}
            else if (rbWind.Checked) {i1=d.AirCurrent(); i2=d.AirCurrent(); i3=d.AirCurrent(); i4=d.AirCurrent(); i5=d.AirCurrent(); i6=d.AirCurrent(); i7=d.AirCurrent(); i8=d.AirCurrent(); i9=d.AirCurrent(); i10=d.AirCurrent();}
            else if (rbOdor.Checked) { i1 = d.Odor().Replace("there is a ", ""); i2 = d.Odor().Replace("there is ", ""); i3 = d.Odor().Replace("there is a ", ""); i4 = d.Odor().Replace("there is a ", ""); i5 = d.Odor().Replace("there is a ", ""); i6 = d.Odor().Replace("there is a ", ""); i7 = d.Odor().Replace("there is a ", ""); i8 = d.Odor().Replace("there is a ", ""); i9 = d.Odor().Replace("there is a ", ""); i10 = d.Odor().Replace("there is a ", ""); }
            else if (rbGenDressing.Checked) {i1=d.GeneralDressing(); i2=d.GeneralDressing(); i3=d.GeneralDressing(); i4=d.GeneralDressing(); i5=d.GeneralDressing(); i6=d.GeneralDressing(); i7=d.GeneralDressing(); i8=d.GeneralDressing(); i9=d.GeneralDressing(); i10=d.GeneralDressing();}
            else if (rbWizaDeco.Checked) { i1 = d.WizardDeco(); i2 = d.WizardDeco(); i3 = d.WizardDeco(); i4 = d.WizardDeco(); i5 = d.WizardDeco(); i6 = d.WizardDeco(); i7 = d.WizardDeco(); i8 = d.WizardDeco(); i9 = d.WizardDeco(); i10 = d.WizardDeco(); }
            else if (rbSyl.Checked) { i1 = n.GenRandSylName(); i2 = n.GenRandSylName(); i3 = n.GenRandSylName(); i4 = n.GenRandSylName(); i5 = n.GenRandSylName(); i6 = n.GenRandSylName(); i7 = n.GenRandSylName(); i8 = n.GenRandSylName(); i9 = n.GenRandSylName(); i10 = n.GenRandSylName(); }
            else { MessageBox.Show("You must select a category of item to generate."); }

            string _stuff = " 1. " + i1 + Environment.NewLine +
                " 2. " + i2 + Environment.NewLine +
                " 3. " + i3 + Environment.NewLine +
                " 4. " + i4 + Environment.NewLine +
                " 5. " + i5 + Environment.NewLine +
                " 6. " + i6 + Environment.NewLine +
                " 7. " + i7 + Environment.NewLine +
                " 8. " + i8 + Environment.NewLine +
                " 9. " + i9 + Environment.NewLine +
                "10. " + i10;

            return _stuff;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save record
            if (rbHumanoid.Checked)
            {
                _filename = @"C:\ITL\Character.xml";
            }
            else if (rbCreature.Checked)
            {
                _filename = @"C:\ITL\Creature.xml";
            }
            else
            {
                _filename = @"C:\ITL\Npc.xml";
            }
            FloraFauna f = new FloraFauna();
            f.SaveChar(_filename, tbName.Text, cbType.Text, cbSubType.Text, tbSt.Text, tbDx.Text, tbIq.Text, tbMa.Text, cbType.Text, cbSubType.Text, tbAttack.Text, tbDmgDie.Text, tbDmgMod.Text, tbArmor.Text, tbHitStop.Text, tbDxMod.Text, tbTalents.Text, tbNotes.Text);

            RefreshList(null);
            ClearAll();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbHumanoid.Checked)
            {
                _filename = @"C:\ITL\Character.xml";
            }
            else if (rbCreature.Checked)
            {
                _filename = @"C:\ITL\Creature.xml";
            }
            else
            {
                _filename = @"C:\ITL\Npc.xml";
            }
            //update creature or humanoid
            FloraFauna f = new FloraFauna();
            f.UpdateChar(_filename, tbName.Text, cbType.Text, cbSubType.Text, tbSt.Text, tbDx.Text, tbIq.Text, tbMa.Text, cbType.Text, cbSubType.Text, tbAttack.Text, tbDmgDie.Text, tbDmgMod.Text, tbArmor.Text, tbHitStop.Text, tbDxMod.Text, tbTalents.Text, tbNotes.Text);

            RefreshList(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbHumanoid.Checked)
            {
                _filename = @"C:\ITL\Character.xml";
            }
            else if (rbCreature.Checked)
            {
                _filename = @"C:\ITL\Creature.xml";
            }
            else
            {
                _filename = @"C:\ITL\Npc.xml";
            }
            //delete creature or humanoid
            FloraFauna f = new FloraFauna();
            f.DeleteChar(_filename, tbName.Text);

            RefreshList(null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        public ObservableCollection<string> OppList(string _filename) //populates list of opponents to combobox
        {
            if (rbHumanoid.Checked)
            {
                _filename = @"C:\ITL\Character.xml";
            }
            else if (rbCreature.Checked)
            {
                _filename = @"C:\ITL\Creature.xml";
            }
            else
            {
                _filename = @"C:\ITL\Npc.xml";
            }

            if (File.Exists(_filename))
            {
                _opponentList.Clear();
                XDocument _xmlDoc = XDocument.Load(_filename);
                var _opList = from rec in _xmlDoc.Descendants("Opponent").OrderBy(n => n.Attribute("name").Value) select rec.Attribute("name");
                _opponentList.Add("---");
                foreach (string _name in _opList.ToList())
                {
                    _opponentList.Add("" + _name);
                }

                _xmlDoc = XDocument.Load(_filename);
                _opList = from rec in _xmlDoc.Descendants("Opponent").OrderBy(n => n.Attribute("name").Value) select rec.Attribute("name");
                foreach (string _name in _opList)
                {
                    if (!_opponentList.Contains(_name))
                    {
                        _opponentList.Add("" + _name);
                    }
                }
                return _opponentList;
            }
            return null;
        }

        public void RefreshList(List<string> list)
        {
            if (rbHumanoid.Checked)
            {
                _filename = @"C:\ITL\Character.xml";
            }
            else if (rbCreature.Checked)
            {
                _filename = @"C:\ITL\Creature.xml";
            }
            else
            {
                _filename = @"C:\ITL\Npc.xml";
            }
            cbNam.DataSource = null;
            cbNam.DataSource = OppList(_filename);
            cbNam.Refresh();
        }

        

        //private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    tbName.Text = cbNam.Text;
        //}        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            if (_filename == @"C:\ITL\Character.xml")
            {
                rbHumanoid.Checked = true;
            }
            else if (_filename == @"C:\ITL\Creature.xml")
            {
                rbCreature.Checked = true;
            }
            else
            {
                rbNpc.Checked = true;
            }
            

            if (cbNam.Text == "---")
            {
                MessageBox.Show("You must select an item.");
            }
            else
            {
                try
                {
                    FloraFauna f = new FloraFauna();
                    List<string> _opponent = f.LoadChar(_filename, cbNam.Text);
                    //tbName.Text = cbNam.Text;

                    if (_opponent[0] == "")
                    {
                        MessageBox.Show("You must select a character before loading.");
                    }
                    else
                    {

                        string tempname = _opponent[0];
                        tbName.Text = tempname;
                        cbType.Text = _opponent[1];
                        cbSubType.Text = _opponent[2];
                        tbSt.Text = _opponent[3];
                        tbDx.Text = _opponent[4];
                        tbIq.Text = _opponent[5];
                        tbMa.Text = _opponent[6];
                        tbArmor.Text = _opponent[7];
                        tbHitStop.Text = _opponent[8];
                        tbDxMod.Text = _opponent[9];
                        tbAttack.Text = _opponent[10];
                        tbDmgDie.Text = _opponent[11];
                        tbDmgMod.Text = _opponent[12];
                        tbTalents.Text = _opponent[13];
                        tbNotes.Text = _opponent[14];
                    }
                }
                catch
                {
                    MessageBox.Show("An unhandled exception has occurred.  You suck.  Try again.");
                }
            }

            RefreshList(null);
                    
        }        

        

        private void rbHumanoid_CheckedChanged(object sender, EventArgs e)
        {
            
                _filename = @"C:\ITL\Character.xml";
                lblClass.Text = "Class Type";
                lblDefense.Text = "Armor";
                lblRace.Text = "Race";
                lblWeapon.Text = "Weapon";
                gbTalents.Text = "Talents";


                Dictionary<string, string> htype = new Dictionary<string, string>();
                htype.Add("0", "Human Tank");
                htype.Add("1", "Barbarian");
                htype.Add("2", "Leader");
                htype.Add("3", "Amazon");
                htype.Add("4", "Mercenary");
                htype.Add("5", "Blademaster");
                htype.Add("6", "Warrior");
                htype.Add("7", "Fighter");
                htype.Add("8", "Thief");
                htype.Add("9", "Gadgeteer");
                htype.Add("10", "Priest");
                htype.Add("11", "Assassin/Spy");
                htype.Add("12", "Scholar");
                htype.Add("13", "Woodsman");
                htype.Add("14", "Rogue");
                htype.Add("15", "Merchant");
                htype.Add("16", "Martial Wizard");
                htype.Add("17", "Adept");
                htype.Add("18", "Townsman Wizard");
                htype.Add("19", "Wizardly Thief");
                htype.Add("20", "Apprentice");
                cbType.DataSource = new BindingSource(htype, null);
                cbType.DisplayMember = "Value";
                cbType.ValueMember = "Key";

                Dictionary<string, string> stype = new Dictionary<string, string>();
                stype.Add("0", "Human");
                stype.Add("1", "Orc");
                stype.Add("2", "Elf");
                stype.Add("3", "Dwarf");
                stype.Add("4", "Goblin");
                stype.Add("5", "Hobgoblin");
                stype.Add("6", "Halfling");
                stype.Add("7", "Prootwaddle");
                stype.Add("8", "Centaur");
                stype.Add("9", "Giant");
                stype.Add("10", "Gargoyle");
                stype.Add("11", "Reptile Man");
                stype.Add("12", "Merman");
                cbSubType.DataSource = new BindingSource(stype, null);
                cbSubType.DisplayMember = "Value";
                cbSubType.ValueMember = "Key";

                RefreshList(null);

            

        }

        private void rbNpc_CheckedChanged(object sender, EventArgs e)
        {
            
            
                _filename = @"C:\ITL\Npc.xml";
                lblClass.Text = "Class Type";
                lblDefense.Text = "Armor";
                lblRace.Text = "Race";
                lblWeapon.Text = "Weapon";
                gbTalents.Text = "Talents";


                Dictionary<string, string> htype = new Dictionary<string, string>();
                htype.Add("0", "Human Tank");
                htype.Add("1", "Barbarian");
                htype.Add("2", "Leader");
                htype.Add("3", "Amazon");
                htype.Add("4", "Mercenary");
                htype.Add("5", "Blademaster");
                htype.Add("6", "Warrior");
                htype.Add("7", "Fighter");
                htype.Add("8", "Thief");
                htype.Add("9", "Gadgeteer");
                htype.Add("10", "Priest");
                htype.Add("11", "Assassin/Spy");
                htype.Add("12", "Scholar");
                htype.Add("13", "Woodsman");
                htype.Add("14", "Rogue");
                htype.Add("15", "Merchant");
                htype.Add("16", "Martial Wizard");
                htype.Add("17", "Adept");
                htype.Add("18", "Townsman Wizard");
                htype.Add("19", "Wizardly Thief");
                htype.Add("20", "Apprentice");
                cbType.DataSource = new BindingSource(htype, null);
                cbType.DisplayMember = "Value";
                cbType.ValueMember = "Key";

                Dictionary<string, string> stype = new Dictionary<string, string>();
                stype.Add("0", "Human");
                stype.Add("1", "Orc");
                stype.Add("2", "Elf");
                stype.Add("3", "Dwarf");
                stype.Add("4", "Goblin");
                stype.Add("5", "Hobgoblin");
                stype.Add("6", "Halfling");
                stype.Add("7", "Prootwaddle");
                stype.Add("8", "Centaur");
                stype.Add("9", "Giant");
                stype.Add("10", "Gargoyle");
                stype.Add("11", "Reptile Man");
                stype.Add("12", "Merman");
                cbSubType.DataSource = new BindingSource(stype, null);
                cbSubType.DisplayMember = "Value";
                cbSubType.ValueMember = "Key";

                RefreshList(null);            
        }

        private void rbCreature_CheckedChanged(object sender, EventArgs e)
        {
            _filename = @"C:\ITL\Creature.xml";
            lblClass.Text = "Creature Type";
            lblDefense.Text = "Defense";
            lblRace.Text = "Subtype";
            lblWeapon.Text = "Attack";
            gbTalents.Text = "Abilities";
            _base = "Monster";

            Dictionary<string, string> htype = new Dictionary<string, string>();
            htype.Add("0", "Creature level 1");
            htype.Add("1", "Creature level 2");
            htype.Add("2", "Creature level 3");
            htype.Add("3", "Creature level 4");
            htype.Add("4", "Creature level 5");
            cbType.DataSource = new BindingSource(htype, null);
            cbType.DisplayMember = "Value";
            cbType.ValueMember = "Key";

            Dictionary<string, string> stype = new Dictionary<string, string>();
            stype.Add("0", "Intelligent Monsters");
            stype.Add("1", "Werewolves and Vampires");
            stype.Add("2", "Undead");
            stype.Add("3", "Reptiles");
            stype.Add("4", "Ghosts Wights and Revenants");
            stype.Add("5", "Magical Creatures");
            stype.Add("6", "Riding Animals");
            stype.Add("7", "Mammals");
            stype.Add("8", "Beasts");
            stype.Add("9", "Giant Insects");
            stype.Add("10", "Snakes & Lizards");
            stype.Add("11", "Aquatic Creatures");
            stype.Add("12", "Plants");
            stype.Add("13", "Nuisance Creatures");
            cbSubType.DataSource = new BindingSource(stype, null);
            cbSubType.DisplayMember = "Value";
            cbSubType.ValueMember = "Key";

            RefreshList(null);
        }

       

        public void ClearAll()
        {
            //clear form
            tbName.Text = "n/a";
            tbSt.Text = "0";
            tbDx.Text = "0";
            tbIq.Text = "0";
            tbMa.Text = "0";
            tbArmor.Text = "nil";
            tbHitStop.Text = "0";
            tbDxMod.Text = "0";
            tbAttack.Text = "0";
            tbDmgDie.Text = "0";
            tbDmgMod.Text = "0";
            tbTalents.Text = "nil";
            tbNotes.Text = "nil";
            cbNam.SelectedIndex = 0;

            RefreshList(null);
        }

        private void btnLoadCombat_Click(object sender, EventArgs e)
        {
            //FloraFauna f = new FloraFauna();
            //f.Attacker();
            //cbAttacker.DataSource = f._attacker;

            //f.Defender();
            //cbDefender.DataSource = f._defender;

            _filename = @"C:\ITL\Combat.xml";

            if (File.Exists(_filename))
            {
                Form1 f1 = new Form1();
                DataSet ds = new DataSet("Tester");
                ds.ReadXml(_filename);
            
                dgvChar.AutoGenerateColumns = true;
                dgvChar.DataSource = ds;
                dgvChar.DataMember = "Opponent";
            }
            else MessageBox.Show("No combatants loaded. Use Flora and Fauna to select.");
        }

        private void btnLoadCombat1_Click(object sender, EventArgs e)
        {
            //save record
            
            FloraFauna f = new FloraFauna();
            f.SaveCombat(tbName.Text, tbSt.Text, tbDx.Text, tbIq.Text, tbMa.Text, tbAttack.Text, tbDmgDie.Text, tbDmgMod.Text, tbArmor.Text, tbHitStop.Text, tbDxMod.Text);

            RefreshList(null);
            ClearAll();
        }

        private void btnClearCombat_Click(object sender, EventArgs e)
        {
            //clear all from Combat.xml
            File.Delete(@"C:\ITL\Combat.xml");
            dgvChar.DataSource = null;
            dgvChar.Rows.Clear();
        }

        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }        


        private void btnGenerateNpc_Click(object sender, EventArgs e)
        {
            NpcGen npc = new NpcGen();
            //temp static data
            string [] np = npc.NpcBuilder(cbLevel.Text);
            string uppername = FirstCharToUpper(np[0]);
            tbNpcName.Text = uppername;
            tbNpcType.Text = np[4];
            tbNpcRace.Text = np[1];
            tbNpcGender.Text = np[3];
            tbNpcAge.Text = np[2];
            tbNpcSt.Text = np[5];
            tbNpcDx.Text = np[6];
            tbNpcIq.Text = np[7];
            tbNpcMa.Text = np[15];
            string abils = np[10];
            tbNpcTalents.Text = string.Join(", ", abils.Split(',').Distinct());  //removes duplicates.            
            tbNpcAppearance.Text = uppername+ np[12];
            tbNpcArmorWeapons.Text = np[8] +", "+np[9];
            Treasure t = new Treasure();
            string treasure = t.PersTreasure(cbLevel.Text);
            tbNpcEquipmentTreasure.Text = treasure+", "+np[13];
            tbNpcBackground.Text = uppername+ np[14];            
        }

        private void btnClearNpc_Click(object sender, EventArgs e)
        {
            tbNpcName.Text = "";
            tbNpcType.Text = "";
            tbNpcRace.Text = "";
            tbNpcGender.Text = "";
            tbNpcAge.Text = "";
            tbNpcSt.Text = "";
            tbNpcDx.Text = "";
            tbNpcIq.Text = "";
            tbNpcMa.Text = "";
            tbNpcTalents.Text = "";
            
            tbNpcAppearance.Text = "";
            tbNpcArmorWeapons.Text = "";
            tbNpcEquipmentTreasure.Text = "";
            tbNpcBackground.Text = "";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //////////////  * * * * * * * saves datagridview as-is to Combat.xml * * * * * * * * /////////////
            DataSet charDataSet = (DataSet)dgvChar.DataSource;  
            charDataSet.WriteXml(@"C:\ITL\Combat.xml");
        }

        private void dgvChar_SelectionChanged(object sender, EventArgs e) 
        {
            //Adjusts column widths but leaves open so user can also modify
            dgvChar.Columns[0].Width = 115;//name
            dgvChar.Columns[1].Width = 25; //ST
            dgvChar.Columns[2].Width = 40;//curr ST
            dgvChar.Columns[3].Width = 40;//AdjDx
            dgvChar.Columns[4].Width = 25;//IQ
            dgvChar.Columns[5].Width = 25;//MA
            dgvChar.Columns[6].Width = 95;//Armor
            dgvChar.Columns[7].Width = 45;//Hit-stop
            dgvChar.Columns[8].Width = 45;//DxMod
            dgvChar.Columns[9].Width = 100;//Weapng
            dgvChar.Columns[10].Width = 50;//Dmg Die
            dgvChar.Columns[11].Width = 55;//Dmg Mod            
            
        }

        private void btnCombatRoll_Click(object sender, EventArgs e)
        {
            if (cbCombatAdjDx.Text == "") { MessageBox.Show("You must first choose an Adjusted Dexterity before rolling."); }
            else if (cbCombatDmgDie.Text == "") { MessageBox.Show("You must first choose a Damage Die before rolling."); }
            else if (cbCombatDmgMod.Text == "") { MessageBox.Show("You must first choose a Damage Mod before rolling."); }
            else if (cbCombatDefenderHitStop.Text == "") { MessageBox.Show("You must first choose a Defender Armor Mod before rolling."); }
            else
            {
                Randomizer r = new Randomizer();
                Randomizer r2 = new Randomizer();
                Randomizer r3 = new Randomizer();
                int adjDx = Convert.ToInt16(cbCombatAdjDx.Text);
                int dmgDie = Convert.ToInt16(cbCombatDmgDie.Text);
                int dmgMod = Convert.ToInt16(cbCombatDmgMod.Text);
                int defense = Convert.ToInt16(cbCombatDefenderHitStop.Text);
                int dice = dmgDie;


                do
                {
                    int temp = r.RandNumber(1, 6) + dmgMod;
                    points = points + temp;
                    dice--;
                } while (dice > 0);
                

                string result;
                int roll = r.RandNumber(1, 6) + r2.RandNumber(1, 6) + r3.RandNumber(1, 6);
                if (roll <= adjDx)
                {
                    //success
                    result = "The attacker landed a hit.  Defender loses " + (points-defense) + " points from their Current ST." +
                        Environment.NewLine+"You can make the adjustment on the Combat Tracker.";
                    MessageBox.Show(result);
                    points = 0;
                }
                else
                {
                    //fail
                    result = "The attacker has missed.";
                    MessageBox.Show(result);
                    points = 0;
                }
                points = 0;
            }
        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        public void SaveToFile()
        {
            string psg, rm, enc, tre;

            psg = tbPasRes.Text;
            rm = tbChaRes.Text;
            enc = tbEncRes.Text;
            tre = tbTreRes.Text;

            if (File.Exists("C:\\ITL\\Results_open_in_excel.txt"))
            {
                string addLine = psg + "\t" + rm + "\t" + enc + "\t" + tre;
                StreamWriter file = new StreamWriter("C:\\ITL\\Results_open_in_excel.txt", true);
                file.WriteLine(addLine);
                file.Close();

            }
            else
            {
                string lines = "Passage\t Room/Chamber\t Encounter\t Treasure\r\n"
                    + psg + "\t" + rm + "\t" + enc + "\t" + tre;
                StreamWriter file = new StreamWriter("C:\\ITL\\Results_open_in_excel.txt");
                file.WriteLine(lines);
                file.Close();
            }
        }
        






    }
}
