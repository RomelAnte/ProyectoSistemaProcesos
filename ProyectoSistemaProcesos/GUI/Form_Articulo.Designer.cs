using System.Drawing.Drawing2D;

namespace ProyectoSistemaProcesos.GUI
{
    partial class Form_Articulo
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.descarga;
            pictureBox4.Location = new Point(550, 340);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 75);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cancel;
            pictureBox3.Location = new Point(660, 205);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 75);
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_synchronize_80;
            pictureBox2.Location = new Point(550, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 75);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.save;
            pictureBox1.Location = new Point(440, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(159, 260);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 75);
            textBox8.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(159, 220);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 23);
            textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(159, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(12, 220);
            label8.Name = "label8";
            label8.Size = new Size(52, 19);
            label8.TabIndex = 5;
            label8.Text = "Costo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(15, 140);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 4;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(15, 100);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 3;
            label6.Text = "Material:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(15, 60);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 2;
            label5.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(19, 20);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(290, 6);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 12;
            label1.Text = "Articulos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 50);
            panel2.TabIndex = 17;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Data_Filtering_128x128;
            pictureBox7.Location = new Point(315, 7);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 21;
            pictureBox7.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 13;
            label2.Text = "Articulo";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 50);
            panel1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(15, 260);
            label9.Name = "label9";
            label9.Size = new Size(94, 19);
            label9.TabIndex = 6;
            label9.Text = "Descripcion:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(17, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(760, 450);
            panel3.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(16, 350);
            label11.Name = "label11";
            label11.Size = new Size(52, 19);
            label11.TabIndex = 34;
            label11.Text = "Costo:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(159, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(15, 390);
            label10.Name = "label10";
            label10.Size = new Size(60, 19);
            label10.TabIndex = 32;
            label10.Text = "Estado:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(159, 390);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Pasivo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(15, 180);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 29;
            label4.Text = "Fecha adquisiscion:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Telas: Diferentes tipos de telas, como algodón, lino, seda, poliéster, denim, cuero, etc., se utilizan para confeccionar las prendas.", "", "Hilos: Hilos de diferentes grosores y colores se usan para coser las piezas de tela y dar forma a la prenda.", "", "Botones: Se utilizan para abrochar la ropa y como elementos decorativos.", "", "Cierres: Cremalleras y otros tipos de cierres son comunes en prendas como pantalones, faldas y chaquetas.", "", "Etiquetas: Etiquetas de tela o papel con información sobre la marca, talla, cuidados, etc.", "", "Entretelas: Se utilizan para reforzar áreas específicas de la prenda.", "", "Tijeras y cortadores: Herramientas para cortar las telas y otros materiales de forma precisa.", "", "Máquinas de coser: Se utilizan para coser las piezas de tela y realizar diversas operaciones de costura.", "", "Reglas y cintas métricas: Se usan para medir y marcar las telas y asegurar que las prendas tengan las dimensiones correctas.", "", "Patrones: Plantillas de papel o cartón que se utilizan para cortar las telas según el diseño deseado.", "", "Planchas y tablas de planchar: Se utilizan para alisar las telas y las costuras.", "", "Alfileres y alfileres de seguridad: Se utilizan para mantener las piezas de tela en su lugar antes de coserlas.", "", "Dedales: Protegen los dedos del cosedor al coser a mano.", "", "Máquinas de corte y plotter: Se utilizan para cortar las telas de manera precisa y eficiente.", "", "Cinta de bies: Se utiliza para rematar los bordes de las prendas." });
            comboBox1.Location = new Point(159, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 28;
            // 
            // Form_Articulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form_Articulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private void fondo()
        {
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, ColorTranslator.FromHtml("#FFFFFF"), ColorTranslator.FromHtml("#10739E"), 0f);
            this.BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics g = Graphics.FromImage(this.BackgroundImage);
            g.FillRectangle(brush, ClientRectangle);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel1.ClientRectangle;
            LinearGradientBrush brush1 = new LinearGradientBrush(rect, Color.White, ColorTranslator.FromHtml("#1BA1E2"), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush1, rect);
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel1.Region = new Region(path);
            panel2.Region = new Region(path);
            Pen pen = new Pen(Color.Black, 1);
            e.Graphics.DrawPath(pen, path);
        }
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label9;
        private Panel panel3;
        private ComboBox comboBox1;
        private PictureBox pictureBox7;
        private Label label4;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
    }
}