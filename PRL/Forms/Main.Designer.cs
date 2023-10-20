namespace PRL.Forms
{
	partial class Main
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
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 12);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 250);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(776, 188);
			dataGridView1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 59);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 2;
			label1.Text = "label1";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(77, 56);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(339, 27);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(77, 98);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(339, 27);
			textBox2.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 101);
			label2.Name = "label2";
			label2.Size = new Size(50, 20);
			label2.TabIndex = 4;
			label2.Text = "label2";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(77, 146);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(339, 27);
			textBox3.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 149);
			label3.Name = "label3";
			label3.Size = new Size(50, 20);
			label3.TabIndex = 6;
			label3.Text = "label3";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(77, 192);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(339, 27);
			textBox4.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 195);
			label4.Name = "label4";
			label4.Size = new Size(50, 20);
			label4.TabIndex = 8;
			label4.Text = "label4";
			// 
			// button2
			// 
			button2.Location = new Point(568, 59);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 10;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// button3
			// 
			button3.Location = new Point(568, 101);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 11;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(568, 149);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 12;
			button4.Text = "button4";
			button4.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
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
			Name = "Main";
			Text = "Main";
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
		private Button button2;
		private Button button3;
		private Button button4;
	}
}