using System.Drawing.Drawing2D;

namespace ProyectoSistemaProcesos.GUI
{
    partial class Form_Moldes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Moldes));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            colorDialog1 = new ColorDialog();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 50);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 12);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 12;
            label1.Text = "Moldes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(33, 180);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 21;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(33, 240);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 22;
            label3.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(33, 300);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 23;
            label4.Text = "Talla:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(33, 360);
            label5.Name = "label5";
            label5.Size = new Size(93, 18);
            label5.TabIndex = 24;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(33, 420);
            label6.Name = "label6";
            label6.Size = new Size(60, 18);
            label6.TabIndex = 25;
            label6.Text = "Costo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(33, 480);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 26;
            label7.Text = "Total:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Delanteros", "Mangas", "Cuello" });
            comboBox1.Location = new Point(33, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 27;
            comboBox1.Text = "-- Seleccione el tipo --";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "2XL", "3XL" });
            comboBox2.Location = new Point(33, 330);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 23);
            comboBox2.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 390);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 30;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 450);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 31;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(31, 110);
            label8.Name = "label8";
            label8.Size = new Size(267, 38);
            label8.TabIndex = 33;
            label8.Text = "Ingresar datos:";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(35, 510);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 34;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.descarga;
            pictureBox4.Location = new Point(546, 390);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 75);
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.save;
            pictureBox1.Location = new Point(441, 390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(360, 110);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(170, 240);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(590, 220);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 70);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(31, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 23);
            panel2.TabIndex = 41;
            panel2.Click += OpenColorDialog;
            // 
            // Form_Moldes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(794, 611);
            Controls.Add(panel2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form_Moldes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Moldes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ColorDialog colorDialog1;
        private Panel panel2;
    }
}