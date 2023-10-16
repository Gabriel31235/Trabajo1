
namespace Trabajo1.Formas
{
    partial class FormaMate
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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.Restar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.Multiplicar = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.Dividir = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dividir)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(266, 19);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 30);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(128, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.plusRightLabel.Location = new System.Drawing.Point(194, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(128, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(260, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(326, 84);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 37);
            this.Sum.TabIndex = 1;
            this.Sum.Click += new System.EventHandler(this.answer_Enter);
            this.Sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // Restar
            // 
            this.Restar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restar.Location = new System.Drawing.Point(327, 144);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(100, 37);
            this.Restar.TabIndex = 2;
            this.Restar.Click += new System.EventHandler(this.answer_Enter);
            this.Restar.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(260, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(129, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.minusRightLabel.Location = new System.Drawing.Point(195, 135);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 8;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.minusLeftLabel.Location = new System.Drawing.Point(51, 135);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiplicar
            // 
            this.Multiplicar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.Location = new System.Drawing.Point(326, 208);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(100, 37);
            this.Multiplicar.TabIndex = 3;
            this.Multiplicar.Click += new System.EventHandler(this.answer_Enter);
            this.Multiplicar.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(260, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(128, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 14;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.timesRightLabel.Location = new System.Drawing.Point(194, 199);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 13;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 199);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dividir
            // 
            this.Dividir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.Location = new System.Drawing.Point(327, 280);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(100, 37);
            this.Dividir.TabIndex = 4;
            this.Dividir.Click += new System.EventHandler(this.answer_Enter);
            this.Dividir.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(261, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(129, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 19;
            this.label13.Text = "/";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dividedRightLabel.Location = new System.Drawing.Point(195, 271);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 18;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dividedLeftLabel.Location = new System.Drawing.Point(51, 271);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(146, 354);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(175, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Iniciar la prueba";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormaMate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Trabajo1.Properties.Resources._91026cba9c6abaa7b2a1d1c474bfb6881;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.Name = "FormaMate";
            this.Text = "FormaMate";
            this.Load += new System.EventHandler(this.FormaMate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dividir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.NumericUpDown Restar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown Multiplicar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown Dividir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}