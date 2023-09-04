using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Shopping_Online.DTO
{
    internal class SANPHAM
    {
        private int maSP;
        private string tenSP;
        private int maLoaiSP;
        private int gia;
        private string ram;
        private string rom;
        private string chip;
        private string camera;
        private string namSX;
        private string quocGia;

        public int MaSP { get => maSP; set => maSP=value; }
        public string TenSP { get => tenSP; set => tenSP=value; }
        public int MaLoaiSP { get => maLoaiSP; set => maLoaiSP=value; }
        public int Gia { get => gia; set => gia=value; }
        public string Ram { get => ram; set => ram=value; }
        public string Rom { get => rom; set => rom=value; }
        public string Chip { get => chip; set => chip=value; }
        public string Camera { get => camera; set => camera=value; }
        public string NamSX { get => namSX; set => namSX=value; }
        public string QuocGia { get => quocGia; set => quocGia=value; }

        public SANPHAM(int masp, string tensp, int maloaisp, int gia, string ram, string rom, string chip, string camera, string namsx, string qg)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.MaLoaiSP = maloaisp;
            this.Gia = gia;
            this.Ram = ram;
            this.Rom = rom;
            this.Chip = chip;
            this.Camera = camera;
            this.NamSX = namsx;
            this.QuocGia = quocGia;
        }
        public SANPHAM(DataRow row)
        {
            this.MaSP = (int)row["MaSP"];
            this.TenSP = row["TenSP"].ToString();
            this.MaLoaiSP = (int)row["MaLoaiSp"];
            this.Gia = (int)Convert.ToDouble(row["Gia"].ToString());
            this.Ram = row["Ram"].ToString();
            this.Rom = row["Rom"].ToString();
            this.Chip = row["Chip"].ToString();
            this.Camera = row["Camera"].ToString();
            this.NamSX = row["NamSX"].ToString();
            this.QuocGia = row["QuocGia"].ToString();
        }
    }
}
