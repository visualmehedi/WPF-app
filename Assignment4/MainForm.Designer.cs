namespace Assignment4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datetimecombolabel = new System.Windows.Forms.Label();
            this.priorityenumlabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPrio = new System.Windows.Forms.ComboBox();
            this.deslabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ReminderBox = new System.Windows.Forms.GroupBox();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.prioritylabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.hourlabel = new System.Windows.Forms.Label();
            this.TodoListBox = new System.Windows.Forms.ListBox();
            this.timerlabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.ReminderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(598, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newToolStripMenuItem.Text = "New datafile";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openToolStripMenuItem.Text = "Open datafile";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveToolStripMenuItem.Text = "Save datafile";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // datetimecombolabel
            // 
            this.datetimecombolabel.AutoSize = true;
            this.datetimecombolabel.Location = new System.Drawing.Point(12, 46);
            this.datetimecombolabel.Name = "datetimecombolabel";
            this.datetimecombolabel.Size = new System.Drawing.Size(73, 13);
            this.datetimecombolabel.TabIndex = 1;
            this.datetimecombolabel.Text = "Date and time";
            // 
            // priorityenumlabel
            // 
            this.priorityenumlabel.AutoSize = true;
            this.priorityenumlabel.Location = new System.Drawing.Point(421, 46);
            this.priorityenumlabel.Name = "priorityenumlabel";
            this.priorityenumlabel.Size = new System.Drawing.Size(38, 13);
            this.priorityenumlabel.TabIndex = 2;
            this.priorityenumlabel.Text = "Priority";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyy-MM-dd    HH:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(131, 43);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // comboBoxPrio
            // 
            this.comboBoxPrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrio.FormattingEnabled = true;
            this.comboBoxPrio.Location = new System.Drawing.Point(465, 43);
            this.comboBoxPrio.Name = "comboBoxPrio";
            this.comboBoxPrio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrio.TabIndex = 4;
            this.comboBoxPrio.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrio_SelectedIndexChanged);
            // 
            // deslabel
            // 
            this.deslabel.AutoSize = true;
            this.deslabel.Location = new System.Drawing.Point(12, 80);
            this.deslabel.Name = "deslabel";
            this.deslabel.Size = new System.Drawing.Size(37, 13);
            this.deslabel.TabIndex = 5;
            this.deslabel.Text = "To Do";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(83, 77);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(503, 20);
            this.DescriptionBox.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(208, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(191, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReminderBox
            // 
            this.ReminderBox.Controls.Add(this.descriptionlabel);
            this.ReminderBox.Controls.Add(this.prioritylabel);
            this.ReminderBox.Controls.Add(this.datelabel);
            this.ReminderBox.Controls.Add(this.hourlabel);
            this.ReminderBox.Controls.Add(this.TodoListBox);
            this.ReminderBox.Location = new System.Drawing.Point(15, 147);
            this.ReminderBox.Name = "ReminderBox";
            this.ReminderBox.Size = new System.Drawing.Size(571, 154);
            this.ReminderBox.TabIndex = 8;
            this.ReminderBox.TabStop = false;
            this.ReminderBox.Text = "To Do Reminder";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.Location = new System.Drawing.Point(347, 25);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionlabel.TabIndex = 11;
            this.descriptionlabel.Text = "Description";
            // 
            // prioritylabel
            // 
            this.prioritylabel.AutoSize = true;
            this.prioritylabel.Location = new System.Drawing.Point(153, 25);
            this.prioritylabel.Name = "prioritylabel";
            this.prioritylabel.Size = new System.Drawing.Size(38, 13);
            this.prioritylabel.TabIndex = 10;
            this.prioritylabel.Text = "Priority";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(27, 25);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(30, 13);
            this.datelabel.TabIndex = 9;
            this.datelabel.Text = "Date";
            // 
            // hourlabel
            // 
            this.hourlabel.AutoSize = true;
            this.hourlabel.Location = new System.Drawing.Point(79, 25);
            this.hourlabel.Name = "hourlabel";
            this.hourlabel.Size = new System.Drawing.Size(30, 13);
            this.hourlabel.TabIndex = 1;
            this.hourlabel.Text = "Hour";
            // 
            // TodoListBox
            // 
            this.TodoListBox.FormattingEnabled = true;
            this.TodoListBox.Location = new System.Drawing.Point(6, 41);
            this.TodoListBox.Name = "TodoListBox";
            this.TodoListBox.Size = new System.Drawing.Size(559, 108);
            this.TodoListBox.TabIndex = 0;
            // 
            // timerlabel
            // 
            this.timerlabel.AutoSize = true;
            this.timerlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.timerlabel.Location = new System.Drawing.Point(505, 304);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(46, 22);
            this.timerlabel.TabIndex = 9;
            this.timerlabel.Text = "timer";
            this.timerlabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 335);
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.ReminderBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.deslabel);
            this.Controls.Add(this.comboBoxPrio);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.priorityenumlabel);
            this.Controls.Add(this.datetimecombolabel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ReminderBox.ResumeLayout(false);
            this.ReminderBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label datetimecombolabel;
        private System.Windows.Forms.Label priorityenumlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxPrio;
        private System.Windows.Forms.Label deslabel;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox ReminderBox;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Label prioritylabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label hourlabel;
        private System.Windows.Forms.ListBox TodoListBox;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timer;
    }
}

