namespace CurceRPVS.View
{
    partial class Options
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
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxQuotSpring = new System.Windows.Forms.TextBox();
            this.textBoxQuatFading = new System.Windows.Forms.TextBox();
            this.comboBoxMass = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.comboBoxQuotSpring = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTimeStep = new System.Windows.Forms.ComboBox();
            this.textBoxTimeStep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxQuatFading = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(358, 217);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(84, 26);
            this.save.TabIndex = 10;
            this.save.Text = "Применить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(154, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Масса груза:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начальное положение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(102, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Начальная скорость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Коэффициент жесткости пружины:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(72, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Коэффициент затухания:";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(253, 8);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(117, 20);
            this.textBoxMass.TabIndex = 0;
            this.textBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valid_KeyPress);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(253, 36);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(117, 20);
            this.textBoxPosition.TabIndex = 2;
            this.textBoxPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valid_KeyPress);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(253, 63);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(117, 20);
            this.textBoxSpeed.TabIndex = 4;
            this.textBoxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valid_KeyPress);
            // 
            // textBoxQuotSpring
            // 
            this.textBoxQuotSpring.Location = new System.Drawing.Point(253, 90);
            this.textBoxQuotSpring.Name = "textBoxQuotSpring";
            this.textBoxQuotSpring.Size = new System.Drawing.Size(117, 20);
            this.textBoxQuotSpring.TabIndex = 6;
            this.textBoxQuotSpring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valid_KeyPress);
            // 
            // textBoxQuatFading
            // 
            this.textBoxQuatFading.Location = new System.Drawing.Point(253, 116);
            this.textBoxQuatFading.Name = "textBoxQuatFading";
            this.textBoxQuatFading.Size = new System.Drawing.Size(117, 20);
            this.textBoxQuatFading.TabIndex = 8;
            this.textBoxQuatFading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valid_KeyPress);
            // 
            // comboBoxMass
            // 
            this.comboBoxMass.DisplayMember = "0";
            this.comboBoxMass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMass.FormattingEnabled = true;
            this.comboBoxMass.Items.AddRange(new object[] {
            "г",
            "кг"});
            this.comboBoxMass.Location = new System.Drawing.Point(376, 8);
            this.comboBoxMass.Name = "comboBoxMass";
            this.comboBoxMass.Size = new System.Drawing.Size(66, 21);
            this.comboBoxMass.TabIndex = 1;
            this.comboBoxMass.Tag = "";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DisplayMember = "1";
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "см",
            "м"});
            this.comboBoxPosition.Location = new System.Drawing.Point(376, 35);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(66, 21);
            this.comboBoxPosition.TabIndex = 3;
            this.comboBoxPosition.Tag = "";
            this.comboBoxPosition.ValueMember = "1";
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.DisplayMember = "1";
            this.comboBoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "м/с",
            "км/ч"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(376, 62);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(66, 21);
            this.comboBoxSpeed.TabIndex = 5;
            this.comboBoxSpeed.ValueMember = "1";
            // 
            // comboBoxQuotSpring
            // 
            this.comboBoxQuotSpring.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuotSpring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxQuotSpring.FormattingEnabled = true;
            this.comboBoxQuotSpring.Items.AddRange(new object[] {
            "Н/м"});
            this.comboBoxQuotSpring.Location = new System.Drawing.Point(376, 89);
            this.comboBoxQuotSpring.Name = "comboBoxQuotSpring";
            this.comboBoxQuotSpring.Size = new System.Drawing.Size(66, 21);
            this.comboBoxQuotSpring.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "с",
            "мин"});
            this.comboBoxTime.Location = new System.Drawing.Point(376, 143);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(66, 21);
            this.comboBoxTime.TabIndex = 14;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(253, 142);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(117, 20);
            this.textBoxTime.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(120, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Время измерения:";
            // 
            // comboBoxTimeStep
            // 
            this.comboBoxTimeStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeStep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTimeStep.FormattingEnabled = true;
            this.comboBoxTimeStep.Items.AddRange(new object[] {
            "с",
            "мин"});
            this.comboBoxTimeStep.Location = new System.Drawing.Point(376, 170);
            this.comboBoxTimeStep.Name = "comboBoxTimeStep";
            this.comboBoxTimeStep.Size = new System.Drawing.Size(66, 21);
            this.comboBoxTimeStep.TabIndex = 17;
            // 
            // textBoxTimeStep
            // 
            this.textBoxTimeStep.Location = new System.Drawing.Point(253, 171);
            this.textBoxTimeStep.Name = "textBoxTimeStep";
            this.textBoxTimeStep.Size = new System.Drawing.Size(117, 20);
            this.textBoxTimeStep.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(96, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Интервал измерения:";
            // 
            // comboBoxQuatFading
            // 
            this.comboBoxQuatFading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuatFading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxQuatFading.FormattingEnabled = true;
            this.comboBoxQuatFading.Items.AddRange(new object[] {
            "Гц"});
            this.comboBoxQuatFading.Location = new System.Drawing.Point(376, 116);
            this.comboBoxQuatFading.Name = "comboBoxQuatFading";
            this.comboBoxQuatFading.Size = new System.Drawing.Size(66, 21);
            this.comboBoxQuatFading.TabIndex = 9;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 255);
            this.Controls.Add(this.comboBoxTimeStep);
            this.Controls.Add(this.textBoxTimeStep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxQuatFading);
            this.Controls.Add(this.comboBoxQuotSpring);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.comboBoxMass);
            this.Controls.Add(this.textBoxQuatFading);
            this.Controls.Add(this.textBoxQuotSpring);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxQuotSpring;
        private System.Windows.Forms.TextBox textBoxQuatFading;
        private System.Windows.Forms.ComboBox comboBoxMass;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.ComboBox comboBoxQuotSpring;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTimeStep;
        private System.Windows.Forms.TextBox textBoxTimeStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxQuatFading;
    }
}