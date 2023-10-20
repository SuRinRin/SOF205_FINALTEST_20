using DAL.Context;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
	public interface IThuCungRespoisitories
	{

        Task<IEnumerable<Thucung>> GetThuCung();
        Task<IEnumerable<Chunhan>> GetChu();

        Task<Thucung> Create(Thucung tc);

        Task<Thucung> Update(Thucung tc);

        Task<Thucung> Delete(int tc);
        Task<Thucung> GetById(int tc);

    }
}
