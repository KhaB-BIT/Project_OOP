using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Desktop
{
    public class testDataGridView
    {
        public testDataGridView(int stt,string tenSach, string theLoai, int soLuong, int giaBan)
        {
            this.stt = stt;
            this.tenSach = tenSach;
            this.theLoai = theLoai;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
        }
        
        private int stt;
        private string tenSach;
        private string theLoai;
        private int giaBan;
        private int soLuong;

        public int Stt { get => stt; set => stt = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
