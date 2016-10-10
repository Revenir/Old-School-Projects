//
//          Program:                      Sebastian Rock     (Lab 4)    
//
//          Description:                  Creates five dice and allows the user to roll them 3 times before
//                                        restarting.    
//
//          Program history:   
//
//                      Date            Programmer              Change   
//                      -------      ------------------      -----------
//                      4/20/2014      Sebastian Rock       Program written   
// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Application
{
    public partial class Form1 : Form
    {
        int rollCount = 0;
        Dice dicePool = new Dice();

        public void CreateDice()
        {
            Die dieOne = new Die();
            Die dieTwo = new Die();
            Die dieThree = new Die();
            Die dieFour = new Die();
            Die dieFive = new Die();

            dicePool.addDie(dieOne);
            dicePool.addDie(dieTwo);
            dicePool.addDie(dieThree);
            dicePool.addDie(dieFour);
            dicePool.addDie(dieFive);

        }

        public void RollDie(bool? isHeld, Label DieValue, int index, Dice dicePool)
        {
            if (isHeld == false)
            {
                dicePool.dieAt(index).Roll();
                DieValue.Text = dicePool.dieAt(index).SideUp.ToString();
            }

        }
        public Form1()
        {
            InitializeComponent();
            CreateDice();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;

            rollCount += 1;

            chkHoldDie1.Enabled = true;
            chkHoldDie2.Enabled = true;
            chkHoldDie3.Enabled = true;
            chkHoldDie4.Enabled = true;
            chkHoldDie5.Enabled = true;

            RollDie(chkHoldDie1.Checked, lblDie1, 0, dicePool);
            RollDie(chkHoldDie2.Checked, lblDie2, 1, dicePool);
            RollDie(chkHoldDie3.Checked, lblDie3, 2, dicePool);
            RollDie(chkHoldDie4.Checked, lblDie4, 3, dicePool);
            RollDie(chkHoldDie5.Checked, lblDie5, 4, dicePool);

            if (rollCount >= 3)
                btnRoll.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkHoldDie1.Enabled = false;
            chkHoldDie2.Enabled = false;
            chkHoldDie3.Enabled = false;
            chkHoldDie4.Enabled = false;
            chkHoldDie5.Enabled = false;

            chkHoldDie1.Checked = false;
            chkHoldDie2.Checked = false;
            chkHoldDie3.Checked = false;
            chkHoldDie4.Checked = false;
            chkHoldDie5.Checked = false;

            lblDie1.Text = String.Empty;
            lblDie2.Text = String.Empty;
            lblDie3.Text = String.Empty;
            lblDie4.Text = String.Empty;
            lblDie5.Text = String.Empty;

            rollCount = 0;
            btnRoll.Enabled = true;
            btnReset.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDie1_Click(object sender, EventArgs e)
        {

        }
    }
}
