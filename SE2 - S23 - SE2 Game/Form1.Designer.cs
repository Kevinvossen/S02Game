namespace SE2___S23___SE2_Game
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
            this.components = new System.ComponentModel.Container();
            this.picGameWorld = new System.Windows.Forms.PictureBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGameWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // picGameWorld
            // 
            this.picGameWorld.BackColor = System.Drawing.Color.White;
            this.picGameWorld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGameWorld.Location = new System.Drawing.Point(12, 12);
            this.picGameWorld.Name = "picGameWorld";
            this.picGameWorld.Size = new System.Drawing.Size(400, 400);
            this.picGameWorld.TabIndex = 0;
            this.picGameWorld.TabStop = false;
            this.picGameWorld.Paint += new System.Windows.Forms.PaintEventHandler(this.picGameWorld_Paint);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 33;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 421);
            this.Controls.Add(this.picGameWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGameWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGameWorld;
        private System.Windows.Forms.Timer timerUpdate;
    }
}

