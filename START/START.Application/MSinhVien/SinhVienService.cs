using Microsoft.EntityFrameworkCore;
using START.Data;
using START.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace START.Application.MSinhVien
{
    public class SinhVienService : iSinhVienService
    {
        private readonly TrDbContext _trDbContext;
        public SinhVienService(TrDbContext trDbContext)
        {
            _trDbContext = trDbContext;
        }

        public async Task<int> Create(SinhVienRequest request)
        {
            var sinhVien = new SinhVien()
            {
                name = request.name,
                address = request.address
            };

            _trDbContext.SinhViens.Add(sinhVien);

            return await _trDbContext.SaveChangesAsync();
;        }

        public async Task<int> Delete(SinhVienRequest request)
        {
            var sinhVien = new SinhVien()
            {
                Id = request.Id
            };

            _trDbContext.SinhViens.Remove(sinhVien);

            return await _trDbContext.SaveChangesAsync();
        }

        public Task<List<SinhVienResponse>> GetAll()
        {
            var respones = _trDbContext.SinhViens.Select(x => new SinhVienResponse()
            {
                Id = x.Id,
                name = x.name,
                address = x.address
            }).ToListAsync();

            return respones;
        }

        public async Task<int> Update(SinhVienRequest request)
        {
            var sinhVien = new SinhVien()
            {
                Id = request.Id,
                name = request.name,
                address = request.address
            };

            _trDbContext.SinhViens.Update(sinhVien);

            return await _trDbContext.SaveChangesAsync();
        }
    }
}
