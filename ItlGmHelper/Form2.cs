using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ItlGmHelper
{
    public partial class Form2 : Form
    {
        public bool checker=false;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetAll();
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear registry of all items
            ClearAll();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //help explanation box
            MessageBox.Show("You may use this setup option to personalize the results of your encounters and treasure.  "+Environment.NewLine+
            "When you fill in all the information contained in the setup screen, it will be stored." + Environment.NewLine +
            "Afterwards when passages and chambers are generated, they will be using the creatures " + Environment.NewLine +
            "and items you've chosen.  The application will substitute orcs, snakes, dragons, and such " + Environment.NewLine +
            "if you have not performed this setup.", 
            "Important Setup Note for ITL GM Helper", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Exclamation, 
            MessageBoxDefaultButton.Button1);           
        }

        private void btnClearSaved_Click(object sender, EventArgs e)
        {
            ClearRegistry();

        }

        public void SetAll()
        {
            Validator();
            if (checker != true)
            {
                //set Easy
                RegistryKey reg = Registry.CurrentUser.CreateSubKey("SOFTWARE\\NallWare\\ITL\\ItlGmHelper");
                reg.SetValue("CreatureE1", tbEasy1.Text);
                reg.SetValue("FromE1", tbEFrom1.Text);
                reg.SetValue("ToE1", tbEto1.Text);
                reg.SetValue("CreatureE2", tbEasy2.Text);
                reg.SetValue("FromE2", tbEFrom2.Text);
                reg.SetValue("ToE2", tbEto2.Text);
                reg.SetValue("CreatureE3", tbEasy3.Text);
                reg.SetValue("FromE3", tbEFrom3.Text);
                reg.SetValue("ToE3", tbEto3.Text);
                reg.SetValue("CreatureE4", tbEasy4.Text);
                reg.SetValue("FromE4", tbEFrom4.Text);
                reg.SetValue("ToE4", tbEto4.Text);
                reg.SetValue("CreatureE5", tbEasy5.Text);
                reg.SetValue("FromE5", tbEFrom5.Text);
                reg.SetValue("ToE5", tbEto5.Text);
                reg.SetValue("CreatureE6", tbEasy6.Text);
                reg.SetValue("FromE6", tbEFrom6.Text);
                reg.SetValue("ToE6", tbEto6.Text);
                reg.SetValue("CreatureE7", tbEasy8.Text);
                reg.SetValue("FromE7", tbEFrom8.Text);
                reg.SetValue("ToE7", tbEto8.Text);
                reg.SetValue("CreatureE9", tbEasy9.Text);
                reg.SetValue("FromE9", tbEFrom9.Text);
                reg.SetValue("ToE9", tbEto9.Text);
                reg.SetValue("CreatureE10", tbEasy10.Text);
                reg.SetValue("FromE10", tbEFrom10.Text);
                reg.SetValue("ToE10", tbEto10.Text);

                //set Moderate           
                reg.SetValue("CreatureM1", tbMod1.Text);
                reg.SetValue("FromM1", tbMFrom1.Text);
                reg.SetValue("ToM1", tbMto1.Text);
                reg.SetValue("CreatureM2", tbMod2.Text);
                reg.SetValue("FromM2", tbMFrom2.Text);
                reg.SetValue("ToM2", tbMto2.Text);
                reg.SetValue("CreatureM3", tbMod3.Text);
                reg.SetValue("FromM3", tbMFrom3.Text);
                reg.SetValue("ToM3", tbMto3.Text);
                reg.SetValue("CreatureM4", tbMod4.Text);
                reg.SetValue("FromM4", tbMFrom4.Text);
                reg.SetValue("ToM4", tbMto4.Text);
                reg.SetValue("CreatureM5", tbMod5.Text);
                reg.SetValue("FromM5", tbMFrom5.Text);
                reg.SetValue("ToM5", tbMto5.Text);
                reg.SetValue("CreatureM6", tbMod6.Text);
                reg.SetValue("FromM6", tbMFrom6.Text);
                reg.SetValue("ToM6", tbMto6.Text);
                reg.SetValue("CreatureM7", tbMod8.Text);
                reg.SetValue("FromM7", tbMFrom8.Text);
                reg.SetValue("ToM7", tbMto8.Text);
                reg.SetValue("CreatureM9", tbMod9.Text);
                reg.SetValue("FromM9", tbMFrom9.Text);
                reg.SetValue("ToM9", tbMto9.Text);
                reg.SetValue("CreatureM10", tbMod10.Text);
                reg.SetValue("FromM10", tbMFrom10.Text);
                reg.SetValue("ToM10", tbMto10.Text);


                //set Difficult            
                reg.SetValue("CreatureD1", tbDif1.Text);
                reg.SetValue("FromD1", tbDFrom1.Text);
                reg.SetValue("ToD1", tbDto1.Text);
                reg.SetValue("CreatureD2", tbDif2.Text);
                reg.SetValue("FromD2", tbDFrom2.Text);
                reg.SetValue("ToD2", tbDto2.Text);
                reg.SetValue("CreatureD3", tbDif3.Text);
                reg.SetValue("FromD3", tbDFrom3.Text);
                reg.SetValue("ToD3", tbDto3.Text);
                reg.SetValue("CreatureD4", tbDif4.Text);
                reg.SetValue("FromD4", tbDFrom4.Text);
                reg.SetValue("ToD4", tbDto4.Text);
                reg.SetValue("CreatureD5", tbDif5.Text);
                reg.SetValue("FromD5", tbDFrom5.Text);
                reg.SetValue("ToD5", tbDto5.Text);
                reg.SetValue("CreatureD6", tbDif6.Text);
                reg.SetValue("FromD6", tbDFrom6.Text);
                reg.SetValue("ToD6", tbDto6.Text);
                reg.SetValue("CreatureD7", tbDif8.Text);
                reg.SetValue("FromD7", tbDFrom8.Text);
                reg.SetValue("ToD7", tbDto8.Text);
                reg.SetValue("CreatureD9", tbDif9.Text);
                reg.SetValue("FromD9", tbDFrom9.Text);
                reg.SetValue("ToD9", tbDto9.Text);
                reg.SetValue("CreatureD10", tbDif10.Text);
                reg.SetValue("FromD10", tbDFrom10.Text);
                reg.SetValue("ToD10", tbDto10.Text);

                //set Wandering           
                reg.SetValue("CreatureW1", tbWan1.Text);
                reg.SetValue("FromW1", tbWFrom1.Text);
                reg.SetValue("ToW1", tbWto1.Text);
                reg.SetValue("CreatureW2", tbWan2.Text);
                reg.SetValue("FromW2", tbWFrom2.Text);
                reg.SetValue("ToW2", tbWto2.Text);
                reg.SetValue("CreatureW3", tbWan3.Text);
                reg.SetValue("FromW3", tbWFrom3.Text);
                reg.SetValue("ToW3", tbWto3.Text);
                reg.SetValue("CreatureW4", tbWan4.Text);
                reg.SetValue("FromW4", tbWFrom4.Text);
                reg.SetValue("ToW4", tbWto4.Text);
                reg.SetValue("CreatureW5", tbWan5.Text);
                reg.SetValue("FromW5", tbWFrom5.Text);
                reg.SetValue("ToW5", tbWto5.Text);
                reg.SetValue("CreatureW6", tbWan6.Text);
                reg.SetValue("FromW6", tbWFrom6.Text);
                reg.SetValue("ToW6", tbWto6.Text);
                reg.SetValue("CreatureW7", tbWan8.Text);
                reg.SetValue("FromW7", tbWFrom8.Text);
                reg.SetValue("ToW7", tbWto8.Text);
                reg.SetValue("CreatureW9", tbWan9.Text);
                reg.SetValue("FromW9", tbWFrom9.Text);
                reg.SetValue("ToW9", tbWto9.Text);
                reg.SetValue("CreatureW10", tbWan10.Text);
                reg.SetValue("FromW10", tbWFrom10.Text);
                reg.SetValue("ToW10", tbWto10.Text);

                //set treasure
                reg.SetValue("Gem1", tbGem1a.Text);
                reg.SetValue("GemValue1", tbGem1b.Text);
                reg.SetValue("Gem2", tbGem2a.Text);
                reg.SetValue("GemValue2", tbGem2b.Text);
                reg.SetValue("Gem3", tbGem3a.Text);
                reg.SetValue("GemValue3", tbGem3b.Text);
                reg.SetValue("Gem4", tbGem4a.Text);
                reg.SetValue("GemValue4", tbGem4b.Text);
                reg.SetValue("Gem5", tbGem5a.Text);
                reg.SetValue("GemValue5", tbGem5b.Text);
                reg.SetValue("Gem6", tbGem6a.Text);
                reg.SetValue("GemValue6", tbGem6b.Text);


                reg.SetValue("Potion1", tbPotion1a.Text);
                reg.SetValue("PotionValue1", tbPotion1b.Text);
                reg.SetValue("Potion2", tbPotion2a.Text);
                reg.SetValue("PotionValue2", tbPotion2b.Text);
                reg.SetValue("Potion3", tbPotion3a.Text);
                reg.SetValue("PotionValue3", tbPotion3b.Text);
                reg.SetValue("Potion4", tbPotion4a.Text);
                reg.SetValue("PotionValue4", tbPotion4b.Text);
                reg.SetValue("Potion5", tbPotion5a.Text);
                reg.SetValue("PotionValue5", tbPotion5b.Text);
                reg.SetValue("Potion6", tbPotion6a.Text);
                reg.SetValue("PotionValue6", tbPotion6b.Text);

                reg.SetValue("Lesser1", tbLesser1a.Text);
                reg.SetValue("LesserValue1", tbLesser1b.Text);
                reg.SetValue("Lesser2", tbLesser2a.Text);
                reg.SetValue("LesserValue2", tbLesser2b.Text);
                reg.SetValue("Lesser3", tbLesser3a.Text);
                reg.SetValue("LesserValue3", tbLesser3b.Text);
                reg.SetValue("Lesser4", tbLesser4a.Text);
                reg.SetValue("LesserValue4", tbLesser4b.Text);
                reg.SetValue("Lesser5", tbLesser5a.Text);
                reg.SetValue("LesserValue5", tbLesser5b.Text);
                reg.SetValue("Lesser6", tbLesser6a.Text);
                reg.SetValue("LesserValue6", tbLesser6b.Text);

                reg.SetValue("Greater1", tbGreater1a.Text);
                reg.SetValue("GreaterValue1", tbGreater1b.Text);
                reg.SetValue("Greater2", tbGreater2a.Text);
                reg.SetValue("GreaterValue2", tbGreater2b.Text);
                reg.SetValue("Greater3", tbGreater3a.Text);
                reg.SetValue("GreaterValue3", tbGreater3b.Text);
                reg.SetValue("Greater4", tbGreater4a.Text);
                reg.SetValue("GreaterValue4", tbGreater4b.Text);
                reg.SetValue("Greater5", tbGreater5a.Text);
                reg.SetValue("GreaterValue5", tbGreater5b.Text);
                reg.SetValue("Greater6", tbGreater6a.Text);
                reg.SetValue("GreaterValue6", tbGreater6b.Text);
                reg.Close();
                MessageBox.Show("All items have been saved.");
            }
            else
            {
                MessageBox.Show("All boxes must be filled in.");
                checker = false;
            }

        }

        


        public void ClearAll()
        {
            tbEasy1.Text = "";  tbEFrom1.Text = "";  tbEto1.Text = "";
            tbEasy2.Text = "";  tbEFrom2.Text = "";  tbEto2.Text = "";
            tbEasy3.Text = "";  tbEFrom3.Text = "";  tbEto3.Text = "";
            tbEasy4.Text = ""; tbEFrom4.Text = ""; tbEto4.Text = "";
            tbEasy5.Text = ""; tbEFrom5.Text = ""; tbEto5.Text = "";
            tbEasy6.Text = ""; tbEFrom6.Text = ""; tbEto6.Text = "";
            tbEasy7.Text = ""; tbEFrom7.Text = ""; tbEto7.Text = "";
            tbEasy8.Text = ""; tbEFrom8.Text = ""; tbEto8.Text = "";
            tbEasy9.Text = ""; tbEFrom9.Text = ""; tbEto9.Text = "";
            tbEasy10.Text = ""; tbEFrom10.Text = ""; tbEto10.Text = "";

            tbMod1.Text = ""; tbMFrom1.Text = ""; tbMto1.Text = "";
            tbMod2.Text = ""; tbMFrom2.Text = ""; tbMto2.Text = "";
            tbMod3.Text = ""; tbMFrom3.Text = ""; tbMto3.Text = "";
            tbMod4.Text = ""; tbMFrom4.Text = ""; tbMto4.Text = "";
            tbMod5.Text = ""; tbMFrom5.Text = ""; tbMto5.Text = "";
            tbMod6.Text = ""; tbMFrom6.Text = ""; tbMto6.Text = "";
            tbMod7.Text = ""; tbMFrom7.Text = ""; tbMto7.Text = "";
            tbMod8.Text = ""; tbMFrom8.Text = ""; tbMto8.Text = "";
            tbMod9.Text = ""; tbMFrom9.Text = ""; tbMto9.Text = "";
            tbMod10.Text = ""; tbMFrom10.Text = ""; tbMto10.Text = "";

            tbDif1.Text = ""; tbDFrom1.Text = ""; tbDto1.Text = "";
            tbDif2.Text = ""; tbDFrom2.Text = ""; tbDto2.Text = "";
            tbDif3.Text = ""; tbDFrom3.Text = ""; tbDto3.Text = "";
            tbDif4.Text = ""; tbDFrom4.Text = ""; tbDto4.Text = "";
            tbDif5.Text = ""; tbDFrom5.Text = ""; tbDto5.Text = "";
            tbDif6.Text = ""; tbDFrom6.Text = ""; tbDto6.Text = "";
            tbDif7.Text = ""; tbDFrom7.Text = ""; tbDto7.Text = "";
            tbDif8.Text = ""; tbDFrom8.Text = ""; tbDto8.Text = "";
            tbDif9.Text = ""; tbDFrom9.Text = ""; tbDto9.Text = "";
            tbDif10.Text = ""; tbDFrom10.Text = ""; tbDto10.Text = "";
            

            tbWan1.Text = ""; tbWFrom1.Text = ""; tbWto1.Text = "";
            tbWan2.Text = ""; tbWFrom2.Text = ""; tbWto2.Text = "";
            tbWan3.Text = ""; tbWFrom3.Text = ""; tbWto3.Text = "";
            tbWan4.Text = ""; tbWFrom4.Text = ""; tbWto4.Text = "";
            tbWan5.Text = ""; tbWFrom5.Text = ""; tbWto5.Text = "";
            tbWan6.Text = ""; tbWFrom6.Text = ""; tbWto6.Text = "";
            tbWan7.Text = ""; tbWFrom7.Text = ""; tbWto7.Text = "";
            tbWan8.Text = ""; tbWFrom8.Text = ""; tbWto8.Text = "";
            tbWan9.Text = ""; tbWFrom9.Text = ""; tbWto9.Text = "";
            tbWan10.Text = ""; tbWFrom10.Text = ""; tbWto10.Text = "";
            
            tbGem1a.Text = ""; tbGem1b.Text = "";
            tbGem2a.Text = ""; tbGem2b.Text = "";
            tbGem3a.Text = ""; tbGem3b.Text = "";
            tbGem4a.Text = ""; tbGem4b.Text = "";
            tbGem5a.Text = ""; tbGem5b.Text = "";
            tbGem6a.Text = ""; tbGem6b.Text = "";

            tbPotion1a.Text = ""; tbPotion1b.Text = "";
            tbPotion2a.Text = ""; tbPotion2b.Text = "";
            tbPotion3a.Text = ""; tbPotion3b.Text = "";
            tbPotion4a.Text = ""; tbPotion4b.Text = "";
            tbPotion5a.Text = ""; tbPotion5b.Text = "";
            tbPotion6a.Text = ""; tbPotion6b.Text = "";

            tbLesser1a.Text = ""; tbLesser1b.Text = "";
            tbLesser2a.Text = ""; tbLesser2b.Text = "";
            tbLesser3a.Text = ""; tbLesser3b.Text = "";
            tbLesser4a.Text = ""; tbLesser4b.Text = "";
            tbLesser5a.Text = ""; tbLesser5b.Text = "";
            tbLesser6a.Text = ""; tbLesser6b.Text = "";

            tbGreater1a.Text = ""; tbGreater1b.Text = "";
            tbGreater2a.Text = ""; tbGreater2b.Text = "";
            tbGreater3a.Text = ""; tbGreater3b.Text = "";
            tbGreater4a.Text = ""; tbGreater4b.Text = "";
            tbGreater5a.Text = ""; tbGreater5b.Text = "";
            tbGreater6a.Text = ""; tbGreater6b.Text = "";

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }


        public void Validator()
        {
            if (tbEasy1.Text == "" || tbEFrom1.Text == "" || tbEto1.Text == "") {checker=true;}
            if (tbEasy2.Text == "" ||tbEFrom2.Text == ""|| tbEto2.Text == "") {checker=true;}
            if (tbEasy3.Text == "" ||tbEFrom3.Text == ""|| tbEto3.Text == "") {checker=true;}
            if (tbEasy4.Text == "" ||tbEFrom4.Text == ""||tbEto4.Text == "") {checker=true;}
            if (tbEasy5.Text == "" ||tbEFrom5.Text == ""|| tbEto5.Text == "") {checker=true;}
            if (tbEasy6.Text == "" ||tbEFrom6.Text == ""|| tbEto6.Text == "") {checker=true;}

            if (tbMod1.Text == ""|| tbMFrom1.Text == ""|| tbMto1.Text == "") {checker=true;}
            if (tbMod2.Text == ""|| tbMFrom2.Text == ""|| tbMto2.Text == "") {checker=true;}
            if (tbMod3.Text == ""|| tbMFrom3.Text == ""|| tbMto3.Text == "") {checker=true;}
            if (tbMod4.Text == ""||tbMFrom4.Text == ""|| tbMto4.Text == "") {checker=true;}
            if (tbMod5.Text == ""||tbMFrom5.Text == ""|| tbMto5.Text == "") {checker=true;}
            if (tbMod6.Text == ""||tbMFrom6.Text == ""|| tbMto6.Text == "") {checker=true;}

            if (tbDif1.Text == ""||tbDFrom1.Text == ""|| tbDto1.Text == "") {checker=true;}
            if (tbDif2.Text == ""||tbDFrom2.Text == ""|| tbDto2.Text == "") {checker=true;}
            if (tbDif3.Text == ""||tbDFrom3.Text == ""|| tbDto3.Text == "") {checker=true;}
            if (tbDif4.Text == ""||tbDFrom4.Text == ""|| tbDto4.Text == "") {checker=true;}
            if (tbDif5.Text == ""||tbDFrom5.Text == ""|| tbDto5.Text == "") {checker=true;}
            if (tbDif6.Text == ""||tbDFrom6.Text == ""|| tbDto6.Text == "") {checker=true;}

            if (tbWan1.Text == ""||tbWFrom1.Text == ""|| tbWto1.Text == "") {checker=true;}
            if (tbWan2.Text == ""||tbWFrom2.Text == ""|| tbWto2.Text == "") {checker=true;}
            if (tbWan3.Text == ""||tbWFrom3.Text == ""|| tbWto3.Text == "") {checker=true;}
            if (tbWan4.Text == ""||tbWFrom4.Text == ""|| tbWto4.Text == "") {checker=true;}
            if (tbWan5.Text == ""||tbWFrom5.Text == ""|| tbWto5.Text == "") {checker=true;}
            if (tbWan6.Text == ""||tbWFrom6.Text == ""|| tbWto6.Text == "") {checker=true;}

            if (tbGem1a.Text == ""|| tbGem1b.Text == "") {checker=true;}
            if (tbGem2a.Text == ""|| tbGem2b.Text == "") {checker=true;}
            if (tbGem3a.Text == ""|| tbGem3b.Text == "") {checker=true;}
            if (tbGem4a.Text == ""||tbGem4b.Text == "") {checker=true;}
            if (tbGem5a.Text == ""|| tbGem5b.Text == "") {checker=true;}
            if (tbGem6a.Text == ""|| tbGem6b.Text == "") {checker=true;}

            if (tbPotion1a.Text == ""|| tbPotion1b.Text == "") {checker=true;}
            if (tbPotion2a.Text == ""|| tbPotion2b.Text == "") {checker=true;}
            if (tbPotion3a.Text == ""|| tbPotion3b.Text == "") {checker=true;}
            if (tbPotion4a.Text == ""|| tbPotion4b.Text == "") {checker=true;}
            if (tbPotion5a.Text == ""|| tbPotion5b.Text == "") {checker=true;}
            if (tbPotion6a.Text == ""||tbPotion6b.Text == "") {checker=true;}

            if (tbLesser1a.Text == ""|| tbLesser1b.Text == "") {checker=true;}
            if (tbLesser2a.Text == ""|| tbLesser2b.Text == "") {checker=true;}
            if (tbLesser3a.Text == ""|| tbLesser3b.Text == "") {checker=true;}
            if (tbLesser4a.Text == ""|| tbLesser4b.Text == "") {checker=true;}
            if (tbLesser5a.Text == ""|| tbLesser5b.Text == "") {checker=true;}
            if (tbLesser6a.Text == ""|| tbLesser6b.Text == "") {checker=true;}

            if (tbGreater1a.Text == ""|| tbGreater1b.Text == "") {checker=true;}
            if (tbGreater2a.Text == ""|| tbGreater2b.Text == "") {checker=true;}
            if (tbGreater3a.Text == ""|| tbGreater3b.Text == "") {checker=true;}
            if (tbGreater4a.Text == ""|| tbGreater4b.Text == "") {checker=true;}
            if (tbGreater5a.Text == ""|| tbGreater5b.Text == "") {checker=true;}
            if (tbGreater6a.Text == "" || tbGreater6b.Text == "") {checker=true;}
        }


        public void ClearRegistry()
        {
            using (RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Nallware\\ITL\\", true))
            {
                if (regkey.OpenSubKey("ItlGmHelper") != null)
                {
                    regkey.DeleteSubKeyTree("ItlGmHelper");
                }
            }            
            MessageBox.Show("All saved items have been cleared.");
        }

     






    }
}
