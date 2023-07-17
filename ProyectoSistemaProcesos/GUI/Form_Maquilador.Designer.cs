using System.Drawing.Drawing2D;

namespace ProyectoSistemaProcesos
{
    partial class Form_Maquilador
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            panel3 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(10, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(780, 483);
            panel3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(430, 280);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 90);
            textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(430, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 34);
            textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(35, 150);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 310);
            textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(35, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 34);
            textBox1.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(450, 250);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 31;
            label5.Text = "Ordenes de trabajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(530, 150);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 30;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(35, 120);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 29;
            label3.Text = "Información";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(35, 40);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 28;
            label2.Text = "Buscar";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.descarga;
            pictureBox4.Location = new Point(540, 405);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 75);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 90);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 26);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 12;
            label1.Text = "Maquilador";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Data_Filtering_128x128;
            pictureBox7.Location = new Point(314, 64);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 36;
            pictureBox7.TabStop = false;
            // 
            // Form_Maquilador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 611);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form_Maquilador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Maquilador";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void fondo()
        {
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, ColorTranslator.FromHtml("#FFFFFF"), ColorTranslator.FromHtml("#10739E"), 0f);
            this.BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics g = Graphics.FromImage(this.BackgroundImage);
            g.FillRectangle(brush, ClientRectangle);
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel1.ClientRectangle;
            LinearGradientBrush brush1 = new LinearGradientBrush(rect, Color.White, ColorTranslator.FromHtml("#1BA1E2"), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush1, rect);
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Cambiar el radio para ajustar la curvatura
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel1.Region = new Region(path);
            Pen pen = new Pen(Color.Black, 1); // Tamaño y color del borde
            e.Graphics.DrawPath(pen, path);
        }
        private Panel panel3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox7;
    }
}