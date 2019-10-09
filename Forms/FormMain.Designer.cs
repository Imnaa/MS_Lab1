namespace MS_Lab1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelAboutTime = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxAboutTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAvgSpeed = new System.Windows.Forms.TextBox();
            this.textBoxConeyorIdle = new System.Windows.Forms.TextBox();
            this.textBoxAvgSpeedQueue1 = new System.Windows.Forms.TextBox();
            this.textBoxMaxTimeIdleQueue1 = new System.Windows.Forms.TextBox();
            this.textBoxMinTimeIdleQueue1 = new System.Windows.Forms.TextBox();
            this.textBoxAvgSpeedQueue2 = new System.Windows.Forms.TextBox();
            this.textBoxMaxTimeIdleQueue2 = new System.Windows.Forms.TextBox();
            this.textBoxMinTimeIdleQueue2 = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countSection1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countSection2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEquipmentFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelAboutTime
            // 
            resources.ApplyResources(this.labelAboutTime, "labelAboutTime");
            this.labelAboutTime.Name = "labelAboutTime";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.queue1,
            this.queue2,
            this.countSection1,
            this.countSection2,
            this.isEquipmentFree,
            this.equipment});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // textBoxTime
            // 
            resources.ApplyResources(this.textBoxTime, "textBoxTime");
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            // 
            // buttonHelp
            // 
            resources.ApplyResources(this.buttonHelp, "buttonHelp");
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxAboutTask
            // 
            resources.ApplyResources(this.textBoxAboutTask, "textBoxAboutTask");
            this.textBoxAboutTask.Name = "textBoxAboutTask";
            this.textBoxAboutTask.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBoxAvgSpeed
            // 
            resources.ApplyResources(this.textBoxAvgSpeed, "textBoxAvgSpeed");
            this.textBoxAvgSpeed.Name = "textBoxAvgSpeed";
            this.textBoxAvgSpeed.ReadOnly = true;
            // 
            // textBoxConeyorIdle
            // 
            resources.ApplyResources(this.textBoxConeyorIdle, "textBoxConeyorIdle");
            this.textBoxConeyorIdle.Name = "textBoxConeyorIdle";
            this.textBoxConeyorIdle.ReadOnly = true;
            // 
            // textBoxAvgSpeedQueue1
            // 
            resources.ApplyResources(this.textBoxAvgSpeedQueue1, "textBoxAvgSpeedQueue1");
            this.textBoxAvgSpeedQueue1.Name = "textBoxAvgSpeedQueue1";
            this.textBoxAvgSpeedQueue1.ReadOnly = true;
            // 
            // textBoxMaxTimeIdleQueue1
            // 
            resources.ApplyResources(this.textBoxMaxTimeIdleQueue1, "textBoxMaxTimeIdleQueue1");
            this.textBoxMaxTimeIdleQueue1.Name = "textBoxMaxTimeIdleQueue1";
            this.textBoxMaxTimeIdleQueue1.ReadOnly = true;
            // 
            // textBoxMinTimeIdleQueue1
            // 
            resources.ApplyResources(this.textBoxMinTimeIdleQueue1, "textBoxMinTimeIdleQueue1");
            this.textBoxMinTimeIdleQueue1.Name = "textBoxMinTimeIdleQueue1";
            this.textBoxMinTimeIdleQueue1.ReadOnly = true;
            // 
            // textBoxAvgSpeedQueue2
            // 
            resources.ApplyResources(this.textBoxAvgSpeedQueue2, "textBoxAvgSpeedQueue2");
            this.textBoxAvgSpeedQueue2.Name = "textBoxAvgSpeedQueue2";
            this.textBoxAvgSpeedQueue2.ReadOnly = true;
            // 
            // textBoxMaxTimeIdleQueue2
            // 
            resources.ApplyResources(this.textBoxMaxTimeIdleQueue2, "textBoxMaxTimeIdleQueue2");
            this.textBoxMaxTimeIdleQueue2.Name = "textBoxMaxTimeIdleQueue2";
            this.textBoxMaxTimeIdleQueue2.ReadOnly = true;
            // 
            // textBoxMinTimeIdleQueue2
            // 
            resources.ApplyResources(this.textBoxMinTimeIdleQueue2, "textBoxMinTimeIdleQueue2");
            this.textBoxMinTimeIdleQueue2.Name = "textBoxMinTimeIdleQueue2";
            this.textBoxMinTimeIdleQueue2.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // queue1
            // 
            this.queue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.queue1, "queue1");
            this.queue1.Name = "queue1";
            this.queue1.ReadOnly = true;
            // 
            // queue2
            // 
            this.queue2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.queue2, "queue2");
            this.queue2.Name = "queue2";
            this.queue2.ReadOnly = true;
            // 
            // countSection1
            // 
            this.countSection1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.countSection1, "countSection1");
            this.countSection1.Name = "countSection1";
            this.countSection1.ReadOnly = true;
            // 
            // countSection2
            // 
            this.countSection2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.countSection2, "countSection2");
            this.countSection2.Name = "countSection2";
            this.countSection2.ReadOnly = true;
            // 
            // isEquipmentFree
            // 
            this.isEquipmentFree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.isEquipmentFree, "isEquipmentFree");
            this.isEquipmentFree.Name = "isEquipmentFree";
            this.isEquipmentFree.ReadOnly = true;
            // 
            // equipment
            // 
            this.equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.equipment, "equipment");
            this.equipment.Name = "equipment";
            this.equipment.ReadOnly = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMinTimeIdleQueue2);
            this.Controls.Add(this.textBoxMaxTimeIdleQueue2);
            this.Controls.Add(this.textBoxAvgSpeedQueue2);
            this.Controls.Add(this.textBoxMinTimeIdleQueue1);
            this.Controls.Add(this.textBoxMaxTimeIdleQueue1);
            this.Controls.Add(this.textBoxAvgSpeedQueue1);
            this.Controls.Add(this.textBoxConeyorIdle);
            this.Controls.Add(this.textBoxAvgSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelAboutTime);
            this.Controls.Add(this.textBoxAboutTask);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelAboutTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxAboutTask;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAvgSpeed;
        private System.Windows.Forms.TextBox textBoxConeyorIdle;
        private System.Windows.Forms.TextBox textBoxAvgSpeedQueue1;
        private System.Windows.Forms.TextBox textBoxMaxTimeIdleQueue1;
        private System.Windows.Forms.TextBox textBoxMinTimeIdleQueue1;
        private System.Windows.Forms.TextBox textBoxAvgSpeedQueue2;
        private System.Windows.Forms.TextBox textBoxMaxTimeIdleQueue2;
        private System.Windows.Forms.TextBox textBoxMinTimeIdleQueue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn queue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn queue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countSection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countSection2;
        private System.Windows.Forms.DataGridViewTextBoxColumn isEquipmentFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment;
    }
}

