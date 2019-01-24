namespace MotorShip
{
    partial class FormPort
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
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.buttonMoorBaseShip = new System.Windows.Forms.Button();
            this.buttonMoorShip = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxUnmoor = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlase = new System.Windows.Forms.Label();
            this.Unmoor = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnmoor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Location = new System.Drawing.Point(-1, 2);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(1011, 717);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // buttonMoorBaseShip
            // 
            this.buttonMoorBaseShip.Location = new System.Drawing.Point(1016, 246);
            this.buttonMoorBaseShip.Name = "buttonMoorBaseShip";
            this.buttonMoorBaseShip.Size = new System.Drawing.Size(183, 79);
            this.buttonMoorBaseShip.TabIndex = 1;
            this.buttonMoorBaseShip.Text = "Пришвартовать корабль";
            this.buttonMoorBaseShip.UseVisualStyleBackColor = true;
            this.buttonMoorBaseShip.Click += new System.EventHandler(this.buttonMoorBaseShip_Click);
            // 
            // buttonMoorShip
            // 
            this.buttonMoorShip.Location = new System.Drawing.Point(1016, 331);
            this.buttonMoorShip.Name = "buttonMoorShip";
            this.buttonMoorShip.Size = new System.Drawing.Size(183, 79);
            this.buttonMoorShip.TabIndex = 2;
            this.buttonMoorShip.Text = "Пришвартовать теплоход";
            this.buttonMoorShip.UseVisualStyleBackColor = true;
            this.buttonMoorShip.Click += new System.EventHandler(this.buttonMoorShip_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxUnmoor);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.labelPlase);
            this.groupBox.Controls.Add(this.Unmoor);
            this.groupBox.Location = new System.Drawing.Point(1016, 496);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(190, 212);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Отшвартовать корабль";
            // 
            // pictureBoxUnmoor
            // 
            this.pictureBoxUnmoor.Location = new System.Drawing.Point(0, 95);
            this.pictureBoxUnmoor.Name = "pictureBoxUnmoor";
            this.pictureBoxUnmoor.Size = new System.Drawing.Size(183, 117);
            this.pictureBoxUnmoor.TabIndex = 4;
            this.pictureBoxUnmoor.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(61, 32);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox.TabIndex = 5;
            // 
            // labelPlase
            // 
            this.labelPlase.AutoSize = true;
            this.labelPlase.Location = new System.Drawing.Point(6, 32);
            this.labelPlase.Name = "labelPlase";
            this.labelPlase.Size = new System.Drawing.Size(49, 17);
            this.labelPlase.TabIndex = 4;
            this.labelPlase.Text = "Место";
            // 
            // Unmoor
            // 
            this.Unmoor.Location = new System.Drawing.Point(6, 60);
            this.Unmoor.Name = "Unmoor";
            this.Unmoor.Size = new System.Drawing.Size(169, 30);
            this.Unmoor.TabIndex = 4;
            this.Unmoor.Text = "Отшвартоваться";
            this.Unmoor.UseVisualStyleBackColor = true;
            this.Unmoor.Click += new System.EventHandler(this.Unmoor_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(1016, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(183, 228);
            this.listBoxLevels.TabIndex = 5;
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 731);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonMoorShip);
            this.Controls.Add(this.buttonMoorBaseShip);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.Text = "Порт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnmoor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.Button buttonMoorBaseShip;
        private System.Windows.Forms.Button buttonMoorShip;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBoxUnmoor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlase;
        private System.Windows.Forms.Button Unmoor;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}