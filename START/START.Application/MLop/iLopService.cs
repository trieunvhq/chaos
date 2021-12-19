using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace START.Application.MLop
{
    public interface iLopService
    {
        public Task<int> Create(LopRequest request); //Kiểu int: nếu status ok => trả về 1
        public Task<int> Update(LopRequest request);
        public Task<int> Delete(LopRequest request);
        public Task<List<LopRespones>> GetAll();
    }
}
