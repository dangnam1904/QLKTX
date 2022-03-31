using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    public class TaiKhoan
    {
        private string tentaikhoan;
        public string TenTaiKhoan
        {
            get => tentaikhoan;
            set => tentaikhoan = value;
        }

        private string Matkhau;
        public string MatKhau
        {
            get => Matkhau;
            set => Matkhau = value;
        }
        public TaiKhoan(string tentaikhoan, string matkhau)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
        }

    }
}
