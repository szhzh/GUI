namespace TicketManager
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
            this.tbStudents = new System.Windows.Forms.TextBox();
            this.tbKids = new System.Windows.Forms.TextBox();
            this.tbPupils = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblPupils = new System.Windows.Forms.Label();
            this.lblKids = new System.Windows.Forms.Label();
            this.tbAll = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbStudents
            // 
            this.tbStudents.Location = new System.Drawing.Point(35, 218);
            this.tbStudents.Name = "tbStudents";
            this.tbStudents.Size = new System.Drawing.Size(100, 20);
            this.tbStudents.TabIndex = 0;
            this.tbStudents.TextChanged += new System.EventHandler(this.tbStudents_TextChanged);
            // 
            // tbKids
            // 
            this.tbKids.Location = new System.Drawing.Point(35, 95);
            this.tbKids.Name = "tbKids";
            this.tbKids.Size = new System.Drawing.Size(100, 20);
            this.tbKids.TabIndex = 1;
            this.tbKids.TextChanged += new System.EventHandler(this.tbKids_TextChanged);
            // 
            // tbPupils
            // 
            this.tbPupils.Location = new System.Drawing.Point(35, 154);
            this.tbPupils.Name = "tbPupils";
            this.tbPupils.Size = new System.Drawing.Size(100, 20);
            this.tbPupils.TabIndex = 2;
            this.tbPupils.TextChanged += new System.EventHandler(this.tbPupils_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Black;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(130, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(217, 15);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Деца- 3лв || Ученици- 4лв || Студенти- 5лв";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(211, 18);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(46, 13);
            this.lblTickets.TabIndex = 4;
            this.lblTickets.Text = "Билети:";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(32, 202);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(109, 13);
            this.lblStudents.TabIndex = 5;
            this.lblStudents.Text = "Билета за студенти:";
            // 
            // lblPupils
            // 
            this.lblPupils.AutoSize = true;
            this.lblPupils.Location = new System.Drawing.Point(32, 138);
            this.lblPupils.Name = "lblPupils";
            this.lblPupils.Size = new System.Drawing.Size(92, 13);
            this.lblPupils.TabIndex = 6;
            this.lblPupils.Text = "Билета за учини:";
            // 
            // lblKids
            // 
            this.lblKids.AutoSize = true;
            this.lblKids.Location = new System.Drawing.Point(32, 79);
            this.lblKids.Name = "lblKids";
            this.lblKids.Size = new System.Drawing.Size(88, 13);
            this.lblKids.TabIndex = 7;
            this.lblKids.Text = "Билета за деца:";
            // 
            // tbAll
            // 
            this.tbAll.Location = new System.Drawing.Point(269, 135);
            this.tbAll.Name = "tbAll";
            this.tbAll.Size = new System.Drawing.Size(100, 20);
            this.tbAll.TabIndex = 8;
            this.tbAll.Text = "0 лв";
            this.tbAll.TextChanged += new System.EventHandler(this.tbAll_TextChanged);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(281, 179);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "Общо:";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(386, 256);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(95, 17);
            this.rbLarge.TabIndex = 10;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Увеличи цени";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 315);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.tbAll);
            this.Controls.Add(this.lblKids);
            this.Controls.Add(this.lblPupils);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPupils);
            this.Controls.Add(this.tbKids);
            this.Controls.Add(this.tbStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudents;
        private System.Windows.Forms.TextBox tbKids;
        private System.Windows.Forms.TextBox tbPupils;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblPupils;
        private System.Windows.Forms.Label lblKids;
        private System.Windows.Forms.TextBox tbAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.RadioButton rbLarge;
    }
}

