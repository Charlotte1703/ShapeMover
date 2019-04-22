namespace Shape
{
    partial class Form1
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonAddRect = new System.Windows.Forms.Button();
            this.buttonAddEllipse = new System.Windows.Forms.Button();
            this.buttonAddTriangle = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonChooseColour = new System.Windows.Forms.Button();
            this.buttonBTF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(22, 22);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(1223, 448);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDisplay_Paint);
            this.pictureBoxDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxDisplay_MouseClick);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(22, 505);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(167, 505);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(96, 476);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(96, 534);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonAddRect
            // 
            this.buttonAddRect.Location = new System.Drawing.Point(275, 476);
            this.buttonAddRect.Name = "buttonAddRect";
            this.buttonAddRect.Size = new System.Drawing.Size(106, 23);
            this.buttonAddRect.TabIndex = 5;
            this.buttonAddRect.Text = "Add Rectangle";
            this.buttonAddRect.UseVisualStyleBackColor = true;
            this.buttonAddRect.Click += new System.EventHandler(this.buttonAddRect_Click);
            // 
            // buttonAddEllipse
            // 
            this.buttonAddEllipse.Location = new System.Drawing.Point(275, 505);
            this.buttonAddEllipse.Name = "buttonAddEllipse";
            this.buttonAddEllipse.Size = new System.Drawing.Size(106, 23);
            this.buttonAddEllipse.TabIndex = 6;
            this.buttonAddEllipse.Text = "Add Ellipse";
            this.buttonAddEllipse.UseVisualStyleBackColor = true;
            this.buttonAddEllipse.Click += new System.EventHandler(this.buttonAddEllipse_Click);
            // 
            // buttonAddTriangle
            // 
            this.buttonAddTriangle.Location = new System.Drawing.Point(275, 534);
            this.buttonAddTriangle.Name = "buttonAddTriangle";
            this.buttonAddTriangle.Size = new System.Drawing.Size(106, 23);
            this.buttonAddTriangle.TabIndex = 7;
            this.buttonAddTriangle.Text = "Add Triangle";
            this.buttonAddTriangle.UseVisualStyleBackColor = true;
            this.buttonAddTriangle.Click += new System.EventHandler(this.buttonAddTriangle_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(409, 476);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete Shape";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChooseColour
            // 
            this.buttonChooseColour.Location = new System.Drawing.Point(409, 505);
            this.buttonChooseColour.Name = "buttonChooseColour";
            this.buttonChooseColour.Size = new System.Drawing.Size(106, 52);
            this.buttonChooseColour.TabIndex = 9;
            this.buttonChooseColour.Text = "Change Shape Colour";
            this.buttonChooseColour.UseVisualStyleBackColor = true;
            this.buttonChooseColour.Click += new System.EventHandler(this.buttonChooseColour_Click);
            // 
            // buttonBTF
            // 
            this.buttonBTF.Location = new System.Drawing.Point(521, 476);
            this.buttonBTF.Name = "buttonBTF";
            this.buttonBTF.Size = new System.Drawing.Size(106, 81);
            this.buttonBTF.TabIndex = 10;
            this.buttonBTF.Text = "BTF";
            this.buttonBTF.UseVisualStyleBackColor = true;
            this.buttonBTF.Click += new System.EventHandler(this.buttonBTF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 569);
            this.Controls.Add(this.buttonBTF);
            this.Controls.Add(this.buttonChooseColour);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddTriangle);
            this.Controls.Add(this.buttonAddEllipse);
            this.Controls.Add(this.buttonAddRect);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "Form1";
            this.Text = "Shape Mover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonAddRect;
        private System.Windows.Forms.Button buttonAddEllipse;
        private System.Windows.Forms.Button buttonAddTriangle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonChooseColour;
        private System.Windows.Forms.Button buttonBTF;
    }
}

