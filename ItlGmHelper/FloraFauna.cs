using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace ItlGmHelper
{
    class FloraFauna
    {        
        Form1 f1 = new Form1();
        public string _name, _type, _subtype, _st, _dx, _iq, _ma, _armor, _hitstop, _dxmod, _weapon, _dmgdie, _dmgmod, _talents, _notes;
        public ObservableCollection<string> _attacker = new ObservableCollection<string>();
        public ObservableCollection<string> _defender = new ObservableCollection<string>();
            public bool SaveChar(string _filename, string _name, string type, string subtype, string _st, string _dx, string _iq, string _ma, string _type, string _subtype, string _weapon, string _dmgdie, string _dmgmod, string _armor, string _hitstop, string _dxmod, string _talents, string _notes)  
            {   
                try
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
                        XmlAttribute characterType = doc.CreateAttribute("type");
                        characterType.Value = _type;
                        Chtr.Attributes.Append(characterType);
                        XmlAttribute characterSubType = doc.CreateAttribute("subtype");
                        characterSubType.Value = _subtype;
                        Chtr.Attributes.Append(characterSubType);
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
                        XmlAttribute characterTalents = doc.CreateAttribute("talents");
                        characterTalents.Value = _talents;
                        Chtr.Attributes.Append(characterTalents);
                        XmlAttribute characterNotes = doc.CreateAttribute("notes");
                        characterNotes.Value = _notes;
                        Chtr.Attributes.Append(characterNotes);                        
                        Character.AppendChild(Chtr);
                        doc.Save(_filename);
                        MessageBox.Show("Record for " + _name + " saved in ITL directory of C:\\");
                    }

                        //xml files exists--add to file
                    else if (File.Exists(_filename))
                    {
                        XmlDocument doc = new XmlDocument();//capture elements and save in .xml file
                        doc.Load(_filename);
                        XmlNode Character = doc.GetElementsByTagName("FloraFauna")[0];
                        XmlNode Chtr = doc.CreateElement("Opponent");
                        XmlAttribute characterName = doc.CreateAttribute("name");
                        characterName.Value = _name;
                        Chtr.Attributes.Append(characterName);
                        XmlAttribute characterType = doc.CreateAttribute("type");
                        characterType.Value = _type;
                        Chtr.Attributes.Append(characterType);
                        XmlAttribute characterSubType = doc.CreateAttribute("subtype");
                        characterSubType.Value = _subtype;
                        Chtr.Attributes.Append(characterSubType);
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
                        XmlAttribute characterTalents = doc.CreateAttribute("talents");
                        characterTalents.Value = _talents;
                        Chtr.Attributes.Append(characterTalents);
                        XmlAttribute characterNotes = doc.CreateAttribute("notes");
                        characterNotes.Value = _notes;
                        Chtr.Attributes.Append(characterNotes);

                        Character.AppendChild(Chtr);
                        doc.Save(_filename);
                        MessageBox.Show("Record for " + _name + " saved.");
                    }
                }
                catch
                {
                    MessageBox.Show("Record for " + _name + " failed to save.");
                    return false;
                }
                return true;
            }



            
            

              public List<string> LoadChar(string _filename, string _name) //Fetches character stats from xml file and loads to the textboxes
        {
            try
            {  
                List<string> _opponent = new List<string>();
                XmlDocument doc = new XmlDocument();
                doc.Load(_filename);
                XmlNode _currNode = doc.SelectSingleNode("/FloraFauna/Opponent[@name='" + _name + "']");

                //get xml values to variable

                _name = _currNode.Attributes["name"].Value;
                _type = _currNode.Attributes["type"].Value;
                _subtype = _currNode.Attributes["subtype"].Value;
                _st = _currNode.Attributes["st"].Value;
                _dx = _currNode.Attributes["dx"].Value;
                _iq = _currNode.Attributes["iq"].Value;
                _ma = _currNode.Attributes["ma"].Value;
                _armor = _currNode.Attributes["armor"].Value;                
                _hitstop = _currNode.Attributes["hitstop"].Value;                
                _dxmod = _currNode.Attributes["dxmod"].Value;                
                _weapon = _currNode.Attributes["weapon"].Value;
                _dmgdie = _currNode.Attributes["dmgdie"].Value;
                _dmgmod = _currNode.Attributes["dmgmod"].Value;                
                _talents = _currNode.Attributes["talents"].Value;
                _notes = _currNode.Attributes["notes"].Value;

                _opponent.Add(_name);
                _opponent.Add(_type);
                _opponent.Add(_subtype);
                _opponent.Add(_st);
                _opponent.Add(_dx);
                _opponent.Add(_iq);
                _opponent.Add(_ma);
                _opponent.Add(_armor);
                _opponent.Add(_hitstop);
                _opponent.Add(_dxmod);
                _opponent.Add(_weapon);
                _opponent.Add(_dmgdie);
                _opponent.Add(_dmgmod);
                _opponent.Add(_talents);
                _opponent.Add(_notes);
                return _opponent;
            }
            catch
            {
                return null;
            }
        }


              public void UpdateChar(string _filename, string _name, string type, string subtype, string _st, string _dx, string _iq, string _ma, string _type, string _subtype, string _weapon, string _dmgdie, string _dmgmod, string _armor, string _hitstop, string _dxmod, string _talents, string _notes) //updates the hero to Monsters.xml
              {
                  try
                  {
                      XmlDocument doc = new XmlDocument();
                      doc.Load(_filename);
                      XmlNode _currNode;

                      _currNode = doc.SelectSingleNode("/FloraFauna/Opponent[@name='" + _name + "']");
                      _currNode.Attributes["name"].Value = _name;
                      _currNode.Attributes["type"].Value = _type;
                      _currNode.Attributes["subtype"].Value = _subtype;
                      _currNode.Attributes["st"].Value = _st;
                      _currNode.Attributes["dx"].Value = _dx;
                      _currNode.Attributes["iq"].Value = _iq;
                      _currNode.Attributes["ma"].Value = _ma;
                      _currNode.Attributes["armor"].Value = _armor;
                      _currNode.Attributes["hitstop"].Value = _hitstop;
                      _currNode.Attributes["dxmod"].Value = _dxmod;
                      _currNode.Attributes["weapon"].Value = _weapon;
                      _currNode.Attributes["dmgdie"].Value = _dmgdie;
                      _currNode.Attributes["dmgmod"].Value = _dmgmod;
                      _currNode.Attributes["talents"].Value = _talents;
                      _currNode.Attributes["notes"].Value = _notes;

                      doc.Save(_filename);
                  }
                  catch
                  {

                  }
              }//end UpdateChar



              public void DeleteChar(string _filename, string _name) //deletes Monster from Monsters.xml file
              {
                  try
                  {   
                      XmlDocument xmlDocument = new XmlDocument();
                      xmlDocument.Load(_filename);
                      XmlNode node = xmlDocument.SelectSingleNode("/FloraFauna/Opponent[@name='" + _name + "']");

                      if (node != null)
                      {
                          node.ParentNode.RemoveChild(node);
                          xmlDocument.Save(_filename);
                      }
                     
                  }
                  catch
                  {
                     
                  }
              }


              public bool SaveCombat(string _name, string _st, string _dx, string _iq, string _ma, string _weapon, string _dmgdie, string _dmgmod, string _armor, string _hitstop, string _dxmod)
              {
                  
                  try
                  {
                      //xml files does not yet exist--must create
                      if (!File.Exists(@"C:\ITL\Combat.xml"))
                      {

                        
                          int adjMa = Convert.ToInt16(_ma) + Convert.ToInt16(_dxmod);
                          string _ma2 = Convert.ToString(adjMa);

                          int adjDx = Convert.ToInt16(_dx) + Convert.ToInt16(_dxmod);
                          string _dx2 = Convert.ToString(adjDx);

                          XmlDocument doc = new XmlDocument();
                          XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                          doc.AppendChild(docNode);
                          XmlNode Character = doc.CreateElement("FloraFauna");
                          doc.AppendChild(Character);
                          XmlNode Chtr = doc.CreateElement("Opponent");
                          XmlAttribute characterName = doc.CreateAttribute("Name");
                          characterName.Value = _name;
                          Chtr.Attributes.Append(characterName);                          
                          XmlAttribute characterSt = doc.CreateAttribute("ST");
                          characterSt.Value = _st;
                          Chtr.Attributes.Append(characterSt);
                          XmlAttribute characterCurrSt = doc.CreateAttribute("CurrSt");
                          characterCurrSt.Value = _st;
                          Chtr.Attributes.Append(characterCurrSt);
                          XmlAttribute characterAdjDx = doc.CreateAttribute("AdjDX");
                          characterAdjDx.Value = _dx2;
                          Chtr.Attributes.Append(characterAdjDx);
                          XmlAttribute characterIq = doc.CreateAttribute("IQ");
                          characterIq.Value = _iq;
                          Chtr.Attributes.Append(characterIq);
                          XmlAttribute characterMa = doc.CreateAttribute("MA");
                          characterMa.Value = _ma2;
                          Chtr.Attributes.Append(characterMa);
                          XmlAttribute characterArmor = doc.CreateAttribute("Armor");
                          characterArmor.Value = _armor;
                          Chtr.Attributes.Append(characterArmor);
                          XmlAttribute characterHitStop = doc.CreateAttribute("Hit-stop");
                          characterHitStop.Value = _hitstop;
                          Chtr.Attributes.Append(characterHitStop);
                          XmlAttribute characterDxMod = doc.CreateAttribute("DXmod");
                          characterDxMod.Value = _dxmod;
                          Chtr.Attributes.Append(characterDxMod);
                          XmlAttribute characterWeapon = doc.CreateAttribute("Weapon");
                          characterWeapon.Value = _weapon;
                          Chtr.Attributes.Append(characterWeapon);
                          XmlAttribute characterDmgDie = doc.CreateAttribute("DmgDie");
                          characterDmgDie.Value = _dmgdie;
                          Chtr.Attributes.Append(characterDmgDie);
                          XmlAttribute characterDmgMod = doc.CreateAttribute("DmgMod");
                          characterDmgMod.Value = _dmgmod;
                          Chtr.Attributes.Append(characterDmgMod);                          
                          Character.AppendChild(Chtr);
                          doc.Save(@"C:\ITL\Combat.xml");
                          MessageBox.Show(_name + " added to combat roster");
                      }

                          //xml files exists--add to file
                      else if (File.Exists(@"C:\ITL\Combat.xml"))
                      {
                         
                          int adjMa = Convert.ToInt16(_ma) + Convert.ToInt16(_dxmod);
                          string _ma2 = Convert.ToString(adjMa);

                          int adjDx = Convert.ToInt16(_dx) + Convert.ToInt16(_dxmod);
                          string _dx2 = Convert.ToString(adjDx);


                          XmlDocument doc = new XmlDocument();//capture elements and save in .xml file
                          doc.Load(@"C:\ITL\Combat.xml");
                          XmlNode Character = doc.GetElementsByTagName("FloraFauna")[0];
                          XmlNode Chtr = doc.CreateElement("Opponent");
                          XmlAttribute characterName = doc.CreateAttribute("Name");
                          characterName.Value = _name;
                          Chtr.Attributes.Append(characterName);
                          XmlAttribute characterSt = doc.CreateAttribute("ST");
                          characterSt.Value = _st;
                          Chtr.Attributes.Append(characterSt);
                          XmlAttribute characterCurrSt = doc.CreateAttribute("CurrSt");
                          characterCurrSt.Value = _st;
                          Chtr.Attributes.Append(characterCurrSt);
                          XmlAttribute characterAdjDx = doc.CreateAttribute("AdjDX");
                          characterAdjDx.Value = _dx2;
                          Chtr.Attributes.Append(characterAdjDx);
                          XmlAttribute characterIq = doc.CreateAttribute("IQ");
                          characterIq.Value = _iq;
                          Chtr.Attributes.Append(characterIq);
                          XmlAttribute characterMa = doc.CreateAttribute("MA");
                          characterMa.Value = _ma2;
                          Chtr.Attributes.Append(characterMa);
                          XmlAttribute characterArmor = doc.CreateAttribute("Armor");
                          characterArmor.Value = _armor;
                          Chtr.Attributes.Append(characterArmor);
                          XmlAttribute characterHitStop = doc.CreateAttribute("Hit-stop");
                          characterHitStop.Value = _hitstop;
                          Chtr.Attributes.Append(characterHitStop);
                          XmlAttribute characterDxMod = doc.CreateAttribute("DXmod");
                          characterDxMod.Value = _dxmod;
                          Chtr.Attributes.Append(characterDxMod);
                          XmlAttribute characterWeapon = doc.CreateAttribute("Weapon");
                          characterWeapon.Value = _weapon;
                          Chtr.Attributes.Append(characterWeapon);
                          XmlAttribute characterDmgDie = doc.CreateAttribute("DmgDie");
                          characterDmgDie.Value = _dmgdie;
                          Chtr.Attributes.Append(characterDmgDie);
                          XmlAttribute characterDmgMod = doc.CreateAttribute("DmgMod");
                          characterDmgMod.Value = _dmgmod;
                          Chtr.Attributes.Append(characterDmgMod);
                          Character.AppendChild(Chtr);
                          doc.Save(@"C:\ITL\Combat.xml");
                          MessageBox.Show(_name + " added to combat roster.");
                      }
                  }
                  catch
                  {
                      MessageBox.Show(_name + " failed to add.");
                      return false;
                  }
                  return true;
              }



              //public ObservableCollection<string> Attacker() //populates list of opponents to combobox
              //{
              //    if (File.Exists(@"C:\ITL\Combat.xml"))
              //    {
              //        _attacker.Clear();
              //        XDocument _xmlDoc = XDocument.Load(@"C:\ITL\Combat.xml");
              //        var _attList = from rec in _xmlDoc.Descendants("Opponent").OrderBy(n => n.Attribute("name").Value) select rec.Attribute("name");
              //        _attacker.Add("---");
              //        foreach (string _name in _attList.ToList())
              //        {
              //            _attacker.Add("" + _name);
              //        }

              //        _xmlDoc = XDocument.Load(@"C:\ITL\Combat.xml");
              //        _attList = from rec in _xmlDoc.Descendants("Opponent").OrderBy(n => n.Attribute("name").Value) select rec.Attribute("name");
              //        foreach (string _name in _attList)
              //        {
              //            if (!_attacker.Contains(_name))
              //            {
              //                _attacker.Add("" + _name);
              //            }
              //        }
              //        return _attacker;
              //    }
              //    return null;
              //}

              //public ObservableCollection<string> Defender() //populates list of opponents to combobox
              //{
              //    if (File.Exists(@"C:\ITL\Combat.xml"))
              //    {
              //        _defender.Clear();
              //        XDocument _xmlDoc = XDocument.Load(@"C:\ITL\Combat.xml");
              //        var _defList = from rec in _xmlDoc.Descendants("Opponent").OrderBy(n => n.Attribute("name").Value) select rec.Attribute("name");
              //        _defender.Add("---");
              //        foreach (string _name in _defList.ToList())
              //        {
              //            _defender.Add("" + _name);
              //        }

              //        _xmlDoc = XDocument.Load(@"C:\ITL\Combat.xml");
              //        _defList = from rec in _xmlDoc.Descendants("Opponent").OrderBy(n => n.Attribute("name").Value) select rec.Attribute("name");
              //        foreach (string _name in _defList)
              //        {
              //            if (!_defender.Contains(_name))
              //            {
              //                _defender.Add("" + _name);
              //            }
              //        }
              //        return _defender;
              //    }
              //    return null;
              //}



    }
}
