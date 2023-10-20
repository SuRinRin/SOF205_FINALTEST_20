namespace PRL.Forms
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
			button1 = new Button();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			textBox3 = new TextBox();
			label3 = new Label();
			textBox4 = new TextBox();
			label4 = new Label();
			sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			textBox5 = new TextBox();
			comboBox1 = new ComboBox();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 10);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "Hien Thi ";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(3, 260);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(794, 188);
			dataGridView1.TabIndex = 1;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 59);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 2;
			label1.Text = "Name";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(68, 56);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(321, 27);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(68, 105);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(321, 27);
			textBox2.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 108);
			label2.Name = "label2";
			label2.Size = new Size(37, 20);
			label2.TabIndex = 4;
			label2.Text = "Loai";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(68, 155);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(321, 27);
			textBox3.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 158);
			label3.Name = "label3";
			label3.Size = new Size(0, 20);
			label3.TabIndex = 6;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(68, 207);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(321, 27);
			textBox4.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 210);
			label4.Name = "label4";
			label4.Size = new Size(38, 20);
			label4.TabIndex = 8;
			label4.Text = "Tuoi";
			// 
			// button2
			// 
			button2.Location = new Point(587, 80);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 10;
			button2.Text = "Them";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(590, 124);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 11;
			button3.Text = "Sua";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(587, 172);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 12;
			button4.Text = "Xoa";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(434, 10);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(354, 27);
			textBox5.TabIndex = 13;
			textBox5.TextChanged += textBox5_TextChanged;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(637, 46);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 14;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 158);
			label5.Name = "label5";
			label5.Size = new Size(72, 20);
			label5.TabIndex = 15;
			label5.Text = "Mau long";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label5);
			Controls.Add(comboBox1);
			Controls.Add(textBox5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(textBox4);
			Controls.Add(label4);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private DataGridView dataGridView1;
		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private TextBox textBox3;
		private Label label3;
		private TextBox textBox4;
		private Label label4;
		private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
		private Button button2;
		private Button button3;
		private Button button4;
		private TextBox textBox5;
		private ComboBox comboBox1;
		private Label label5;
	}
}