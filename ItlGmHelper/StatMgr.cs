using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace ItlGmHelper
{
    class StatMgr
    {
        Form1 f1 = new Form1();
        string _filename = @"C:\ITL\StatMgr.xml";

        public void SaveChar(string _name, string _st, string _dx, string _iq, string _ma, string _weapon, string _dmgdie, string _dmgmod, string _armor, string _hitstop, string _dxmod, string _currSt, string _fatigue, string _wounds)
        {

            //xml files does not yet exist--must create
            if (!File.Exists(_filename))
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);
                XmlNode Character = doc.CreateElement("FloraFauna");
                doc.AppendChild(Character);
                XmlNode Chtr = doc.CreateElement("Opponent");
                XmlAttribute characterName = doc.CreateAttribute("name");
                characterName.Value = _name;
                Chtr.Attributes.Append(characterName);
                XmlAttribute characterSt = doc.CreateAttribute("st");
                characterSt.Value = _st;
                Chtr.Attributes.Append(characterSt);
                XmlAttribute characterDx = doc.CreateAttribute("dx");
                characterDx.Value = _dx;
                Chtr.Attributes.Append(characterDx);
                XmlAttribute characterIq = doc.CreateAttribute("iq");
                characterIq.Value = _iq;
                Chtr.Attributes.Append(characterIq);
                XmlAttribute characterMa = doc.CreateAttribute("ma");
                characterMa.Value = _ma;
                Chtr.Attributes.Append(characterMa);
                XmlAttribute characterArmor = doc.CreateAttribute("armor");
                characterArmor.Value = _armor;
                Chtr.Attributes.Append(characterArmor);
                XmlAttribute characterHitStop = doc.CreateAttribute("hitstop");
                characterHitStop.Value = _hitstop;
                Chtr.Attributes.Append(characterHitStop);
                XmlAttribute characterDxMod = doc.CreateAttribute("dxmod");
                characterDxMod.Value = _dxmod;
                Chtr.Attributes.Append(characterDxMod);
                XmlAttribute characterWeapon = doc.CreateAttribute("weapon");
                characterWeapon.Value = _weapon;
                Chtr.Attributes.Append(characterWeapon);
                XmlAttribute characterDmgDie = doc.CreateAttribute("dmgdie");
                characterDmgDie.Value = _dmgdie;
                Chtr.Attributes.Append(characterDmgDie);
                XmlAttribute characterDmgMod = doc.CreateAttribute("dmgmod");
                characterDmgMod.Value = _dmgmod;
                Chtr.Attributes.Append(characterDmgMod);
                XmlAttribute characterCurrSt = doc.CreateAttribute("currSt");
                characterCurrSt.Value = _currSt;
                Chtr.Attributes.Append(characterCurrSt);
                XmlAttribute characterFatigue = doc.CreateAttribute("fatigue");
                characterFatigue.Value = _fatigue;
                Chtr.Attributes.Append(characterFatigue);
                XmlAttribute characterWounds = doc.CreateAttribute("wounds");
                characterWounds.Value = _wounds;
                Chtr.Attributes.Append(characterWounds);

                Character.AppendChild(Chtr);
                doc.Save(_filename);
                MessageBox.Show("Record for " + _name + " saved in ITL directory of C:\\");
            }
        }
                    

    }


}
