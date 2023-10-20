using BUS.IServices;
using DAL.DomainClass;
using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
	public class ThuCungService : IThuCungService
	{
		private readonly ThuCungRespoisitories _repo;
		public ThuCungService()
		{
			_repo = new ThuCungRespoisitories();
		}
		public Task<Thucung> Create(ThuCungCreateRequest tc)
		{
			var a = _repo.Create(new Thucung()
			{
				Ten = tc.Ten,
				Loai = tc.Loai,
				Maulong = tc.Maulong,
				Tuoi = tc.Tuoi,
				IdCn = 1,
			});
			return a;

		}
		public  Task<Thucung> Delete(int tc)
		{
			var a = _repo.Delete(tc);
			return a;
		}

		public async Task<IEnumerable<Thucung>> GetThuCung()
		{
			var c = await _repo.GetThuCung();
			//var k = await _repo.GetChu();
			//int stt = 0;
			return c;
		}
		public async Task<IEnumerable<Chunhan>> GetChuNhan()
		{
			var c = await _repo.GetChu();
			//var k = await _repo.GetChu();
			//int stt = 0;
			return c;
		}
		public async Task<Thucung> Update(int id, ThuCungCreateRequest tc)
		{
			var a = await _repo.GetById(id);
				return await _repo.Update(a);			
		}
		
	}
}
