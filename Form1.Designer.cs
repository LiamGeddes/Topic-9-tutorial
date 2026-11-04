namespace Topic_9_tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(201, 283);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click me";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(128, 83);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(162, 13);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Click on the Button or Picturebox";
            // 
            // imgCharacter
            // 
            this.imgCharacter.Image = ((System.Drawing.Image)(resources.GetObject("imgCharacter.Image")));
            this.imgCharacter.Location = new System.Drawing.Point(63, 217);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(100, 111);
            this.imgCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCharacter.TabIndex = 2;
            this.imgCharacter.TabStop = false;
            this.imgCharacter.Visible = false;
            this.imgCharacter.Click += new System.EventHandler(this.imgCharacter_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(333, 217);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(84, 132);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnQuit;
    }
}

