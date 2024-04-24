using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl
{
    internal class NhanVien
    {
        private string IDNhanVien {  get; set; }
        private string IDTaiKhoang { get; set; }
        private string TenNhanVien { get; set; }
        private DateTime NgaySinh { get; set; }
        private bool GioiTinh { get; set; } // true: Nam, false: Nữ
        private string ViTri { get; set; }
        private string SoDienThoai { get; set; }
        private string DiaChi { get; set;}

    }
}
