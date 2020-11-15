namespace SkillCheck
{
    partial class SkillCheck
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_DoGen = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pcb_DoGen = new System.Windows.Forms.PictureBox();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.pnl_BoxCollider = new System.Windows.Forms.Panel();
            this.pnl_PipeCollider = new System.Windows.Forms.Panel();
            this.pnl_GreatBoxCollider = new System.Windows.Forms.Panel();
            this.pnl_BackGroundCollision = new System.Windows.Forms.Panel();
            this.timer_Generator = new System.Windows.Forms.Timer(this.components);
            this.timer_Controls = new System.Windows.Forms.Timer(this.components);
            this.btn_Check = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_DoGen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_Main.Controls.Add(this.btn_Check);
            this.pnl_Main.Controls.Add(this.pnl_GreatBoxCollider);
            this.pnl_Main.Controls.Add(this.pnl_BoxCollider);
            this.pnl_Main.Controls.Add(this.pnl_PipeCollider);
            this.pnl_Main.Controls.Add(this.pnl_BackGroundCollision);
            this.pnl_Main.Controls.Add(this.lbl_Progress);
            this.pnl_Main.Controls.Add(this.pcb_DoGen);
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.lbl_DoGen);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(986, 635);
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_DoGen
            // 
            this.lbl_DoGen.AutoSize = true;
            this.lbl_DoGen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoGen.ForeColor = System.Drawing.Color.White;
            this.lbl_DoGen.Location = new System.Drawing.Point(3, 85);
            this.lbl_DoGen.Name = "lbl_DoGen";
            this.lbl_DoGen.Size = new System.Drawing.Size(162, 32);
            this.lbl_DoGen.TabIndex = 0;
            this.lbl_DoGen.Text = "Fazer Gerador";
            this.lbl_DoGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(938, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(45, 45);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pcb_DoGen
            // 
            this.pcb_DoGen.BackColor = System.Drawing.Color.Transparent;
            this.pcb_DoGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_DoGen.Image = global::SkillCheck.Properties.Resources.AlavancaTransp;
            this.pcb_DoGen.Location = new System.Drawing.Point(-33, 120);
            this.pcb_DoGen.Name = "pcb_DoGen";
            this.pcb_DoGen.Size = new System.Drawing.Size(175, 193);
            this.pcb_DoGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_DoGen.TabIndex = 2;
            this.pcb_DoGen.TabStop = false;
            this.pcb_DoGen.Click += new System.EventHandler(this.pcb_DoGen_Click);
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Progress.ForeColor = System.Drawing.Color.White;
            this.lbl_Progress.Location = new System.Drawing.Point(12, 325);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(144, 32);
            this.lbl_Progress.TabIndex = 3;
            this.lbl_Progress.Text = "Progresso: 0";
            this.lbl_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Progress.Visible = false;
            // 
            // pnl_BoxCollider
            // 
            this.pnl_BoxCollider.BackColor = System.Drawing.Color.Teal;
            this.pnl_BoxCollider.Location = new System.Drawing.Point(820, 248);
            this.pnl_BoxCollider.Name = "pnl_BoxCollider";
            this.pnl_BoxCollider.Size = new System.Drawing.Size(35, 65);
            this.pnl_BoxCollider.TabIndex = 4;
            this.pnl_BoxCollider.Visible = false;
            // 
            // pnl_PipeCollider
            // 
            this.pnl_PipeCollider.BackColor = System.Drawing.Color.Red;
            this.pnl_PipeCollider.Location = new System.Drawing.Point(737, 520);
            this.pnl_PipeCollider.Name = "pnl_PipeCollider";
            this.pnl_PipeCollider.Size = new System.Drawing.Size(200, 10);
            this.pnl_PipeCollider.TabIndex = 7;
            this.pnl_PipeCollider.Visible = false;
            // 
            // pnl_GreatBoxCollider
            // 
            this.pnl_GreatBoxCollider.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_GreatBoxCollider.Location = new System.Drawing.Point(820, 251);
            this.pnl_GreatBoxCollider.Name = "pnl_GreatBoxCollider";
            this.pnl_GreatBoxCollider.Size = new System.Drawing.Size(35, 25);
            this.pnl_GreatBoxCollider.TabIndex = 6;
            this.pnl_GreatBoxCollider.Visible = false;
            // 
            // pnl_BackGroundCollision
            // 
            this.pnl_BackGroundCollision.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_BackGroundCollision.Location = new System.Drawing.Point(820, 42);
            this.pnl_BackGroundCollision.Name = "pnl_BackGroundCollision";
            this.pnl_BackGroundCollision.Size = new System.Drawing.Size(35, 534);
            this.pnl_BackGroundCollision.TabIndex = 7;
            this.pnl_BackGroundCollision.Visible = false;
            // 
            // timer_Generator
            // 
            this.timer_Generator.Interval = 1000;
            this.timer_Generator.Tick += new System.EventHandler(this.timer_Generator_Tick);
            // 
            // timer_Controls
            // 
            this.timer_Controls.Interval = 15;
            this.timer_Controls.Tick += new System.EventHandler(this.timer_Controls_Tick);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.Color.Silver;
            this.btn_Check.Location = new System.Drawing.Point(327, 567);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(339, 56);
            this.btn_Check.TabIndex = 8;
            this.btn_Check.Text = "Check! (Ou pressione F)";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Visible = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // SkillCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 635);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SkillCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skill Check";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SkillCheck_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_DoGen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_DoGen;
        private System.Windows.Forms.PictureBox pcb_DoGen;
        private System.Windows.Forms.Panel pnl_GreatBoxCollider;
        private System.Windows.Forms.Panel pnl_PipeCollider;
        private System.Windows.Forms.Panel pnl_BoxCollider;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.Panel pnl_BackGroundCollision;
        private System.Windows.Forms.Timer timer_Generator;
        private System.Windows.Forms.Timer timer_Controls;
        private System.Windows.Forms.Button btn_Check;
    }
}

