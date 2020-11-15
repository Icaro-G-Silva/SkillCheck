using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCheck
{
    public partial class SkillCheck : Form
    {

        #region Setting some attributes
        private Random random = new Random();
        private Boolean skillAppeared = false;
        private Double progress = 0.0;

        private int yCoordsPipe = 42;
        private int yCoordsBox = 0;
        private int yCoordsGreatBox = 0;

        //1 = Go Forward; 0 = Go backward
        private int pipeDirection = 1;
        private int turns = 0;
        #endregion

        public SkillCheck()
        {
            InitializeComponent();
        }

        #region UserInteractions
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcb_DoGen_Click(object sender, EventArgs e)
        {
            timer_Generator.Start();
            lbl_Progress.Visible = true;
        }
        
        private void btn_Check_Click(object sender, EventArgs e)
        {
            checkSkillCheck();
        }

        private void SkillCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("F")) checkSkillCheck();
        }
        #endregion

        #region Logical Processes
        private void timer_Generator_Tick(object sender, EventArgs e)
        {
            if(progress < 100)
            {
                if (!skillAppeared)
                {
                    if (random.NextDouble() <= 0.085)
                    {
                        btn_Check.Visible = true;
                        pnl_BackGroundCollision.Visible = true;

                        //Box Positioning
                        yCoordsBox = random.Next(32, 400);
                        pnl_BoxCollider.Location = new Point(615, yCoordsBox);
                        
                        //GreatBox Positioning
                        yCoordsGreatBox = random.Next(yCoordsBox, yCoordsBox + 40);
                        pnl_GreatBoxCollider.Location = new Point(615, yCoordsGreatBox);
                        
                        pnl_BoxCollider.Visible = true;
                        pnl_BoxCollider.BringToFront();
                        pnl_GreatBoxCollider.Visible = true;
                        pnl_GreatBoxCollider.BringToFront();
                        pnl_PipeCollider.Visible = true;
                        pnl_PipeCollider.BringToFront();

                        timer_Controls.Start();
                        skillAppeared = true;
                    }
                    progress += 1.25;
                    updateLabel();
                }
            }
            else
            {
                timer_Generator.Stop();
                timer_Controls.Stop();
                resetControls();
                progress = 0.0;
                lbl_Progress.Visible = false;
                MessageBox.Show("Gerador 100% funcional.", "Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer_Controls_Tick(object sender, EventArgs e)
        {
            if (pipeDirection == 1) yCoordsPipe += 5;
            else if (pipeDirection == 0) yCoordsPipe -= 5;

            pnl_PipeCollider.Location = new Point(550, yCoordsPipe);

            if (yCoordsPipe <= 35)
            {
                pipeDirection = 1;
                if (turns == 1) genError();
                turns++;
            }
            else if (yCoordsPipe >= 460) pipeDirection = 0;
        }
        
        private void checkSkillCheck()
        {
            if(skillAppeared)
            {
                if (yCoordsPipe > (yCoordsBox - 15) && yCoordsPipe < (yCoordsBox + 75))
                {
                    if (yCoordsPipe > (yCoordsGreatBox - 5) && yCoordsPipe < (yCoordsGreatBox + 20))
                    {
                        progress += 15.0;
                        updateLabel();
                        resetControls();
                    }
                    else
                    {
                        progress += 8.0;
                        updateLabel();
                        resetControls();
                    }
                }
                else genError();
            }
        }
        #endregion

        #region Utils
        private void hidePanels()
        {
            pnl_BackGroundCollision.Visible = false;
            pnl_BoxCollider.Visible = false;
            pnl_GreatBoxCollider.Visible = false;
            pnl_PipeCollider.Visible = false;
            btn_Check.Visible = false;
        }

        private void resetControls()
        {
            hidePanels();
            timer_Controls.Stop();
            skillAppeared = false;
            turns = 0;
            yCoordsPipe = 42;
        }
        
        private void genError()
        {
            progress -= 20.0;
            if (progress < 0.0) progress = 0.0;
            updateLabel();
            resetControls();
            MessageBox.Show("BOOM!", "Errou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateLabel()
        {
            lbl_Progress.Text = "Progresso: " + progress + "%";
        }
        #endregion
    }
}
