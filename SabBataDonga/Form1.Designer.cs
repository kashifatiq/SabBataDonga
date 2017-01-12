namespace SabBataDonga
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
            this.txtJadoo = new System.Windows.Forms.TextBox();
            this.btnNayaSawal = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJadoo
            // 
            this.txtJadoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJadoo.Location = new System.Drawing.Point(12, 101);
            this.txtJadoo.Name = "txtJadoo";
            this.txtJadoo.Size = new System.Drawing.Size(1151, 38);
            this.txtJadoo.TabIndex = 0;
            this.txtJadoo.TextChanged += new System.EventHandler(this.txtJadoo_TextChanged);
            this.txtJadoo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJadoo_KeyDown);
            this.txtJadoo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJadoo_KeyPress);
            this.txtJadoo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJadoo_KeyUp);
            // 
            // btnNayaSawal
            // 
            this.btnNayaSawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNayaSawal.Location = new System.Drawing.Point(1169, 101);
            this.btnNayaSawal.Name = "btnNayaSawal";
            this.btnNayaSawal.Size = new System.Drawing.Size(132, 37);
            this.btnNayaSawal.TabIndex = 2;
            this.btnNayaSawal.Text = "Naya Sawal";
            this.btnNayaSawal.UseVisualStyleBackColor = true;
            this.btnNayaSawal.Click += new System.EventHandler(this.btnNayaSawal_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(12, 188);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(1151, 38);
            this.txtQuestion.TabIndex = 3;
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAnswer.Location = new System.Drawing.Point(1169, 188);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(132, 37);
            this.btnGetAnswer.TabIndex = 4;
            this.btnGetAnswer.Text = "Jawab Do";
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAnswer.Location = new System.Drawing.Point(16, 292);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 31);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Neeche die gaye dabbe main apna swal likh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bhai se request kar pehle";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnGetAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnNayaSawal);
            this.Controls.Add(this.txtJadoo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sab Bata Donga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJadoo;
        private System.Windows.Forms.Button btnNayaSawal;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnGetAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

