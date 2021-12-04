namespace mcramcalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.playersBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pluginsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverRamBox = new System.Windows.Forms.TextBox();
            this.versionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.isWorldPregenerated = new System.Windows.Forms.CheckBox();
            this.isWorldSmall = new System.Windows.Forms.CheckBox();
            this.genSettingsQ = new System.Windows.Forms.CheckBox();
            this.isCracked = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.worldPregenQ = new System.Windows.Forms.CheckBox();
            this.optimizedSettingsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.playersBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pluginsBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.serverRamBox);
            this.panel1.Controls.Add(this.versionBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 174);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Players";
            // 
            // playersBox
            // 
            this.playersBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.playersBox.FormattingEnabled = true;
            this.playersBox.Items.AddRange(new object[] {
            "0-5",
            "6-10",
            "11-20",
            "21-50",
            "51-99",
            "100+"});
            this.playersBox.Location = new System.Drawing.Point(123, 62);
            this.playersBox.Name = "playersBox";
            this.playersBox.Size = new System.Drawing.Size(121, 23);
            this.playersBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plugins";
            // 
            // pluginsBox
            // 
            this.pluginsBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.pluginsBox.FormattingEnabled = true;
            this.pluginsBox.Items.AddRange(new object[] {
            "0-10 ",
            "11-20 (R)",
            "21-39",
            "40+"});
            this.pluginsBox.Location = new System.Drawing.Point(123, 37);
            this.pluginsBox.Name = "pluginsBox";
            this.pluginsBox.Size = new System.Drawing.Size(121, 23);
            this.pluginsBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minecraft Version";
            // 
            // serverRamBox
            // 
            this.serverRamBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.serverRamBox.Location = new System.Drawing.Point(120, 142);
            this.serverRamBox.Name = "serverRamBox";
            this.serverRamBox.Size = new System.Drawing.Size(100, 23);
            this.serverRamBox.TabIndex = 4;
            this.serverRamBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // versionBox
            // 
            this.versionBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Items.AddRange(new object[] {
            "1.8",
            "1.9",
            "1.10",
            "1.11",
            "1.12",
            "1.13",
            "1.14",
            "1.15",
            "1.16",
            "1.17",
            "1.18"});
            this.versionBox.Location = new System.Drawing.Point(123, 12);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(121, 23);
            this.versionBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server RAM in MB";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.isWorldPregenerated);
            this.panel2.Controls.Add(this.isWorldSmall);
            this.panel2.Controls.Add(this.genSettingsQ);
            this.panel2.Controls.Add(this.isCracked);
            this.panel2.Controls.Add(this.calculate);
            this.panel2.Location = new System.Drawing.Point(584, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 174);
            this.panel2.TabIndex = 1;
            // 
            // isWorldPregenerated
            // 
            this.isWorldPregenerated.AutoSize = true;
            this.isWorldPregenerated.Location = new System.Drawing.Point(14, 39);
            this.isWorldPregenerated.Name = "isWorldPregenerated";
            this.isWorldPregenerated.Size = new System.Drawing.Size(142, 19);
            this.isWorldPregenerated.TabIndex = 6;
            this.isWorldPregenerated.Text = "is World Pregenerated";
            this.isWorldPregenerated.UseVisualStyleBackColor = true;
            // 
            // isWorldSmall
            // 
            this.isWorldSmall.AutoSize = true;
            this.isWorldSmall.Location = new System.Drawing.Point(14, 64);
            this.isWorldSmall.Name = "isWorldSmall";
            this.isWorldSmall.Size = new System.Drawing.Size(101, 19);
            this.isWorldSmall.TabIndex = 5;
            this.isWorldSmall.Text = "is World 5GB+";
            this.isWorldSmall.UseVisualStyleBackColor = true;
            // 
            // genSettingsQ
            // 
            this.genSettingsQ.AutoSize = true;
            this.genSettingsQ.Enabled = false;
            this.genSettingsQ.Location = new System.Drawing.Point(14, 116);
            this.genSettingsQ.Name = "genSettingsQ";
            this.genSettingsQ.Size = new System.Drawing.Size(178, 19);
            this.genSettingsQ.TabIndex = 3;
            this.genSettingsQ.Text = "Generate optimized settings?";
            this.genSettingsQ.UseVisualStyleBackColor = true;
            // 
            // isCracked
            // 
            this.isCracked.AutoSize = true;
            this.isCracked.Location = new System.Drawing.Point(14, 14);
            this.isCracked.Name = "isCracked";
            this.isCracked.Size = new System.Drawing.Size(141, 19);
            this.isCracked.TabIndex = 1;
            this.isCracked.Text = "is Cracked? (waterfall)";
            this.isCracked.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.White;
            this.calculate.Location = new System.Drawing.Point(14, 141);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(175, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate!";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // worldPregenQ
            // 
            this.worldPregenQ.Location = new System.Drawing.Point(0, 0);
            this.worldPregenQ.Name = "worldPregenQ";
            this.worldPregenQ.Size = new System.Drawing.Size(104, 24);
            this.worldPregenQ.TabIndex = 0;
            // 
            // optimizedSettingsLabel
            // 
            this.optimizedSettingsLabel.AutoSize = true;
            this.optimizedSettingsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optimizedSettingsLabel.Location = new System.Drawing.Point(12, 12);
            this.optimizedSettingsLabel.Name = "optimizedSettingsLabel";
            this.optimizedSettingsLabel.Size = new System.Drawing.Size(0, 17);
            this.optimizedSettingsLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 194);
            this.Controls.Add(this.optimizedSettingsLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 233);
            this.MinimumSize = new System.Drawing.Size(816, 233);
            this.Name = "Form1";
            this.Text = "Minecraft RAM Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button calculate;
        private Label label1;
        private TextBox serverRamBox;
        private ComboBox versionBox;
        private CheckBox genSettingsQ;
        private CheckBox isCracked;
        private Label label2;
        private Label label5;
        private ComboBox playersBox;
        private Label label3;
        private ComboBox pluginsBox;
        private CheckBox isWorldSmall;
        private CheckBox worldPregenQ;
        private CheckBox isWorldPregenerated;
        private Label optimizedSettingsLabel;
    }
}