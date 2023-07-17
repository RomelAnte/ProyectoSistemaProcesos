using System.Drawing.Drawing2D;
namespace ProyectoSistemaProcesos.GUI
{
    partial class Form_Inventario
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label18 = new Label();
            pictureBox6 = new PictureBox();
            textBox9 = new TextBox();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBox8 = new TextBox();
            pictureBox7 = new PictureBox();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(450, 6);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 12;
            label1.Text = "Inventario";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 50);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(10, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 500);
            panel2.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(170, 380);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(10, 380);
            label10.Name = "label10";
            label10.Size = new Size(71, 17);
            label10.TabIndex = 23;
            label10.Text = "Proveedor:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(170, 340);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(200, 23);
            textBox10.TabIndex = 22;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label18.Location = new Point(10, 340);
            label18.Name = "label18";
            label18.Size = new Size(46, 17);
            label18.TabIndex = 21;
            label18.Text = "Fecha:";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.descarga;
            pictureBox6.Location = new Point(819, 290);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(80, 80);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(170, 300);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(200, 23);
            textBox9.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icons8_synchronize_80;
            pictureBox2.Location = new Point(714, 290);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(10, 300);
            label9.Name = "label9";
            label9.Size = new Size(68, 17);
            label9.TabIndex = 19;
            label9.Text = "Categoria:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.cancel;
            pictureBox5.Location = new Point(605, 290);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.save;
            pictureBox1.Location = new Point(486, 290);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 130);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 75);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(10, 260);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 6;
            label8.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(10, 220);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 5;
            label7.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(10, 130);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 4;
            label6.Text = "Descripcion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(10, 90);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 3;
            label5.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(10, 50);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 2;
            label4.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 25);
            label3.Name = "label3";
            label3.Size = new Size(235, 18);
            label3.TabIndex = 1;
            label3.Text = "Ingrese del nuevo producto";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7 });
            dataGridView1.Location = new Point(390, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 65;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 130);
            dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.Width = 110;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.Name = "Column2";
            Column2.Width = 110;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            Column3.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "Categoria";
            Column4.Name = "Column4";
            Column4.Width = 110;
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha";
            Column5.Name = "Column5";
            Column5.Width = 110;
            // 
            // Column7
            // 
            Column7.HeaderText = "Proveedor";
            Column7.Name = "Column7";
            Column7.Width = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(10, 15);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 0;
            label2.Text = "Producto:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(120, 15);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 23);
            textBox8.TabIndex = 19;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Data_Filtering_128x128;
            pictureBox7.Location = new Point(280, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(textBox8);
            panel6.Location = new Point(10, 70);
            panel6.Name = "panel6";
            panel6.Size = new Size(1112, 50);
            panel6.TabIndex = 21;
            
            panel6.BackColor = Color.Transparent;
            panel6.Paint += panel2_Paint;
            // 
            // Form_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 636);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Name = "Form_Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Ventas_Pagos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel1.ClientRectangle;
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
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox textBox8;
        private PictureBox pictureBox7;
        private Panel panel6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox10;
        private Label label18;
        private TextBox textBox9;
        private Label label9;
    }
}