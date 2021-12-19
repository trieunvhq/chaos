using Microsoft.EntityFrameworkCore;
using START.Data;
using START.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace START.Application.MLop
{
    public class LopService : iLopService
    {
        private readonly TrDbContext _trDbContext;
        public LopService(TrDbContext trDbContext)
        {
            _trDbContext = trDbContext;
        }

        public async Task<int> Create(LopRequest request)
        {
            var lop = new Lop()
            {
                name = request.name,
                numberSinhVien = request.numberSinhVien
            };

            _trDbContext.Lops.Add(lop);

            return await _trDbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(LopRequest request)
        {
            var lop = new Lop()
            {
                id = request.id
            };

            _trDbContext.Lops.Remove(lop);

            return await _trDbContext.SaveChangesAsync();
        }

        public Task<List<LopRespones>> GetAll()
        {
            var respones = _trDbContext.Lops.Select(x => new LopRespones()
            {
                id = x.id,
                name = x.name,
                numberSinhVien = x.numberSinhVien
            }).ToListAsync();

            return respones;
        }

        public async Task<int> Update(LopRequest request)
        {
            var lop = new Lop()
            {
                id = request.id,
                name = request.name,
                numberSinhVien = request.numberSinhVien
            };

            _trDbContext.Lops.Update(lop);

            return await _trDbContext.SaveChangesAsync();
        }
    }
}
