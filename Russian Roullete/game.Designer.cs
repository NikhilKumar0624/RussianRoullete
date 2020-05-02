namespace Russian_Roullete
{
    partial class game
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
            this.gifimageplayer = new System.Windows.Forms.PictureBox();
            this.loadbut = new System.Windows.Forms.Button();
            this.spinbut = new System.Windows.Forms.Button();
            this.shootbut = new System.Windows.Forms.Button();
            this.shootawaybut = new System.Windows.Forms.Button();
            this.buttonRetry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gifimageplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.gifimageplayer.Location = new System.Drawing.Point(183, 109);
            this.gifimageplayer.Name = "pictureBox1";
            this.gifimageplayer.Size = new System.Drawing.Size(558, 250);
            this.gifimageplayer.TabIndex = 0;
            this.gifimageplayer.TabStop = false;
            // 
            // buttonload
            // 
            this.loadbut.BackColor = System.Drawing.Color.Black;
            this.loadbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbut.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbut.ForeColor = System.Drawing.Color.Red;
            this.loadbut.Location = new System.Drawing.Point(12, 109);
            this.loadbut.Name = "buttonload";
            this.loadbut.Size = new System.Drawing.Size(127, 62);
            this.loadbut.TabIndex = 1;
            this.loadbut.Text = "Load";
            this.loadbut.UseVisualStyleBackColor = false;
            this.loadbut.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // buttonSpin
            // 
            this.spinbut.BackColor = System.Drawing.Color.Black;
            this.spinbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spinbut.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinbut.ForeColor = System.Drawing.Color.Red;
            this.spinbut.Location = new System.Drawing.Point(12, 241);
            this.spinbut.Name = "buttonSpin";
            this.spinbut.Size = new System.Drawing.Size(127, 62);
            this.spinbut.TabIndex = 2;
            this.spinbut.Text = "Spin";
            this.spinbut.UseVisualStyleBackColor = false;
            this.spinbut.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // buttonShoot
            // 
            this.shootbut.BackColor = System.Drawing.Color.Black;
            this.shootbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shootbut.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootbut.ForeColor = System.Drawing.Color.Red;
            this.shootbut.Location = new System.Drawing.Point(12, 368);
            this.shootbut.Name = "buttonShoot";
            this.shootbut.Size = new System.Drawing.Size(127, 62);
            this.shootbut.TabIndex = 3;
            this.shootbut.Text = "Shoot";
            this.shootbut.UseVisualStyleBackColor = false;
            this.shootbut.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // buttonshootaway
            // 
            this.shootawaybut.BackColor = System.Drawing.Color.Black;
            this.shootawaybut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shootawaybut.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootawaybut.ForeColor = System.Drawing.Color.Red;
            this.shootawaybut.Location = new System.Drawing.Point(353, 368);
            this.shootawaybut.Name = "buttonshootaway";
            this.shootawaybut.Size = new System.Drawing.Size(161, 62);
            this.shootawaybut.TabIndex = 4;
            this.shootawaybut.Text = "Shoot Away";
            this.shootawaybut.UseVisualStyleBackColor = false;
            this.shootawaybut.Click += new System.EventHandler(this.buttonshootaway_Click);
            // 
            // buttonRetry
            // 
            this.buttonRetry.BackColor = System.Drawing.Color.Black;
            this.buttonRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetry.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetry.ForeColor = System.Drawing.Color.Red;
            this.buttonRetry.Location = new System.Drawing.Point(705, 368);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(127, 62);
            this.buttonRetry.TabIndex = 5;
            this.buttonRetry.Text = "Retry";
            this.buttonRetry.UseVisualStyleBackColor = false;
            this.buttonRetry.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(315, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Russian Roullete";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(854, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.shootawaybut);
            this.Controls.Add(this.shootbut);
            this.Controls.Add(this.spinbut);
            this.Controls.Add(this.loadbut);
            this.Controls.Add(this.gifimageplayer);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gifimageplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gifimageplayer;
        private System.Windows.Forms.Button loadbut;
        private System.Windows.Forms.Button spinbut;
        private System.Windows.Forms.Button shootbut;
        private System.Windows.Forms.Button shootawaybut;
        private System.Windows.Forms.Button buttonRetry;
        private System.Windows.Forms.Label label2;
    }
}