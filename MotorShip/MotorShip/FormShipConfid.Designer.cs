namespace MotorShip
{
    partial class FormShipConfid
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
            this.groupShips = new System.Windows.Forms.GroupBox();
            this.BaseShip = new System.Windows.Forms.Label();
            this.MotorShip = new System.Windows.Forms.Label();
            this.panelShip = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.ShipBox = new System.Windows.Forms.PictureBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.Green = new System.Windows.Forms.Panel();
            this.Blue = new System.Windows.Forms.Panel();
            this.White = new System.Windows.Forms.Panel();
            this.Black = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMark = new System.Windows.Forms.Button();
            this.groupShips.SuspendLayout();
            this.panelShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Green.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupShips
            // 
            this.groupShips.Controls.Add(this.BaseShip);
            this.groupShips.Controls.Add(this.MotorShip);
            this.groupShips.Location = new System.Drawing.Point(12, 12);
            this.groupShips.Name = "groupShips";
            this.groupShips.Size = new System.Drawing.Size(146, 140);
            this.groupShips.TabIndex = 2;
            this.groupShips.TabStop = false;
            this.groupShips.Text = "Тип корабля";
            // 
            // BaseShip
            // 
            this.BaseShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseShip.Location = new System.Drawing.Point(19, 38);
            this.BaseShip.Name = "BaseShip";
            this.BaseShip.Size = new System.Drawing.Size(75, 20);
            this.BaseShip.TabIndex = 2;
            this.BaseShip.Text = "Корабль";
            this.BaseShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseShip_MouseDown);
            // 
            // MotorShip
            // 
            this.MotorShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MotorShip.Location = new System.Drawing.Point(19, 67);
            this.MotorShip.Name = "MotorShip";
            this.MotorShip.Size = new System.Drawing.Size(75, 20);
            this.MotorShip.TabIndex = 1;
            this.MotorShip.Text = "Теплоход";
            this.MotorShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MotorShip_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.Controls.Add(this.labelColor);
            this.panelShip.Controls.Add(this.ShipBox);
            this.panelShip.Controls.Add(this.labelDopColor);
            this.panelShip.Location = new System.Drawing.Point(174, 12);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(216, 255);
            this.panelShip.TabIndex = 3;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // labelColor
            // 
            this.labelColor.AllowDrop = true;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(35, 190);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(150, 20);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Основной цвет";
            this.labelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // ShipBox
            // 
            this.ShipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShipBox.Location = new System.Drawing.Point(18, 13);
            this.ShipBox.Name = "ShipBox";
            this.ShipBox.Size = new System.Drawing.Size(182, 154);
            this.ShipBox.TabIndex = 0;
            this.ShipBox.TabStop = false;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(35, 220);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(150, 20);
            this.labelDopColor.TabIndex = 4;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelOrange);
            this.groupBox1.Controls.Add(this.panelGray);
            this.groupBox1.Controls.Add(this.panelYellow);
            this.groupBox1.Controls.Add(this.panelRed);
            this.groupBox1.Controls.Add(this.panelBlue);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.White);
            this.groupBox1.Controls.Add(this.Black);
            this.groupBox1.Location = new System.Drawing.Point(407, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(52, 153);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(39, 38);
            this.panelOrange.TabIndex = 7;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(7, 153);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(39, 38);
            this.panelGray.TabIndex = 6;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(51, 110);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(39, 38);
            this.panelYellow.TabIndex = 5;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(7, 109);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(39, 38);
            this.panelRed.TabIndex = 4;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(52, 66);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(39, 38);
            this.panelBlue.TabIndex = 3;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Controls.Add(this.Blue);
            this.Green.Location = new System.Drawing.Point(6, 67);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(39, 36);
            this.Green.TabIndex = 2;
            this.Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(46, 2);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(39, 36);
            this.Blue.TabIndex = 3;
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(51, 22);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(39, 36);
            this.White.TabIndex = 1;
            this.White.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(7, 22);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(37, 36);
            this.Black.TabIndex = 0;
            this.Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 175);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 28);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonMark
            // 
            this.buttonMark.Location = new System.Drawing.Point(11, 209);
            this.buttonMark.Name = "buttonMark";
            this.buttonMark.Size = new System.Drawing.Size(95, 23);
            this.buttonMark.TabIndex = 8;
            this.buttonMark.Text = "Отмена";
            this.buttonMark.UseVisualStyleBackColor = true;
            // 
            // FormShipConfid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 401);
            this.Controls.Add(this.buttonMark);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupShips);
            this.Name = "FormShipConfid";
            this.Text = "FormShipConfid";
            this.groupShips.ResumeLayout(false);
            this.panelShip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShipBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Green.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupShips;
        private System.Windows.Forms.Label BaseShip;
        private System.Windows.Forms.Label MotorShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.PictureBox ShipBox;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel Green;
        private System.Windows.Forms.Panel Blue;
        private System.Windows.Forms.Panel White;
        private System.Windows.Forms.Panel Black;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMark;
    }
}