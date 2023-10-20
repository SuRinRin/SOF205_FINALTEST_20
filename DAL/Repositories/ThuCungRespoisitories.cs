using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class ThuCungRespoisitories : IThuCungRespoisitories 
	{

		private readonly ThiThuDBContext dBContext;
		public ThuCungRespoisitories()
		{
			dBContext = new ThiThuDBContext();
		}
		public async Task<IEnumerable<Thucung>> GetThuCung()
		{
			return await dBContext.Thucungs.ToListAsync();
		}
		public async Task<Thucung> Create(Thucung tc)
		{
			await dBContext.Thucungs.AddAsync(tc);
			await dBContext.SaveChangesAsync();
			return tc;
		}
		public async Task<Thucung> Update(Thucung tc)
		{
			dBContext.Thucungs.Update(tc);
			await dBContext.SaveChangesAsync();
			return tc;
		}
		public async Task<Thucung> Delete(int tc)
		{
			var c = await dBContext.Thucungs.FindAsync(tc);
			dBContext.Thucungs.Remove(c);
			await dBContext.SaveChangesAsync();
			return c;
		}

		public async Task<Thucung> GetById(int tc)
		{
			var a = await dBContext.Thucungs.FindAsync(tc);
			return a;
		}

		public async  Task<IEnumerable<Chunhan>> GetChu()
		{
			return await dBContext.Chunhans.ToListAsync();

		}

	}
}
