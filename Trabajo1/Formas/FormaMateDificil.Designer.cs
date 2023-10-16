
namespace Trabajo1.Formas
{
    partial class FormaMateDificil
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.Multiplicar = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.Restar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dividir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(404, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 48);
            this.button2.TabIndex = 72;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(31, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 71;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Maroon;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Gray;
            this.startButton.Location = new System.Drawing.Point(178, 374);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(183, 66);
            this.startButton.TabIndex = 49;
            this.startButton.Text = "Iniciar la prueba";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Dividir
            // 
            this.Dividir.BackColor = System.Drawing.Color.Maroon;
            this.Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.ForeColor = System.Drawing.Color.Gray;
            this.Dividir.Location = new System.Drawing.Point(330, 282);
            this.Dividir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dividir.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(101, 37);
            this.Dividir.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(264, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 70);
            this.label12.TabIndex = 70;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(132, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 70);
            this.label13.TabIndex = 69;
            this.label13.Text = "/";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dividedRightLabel.Location = new System.Drawing.Point(198, 274);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(68, 70);
            this.dividedRightLabel.TabIndex = 68;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dividedLeftLabel.Location = new System.Drawing.Point(54, 274);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(68, 70);
            this.dividedLeftLabel.TabIndex = 67;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiplicar
            // 
            this.Multiplicar.BackColor = System.Drawing.Color.Maroon;
            this.Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.ForeColor = System.Drawing.Color.Gray;
            this.Multiplicar.Location = new System.Drawing.Point(329, 212);
            this.Multiplicar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Multiplicar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(101, 37);
            this.Multiplicar.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(263, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 70);
            this.label8.TabIndex = 66;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(131, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 70);
            this.label9.TabIndex = 65;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timesRightLabel.Location = new System.Drawing.Point(197, 202);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(68, 70);
            this.timesRightLabel.TabIndex = 64;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timesLeftLabel.Location = new System.Drawing.Point(54, 208);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(68, 71);
            this.timesLeftLabel.TabIndex = 63;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Restar
            // 
            this.Restar.BackColor = System.Drawing.Color.Maroon;
            this.Restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restar.ForeColor = System.Drawing.Color.Gray;
            this.Restar.Location = new System.Drawing.Point(330, 146);
            this.Restar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Restar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(101, 37);
            this.Restar.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(264, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 70);
            this.label4.TabIndex = 62;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(132, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 70);
            this.label5.TabIndex = 61;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusRightLabel.Location = new System.Drawing.Point(198, 138);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(68, 70);
            this.minusRightLabel.TabIndex = 60;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusLeftLabel.Location = new System.Drawing.Point(54, 138);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(68, 70);
            this.minusLeftLabel.TabIndex = 59;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.Color.Maroon;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.ForeColor = System.Drawing.Color.Gray;
            this.Sum.Location = new System.Drawing.Point(329, 88);
            this.Sum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(101, 37);
            this.Sum.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(263, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 70);
            this.label3.TabIndex = 58;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(131, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 70);
            this.label2.TabIndex = 57;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusRightLabel.Location = new System.Drawing.Point(197, 78);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(68, 70);
            this.plusRightLabel.TabIndex = 54;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusLeftLabel.Location = new System.Drawing.Point(53, 78);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(68, 70);
            this.plusLeftLabel.TabIndex = 52;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(131, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Time Left";
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Maroon;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.TimeLabel.Location = new System.Drawing.Point(329, 21);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 30);
            this.TimeLabel.TabIndex = 48;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FormaMateDificil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Trabajo1.Properties.Resources._44742;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 443);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormaMateDificil";
            this.Text = "FormaMateDificil";
            ((System.ComponentModel.ISupportInitialize)(this.Dividir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown Dividir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.NumericUpDown Multiplicar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown Restar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}