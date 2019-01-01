namespace _261218__3
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
            this.yellowPanel1 = new System.Windows.Forms.Panel();
            this.redPanel0 = new System.Windows.Forms.Panel();
            this.greenPanel3 = new System.Windows.Forms.Panel();
            this.bluePanel2 = new System.Windows.Forms.Panel();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yellowPanel1
            // 
            this.yellowPanel1.BackColor = System.Drawing.Color.Yellow;
            this.yellowPanel1.Location = new System.Drawing.Point(411, 60);
            this.yellowPanel1.Name = "yellowPanel1";
            this.yellowPanel1.Size = new System.Drawing.Size(245, 144);
            this.yellowPanel1.TabIndex = 0;
            this.yellowPanel1.Click += new System.EventHandler(this.yellowPanel1_Click_1);
            // 
            // redPanel0
            // 
            this.redPanel0.BackColor = System.Drawing.Color.Red;
            this.redPanel0.Location = new System.Drawing.Point(163, 60);
            this.redPanel0.Name = "redPanel0";
            this.redPanel0.Size = new System.Drawing.Size(242, 144);
            this.redPanel0.TabIndex = 1;
            this.redPanel0.Click += new System.EventHandler(this.redPanel0_Click_1);
            // 
            // greenPanel3
            // 
            this.greenPanel3.BackColor = System.Drawing.Color.Lime;
            this.greenPanel3.Location = new System.Drawing.Point(411, 210);
            this.greenPanel3.Name = "greenPanel3";
            this.greenPanel3.Size = new System.Drawing.Size(245, 134);
            this.greenPanel3.TabIndex = 2;
            this.greenPanel3.Click += new System.EventHandler(this.greenPanel3_Click_1);
            // 
            // bluePanel2
            // 
            this.bluePanel2.BackColor = System.Drawing.Color.Blue;
            this.bluePanel2.Location = new System.Drawing.Point(163, 210);
            this.bluePanel2.Name = "bluePanel2";
            this.bluePanel2.Size = new System.Drawing.Size(242, 134);
            this.bluePanel2.TabIndex = 3;
            this.bluePanel2.Click += new System.EventHandler(this.bluePanel2_Click_1);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(346, 388);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(120, 23);
            this.startGameBtn.TabIndex = 4;
            this.startGameBtn.Text = "START";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click_1);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.Color.Coral;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.scoreLbl.Location = new System.Drawing.Point(634, 383);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(65, 24);
            this.scoreLbl.TabIndex = 5;
            this.scoreLbl.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.bluePanel2);
            this.Controls.Add(this.greenPanel3);
            this.Controls.Add(this.redPanel0);
            this.Controls.Add(this.yellowPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel yellowPanel1;
        private System.Windows.Forms.Panel redPanel0;
        private System.Windows.Forms.Panel greenPanel3;
        private System.Windows.Forms.Panel bluePanel2;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label scoreLbl;
    }
}

