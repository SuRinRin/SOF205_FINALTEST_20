using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
	public interface IThuCungService
	{
		Task<IEnumerable<Thucung>> GetThuCung();
		Task<IEnumerable<Chunhan>> GetChuNhan();
		Task<Thucung> Create(ThuCungCreateRequest tc);

		Task<Thucung> Update(int id, ThuCungCreateRequest tc);

		Task<Thucung> Delete(int tc);
	}
}
