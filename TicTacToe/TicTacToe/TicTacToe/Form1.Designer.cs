namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrajZnovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.štejOdZačetkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomočToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stetjeZmagaX = new System.Windows.Forms.Label();
            this.stetjeDraw = new System.Windows.Forms.Label();
            this.stetjeZmagaO = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.casomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.pomočToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igrajZnovaToolStripMenuItem,
            this.štejOdZačetkaToolStripMenuItem,
            this.zapriToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // igrajZnovaToolStripMenuItem
            // 
            this.igrajZnovaToolStripMenuItem.Name = "igrajZnovaToolStripMenuItem";
            this.igrajZnovaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.igrajZnovaToolStripMenuItem.Text = "Igraj znova :)";
            this.igrajZnovaToolStripMenuItem.Click += new System.EventHandler(this.igrajZnovaToolStripMenuItem_Click);
            // 
            // štejOdZačetkaToolStripMenuItem
            // 
            this.štejOdZačetkaToolStripMenuItem.Name = "štejOdZačetkaToolStripMenuItem";
            this.štejOdZačetkaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.štejOdZačetkaToolStripMenuItem.Text = "Štej od začetka";
            this.štejOdZačetkaToolStripMenuItem.Click += new System.EventHandler(this.štejOdZačetkaToolStripMenuItem_Click);
            // 
            // zapriToolStripMenuItem
            // 
            this.zapriToolStripMenuItem.Name = "zapriToolStripMenuItem";
            this.zapriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zapriToolStripMenuItem.Text = "Zapri :(";
            this.zapriToolStripMenuItem.Click += new System.EventHandler(this.zapriToolStripMenuItem_Click);
            // 
            // pomočToolStripMenuItem
            // 
            this.pomočToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omeniToolStripMenuItem});
            this.pomočToolStripMenuItem.Name = "pomočToolStripMenuItem";
            this.pomočToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomočToolStripMenuItem.Text = "Pomoč";
            // 
            // omeniToolStripMenuItem
            // 
            this.omeniToolStripMenuItem.Name = "omeniToolStripMenuItem";
            this.omeniToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.omeniToolStripMenuItem.Text = "O aplikaciji";
            this.omeniToolStripMenuItem.Click += new System.EventHandler(this.omeniToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(34, 48);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.pritisk_gumb);
            this.A1.MouseEnter += new System.EventHandler(this.vGumb);
            this.A1.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(115, 48);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.pritisk_gumb);
            this.A2.MouseEnter += new System.EventHandler(this.vGumb);
            this.A2.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(196, 48);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.pritisk_gumb);
            this.A3.MouseEnter += new System.EventHandler(this.vGumb);
            this.A3.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(34, 129);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.pritisk_gumb);
            this.B1.MouseEnter += new System.EventHandler(this.vGumb);
            this.B1.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(115, 129);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.pritisk_gumb);
            this.B2.MouseEnter += new System.EventHandler(this.vGumb);
            this.B2.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(196, 129);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.pritisk_gumb);
            this.B3.MouseEnter += new System.EventHandler(this.vGumb);
            this.B3.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(115, 210);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.pritisk_gumb);
            this.C2.MouseEnter += new System.EventHandler(this.vGumb);
            this.C2.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(34, 210);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.pritisk_gumb);
            this.C1.MouseEnter += new System.EventHandler(this.vGumb);
            this.C1.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(196, 210);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.pritisk_gumb);
            this.C3.MouseEnter += new System.EventHandler(this.vGumb);
            this.C3.MouseLeave += new System.EventHandler(this.izGumb);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 48);
            this.label1.MaximumSize = new System.Drawing.Size(68, 16);
            this.label1.MinimumSize = new System.Drawing.Size(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ZMAGA: X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 48);
            this.label2.MaximumSize = new System.Drawing.Size(81, 16);
            this.label2.MinimumSize = new System.Drawing.Size(81, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "DRAW";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 48);
            this.label3.MaximumSize = new System.Drawing.Size(69, 16);
            this.label3.MinimumSize = new System.Drawing.Size(69, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "ZMAGA: O";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stetjeZmagaX
            // 
            this.stetjeZmagaX.AutoSize = true;
            this.stetjeZmagaX.Location = new System.Drawing.Point(333, 74);
            this.stetjeZmagaX.Name = "stetjeZmagaX";
            this.stetjeZmagaX.Size = new System.Drawing.Size(13, 13);
            this.stetjeZmagaX.TabIndex = 14;
            this.stetjeZmagaX.Text = "0";
            // 
            // stetjeDraw
            // 
            this.stetjeDraw.AutoSize = true;
            this.stetjeDraw.Location = new System.Drawing.Point(410, 74);
            this.stetjeDraw.Name = "stetjeDraw";
            this.stetjeDraw.Size = new System.Drawing.Size(13, 13);
            this.stetjeDraw.TabIndex = 15;
            this.stetjeDraw.Text = "0";
            // 
            // stetjeZmagaO
            // 
            this.stetjeZmagaO.AutoSize = true;
            this.stetjeZmagaO.Location = new System.Drawing.Point(494, 74);
            this.stetjeZmagaO.Name = "stetjeZmagaO";
            this.stetjeZmagaO.Size = new System.Drawing.Size(13, 13);
            this.stetjeZmagaO.TabIndex = 16;
            this.stetjeZmagaO.Text = "0";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(452, 322);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 22;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(312, 229);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 23;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(312, 262);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 24;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // casomer
            // 
            this.casomer.Location = new System.Drawing.Point(402, 244);
            this.casomer.Name = "casomer";
            this.casomer.Size = new System.Drawing.Size(59, 20);
            this.casomer.TabIndex = 25;
            this.casomer.Text = "0";
            this.casomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "SEC";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(552, 357);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.casomer);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stetjeZmagaO);
            this.Controls.Add(this.stetjeDraw);
            this.Controls.Add(this.stetjeZmagaX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomočToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrajZnovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapriToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stetjeZmagaX;
        private System.Windows.Forms.Label stetjeDraw;
        private System.Windows.Forms.Label stetjeZmagaO;
        private System.Windows.Forms.ToolStripMenuItem štejOdZačetkaToolStripMenuItem;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox casomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

