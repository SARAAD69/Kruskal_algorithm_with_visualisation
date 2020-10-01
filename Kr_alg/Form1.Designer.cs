namespace Kr_alg
{
    partial class Kruskal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Solve = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(48, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(876, 34);
            this.Solve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(123, 38);
            this.Solve.TabIndex = 1;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(876, 100);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(123, 37);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Min.ForeColor = System.Drawing.Color.Crimson;
            this.Min.Location = new System.Drawing.Point(685, 363);
            this.Min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(100, 44);
            this.Min.TabIndex = 3;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = false;
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Max.ForeColor = System.Drawing.Color.DarkCyan;
            this.Max.Location = new System.Drawing.Point(847, 362);
            this.Max.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 46);
            this.Max.TabIndex = 4;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 495);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Draw edges holding Ctrl and clicking on vertices to connect";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(722, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Kruskal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kruskal";
            this.Text = "Kruskal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button Clear;
        public System.Windows.Forms.Button Min;
        public System.Windows.Forms.Button Max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

