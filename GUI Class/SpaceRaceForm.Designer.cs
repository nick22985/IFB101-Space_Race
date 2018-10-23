namespace GUI_Class
{
    partial class SpaceRaceForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gamereset = new System.Windows.Forms.Button();
            this.RollDice = new System.Windows.Forms.Button();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.singlestep = new System.Windows.Forms.GroupBox();
            this.SingleStepNo = new System.Windows.Forms.RadioButton();
            this.SingleStepYes = new System.Windows.Forms.RadioButton();
            this.spaceracetitle = new System.Windows.Forms.Label();
            this.numberofplayerstext = new System.Windows.Forms.Label();
            this.playerstext = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            this.singlestep.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gamereset);
            this.splitContainer1.Panel2.Controls.Add(this.RollDice);
            this.splitContainer1.Panel2.Controls.Add(this.playersDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.singlestep);
            this.splitContainer1.Panel2.Controls.Add(this.spaceracetitle);
            this.splitContainer1.Panel2.Controls.Add(this.numberofplayerstext);
            this.splitContainer1.Panel2.Controls.Add(this.playerstext);
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Size = new System.Drawing.Size(884, 661);
            this.splitContainer1.SplitterDistance = 664;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel.ColumnCount = 8;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(664, 661);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // gamereset
            // 
            this.gamereset.Location = new System.Drawing.Point(33, 626);
            this.gamereset.Name = "gamereset";
            this.gamereset.Size = new System.Drawing.Size(75, 23);
            this.gamereset.TabIndex = 6;
            this.gamereset.Text = "Game Reset";
            this.gamereset.UseVisualStyleBackColor = true;
            // 
            // RollDice
            // 
            this.RollDice.Location = new System.Drawing.Point(83, 597);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(75, 23);
            this.RollDice.TabIndex = 0;
            this.RollDice.Text = "Roll Dice";
            this.RollDice.UseVisualStyleBackColor = true;
            this.RollDice.Click += new System.EventHandler(this.RollDice_Click);
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Location = new System.Drawing.Point(18, 125);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.Size = new System.Drawing.Size(176, 124);
            this.playersDataGridView.TabIndex = 5;
            // 
            // singlestep
            // 
            this.singlestep.Controls.Add(this.SingleStepNo);
            this.singlestep.Controls.Add(this.SingleStepYes);
            this.singlestep.Location = new System.Drawing.Point(45, 354);
            this.singlestep.Name = "singlestep";
            this.singlestep.Size = new System.Drawing.Size(133, 54);
            this.singlestep.TabIndex = 4;
            this.singlestep.TabStop = false;
            this.singlestep.Text = "Single Step?";
            // 
            // SingleStepNo
            // 
            this.SingleStepNo.AutoSize = true;
            this.SingleStepNo.Location = new System.Drawing.Point(74, 19);
            this.SingleStepNo.Name = "SingleStepNo";
            this.SingleStepNo.Size = new System.Drawing.Size(39, 17);
            this.SingleStepNo.TabIndex = 1;
            this.SingleStepNo.TabStop = true;
            this.SingleStepNo.Text = "No";
            this.SingleStepNo.UseVisualStyleBackColor = true;
            // 
            // SingleStepYes
            // 
            this.SingleStepYes.AutoSize = true;
            this.SingleStepYes.Location = new System.Drawing.Point(25, 19);
            this.SingleStepYes.Name = "SingleStepYes";
            this.SingleStepYes.Size = new System.Drawing.Size(43, 17);
            this.SingleStepYes.TabIndex = 0;
            this.SingleStepYes.TabStop = true;
            this.SingleStepYes.Text = "Yes";
            this.SingleStepYes.UseVisualStyleBackColor = true;
            // 
            // spaceracetitle
            // 
            this.spaceracetitle.AutoSize = true;
            this.spaceracetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.spaceracetitle.Location = new System.Drawing.Point(39, 9);
            this.spaceracetitle.Name = "spaceracetitle";
            this.spaceracetitle.Size = new System.Drawing.Size(155, 31);
            this.spaceracetitle.TabIndex = 1;
            this.spaceracetitle.Text = "SpaceRace";
            // 
            // numberofplayerstext
            // 
            this.numberofplayerstext.AutoSize = true;
            this.numberofplayerstext.Location = new System.Drawing.Point(15, 51);
            this.numberofplayerstext.Name = "numberofplayerstext";
            this.numberofplayerstext.Size = new System.Drawing.Size(93, 13);
            this.numberofplayerstext.TabIndex = 2;
            this.numberofplayerstext.Text = "Number of Players";
            // 
            // playerstext
            // 
            this.playerstext.AutoSize = true;
            this.playerstext.Location = new System.Drawing.Point(87, 89);
            this.playerstext.Name = "playerstext";
            this.playerstext.Size = new System.Drawing.Size(41, 13);
            this.playerstext.TabIndex = 3;
            this.playerstext.Text = "Players";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(119, 626);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SpaceRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SpaceRaceForm";
            this.Text = "Space Race";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            this.singlestep.ResumeLayout(false);
            this.singlestep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label spaceracetitle;
        private System.Windows.Forms.Label numberofplayerstext;
        private System.Windows.Forms.Label playerstext;
        private System.Windows.Forms.GroupBox singlestep;
        private System.Windows.Forms.RadioButton SingleStepNo;
        private System.Windows.Forms.RadioButton SingleStepYes;
        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.Button gamereset;
    }
}

