using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace START.Application.MSinhVien
{
    public interface iSinhVienService 
    {
        public Task<int> Create(SinhVienRequest request); //Kiểu int: nếu status ok => trả về 1
        public Task<int> Update(SinhVienRequest request);
        public Task<int> Delete(SinhVienRequest request);
        public Task<List<SinhVienResponse>> GetAll();
    }
}
