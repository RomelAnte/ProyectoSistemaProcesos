using System.Drawing.Drawing2D;
namespace ProyectoSistemaProcesos.GUI
{
    partial class Form_Ventas_Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ventas_Pagos));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel5 = new Panel();
            textBox7 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            label17 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBox6 = new TextBox();
            listBox2 = new ListBox();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            textBox8 = new TextBox();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(410, 6);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 12;
            label1.Text = "Ventas y Pagos";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 50);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(10, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 420);
            panel2.TabIndex = 15;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.cancel;
            pictureBox5.Location = new Point(190, 319);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 65);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 319);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(190, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(130, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(100, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(48, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(100, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(100, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 64);
            listBox1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(10, 250);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 7;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(155, 210);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 6;
            label8.Text = "%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(10, 210);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 5;
            label7.Text = "Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(10, 170);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 4;
            label6.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(10, 130);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 3;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(10, 50);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 2;
            label4.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 20);
            label3.Name = "label3";
            label3.Size = new Size(234, 17);
            label3.TabIndex = 1;
            label3.Text = "Ingrese la informacion de la ventana";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(381, 566);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Cantidad, Precio, Descuento, Total });
            dataGridView1.Location = new Point(390, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 130);
            dataGridView1.TabIndex = 16;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 114;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 114;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 114;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 114;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.Width = 114;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 114;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(393, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(724, 280);
            panel3.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox7);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(320, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(320, 255);
            panel5.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(10, 180);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 19);
            textBox7.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(10, 225);
            label16.Name = "label16";
            label16.Size = new Size(60, 18);
            label16.TabIndex = 6;
            label16.Text = "$ 0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(10, 200);
            label15.Name = "label15";
            label15.Size = new Size(79, 18);
            label15.TabIndex = 5;
            label15.Text = "Cambio:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(10, 150);
            label14.Name = "label14";
            label14.Size = new Size(91, 18);
            label14.TabIndex = 4;
            label14.Text = "Paga con:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(10, 85);
            label13.Name = "label13";
            label13.Size = new Size(60, 18);
            label13.TabIndex = 3;
            label13.Text = "$ 0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(10, 60);
            label12.Name = "label12";
            label12.Size = new Size(183, 18);
            label12.TabIndex = 2;
            label12.Text = "Total con descuento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(10, 30);
            label11.Name = "label11";
            label11.Size = new Size(60, 18);
            label11.TabIndex = 1;
            label11.Text = "$ 0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(10, 5);
            label10.Name = "label10";
            label10.Size = new Size(178, 18);
            label10.TabIndex = 0;
            label10.Text = "Total sin descuento:";
            // 
            // panel4
            // 
            panel4.Controls.Add(label17);
            panel4.Controls.Add(pictureBox8);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(listBox2);
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(285, 255);
            panel4.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(233, 13);
            label17.Name = "label17";
            label17.Size = new Size(43, 13);
            label17.TabIndex = 19;
            label17.Text = "Cliente";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Data_Filtering_128x128;
            pictureBox8.Location = new Point(205, 10);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_print;
            pictureBox3.Location = new Point(154, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.save;
            pictureBox4.Location = new Point(43, 169);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(10, 10);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(190, 23);
            textBox6.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(10, 50);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(220, 94);
            listBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(33, 18);
            label2.TabIndex = 0;
            label2.Text = "CI:";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.descarga;
            pictureBox6.Location = new Point(468, 566);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(65, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(130, 90);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 23);
            textBox8.TabIndex = 19;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Data_Filtering_128x128;
            pictureBox7.Location = new Point(335, 85);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // Form_Ventas_Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 636);
            Controls.Add(pictureBox7);
            Controls.Add(textBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "Form_Ventas_Pagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Ventas_Pagos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private void fondo()
        {
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, ColorTranslator.FromHtml("#FFFFFF"), ColorTranslator.FromHtml("#10739E"), 1f);
            this.BackgroundImage = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics g = Graphics.FromImage(this.BackgroundImage);
            g.FillRectangle(brush, ClientRectangle);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel5.BorderStyle = BorderStyle.FixedSingle;
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

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox6;
        private ListBox listBox2;
        private TextBox textBox7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private TextBox textBox8;
        private PictureBox pictureBox7;
        private Label label17;
        private PictureBox pictureBox8;
    }
}