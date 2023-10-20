using BUS;
using BUS.IServices;
using BUS.Services;
using DAL.DomainClass;
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
	public partial class Main : Form
	{
		private readonly ThuCungService service;
		public Main()
		{
			service = new ThuCungService();
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			LoadData();
		}
		async void LoadData()
		{
			var c = await service.GetThuCung();
			dataGridView1.DataSource = c.ToList();
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			//thêm 
			var c = await service.Create(new()
			{
				Ten = textBox1.Text,
				Loai = textBox2.Text,
				Maulong = textBox3.Text,
				Tuoi = Convert.ToInt32(textBox4.Text),
				IdCn = 1,
			});
			LoadData();
		}

		private async void button2_Click_1(object sender, EventArgs e)
		{
//thêm 
			var c = await service.Create(new Thucung()
			{
				Ten = textBox1.Text,
				Loai = textBox2.Text,
				Maulong = textBox3.Text,
				Tuoi = Convert.ToInt32(textBox4.Text),
				IdCn = null
			});
			LoadData();
		}

		
	}
}
