namespace LocalOrsplaynInterpolation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SplaynRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y4 = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.y5 = new System.Windows.Forms.TextBox();
            this.x5 = new System.Windows.Forms.TextBox();
            this.y6 = new System.Windows.Forms.TextBox();
            this.x6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BitmapGraph = new System.Windows.Forms.GroupBox();
            this.pl = new System.Windows.Forms.Button();
            this.mn = new System.Windows.Forms.Button();
            this.ScrollV = new System.Windows.Forms.VScrollBar();
            this.ScrollH = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // SplaynRun
            // 
            this.SplaynRun.Location = new System.Drawing.Point(639, 218);
            this.SplaynRun.Name = "SplaynRun";
            this.SplaynRun.Size = new System.Drawing.Size(120, 267);
            this.SplaynRun.TabIndex = 0;
            this.SplaynRun.Text = "Splayn";
            this.SplaynRun.UseVisualStyleBackColor = true;
            this.SplaynRun.Click += new System.EventHandler(this.SplaynRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(635, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(639, 42);
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            this.x1.Size = new System.Drawing.Size(50, 20);
            this.x1.TabIndex = 2;
            this.x1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x1_KeyDown);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(709, 42);
            this.y1.Name = "y1";
            this.y1.ReadOnly = true;
            this.y1.Size = new System.Drawing.Size(50, 20);
            this.y1.TabIndex = 3;
            this.y1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y1_KeyDown);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(709, 72);
            this.y2.Name = "y2";
            this.y2.ReadOnly = true;
            this.y2.Size = new System.Drawing.Size(50, 20);
            this.y2.TabIndex = 5;
            this.y2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y2_KeyDown);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(639, 72);
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            this.x2.Size = new System.Drawing.Size(50, 20);
            this.x2.TabIndex = 4;
            this.x2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x2_KeyDown);
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(709, 132);
            this.y4.Name = "y4";
            this.y4.ReadOnly = true;
            this.y4.Size = new System.Drawing.Size(50, 20);
            this.y4.TabIndex = 9;
            this.y4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y4_KeyDown);
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(639, 132);
            this.x4.Name = "x4";
            this.x4.ReadOnly = true;
            this.x4.Size = new System.Drawing.Size(50, 20);
            this.x4.TabIndex = 8;
            this.x4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x4_KeyDown);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(709, 102);
            this.y3.Name = "y3";
            this.y3.ReadOnly = true;
            this.y3.Size = new System.Drawing.Size(50, 20);
            this.y3.TabIndex = 7;
            this.y3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y3_KeyDown);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(639, 102);
            this.x3.Name = "x3";
            this.x3.ReadOnly = true;
            this.x3.Size = new System.Drawing.Size(50, 20);
            this.x3.TabIndex = 6;
            this.x3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x3_KeyDown);
            // 
            // y5
            // 
            this.y5.Location = new System.Drawing.Point(709, 162);
            this.y5.Name = "y5";
            this.y5.ReadOnly = true;
            this.y5.Size = new System.Drawing.Size(50, 20);
            this.y5.TabIndex = 11;
            this.y5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y5_KeyDown);
            // 
            // x5
            // 
            this.x5.Location = new System.Drawing.Point(639, 162);
            this.x5.Name = "x5";
            this.x5.ReadOnly = true;
            this.x5.Size = new System.Drawing.Size(50, 20);
            this.x5.TabIndex = 10;
            this.x5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x5_KeyDown);
            // 
            // y6
            // 
            this.y6.Location = new System.Drawing.Point(709, 192);
            this.y6.Name = "y6";
            this.y6.ReadOnly = true;
            this.y6.Size = new System.Drawing.Size(50, 20);
            this.y6.TabIndex = 13;
            this.y6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y6_KeyDown);
            // 
            // x6
            // 
            this.x6.Location = new System.Drawing.Point(639, 192);
            this.x6.Name = "x6";
            this.x6.ReadOnly = true;
            this.x6.Size = new System.Drawing.Size(50, 20);
            this.x6.TabIndex = 12;
            this.x6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x6_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(705, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            // 
            // BitmapGraph
            // 
            this.BitmapGraph.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BitmapGraph.Location = new System.Drawing.Point(12, 10);
            this.BitmapGraph.MaximumSize = new System.Drawing.Size(600, 600);
            this.BitmapGraph.MinimumSize = new System.Drawing.Size(600, 600);
            this.BitmapGraph.Name = "BitmapGraph";
            this.BitmapGraph.Size = new System.Drawing.Size(600, 600);
            this.BitmapGraph.TabIndex = 15;
            this.BitmapGraph.TabStop = false;
            this.BitmapGraph.Text = "График";
            // 
            // pl
            // 
            this.pl.Location = new System.Drawing.Point(639, 491);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(55, 140);
            this.pl.TabIndex = 16;
            this.pl.Text = "+";
            this.pl.UseVisualStyleBackColor = true;
            this.pl.Click += new System.EventHandler(this.pl_Click);
            // 
            // mn
            // 
            this.mn.Location = new System.Drawing.Point(704, 491);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(55, 140);
            this.mn.TabIndex = 17;
            this.mn.Text = "-";
            this.mn.UseVisualStyleBackColor = true;
            this.mn.Click += new System.EventHandler(this.mn_Click);
            // 
            // ScrollV
            // 
            this.ScrollV.Location = new System.Drawing.Point(615, 10);
            this.ScrollV.Maximum = 600;
            this.ScrollV.Name = "ScrollV";
            this.ScrollV.Size = new System.Drawing.Size(17, 600);
            this.ScrollV.SmallChange = 10;
            this.ScrollV.TabIndex = 18;
            this.ScrollV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollV_Scroll);
            // 
            // ScrollH
            // 
            this.ScrollH.Location = new System.Drawing.Point(12, 613);
            this.ScrollH.Maximum = 600;
            this.ScrollH.Name = "ScrollH";
            this.ScrollH.Size = new System.Drawing.Size(600, 21);
            this.ScrollH.SmallChange = 10;
            this.ScrollH.TabIndex = 19;
            this.ScrollH.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollH_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 633);
            this.Controls.Add(this.ScrollH);
            this.Controls.Add(this.ScrollV);
            this.Controls.Add(this.mn);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.BitmapGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y6);
            this.Controls.Add(this.x6);
            this.Controls.Add(this.y5);
            this.Controls.Add(this.x5);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SplaynRun);
            this.MaximumSize = new System.Drawing.Size(831, 672);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SplaynRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y4;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox y5;
        private System.Windows.Forms.TextBox x5;
        private System.Windows.Forms.TextBox y6;
        private System.Windows.Forms.TextBox x6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BitmapGraph;
        private System.Windows.Forms.Button pl;
        private System.Windows.Forms.Button mn;
        private System.Windows.Forms.VScrollBar ScrollV;
        private System.Windows.Forms.HScrollBar ScrollH;
    }
}

