namespace CurceRPVS.View
{
    partial class Setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelTable = new System.Windows.Forms.LinkLabel();
            this.linkLabelGraf = new System.Windows.Forms.LinkLabel();
            this.linkLabelOther = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarLine = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTable = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxMass = new System.Windows.Forms.CheckBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxV = new System.Windows.Forms.CheckBox();
            this.checkBoxQ = new System.Windows.Forms.CheckBox();
            this.checkBoxW = new System.Windows.Forms.CheckBox();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelGraf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLine)).BeginInit();
            this.panelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelTable);
            this.groupBox1.Controls.Add(this.linkLabelGraf);
            this.groupBox1.Controls.Add(this.linkLabelOther);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // linkLabelTable
            // 
            this.linkLabelTable.AutoSize = true;
            this.linkLabelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelTable.Location = new System.Drawing.Point(9, 123);
            this.linkLabelTable.Name = "linkLabelTable";
            this.linkLabelTable.Size = new System.Drawing.Size(121, 29);
            this.linkLabelTable.TabIndex = 2;
            this.linkLabelTable.TabStop = true;
            this.linkLabelTable.Text = "Таблица";
            this.linkLabelTable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabelGraf
            // 
            this.linkLabelGraf.AutoSize = true;
            this.linkLabelGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelGraf.Location = new System.Drawing.Point(9, 69);
            this.linkLabelGraf.Name = "linkLabelGraf";
            this.linkLabelGraf.Size = new System.Drawing.Size(105, 29);
            this.linkLabelGraf.TabIndex = 1;
            this.linkLabelGraf.TabStop = true;
            this.linkLabelGraf.Text = "График";
            this.linkLabelGraf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelOther
            // 
            this.linkLabelOther.AutoSize = true;
            this.linkLabelOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelOther.Location = new System.Drawing.Point(9, 16);
            this.linkLabelOther.Name = "linkLabelOther";
            this.linkLabelOther.Size = new System.Drawing.Size(100, 29);
            this.linkLabelOther.TabIndex = 0;
            this.linkLabelOther.TabStop = true;
            this.linkLabelOther.Text = "Общие";
            this.linkLabelOther.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelTable);
            this.groupBox2.Controls.Add(this.buttonCancel);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.panelGraf);
            this.groupBox2.Location = new System.Drawing.Point(164, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 466);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(6, 437);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(317, 437);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Применить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelGraf
            // 
            this.panelGraf.Controls.Add(this.label3);
            this.panelGraf.Controls.Add(this.checkBoxY);
            this.panelGraf.Controls.Add(this.checkBoxX);
            this.panelGraf.Controls.Add(this.trackBarLine);
            this.panelGraf.Controls.Add(this.label2);
            this.panelGraf.Controls.Add(this.button1);
            this.panelGraf.Controls.Add(this.label1);
            this.panelGraf.Location = new System.Drawing.Point(13, 346);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(376, 85);
            this.panelGraf.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отображение линейной сетки по ...";
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY.Location = new System.Drawing.Point(159, 172);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(165, 28);
            this.checkBoxY.TabIndex = 4;
            this.checkBoxY.Text = "координате Оу";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxX.Location = new System.Drawing.Point(159, 138);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(166, 28);
            this.checkBoxX.TabIndex = 3;
            this.checkBoxX.Text = "координате Ох";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цвет линии";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarLine
            // 
            this.trackBarLine.Location = new System.Drawing.Point(159, 50);
            this.trackBarLine.Maximum = 8;
            this.trackBarLine.Minimum = 1;
            this.trackBarLine.Name = "trackBarLine";
            this.trackBarLine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarLine.Size = new System.Drawing.Size(115, 45);
            this.trackBarLine.TabIndex = 2;
            this.trackBarLine.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarLine.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Толщина линии";
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.checkBoxE);
            this.panelTable.Controls.Add(this.checkBoxW);
            this.panelTable.Controls.Add(this.checkBoxQ);
            this.panelTable.Controls.Add(this.checkBoxV);
            this.panelTable.Controls.Add(this.checkBoxC);
            this.panelTable.Controls.Add(this.label4);
            this.panelTable.Controls.Add(this.checkBoxMass);
            this.panelTable.Controls.Add(this.checkBoxTime);
            this.panelTable.Location = new System.Drawing.Point(6, 13);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(383, 276);
            this.panelTable.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отображение линейной сетки по ...";
            // 
            // checkBoxMass
            // 
            this.checkBoxMass.AutoSize = true;
            this.checkBoxMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMass.Location = new System.Drawing.Point(58, 69);
            this.checkBoxMass.Name = "checkBoxMass";
            this.checkBoxMass.Size = new System.Drawing.Size(136, 28);
            this.checkBoxMass.TabIndex = 2;
            this.checkBoxMass.Text = "масса груза";
            this.checkBoxMass.UseVisualStyleBackColor = true;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTime.Location = new System.Drawing.Point(58, 35);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(189, 28);
            this.checkBoxTime.TabIndex = 1;
            this.checkBoxTime.Text = "время измерения";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxC.Location = new System.Drawing.Point(58, 171);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(234, 28);
            this.checkBoxC.TabIndex = 5;
            this.checkBoxC.Text = "коэфициент затухания";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxV
            // 
            this.checkBoxV.AutoSize = true;
            this.checkBoxV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxV.Location = new System.Drawing.Point(58, 137);
            this.checkBoxV.Name = "checkBoxV";
            this.checkBoxV.Size = new System.Drawing.Size(112, 28);
            this.checkBoxV.TabIndex = 4;
            this.checkBoxV.Text = "скорость";
            this.checkBoxV.UseVisualStyleBackColor = true;
            // 
            // checkBoxQ
            // 
            this.checkBoxQ.AutoSize = true;
            this.checkBoxQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxQ.Location = new System.Drawing.Point(58, 103);
            this.checkBoxQ.Name = "checkBoxQ";
            this.checkBoxQ.Size = new System.Drawing.Size(213, 28);
            this.checkBoxQ.TabIndex = 3;
            this.checkBoxQ.Text = "конечный результат";
            this.checkBoxQ.UseVisualStyleBackColor = true;
            // 
            // checkBoxW
            // 
            this.checkBoxW.AutoSize = true;
            this.checkBoxW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxW.Location = new System.Drawing.Point(58, 205);
            this.checkBoxW.Name = "checkBoxW";
            this.checkBoxW.Size = new System.Drawing.Size(185, 28);
            this.checkBoxW.TabIndex = 6;
            this.checkBoxW.Text = "круговая частота";
            this.checkBoxW.UseVisualStyleBackColor = true;
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxE.Location = new System.Drawing.Point(58, 239);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(212, 28);
            this.checkBoxE.TabIndex = 7;
            this.checkBoxE.Text = "параметр затухания";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Text = "Свойство";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelGraf.ResumeLayout(false);
            this.panelGraf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLine)).EndInit();
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabelTable;
        private System.Windows.Forms.LinkLabel linkLabelGraf;
        private System.Windows.Forms.LinkLabel linkLabelOther;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelGraf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.CheckBox checkBoxW;
        private System.Windows.Forms.CheckBox checkBoxQ;
        private System.Windows.Forms.CheckBox checkBoxV;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxMass;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.TrackBar trackBarLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxE;
    }
}