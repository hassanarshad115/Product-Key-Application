namespace Second
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totaldaysleftlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productkeymaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Second.Properties.Resources.game;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // totaldaysleftlabel
            // 
            this.totaldaysleftlabel.AutoSize = true;
            this.totaldaysleftlabel.BackColor = System.Drawing.Color.DarkGray;
            this.totaldaysleftlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totaldaysleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldaysleftlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totaldaysleftlabel.Location = new System.Drawing.Point(123, 112);
            this.totaldaysleftlabel.Name = "totaldaysleftlabel";
            this.totaldaysleftlabel.Size = new System.Drawing.Size(253, 29);
            this.totaldaysleftlabel.TabIndex = 1;
            this.totaldaysleftlabel.Text = "You Have Left 30 Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(165, 166);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(258, 23);
            this.nametextBox.TabIndex = 3;
            this.nametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Key:";
            // 
            // productkeymaskedTextBox
            // 
            this.productkeymaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productkeymaskedTextBox.Location = new System.Drawing.Point(165, 206);
            this.productkeymaskedTextBox.Name = "productkeymaskedTextBox";
            this.productkeymaskedTextBox.Size = new System.Drawing.Size(258, 23);
            this.productkeymaskedTextBox.TabIndex = 4;
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(165, 244);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(142, 23);
            this.enterbutton.TabIndex = 5;
            this.enterbutton.Text = "&Enter Product Key";
            this.enterbutton.UseVisualStyleBackColor = true;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(332, 244);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(91, 23);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "&Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 279);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.productkeymaskedTextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totaldaysleftlabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label totaldaysleftlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox productkeymaskedTextBox;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

