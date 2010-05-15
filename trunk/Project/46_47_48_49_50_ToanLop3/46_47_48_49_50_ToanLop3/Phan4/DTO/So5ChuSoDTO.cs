using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _46_47_48_49_50_ToanLop3.Phan4.DTO
{
    class So5ChuSoDTO
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
        private int phepTinh;

        public int PhepTinh
        {
            get { return phepTinh; }
            set { phepTinh = value; }
        }
        private int ketQua;

        public int KetQua
        {
            get { return ketQua; }
            set { ketQua = value; }
        }

        public So5ChuSoDTO() { }
        
        public So5ChuSoDTO(int soThuNhat, int soThuHai, int phepTinh, int ketQua) {
            this.soThuNhat = soThuNhat;
            this.soThuHai = soThuHai;
            this.phepTinh = phepTinh;
            this.ketQua = ketQua;
        }


    }
   
}
