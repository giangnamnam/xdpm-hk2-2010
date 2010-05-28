using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _46_47_48_49_50_ToanLop3.Phan4.DTO
{
    class PhepTinhDTO
    {
        private int soThuNhat;

        public int SoThuNhat
        {
            get { return soThuNhat; }
            set { soThuNhat = value; }
        }
        private int soThuHai;

        public int SoThuHai
        {
            get { return soThuHai; }
            set { soThuHai = value; }
        }
        
        private int ketQua;

        public int KetQua
        {
            get { return ketQua; }
            set { ketQua = value; }
        }

        public PhepTinhDTO() { }

        public PhepTinhDTO(int soThuNhat, int soThuHai, int ketQua)
        {
            this.soThuNhat = soThuNhat;
            this.soThuHai = soThuHai;
            this.ketQua = ketQua;
        }
    }
}
