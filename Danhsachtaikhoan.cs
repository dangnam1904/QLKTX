using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
   public class Danhsachtaikhoan
    {
        private static Danhsachtaikhoan instance;
        public static Danhsachtaikhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new Danhsachtaikhoan();
                return instance;
            }
            set => instance = value;
        }
        List<TaiKhoan> listtaikhoan;
        public  List<TaiKhoan> ListTaiKhoan
        {
            get => listtaikhoan;
            set => listtaikhoan = value;
        }
        Danhsachtaikhoan()
        {
            listtaikhoan = new List<TaiKhoan>();
            listtaikhoan.Add(new TaiKhoan("dangnam", "12345"));
        }
    }
}
