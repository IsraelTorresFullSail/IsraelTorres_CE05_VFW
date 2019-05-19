namespace IsraelTorres_CE05
{
    partial class UserInputDialog
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.radioButtonFreighter = new System.Windows.Forms.RadioButton();
            this.radioButtonDestryer = new System.Windows.Forms.RadioButton();
            this.radioButtonCruiser = new System.Windows.Forms.RadioButton();
            this.checkBoxActiveDuty = new System.Windows.Forms.CheckBox();
            this.labelCrewSize = new System.Windows.Forms.Label();
            this.numericUpDownCrewSize = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrewSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonApply);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonOk);
            this.groupBox1.Controls.Add(this.radioButtonFreighter);
            this.groupBox1.Controls.Add(this.radioButtonDestryer);
            this.groupBox1.Controls.Add(this.radioButtonCruiser);
            this.groupBox1.Controls.Add(this.checkBoxActiveDuty);
            this.groupBox1.Controls.Add(this.labelCrewSize);
            this.groupBox1.Controls.Add(this.numericUpDownCrewSize);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 764);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Input";
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(51, 650);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(428, 60);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Visible = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(51, 556);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(428, 60);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(51, 464);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(428, 60);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // radioButtonFreighter
            // 
            this.radioButtonFreighter.AutoSize = true;
            this.radioButtonFreighter.Location = new System.Drawing.Point(167, 382);
            this.radioButtonFreighter.Name = "radioButtonFreighter";
            this.radioButtonFreighter.Size = new System.Drawing.Size(129, 29);
            this.radioButtonFreighter.TabIndex = 2;
            this.radioButtonFreighter.TabStop = true;
            this.radioButtonFreighter.Text = "Freighter";
            this.radioButtonFreighter.UseVisualStyleBackColor = true;
            // 
            // radioButtonDestryer
            // 
            this.radioButtonDestryer.AutoSize = true;
            this.radioButtonDestryer.Location = new System.Drawing.Point(167, 347);
            this.radioButtonDestryer.Name = "radioButtonDestryer";
            this.radioButtonDestryer.Size = new System.Drawing.Size(136, 29);
            this.radioButtonDestryer.TabIndex = 1;
            this.radioButtonDestryer.TabStop = true;
            this.radioButtonDestryer.Text = "Destroyer";
            this.radioButtonDestryer.UseVisualStyleBackColor = true;
            // 
            // radioButtonCruiser
            // 
            this.radioButtonCruiser.AutoSize = true;
            this.radioButtonCruiser.Location = new System.Drawing.Point(167, 312);
            this.radioButtonCruiser.Name = "radioButtonCruiser";
            this.radioButtonCruiser.Size = new System.Drawing.Size(112, 29);
            this.radioButtonCruiser.TabIndex = 0;
            this.radioButtonCruiser.TabStop = true;
            this.radioButtonCruiser.Text = "Cruiser";
            this.radioButtonCruiser.UseVisualStyleBackColor = true;
            // 
            // checkBoxActiveDuty
            // 
            this.checkBoxActiveDuty.AutoSize = true;
            this.checkBoxActiveDuty.Location = new System.Drawing.Point(167, 240);
            this.checkBoxActiveDuty.Name = "checkBoxActiveDuty";
            this.checkBoxActiveDuty.Size = new System.Drawing.Size(153, 29);
            this.checkBoxActiveDuty.TabIndex = 4;
            this.checkBoxActiveDuty.Text = "Active Duty";
            this.checkBoxActiveDuty.UseVisualStyleBackColor = true;
            // 
            // labelCrewSize
            // 
            this.labelCrewSize.AutoSize = true;
            this.labelCrewSize.Location = new System.Drawing.Point(46, 160);
            this.labelCrewSize.Name = "labelCrewSize";
            this.labelCrewSize.Size = new System.Drawing.Size(115, 25);
            this.labelCrewSize.TabIndex = 3;
            this.labelCrewSize.Text = "Crew Size:";
            // 
            // numericUpDownCrewSize
            // 
            this.numericUpDownCrewSize.Location = new System.Drawing.Point(167, 158);
            this.numericUpDownCrewSize.Name = "numericUpDownCrewSize";
            this.numericUpDownCrewSize.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownCrewSize.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(87, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(312, 31);
            this.textBoxName.TabIndex = 0;
            // 
            // UserInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 764);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(550, 50);
            this.Name = "UserInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserInputDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrewSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFreighter;
        private System.Windows.Forms.RadioButton radioButtonDestryer;
        private System.Windows.Forms.RadioButton radioButtonCruiser;
        private System.Windows.Forms.CheckBox checkBoxActiveDuty;
        private System.Windows.Forms.Label labelCrewSize;
        private System.Windows.Forms.NumericUpDown numericUpDownCrewSize;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}