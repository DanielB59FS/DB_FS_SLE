
namespace Saiph_Level_Editor
{
    partial class SaiphLevelEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaiphLevelEditor));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.lbNodes = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.nudAmount = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.gbPosition = new System.Windows.Forms.GroupBox();
			this.lblYPos = new System.Windows.Forms.Label();
			this.lblXPos = new System.Windows.Forms.Label();
			this.nudYPosition = new System.Windows.Forms.NumericUpDown();
			this.nudXPosition = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.nudWaitTime = new System.Windows.Forms.NumericUpDown();
			this.cbEnemyType = new System.Windows.Forms.ComboBox();
			this.lblWaitTime = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nudInterval = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
			this.gbPosition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudYPosition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudXPosition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWaitTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(909, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
			this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(909, 600);
			this.splitContainer1.SplitterDistance = 600;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.lbNodes);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer2.Size = new System.Drawing.Size(303, 598);
			this.splitContainer2.SplitterDistance = 320;
			this.splitContainer2.TabIndex = 0;
			// 
			// lbNodes
			// 
			this.lbNodes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNodes.FormattingEnabled = true;
			this.lbNodes.Location = new System.Drawing.Point(0, 0);
			this.lbNodes.Name = "lbNodes";
			this.lbNodes.Size = new System.Drawing.Size(303, 320);
			this.lbNodes.TabIndex = 1;
			this.lbNodes.SelectedIndexChanged += new System.EventHandler(this.lbNodes_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnRemove);
			this.groupBox1.Controls.Add(this.nudAmount);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.gbPosition);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.nudWaitTime);
			this.groupBox1.Controls.Add(this.cbEnemyType);
			this.groupBox1.Controls.Add(this.lblWaitTime);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.nudInterval);
			this.groupBox1.Location = new System.Drawing.Point(7, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(287, 268);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Spawn Node Attributes";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(182, 239);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(98, 23);
			this.btnUpdate.TabIndex = 15;
			this.btnUpdate.Text = "Update Node";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(183, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Milliseconds";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(82, 239);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(98, 23);
			this.btnRemove.TabIndex = 14;
			this.btnRemove.Text = "Remove Node";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// nudAmount
			// 
			this.nudAmount.Location = new System.Drawing.Point(79, 207);
			this.nudAmount.Name = "nudAmount";
			this.nudAmount.Size = new System.Drawing.Size(98, 20);
			this.nudAmount.TabIndex = 8;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(5, 239);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add Node";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Amount:";
			// 
			// gbPosition
			// 
			this.gbPosition.Controls.Add(this.lblYPos);
			this.gbPosition.Controls.Add(this.lblXPos);
			this.gbPosition.Controls.Add(this.nudYPosition);
			this.gbPosition.Controls.Add(this.nudXPosition);
			this.gbPosition.Location = new System.Drawing.Point(7, 19);
			this.gbPosition.Name = "gbPosition";
			this.gbPosition.Size = new System.Drawing.Size(242, 48);
			this.gbPosition.TabIndex = 0;
			this.gbPosition.TabStop = false;
			this.gbPosition.Text = "Position";
			// 
			// lblYPos
			// 
			this.lblYPos.AutoSize = true;
			this.lblYPos.Location = new System.Drawing.Point(135, 21);
			this.lblYPos.Name = "lblYPos";
			this.lblYPos.Size = new System.Drawing.Size(17, 13);
			this.lblYPos.TabIndex = 3;
			this.lblYPos.Text = "Y:";
			// 
			// lblXPos
			// 
			this.lblXPos.AutoSize = true;
			this.lblXPos.Location = new System.Drawing.Point(23, 21);
			this.lblXPos.Name = "lblXPos";
			this.lblXPos.Size = new System.Drawing.Size(17, 13);
			this.lblXPos.TabIndex = 2;
			this.lblXPos.Text = "X:";
			// 
			// nudYPosition
			// 
			this.nudYPosition.Location = new System.Drawing.Point(158, 19);
			this.nudYPosition.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
			this.nudYPosition.Name = "nudYPosition";
			this.nudYPosition.Size = new System.Drawing.Size(68, 20);
			this.nudYPosition.TabIndex = 1;
			this.nudYPosition.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudYPosition.ValueChanged += new System.EventHandler(this.nudYPosition_ValueChanged);
			// 
			// nudXPosition
			// 
			this.nudXPosition.Location = new System.Drawing.Point(46, 19);
			this.nudXPosition.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
			this.nudXPosition.Name = "nudXPosition";
			this.nudXPosition.Size = new System.Drawing.Size(68, 20);
			this.nudXPosition.TabIndex = 0;
			this.nudXPosition.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudXPosition.ValueChanged += new System.EventHandler(this.nudXPosition_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Enemy Type:";
			// 
			// nudWaitTime
			// 
			this.nudWaitTime.Location = new System.Drawing.Point(79, 85);
			this.nudWaitTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudWaitTime.Name = "nudWaitTime";
			this.nudWaitTime.Size = new System.Drawing.Size(98, 20);
			this.nudWaitTime.TabIndex = 1;
			// 
			// cbEnemyType
			// 
			this.cbEnemyType.FormattingEnabled = true;
			this.cbEnemyType.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
			this.cbEnemyType.Location = new System.Drawing.Point(79, 165);
			this.cbEnemyType.Name = "cbEnemyType";
			this.cbEnemyType.Size = new System.Drawing.Size(98, 21);
			this.cbEnemyType.TabIndex = 6;
			this.cbEnemyType.SelectedIndexChanged += new System.EventHandler(this.cbEnemyType_SelectedIndexChanged);
			// 
			// lblWaitTime
			// 
			this.lblWaitTime.AutoSize = true;
			this.lblWaitTime.Location = new System.Drawing.Point(15, 87);
			this.lblWaitTime.Name = "lblWaitTime";
			this.lblWaitTime.Size = new System.Drawing.Size(58, 13);
			this.lblWaitTime.TabIndex = 2;
			this.lblWaitTime.Text = "Wait Time:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Interval:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(183, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Milliseconds";
			// 
			// nudInterval
			// 
			this.nudInterval.DecimalPlaces = 1;
			this.nudInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.nudInterval.Location = new System.Drawing.Point(79, 125);
			this.nudInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudInterval.Name = "nudInterval";
			this.nudInterval.Size = new System.Drawing.Size(98, 20);
			this.nudInterval.TabIndex = 4;
			// 
			// SaiphLevelEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 624);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SaiphLevelEditor";
			this.Text = "Saiph Level Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaiphLevelEditor_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
			this.gbPosition.ResumeLayout(false);
			this.gbPosition.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudYPosition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudXPosition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWaitTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lbNodes;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.NumericUpDown nudYPosition;
        private System.Windows.Forms.NumericUpDown nudXPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWaitTime;
        private System.Windows.Forms.ComboBox cbEnemyType;
        private System.Windows.Forms.Label lblWaitTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

