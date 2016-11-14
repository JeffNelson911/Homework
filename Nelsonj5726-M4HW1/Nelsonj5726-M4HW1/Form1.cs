using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelsonj5726_M4HW1
{
    public partial class bestiaryForm : Form
    {
        int count = 0;
        NPC madman;
        NPC guard;
        Monster goblin;
        Monster corruptedEmpireSoldier;
        private List<MobileObject> enemyList = new List<MobileObject>();

        public bestiaryForm()
        {
            InitializeComponent();
            madman = new NPC("A raving madman",5, 5, 1, 1, 1, 0, true, false);
            guard = new NPC("Guard", 10, 10, 4, 3, 4, 5, true, false);
            goblin = new Monster("A skulking goblin", 5, 5, 1, 2, 2, 0, true, false);
            corruptedEmpireSoldier = new Monster("A corrupted soldier of the empire", 15, 15, 6, 4, 5, 3, true, false);
            enemyList.Add(madman);
            enemyList.Add(guard);
            enemyList.Add(goblin);
            enemyList.Add(corruptedEmpireSoldier);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            count++;
            if (count == enemyList.Count)
            {
                count = 0;
            }
            displayTextbox.Clear();
            displayTextbox.AppendText("Name: " + enemyList[count].Name);
            displayTextbox.AppendText("\nHP: " + enemyList[count].maxHP.ToString());
            displayTextbox.AppendText("\nAttack: " + enemyList[count].attack.ToString());
            displayTextbox.AppendText("\nDamage: " + enemyList[count].damage.ToString());
            if (enemyList[count].canAttack)
            {
                displayTextbox.AppendText("\nThis creature is hostile.");
            }
            else
            {
                displayTextbox.AppendText("\nThis creature is not aggressive.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
