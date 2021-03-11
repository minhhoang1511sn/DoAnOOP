using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class ChuongNuoi
    {
        public string MaChuong { get; set; }
        public string LoaiChuong { get; set; }
        public string MaDongVat { get; set; }
        public string MaPhongBan { get; set; }

        public ChuongNuoi(string MaChuong, string LoaiChuong, string MaDongVat, string MaPhongBan)
        {
            this.MaChuong = MaChuong;
            this.LoaiChuong = LoaiChuong;
            this.MaDongVat = MaDongVat;
            this.MaPhongBan = MaPhongBan;
        }

        public ChuongNuoi(ChuongNuoi CN)
        {
            if (CN != null)
            {
                this.MaChuong = CN.MaChuong;
                this.LoaiChuong = CN.LoaiChuong;
                this.MaDongVat = CN.MaDongVat;
                this.MaPhongBan = CN.MaPhongBan;
            }
        }
    }
}