using BUS;
using BUS.Services;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
	public partial class Form1 : Form
	{
		private readonly ThuCungService _sv;
		int selectedId = -1;

		public Form1()
		{
			InitializeComponent();
			_sv = new ThuCungService();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			LoadaData();
		}
		async void LoadaData()
		{
			int stt = 1;
			var s = await _sv.GetThuCung();
			var c = await _sv.GetChuNhan();
			var g = s.Join(c, a => a.IdCn, b => b.Id, (a, b) => new ThuCungDTO()
			{
				STT = stt++, //0
				Ten = a.Ten, //1
				Loai = a.Loai, //2
				Maulong = a.Maulong, //3
				Tuoi = a.Tuoi, //4
				Diachi = b.Diachi, //5
				IdTc = a.Id,
			}).ToList();
			dataGridView1.DataSource = g.ToList();
		}
		private async void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var s = await _sv.Create(new ThuCungCreateRequest()
				{
					Ten = textBox1.Text,
					Loai = textBox2.Text,
					Maulong = textBox3.Text,
					Tuoi = Convert.ToInt32(textBox4.Text),
					IdCn = 1,
				});
				LoadaData();
				MessageBox.Show("Them Thanh cong");
			}
			catch
			{
				MessageBox.Show("Them that bai");
			}

		}

		void LoadComboBox()
		{
			comboBox1.Items.Add("Loai");//0
			comboBox1.Items.Add("Mau Long");//1
			comboBox1.Items.Add("Ten Chu"); //2
			comboBox1.Items.Add("Thu cung"); //3

		}


		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());

		}

		private async void button4_Click(object sender, EventArgs e)
		{
			try
			{
				var c = await _sv.Delete(selectedId);
				LoadaData();
				MessageBox.Show("Xoa Thanh cong");
			}
			catch
			{
				MessageBox.Show("Xoa that bai");
			}

		}
		private async void button3_Click(object sender, EventArgs e)
		{
			try
			{
				var s = await _sv.Update(selectedId, new ThuCungCreateRequest()
				{
					Ten = textBox1.Text,
					Loai = textBox2.Text,
					Maulong = textBox3.Text,
					Tuoi = Convert.ToInt32(textBox4.Text),
					IdCn = 1,
				});
				MessageBox.Show("Sua Thanh cong");

			}
			catch
			{
				MessageBox.Show("Sua that bai");

			}

		}

		private async void textBox5_TextChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				var c = await _sv.GetThuCung();
				var b = c.Where(x => x.Loai.ToLower().Trim().Contains(textBox5.Text.ToLower().Trim())).ToList();
			}
			if (comboBox1.SelectedIndex == 1)
			{
				var c = await _sv.GetThuCung();
				var b = c.Where(x => x.Maulong.Contains(textBox5.Text)).ToList();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadaData();
			LoadComboBox();
		}
	}
}
