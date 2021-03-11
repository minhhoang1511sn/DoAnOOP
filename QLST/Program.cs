/** Đồ án cuối kì Lập Trình Hường Đối Tượng
 * Lê Trần Minh Nhựt - 19110257 - Trưởng Nhóm
 * Lê Vũ Minh Hoàng - 19119181
 * Nguyễn Thanh Minh Đức - 19110017
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class Program
    {
        public static RandomDate date = new RandomDate();
        public static List<Ve> ve = new List<Ve>();
        public static List<ThucAn> dt = new List<ThucAn>();
        public static List<DongVat> dv = new List<DongVat>();
        public static List<KhachXem> kx = new List<KhachXem>();
        public static List<PhongBan> pb = new List<PhongBan>();
        public static List<KhauPhan> kp = new List<KhauPhan>();
        public static List<NhanVien> nv = new List<NhanVien>();
        public static List<ChuongNuoi> cn = new List<ChuongNuoi>();
        public static List<CongTyBanVe> ct = new List<CongTyBanVe>();
        public static List<LoaiDongVat> ldv = new List<LoaiDongVat>();
        public static List<DVChuongNuoi> dvcn = new List<DVChuongNuoi>();

        public static void TaoDSDongVat()
        {
            dv.Add(new DongVat("Sư Tử", "01", "anthit"));
            dv.Add(new DongVat("Hổ", "02", "anthit"));
            dv.Add(new DongVat("Voi Châu Á", "03", "anco"));
            dv.Add(new DongVat("Hươu Cao Cổ", "04", "anco"));
            dv.Add(new DongVat("Linh Dương", "05", "anco"));
            dv.Add(new DongVat("Thằn Lằn", "06", "anthit"));
            dv.Add(new DongVat("Đười Ươi", "07", "anco"));
            dv.Add(new DongVat("Khỉ", "08", "anco"));
            dv.Add(new DongVat("Gấu", "09", "anthit"));
            dv.Add(new DongVat("Khỉ Sóc", "10", "anco"));
            dv.Add(new DongVat("Hà Mã", "11", "anthit"));
            dv.Add(new DongVat("Ngựa Vằn", "12", "anco"));
            dv.Add(new DongVat("Gấu Ngựa", "13", "anthit"));
            dv.Add(new DongVat("Sói Xám", "14", "anthit"));
            dv.Add(new DongVat("Tê Giác", "15", "anco"));
            dv.Add(new DongVat("Sóc Đen Côn Đảo", "16", "soc"));
            dv.Add(new DongVat("Cầy Mực", "17", "chon"));
            dv.Add(new DongVat("Cóc Mày Mắt Đỏ", "18", "luongcu"));
            dv.Add(new DongVat("Cá Heo", "19", "ca"));
            dv.Add(new DongVat("Báo Lửa", "20", "anthit"));
            dv.Add(new DongVat("Bọ Hung Ba Sừng", "21", "contrung"));
            dv.Add(new DongVat("Rái Cá", "22", "anthit"));
            dv.Add(new DongVat("Bướm Chúa Rừng", "23", "contrung"));
            dv.Add(new DongVat("Rắn Hổ Mang Chú", "24", "bosat"));
            dv.Add(new DongVat("Sói Xám", "25", "anthit"));
            dv.Add(new DongVat("Cò Quắm Đỏ", "26", "chim"));
            dv.Add(new DongVat("Bướm Châu Phi", "27", "contrung"));
            dv.Add(new DongVat("Bọ Cánh Đỏ", "28", "contrung"));
        }

        public static void TaoDSLoaiDongVat()
        {
            ldv.Add(new LoaiDongVat("Bò Sát", "bosat"));
            ldv.Add(new LoaiDongVat("Chim", "chim"));
            ldv.Add(new LoaiDongVat("Lưỡng Cư", "luongcu"));
            ldv.Add(new LoaiDongVat("Côn Trùng", "contrung"));
            ldv.Add(new LoaiDongVat("Cá", "ca"));
            ldv.Add(new LoaiDongVat("Chồn", "chon"));
            ldv.Add(new LoaiDongVat("Sóc", "soc"));
            ldv.Add(new LoaiDongVat("Ăn Thịt", "anthit"));
            ldv.Add(new LoaiDongVat("Ăn Cỏ", "anco"));
        }

        public static void TaoDSChuongNuoi()
        {
            cn.Add(new ChuongNuoi("A", "Đặc Biệt", "01", "PB11"));
            cn.Add(new ChuongNuoi("B", "Thường", "02", "PB8"));
            cn.Add(new ChuongNuoi("C", "Thường", "03", "PB8"));
            cn.Add(new ChuongNuoi("D", "Thường", "04", "PB8"));
            cn.Add(new ChuongNuoi("E", "Thường", "05", "PB8"));
            cn.Add(new ChuongNuoi("F", "Đặc Biệt", "06", "PB11"));
            cn.Add(new ChuongNuoi("G", "Thường", "07", "PB9"));
            cn.Add(new ChuongNuoi("H", "Thường", "08", "PB9"));
            cn.Add(new ChuongNuoi("I", "Đặc Biệt", "09", "PB11"));
            cn.Add(new ChuongNuoi("J", "Thường", "10", "PB9"));
            cn.Add(new ChuongNuoi("K", "Thường", "11", "PB9"));
            cn.Add(new ChuongNuoi("L", "Đặc Biệt", "12", "PB11"));
            cn.Add(new ChuongNuoi("M", "Thường", "13", "PB10"));
            cn.Add(new ChuongNuoi("N", "Đặc Biệt", "14", "PB11"));
            cn.Add(new ChuongNuoi("O", "Đặc Biệt", "15", "PB11"));
            cn.Add(new ChuongNuoi("P", "Thường", "16", "PB10"));
            cn.Add(new ChuongNuoi("Q", "Thường", "17", "PB8"));
            cn.Add(new ChuongNuoi("R", "Đặc Biệt", "18", "PB11"));
            cn.Add(new ChuongNuoi("S", "Thường", "19", "PB9"));
            cn.Add(new ChuongNuoi("T", "Đặc Biệt", "20", "PB9"));
            cn.Add(new ChuongNuoi("U", "Thường", "21", "PB9"));
            cn.Add(new ChuongNuoi("V", "Thường", "22", "PB9"));
            cn.Add(new ChuongNuoi("W", "Thường", "23", "PB9"));
            cn.Add(new ChuongNuoi("X", "Đặc Biệt", "24", "PB11"));
            cn.Add(new ChuongNuoi("Y", "Thường", "25", "PB11"));
            cn.Add(new ChuongNuoi("Z", "Đặc Biệt", "26", "PB11"));
            cn.Add(new ChuongNuoi("AA", "Thường", "27", "PB10"));
            cn.Add(new ChuongNuoi("AB", "Đặc Biệt", "28", "PB11"));
        }

        public static void TaoDSDVChuongNuoi()
        {
            dvcn.Add(new DVChuongNuoi("01", "A", date, 2));
            dvcn.Add(new DVChuongNuoi("02", "B", date, 2));
            dvcn.Add(new DVChuongNuoi("03", "C", date, 2));
            dvcn.Add(new DVChuongNuoi("04", "D", date, 2));
            dvcn.Add(new DVChuongNuoi("05", "E", date, 4));
            dvcn.Add(new DVChuongNuoi("06", "F", date, 4));
            dvcn.Add(new DVChuongNuoi("07", "G", date, 4));
            dvcn.Add(new DVChuongNuoi("08", "H", date, 4));
            dvcn.Add(new DVChuongNuoi("09", "I", date, 8));
            dvcn.Add(new DVChuongNuoi("10", "J", date, 8));
            dvcn.Add(new DVChuongNuoi("11", "K", date, 8));
            dvcn.Add(new DVChuongNuoi("12", "L", date, 8));
            dvcn.Add(new DVChuongNuoi("13", "M", date, 12));
            dvcn.Add(new DVChuongNuoi("14", "N", date, 12));
            dvcn.Add(new DVChuongNuoi("15", "O", date, 12));
            dvcn.Add(new DVChuongNuoi("16", "P", date, 12));
            dvcn.Add(new DVChuongNuoi("17", "Q", date, 24));
            dvcn.Add(new DVChuongNuoi("18", "R", date, 24));
            dvcn.Add(new DVChuongNuoi("19", "S", date, 24));
            dvcn.Add(new DVChuongNuoi("20", "T", date, 24));
            dvcn.Add(new DVChuongNuoi("21", "U", date, 36));
            dvcn.Add(new DVChuongNuoi("22", "V", date, 36));
            dvcn.Add(new DVChuongNuoi("23", "W", date, 36));
            dvcn.Add(new DVChuongNuoi("24", "X", date, 36));
            dvcn.Add(new DVChuongNuoi("25", "Y", date, 48));
            dvcn.Add(new DVChuongNuoi("26", "Z", date, 48));
        }

        public static void TaoDSKhauPhan()
        {
            kp.Add(new KhauPhan("01", "THIT"));
            kp.Add(new KhauPhan("02", "THIT"));
            kp.Add(new KhauPhan("06", "THIT"));
            kp.Add(new KhauPhan("14", "THIT"));
            kp.Add(new KhauPhan("20", "THIT"));
            kp.Add(new KhauPhan("24", "THIT"));
            kp.Add(new KhauPhan("09", "THIT"));
            kp.Add(new KhauPhan("11", "THIT"));
            kp.Add(new KhauPhan("13", "THIT"));
            kp.Add(new KhauPhan("22", "THIT"));
            kp.Add(new KhauPhan("25", "THIT"));
            kp.Add(new KhauPhan("03", "THUCVAT01"));
            kp.Add(new KhauPhan("04", "THUCVAT01"));
            kp.Add(new KhauPhan("05", "THUCVAT01"));
            kp.Add(new KhauPhan("14", "THUCVAT01"));
            kp.Add(new KhauPhan("07", "THUCVAT02"));
            kp.Add(new KhauPhan("08", "THUCVAT02"));
            kp.Add(new KhauPhan("10", "THUCVAT02"));
            kp.Add(new KhauPhan("12", "THUCVAT02"));
            kp.Add(new KhauPhan("15", "THUCVAT03"));
            kp.Add(new KhauPhan("16", "THUCVAT03"));
            kp.Add(new KhauPhan("17", "THUCVAT03"));
            kp.Add(new KhauPhan("17", "CONTRUNG"));
            kp.Add(new KhauPhan("18", "CONTRUNG"));
            kp.Add(new KhauPhan("21", "CONTRUNG"));
            kp.Add(new KhauPhan("23", "CONTRUNG"));
            kp.Add(new KhauPhan("19", "HAISAN"));
            kp.Add(new KhauPhan("26", "HAISAN"));
            kp.Add(new KhauPhan("22", "HAISAN"));
        }

        public static void TaoDSThucAn()
        {
            dt.Add(new ThucAn("THIT", "Thịt"));
            dt.Add(new ThucAn("THUCVAT01", "Cỏ"));
            dt.Add(new ThucAn("THUCVAT02", "Trái Cây"));
            dt.Add(new ThucAn("THUCVAT03", "Hoa Quả"));
            dt.Add(new ThucAn("CONTRUNG", "Côn Trùng"));
            dt.Add(new ThucAn("HAISAN", "Hải Sản"));
        }

        public static void TaoDSPhongBan()
        {
            pb.Add(new PhongBan("PB1", "Phòng Ban Chăm Sóc Khách Hàng", "Trung tâm Sở Thú"));
            pb.Add(new PhongBan("PB2", "Phòng Ban Bán Vé", "Cổng Sở Thú"));
            pb.Add(new PhongBan("PB3", "Phòng Ban Bảo Vệ", "Trung Tâm Sở Thú"));
            pb.Add(new PhongBan("PB4", "Phòng Ban Thức Ăn", "Phía Tây Sở Thú"));
            pb.Add(new PhongBan("PB5", "Phòng Ban Quản Lý Nhân Viên", "Phía Đông Sở Thú"));
            pb.Add(new PhongBan("PB6", "Phòng Ban Chăm Sóc Thú", "Phía Nam Sở Thú"));
            pb.Add(new PhongBan("PB7", "Phòng Ban Vệ Sinh", "Phía Bắc Sở Thú"));
            pb.Add(new PhongBan("PB8", "Phòng Ban Quản Lý Chuồng Thường Phía Bắc", "Phía Bắc Sở Thú"));
            pb.Add(new PhongBan("PB9", "Phòng Ban Quản Lý Chuồng Thường Phía Nam", "Phía Nam Sở Thú"));
            pb.Add(new PhongBan("PB10", "Phòng Ban Quản Lý Chuồng Thường Phía Tây", "Phía Tây Sở Thú"));
            pb.Add(new PhongBan("PB11", "Phòng Ban Quản Lý Chuồng Thường Phía Đông", "Phía Đông Sở Thú"));
            pb.Add(new PhongBan("PB12", "Phòng Ban Quản Lý Chuồng Đặc Biệt Phía Bắc", "Phía Bắc Sở Thú"));
            pb.Add(new PhongBan("PB13", "Phòng Ban Quản Lý Chuồng Đặc Biệt Phía Nam", "Phía Nam Sở Thú"));
            pb.Add(new PhongBan("PB14", "Phòng Ban Quản Lý Chuồng Đặc Biệt Phía Tây", "Phía Tây Sở Thú"));
            pb.Add(new PhongBan("PB15", "Phòng Ban Quản Lý Chuồng Đặc Biệt Phía Đông", "Phía Đông Sở Thú"));
        }

        public static void TaoDSCongTyBanVe()
        {
            ct.Add(new CongTyBanVe("CTY01", "Công ty 01", 1000, 800, date, "NV2"));
            ct.Add(new CongTyBanVe("CTY02", "Công ty 02", 1500, 900, date, "NV3"));
            ct.Add(new CongTyBanVe("CTY03", "Công ty 03", 2000, 1500, date, "NV3"));
            ct.Add(new CongTyBanVe("CTY04", "Công ty 04", 2500, 200, date, "NV2"));
            ct.Add(new CongTyBanVe("CTY05", "Công ty 05", 1200, 1100, date, "NV2"));
            ct.Add(new CongTyBanVe("CTY06", "Công ty 06", 1300, 1000, date, "NV2"));
            ct.Add(new CongTyBanVe("CTY07", "Công ty 07", 3000, 2000, date, "NV3"));
        }

        public static void TaoDSNhanVien()
        {
            nv.Add(new NhanVien("NV1", "Nguyễn Thanh Minh Đức", "PB1", "Nhân viên Chăm Sóc Khách Hàng"));
            nv.Add(new NhanVien("NV2", "Lê Vũ Minh Hoàng", "PB2", "Nhân viên Bán Vé"));
            nv.Add(new NhanVien("NV3", "Đoàn Thị Thanh Vân", "PB2", "Nhân viên Bán Vé"));
            nv.Add(new NhanVien("NV4", "Lê Trần Minh Nhựt", "PB3", "Nhân viên Bảo Vệ"));
            nv.Add(new NhanVien("NV5", "Bạch Trung Quốc", "PB3", "Nhân viên Thức Ăn"));
            nv.Add(new NhanVien("NV6", "Nguyễn Như Anh Tài", "PB4", "Nhân viên Thức Ăn"));
            nv.Add(new NhanVien("NV7", "Trần Tiến Phát", "PB4", "Nhân viên Bảo Vệ"));
            nv.Add(new NhanVien("NV8", "Đặng Lê Quang", "PB5", "Quản lý"));
            nv.Add(new NhanVien("NV9", "Nguyễn Thành Long", "PB6", "Nhân viên Chăm Sóc Thú Ăn Thịt"));
            nv.Add(new NhanVien("NV10", "Dương Hoàng Thy Trân", "PB6", "Nhân viên Chăm Sóc Thú Ăn Thịt"));
            nv.Add(new NhanVien("NV11", "Hoàng Nguyễn Kim Duy", "PB6", "Nhân viên Chăm Sóc Thú Ăn Cỏ"));
            nv.Add(new NhanVien("NV12", "Nguyễn Khánh Hòa", "PB6", "Nhân viên Chăm Sóc Thú Ăn Cỏ"));
            nv.Add(new NhanVien("NV13", "Bùi Hà Nhi", "PB7", "Nhân viên Vệ Sinh"));
            nv.Add(new NhanVien("NV14", "Mai Thanh Phúc", "PB7", "Nhân viên Vệ Sinh"));
            nv.Add(new NhanVien("NV15", "Hoàng Nguyễn Thịnh", "PB8", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV16", "Nguyễn Giang", "PB9", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV17", "Bùi Công Thành", "PB10", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV18", "Mai Yến Nhi", "PB11", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV19", "Nguyễn Thị Sa", "PB8", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV20", "Lê Thành Bo", "PB9", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV21", "Lê Ngọc Thoa", "PB10", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV22", "Quản Minh Đức", "PB12", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV23", "Nguyễn Khá Bảnh", "PB13", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV24", "Lê Thị Thùy Dương", "PB12", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV25", "Lê Thị Nhung", "PB13", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV26", "Đỗ Minh Đức", "PB14", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV27", "Nguyễn Ngọc Nguyên", "PB15", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV28", "Nguyễn Quang Huy", "PB14", "Nhân viên Quản Lý Chuồng Thú"));
            nv.Add(new NhanVien("NV29", "Trần Vĩnh Tiến", "PB15", "Nhân viên Quản Lý Chuồng Thú"));
        }

        public static void TaoDSVe()
        {
            ve.Add(new Ve("V1", "Kh01", "NV2", date));
            ve.Add(new Ve("V2", "Kh02", "NV2", date));
            ve.Add(new Ve("V3", "Kh03", "NV2", date));
            ve.Add(new Ve("V4", "Kh04", "NV2", date));
            ve.Add(new Ve("V5", "Kh05", "NV2", date));
            ve.Add(new Ve("V6", "Kh06", "NV2", date));
            ve.Add(new Ve("V7", "Kh07", "NV2", date));
            ve.Add(new Ve("V8", "Kh08", "NV2", date));
            ve.Add(new Ve("V9", "Kh09", "NV2", date));
            ve.Add(new Ve("V10", "Kh10", "NV2", date));
            ve.Add(new Ve("V11", "Kh11", "NV2", date));
            ve.Add(new Ve("V12", "Kh12", "NV2", date));
            ve.Add(new Ve("V13", "Kh13", "NV2", date));
            ve.Add(new Ve("V14", "Kh14", "NV2", date));
            ve.Add(new Ve("V15", "Kh15", "NV3", date));
            ve.Add(new Ve("V16", "Kh16", "NV3", date));
            ve.Add(new Ve("V17", "Kh17", "NV3", date));
            ve.Add(new Ve("V18", "Kh18", "NV3", date));
            ve.Add(new Ve("V19", "Kh19", "NV3", date));
            ve.Add(new Ve("V20", "Kh20", "NV3", date));
            ve.Add(new Ve("V21", "Kh21", "NV3", date));
            ve.Add(new Ve("V22", "Kh22", "NV3", date));
            ve.Add(new Ve("V23", "Kh23", "NV3", date));
            ve.Add(new Ve("V24", "Kh24", "NV3", date));
            ve.Add(new Ve("V25", "Kh25", "NV3", date));
            ve.Add(new Ve("V26", "Kh26", "NV3", date));
            ve.Add(new Ve("V27", "Kh27", "NV3", date));
            ve.Add(new Ve("V28", "Kh28", "NV3", date));
            ve.Add(new Ve("V29", "Kh29", "NV3", date));
            ve.Add(new Ve("V30", "Kh30", "NV3", date));
        }

        public static void TaoDSKhachXem()
        {
            kx.Add(new KhachXem("Hồ Hoài Phong", "Kh01", "V1", date));
            kx.Add(new KhachXem("Nguyễn Văn Sơn", "Kh02", "V2", date));
            kx.Add(new KhachXem("Nguyễn Trường Giang", "Kh03", "V3", date));
            kx.Add(new KhachXem("Dan Bảo Nguyễn", "Kh04", "V4", date));
            kx.Add(new KhachXem("Nguyễn Thuận", "Kh05", "V5", date));
            kx.Add(new KhachXem("Trần Nguyễn Quốc Khánh", "Kh06", "V6", date));
            kx.Add(new KhachXem("Nguyễn Kỳ Hải", "Kh07", "V7", date));
            kx.Add(new KhachXem("Lê Trung Hậu", "Kh08", "V8", date));
            kx.Add(new KhachXem("Nguyễn Xuân Bách", "Kh09", "V9", date));
            kx.Add(new KhachXem("Bùi Đình Xuân", "Kh10", "V10", date));
            kx.Add(new KhachXem("Trịnh Định Hoàng Huy", "Kh11", "V11", date));
            kx.Add(new KhachXem("Nguyễn Thành Trọng", "Kh12", "V12", date));
            kx.Add(new KhachXem("Huỳnh Minh Thông", "Kh13", "V13", date));
            kx.Add(new KhachXem("Lê Nhựt Trường", "Kh14", "V14", date));
            kx.Add(new KhachXem("Nguyễn Minh Trí", "Kh15", "V15", date));
            kx.Add(new KhachXem("Hoàng Minh Đức", "Kh16", "V16", date));
            kx.Add(new KhachXem("Trần Mạnh Cường", "Kh17", "V7", date));
            kx.Add(new KhachXem("Nguyễn Văn Hoàng", "Kh18", "V18", date));
            kx.Add(new KhachXem("Vỹ Minh Khánh Hoa", "Kh19", "V19", date));
            kx.Add(new KhachXem("Bùi Công Danh", "Kh20", "V20", date));
            kx.Add(new KhachXem("Nguyễn Thị Xuân Thanh", "Kh21", "V21", date));
            kx.Add(new KhachXem("Hồ Quốc Vinh", "Kh22", "V22", date));
            kx.Add(new KhachXem("Phan Tân Tỵ", "Kh23", "V23", date));
            kx.Add(new KhachXem("Nguyễn Trọng Hiếu", "Kh24", "V24", date));
            kx.Add(new KhachXem("Nguyễn Nhật Tâm", "Kh25", "V25", date));
            kx.Add(new KhachXem("Nguyễn Chí Hải", "Kh26", "V26", date));
            kx.Add(new KhachXem("Lê Hoàng Lộc", "Kh27", "V27", date));
            kx.Add(new KhachXem("Nguyễn Thái Hưng", "Kh28", "V28", date));
            kx.Add(new KhachXem("Hoàng Nhựt Khánh Ngân", "Kh29", "V29", date));
            kx.Add(new KhachXem("Lê Hoàng Mai Ngân", "Kh30", "V30", date));
        }

        ////CÁC TRUY VẤN LINQ
        //BÀI LÀM: Nguyễn Thanh Minh Đức - 19110017
        //1. Cho biết thông tin khách đến xem có mã vé là ?
        public static void MinhDuc1()
        {
            Console.WriteLine("|************************************************************************|");
            Console.WriteLine("|    Bạn đã chọn câu 1: Cho biết thông tin khách đến xem có mã vé là ?   |");
            Console.WriteLine("|________________________________________________________________________|");
            Console.WriteLine("                                                                         ");
            Console.Write("- Nhập mã vé {V1 - V30}: "); string mvmua = Console.ReadLine();
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("|            |                            |              |               |");
            Console.WriteLine("|  Mã Khách  |         Tên Khách          |    Mã Vé     |    Ngày Mua   |");
            Console.WriteLine("|____________|____________________________|______________|_______________|");
            var ds_kx = from kxem in kx select kxem;

            foreach (var nv in ds_kx)
            {
                if (mvmua == nv.MaVe)
                {
                    Console.WriteLine("|            |                            |              |               |");
                    Console.WriteLine($"|    {nv.MaKhach}    |" +
                                      $"   {nv.TenKhach.PadRight(25)}|" +
                                      $"      {nv.MaVe }      |" +
                                      $"   {nv.NgayVaoXem.RandomDateTime():MM/dd/yyyy}  |");
                    Console.WriteLine("|____________|____________________________|______________|_______________|");
                }
            }
        }

        //2. Liệt kê danh sách các động vật ăn thịt
        public static void MinhDuc2()
        {
            Console.WriteLine("|*************************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 2: Liệt kê danh sách các động vật ăn thịt  |");
            Console.WriteLine("|_____________________________________________________________|");
            Console.WriteLine("|                              |                              |");
            Console.WriteLine("|          Mã Động Vật         |          Tên Động Vật        |");
            Console.WriteLine("|______________________________|______________________________|");
            var ds_dv_an_thit = dv.Where(a => a.MaLoaiDongVat == "anthit");
            foreach (var i in ds_dv_an_thit)
            {
                Console.WriteLine("|                              |                              |");
                Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                  $"            {i.TenDongVat.PadRight(18)}|");
                Console.WriteLine("|______________________________|______________________________|");
            }
        }

        //3. In ra thông tin các động vật ăn trái cây
        public static void MinhDuc3()
        {
            Console.WriteLine("|**********************************************************************|");
            Console.WriteLine("|      Bạn đã chọn câu 3: In ra thông tin các động vật ăn trái cây     |");
            Console.WriteLine("|______________________________________________________________________|");
            Console.WriteLine("|                              |                                       |");
            Console.WriteLine("|          Mã Động Vật         |            Tên Động Vật               |");
            Console.WriteLine("|______________________________|_______________________________________|");
            var ds_ma_dv = kp.Where(a => a.MaThucAn == "THUCVAT02").Select(b => b.MaDongVat);
            foreach (var a in ds_ma_dv)
            {
                foreach (var c in dv)
                {
                    if (a == c.MaDongVat)
                    {
                        Console.WriteLine("|                              |                                       |");
                        Console.WriteLine($"|             {c.MaDongVat.PadRight(16)} |" +
                                          $"            {c.TenDongVat.PadRight(18)}         |");
                        Console.WriteLine("|______________________________|_______________________________________|");
                    }
                }
            }
        }

        //4. Liệt kê các nhân viên bán vé
        public static void MinhDuc4()
        {
            Console.WriteLine("|*****************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 4: Liệt kê các nhân viên bán vé    |");
            Console.WriteLine("|_____________________________________________________|");
            Console.WriteLine("|                 |                                   |");
            Console.WriteLine("|   Mã Nhân Viên  |          Tên Nhân Viên            |");
            Console.WriteLine("|_________________|___________________________________|");
            var ds_nv = nv.Select(x => x).Where(f => f.ChucVu == "Nhân viên Bán Vé");
            foreach (var i in ds_nv)
            {
                Console.WriteLine("|                 |                                   |");
                Console.WriteLine($"|{i.MaNhanVien.PadLeft(10)}       |" +
                                  $"        {i.TenNhanVien.PadRight(27)}|");
                Console.WriteLine("|_________________|___________________________________|");
            }
        }

        //5. Liệt kê các động vật loài côn trùng có trong Sở Thú
        public static void MinhDuc5()
        {
            Console.WriteLine("|************************************************************************|");
            Console.WriteLine("| Bạn đã chọn câu 5: Liệt kê các động vật loài côn trùng có trong Sở Thú |");
            Console.WriteLine("|________________________________________________________________________|");
            Console.WriteLine("|                              |                                         |");
            Console.WriteLine("|          Mã Động Vật         |               Tên Động Vật              |");
            Console.WriteLine("|______________________________|_________________________________________|");
            var ds_ct = dv.Where(a => a.MaLoaiDongVat == "contrung");
            foreach (var i in ds_ct)
            {
                Console.WriteLine("|                              |                                         |");
                Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                  $"           {i.TenDongVat.PadRight(30)}|");
                Console.WriteLine("|______________________________|_________________________________________|");
            }
        }

        //6. Liệt kê danh sách các động vật sẽ nuôi từ 1 năm trở lên
        public static void MinhDuc6()
        {
            Console.WriteLine("|****************************************************************************|");
            Console.WriteLine("| Bạn đã chọn câu 6: Liệt kê danh sách các động vật sẽ nuôi từ 1 năm trở lên |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|                              |                                             |");
            Console.WriteLine("|          Mã Động Vật         |                 Tên Động Vật                |");
            Console.WriteLine("|______________________________|_____________________________________________|");
            var ds_dv = dvcn.Where(a => a.TGRaChuong > 12);
            foreach (var j in dv)
            {
                foreach (var i in ds_dv)
                {
                    if (j.MaDongVat == i.MaDongVat)
                    {
                        Console.WriteLine("|                              |                                             |");
                        Console.WriteLine($"|            {i.MaDongVat.PadRight(17)} |" +
                                          $"             {j.TenDongVat.PadRight(30)}  |");
                        Console.WriteLine("|______________________________|_____________________________________________|");
                    }
                }
            }
        }

        //7. Công ty mua nhiều vé nhất
        public static void MinhDuc7()
        {
            Console.WriteLine("|*********************************************************|");
            Console.WriteLine("|       Bạn đã chọn câu 7: Công ty mua nhiều vé nhất      |");
            Console.WriteLine("|_________________________________________________________|");
            Console.WriteLine("|              |                      |                   |");
            Console.WriteLine("|  Mã Công Ty  |      Tên Công Ty     |  Số Lượng Vé Mua  |");
            Console.WriteLine("|______________|______________________|___________________|");
            var ct_max = ct.Max(a => a.SoLuongVeMua);
            foreach (var i in ct)
                if (i.SoLuongVeMua == ct_max)
                {
                    Console.WriteLine("|              |                      |                   |");
                    Console.WriteLine($"|     {i.MaCongTy.PadLeft(4)}    |" +
                                      $"      {i.TenCongTy.PadRight(15)} |" +
                                      $"      {i.SoLuongVeMua.ToString().PadRight(13)}|");
                    Console.WriteLine("|______________|______________________|___________________|");
                }
        }

        //8. Thông tin các nhân viên quản lý chuồng nuôi
        public static void MinhDuc8()
        {
            Console.WriteLine("|******************************************************************************************************|");
            Console.WriteLine("|                     Bạn đã chọn câu 8: Thông tin các nhân viên quản lý chuồng nuôi                   |");
            Console.WriteLine("|______________________________________________________________________________________________________|");
            Console.WriteLine("|                                                      |               |                               |");
            Console.WriteLine("|                   Tên Phòng Ban                      |  Mã Nhân Viên |         Tên Nhân Viên         |");
            Console.WriteLine("|______________________________________________________|_______________|_______________________________|");
            var ttnv = nv.Where(a => a.ChucVu == "Nhân viên Quản Lý Chuồng Thú");
            var pbql = from p in pb
                       from q in ttnv
                       where p.MaPhongBan == q.MaPhongBan
                       select p;
            pbql = pbql.Distinct().ToList();
            foreach (var i in pbql)
            {
                foreach (var j in ttnv)
                {
                    if (i.MaPhongBan == j.MaPhongBan)
                    {
                        Console.WriteLine("|                                                      |               |                               |");
                        Console.WriteLine($"|     {i.TenPhongBan.PadRight(49)}|" +
                                          $"      {j.MaNhanVien.PadRight(8)} |" +
                                          $"      {j.TenNhanVien.PadRight(25)}|");
                        Console.WriteLine("|______________________________________________________|_______________|_______________________________|");
                    }
                }
            }
        }

        //9. Doanh thu của công viên nếu giá vé là 50.000/lượt
        public static void MinhDuc9()
        {
            Console.WriteLine("|*************************************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 9: Doanh thu của công viên nếu giá vé là 50.000/lượt   |");
            Console.WriteLine("|_________________________________________________________________________|");
            var fcv = ve.Count();
            int fct = ct.Sum(a => a.SoLuongVeMua);
            const double i = 50000;
            double doanhthu = (fcv + fct) * i;
            Console.WriteLine("|                                                                         |");
            Console.WriteLine($"|              Doanh thu của Sở Thú: {doanhthu}                            |");
            Console.WriteLine("|_________________________________________________________________________|");
        }

        //10. Lượng khách đến xem
        public static void MinhDuc10()
        {
            Console.WriteLine("|*****************************************|");
            Console.WriteLine("| Bạn đã chọn câu 10: Lượng khách đến xem |");
            Console.WriteLine("|_________________________________________|");
            Console.WriteLine("|                     |                   |");
            Console.WriteLine("|    Ngày đến xem     |    Lượng Khách    |");
            Console.WriteLine("|_____________________|___________________|");
            var time = from a in kx
                       group a by a.NgayVaoXem.RandomDateTime() into aa
                       select new
                       {
                           day = aa.Key,
                           times = aa.Count()
                       };
            foreach (var i in time)
            {
                Console.WriteLine("|                     |                   |");
                Console.WriteLine($"|     {i.day:MM/dd/yyyy}      " +
                                  $"| {i.times.ToString().PadRight(13).PadLeft(18)}|");
                Console.WriteLine("|_____________________|___________________|");
            }
        }

        //BÀI LÀM: Lê Vũ Minh Hoàng - 19119181
        //1. In thông tin nhân viên
        public static void MinhHoang1()
        {
            Console.WriteLine("|**************************************************************************************************************|");
            Console.WriteLine("|                                Bạn đã chọn câu 11: In thông tin nhân viên                                    |");
            Console.WriteLine("|______________________________________________________________________________________________________________|");
            Console.WriteLine("|                 |                                  |                                    |                    |");
            Console.WriteLine("|   Mã Nhân Viên  |          Tên Nhân Viên           |               Chức Vụ              |  Mã Phòng Quản Lý  |");
            Console.WriteLine("|_________________|__________________________________|____________________________________|____________________|");
            var ds_nv = nv.Select(t => t);
            foreach (var nv in ds_nv)
            {
                Console.WriteLine("|                 |                                  |                                    |                    |");
                Console.WriteLine($"|       {nv.MaNhanVien.PadRight(4)}      |" +
                                  $"      {nv.TenNhanVien.PadRight(28)}|" +
                                  $"   {nv.ChucVu.PadRight(30)}   |" +
                                  $"       {nv.MaPhongBan.PadRight(10)}   |");
                Console.WriteLine("|_________________|__________________________________|____________________________________|____________________|");
            }
        }

        //2. Cho biết số nhân viên của từng phòng ban ?
        public static void MinhHoang2()
        {
            Console.WriteLine("|*******************************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 12: Cho biết số nhân viên của từng phòng ban ?   |");
            Console.WriteLine("|___________________________________________________________________|");
            Console.WriteLine("|                                |                                  |");
            Console.WriteLine("|          Mã Phòng Ban          |         Số Lượng Nhân Viên       |");
            Console.WriteLine("|________________________________|__________________________________|");
            var sonhanvien = nv.GroupBy(t => t.MaPhongBan).Select(g => new
            {
                mk = g.Key,
                mv = g.Count()
            });
            foreach (var nv in sonhanvien)
            {
                Console.WriteLine("|                                |                                  |");
                Console.WriteLine($"|             {nv.mk.PadRight(4)}               |" +
                                  $"                {nv.mv}                 |");
                Console.WriteLine("|________________________________|__________________________________|");
            }
        }

        //3. Sắp xếp số lượng vé được mua theo chiều giảm
        public static void MinhHoang3()
        {
            Console.WriteLine("|*************************************************************************|");
            Console.WriteLine("|     Bạn đã chọn câu 13: Sắp xếp số lượng vé được mua theo chiều giảm    |");
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("|                                    |                                    |");
            Console.WriteLine("|            Mã Công Ty              |            Số Lượng Vé Mua         |");
            Console.WriteLine("|____________________________________|____________________________________|");
            var sapXepve = ct.OrderByDescending(x => x.SoLuongVeMua);
            foreach (var sapxep in sapXepve)
            {
                Console.WriteLine("|                                    |                                    |");
                Console.WriteLine($"|            {sapxep.TenCongTy}              |" +
                                  $"                {sapxep.SoLuongVeMua}                |");
                Console.WriteLine("|____________________________________|____________________________________|");
            }
        }

        //4. In thông tin nhân viên có chức vụ "bảo vệ"
        public static void MinhHoang4()
        {
            Console.WriteLine("|**************************************************************************************************************|");
            Console.WriteLine("|                      Bạn đã chọn câu 14: In thông tin nhân viên có chức vụ bảo vệ                            |");
            Console.WriteLine("|______________________________________________________________________________________________________________|");
            Console.WriteLine("|                 |                                  |                                    |                    |");
            Console.WriteLine("|   Mã Nhân Viên  |          Tên Nhân Viên           |               Chức Vụ              |  Mã Phòng Quản Lý  |");
            Console.WriteLine("|_________________|__________________________________|____________________________________|____________________|");
            var ds_nv = nv.Select(x => x).Where(f => f.ChucVu == "Nhân viên Bảo Vệ");
            foreach (var nv in ds_nv)
            {
                Console.WriteLine("|                 |                                  |                                    |                    |");
                Console.WriteLine($"|       {nv.MaNhanVien}       |" +
                                  $"        {nv.TenNhanVien.PadRight(26)}|" +
                                  $"           {nv.ChucVu.PadRight(24)} |" +
                                  $"         {nv.MaPhongBan}        |");
                Console.WriteLine("|_________________|__________________________________|____________________________________|____________________|");
            }
        }

        //5. In thông tin nhân viên bán được nhiều vé nhất
        public static void MinhHoang5()
        {
            Console.WriteLine("|**************************************************************************|");
            Console.WriteLine("|     Bạn đã chọn câu 15: In thông tin nhân viên bán được nhiều vé nhất    |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                  |                              |                        |");
            Console.WriteLine("|   Mã Nhân Viên   |        Tên Nhân Viên         |     Số Vé Bán Được     |");
            Console.WriteLine("|__________________|______________________________|________________________|");
            var NVMax = from ss in ve
                        group ss by ss.MaNhanVienBanVe into k
                        select new { NhanVien = k.Key, sove = (from ss in k select ss.MaVe).Count() };
            var MAX = (from ss in NVMax
                       join k in nv on ss.NhanVien equals k.MaNhanVien
                       where ss.sove == NVMax.Max(sove => sove.sove)
                       select ss).OrderBy(f => f.sove);
            foreach (var ss in MAX)
            {
                foreach (var t in nv)
                {
                    if (ss.NhanVien == t.MaNhanVien)
                    {
                        Console.WriteLine("|                  |                              |                        |");
                        Console.WriteLine($"|       {ss.NhanVien}        |" +
                                          $"      {t.TenNhanVien}      |" +
                                          $"          {ss.sove}            |");
                        Console.WriteLine("|__________________|______________________________|________________________|");
                    }
                }
            }
        }

        //6. Cho biết phòng ban nào có nhiều nhân viên nhất
        public static void MinhHoang6()
        {
            Console.WriteLine("|********************************************************************|");
            Console.WriteLine("|     Bạn đã chọn câu 16: Phòng ban nào có nhiều nhân viên nhất      |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                  |                               |                 |");
            Console.WriteLine("|   Mã Phòng Ban   |        Tên Phòng Ban          |   Số Nhân Viên  |");
            Console.WriteLine("|__________________|_______________________________|_________________|");
            var PBNVMax = from ss in nv
                          group ss by ss.MaPhongBan into k
                          select new { PB = k.Key, sonv = (from ss in k select ss.MaNhanVien).Count() };
            var MAX = (from ss in PBNVMax
                       join k in pb on ss.PB equals k.MaPhongBan
                       where ss.sonv == PBNVMax.Max(sonv => sonv.sonv)
                       select ss).OrderBy(f => f.sonv);
            foreach (var ss in MAX)
            {
                foreach (var g in pb)
                {
                    if (ss.PB == g.MaPhongBan)
                    {
                        Console.WriteLine("|                  |                               |                 |");
                        Console.WriteLine($"|       {ss.PB}        |" +
                                          $"    {g.TenPhongBan}     |" +
                                          $"        {ss.sonv}        |");
                        Console.WriteLine("|__________________|_______________________________|_________________|");
                    }
                }
            }
        }

        //7. Cho biết khách hàng mua nhiều vé nhất
        public static void MinhHoang7()
        {
            Console.WriteLine("|**************************************************************|");
            Console.WriteLine("|        Bạn đã chọn câu 17: Khách hàng mua nhiều vé nhất      |");
            Console.WriteLine("|______________________________________________________________|");
            Console.WriteLine("|            |                              |                  |");
            Console.WriteLine("|  Mã Khách  |         Tên Khách            |    Số Vé Mua     |");
            Console.WriteLine("|____________|______________________________|__________________|");
            var KHMAx = from ss in kx
                        group ss by ss.MaKhach into k
                        select new { MaKhach = k.Key, sove = (from ss in k select ss.MaVe).Count() };
            var MAX = (from ss in KHMAx
                       join k in kx on ss.MaKhach equals k.MaKhach
                       where ss.sove == KHMAx.Max(sove => sove.sove)
                       select ss).OrderBy(f => f.sove);
            foreach (var ss in MAX)
            {
                foreach (var l in kx)
                {
                    if (ss.MaKhach == l.MaKhach)
                    {
                        Console.WriteLine("|            |                              |                  |");
                        Console.WriteLine($"|    {ss.MaKhach}    |" +
                                          $"    {l.TenKhach.PadRight(23)}   |" +
                                          $"        {ss.sove }         |");
                        Console.WriteLine("|____________|______________________________|__________________|");
                    }
                }
            }
        }

        //8. Cho biết phòng ban nào nằm tại phía đông Sở Thú
        public static void MinhHoang8()
        {
            Console.WriteLine("|***********************************************************************************|");
            Console.WriteLine("|        Bạn đã chọn câu 18: Cho biết phòng ban nào nằm tại phía đông Sở Thú        |");
            Console.WriteLine("|___________________________________________________________________________________|");
            Console.WriteLine("|                               |                                                   |");
            Console.WriteLine("|          Mã Phòng Ban         |                 Tên Phòng Ban                     |");
            Console.WriteLine("|_______________________________|___________________________________________________|");
            var NVQL = from ss in pb select ss;
            foreach (var ss in pb)
            {
                if (ss.DiaDiem == "Phía Đông Sở Thú")
                {
                    Console.WriteLine("|                               |                                                   |");
                    Console.WriteLine($"|             {ss.MaPhongBan.PadRight(4)}              |" +
                                      $"  {ss.TenPhongBan.PadRight(45)}    | ");
                    Console.WriteLine("|_______________________________|___________________________________________________|");
                }
            }
        }

        //9. Tổng số vé công ty đã mua để bán
        public static void MinhHoang9()
        {
            Console.WriteLine("|****************************************************************|");
            Console.WriteLine("| Bạn đã chọn câu 19: Tổng số vé công ty mà Sở Thú đã mua để bán |");
            Console.WriteLine("|________________________________________________________________|");
            Console.WriteLine("|                               |                                |");
            Console.WriteLine("|            Mã Công Ty         |        Số Lượng Vé Mua         |");
            Console.WriteLine("|_______________________________|________________________________|");
            var sapXepve = ct.OrderBy(x => x.SoLuongVeMua);
            foreach (var sapxep in sapXepve)
            {
                Console.WriteLine("|                               |                                |");
                Console.WriteLine($"|            {sapxep.TenCongTy}         |" +
                                  $"              {sapxep.SoLuongVeMua}              |");
                Console.WriteLine("|_______________________________|________________________________|");
            }
            var chiphi = from v in ct
                         select new
                         {
                             sove = v.SoLuongVeMua
                         };

            double sum = chiphi.Sum(t => t.sove);
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|       Tổng số vé công ty mà Sở Thú đã mua để bán: {0}        |", sum);
            Console.WriteLine("|________________________________________________________________|");
        }

        //10. In thông tin công ty mua từ 2000 vé trở lên
        public static void MinhHoang10()
        {
            Console.WriteLine("|********************************************************************|");
            Console.WriteLine("| Bạn đã chọn câu 20: In ra thông tin công ty mua từ 2000 vé trở lên |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|               |                |             |                     |");
            Console.WriteLine("|   Mã Công ty  |  Tên Công Ty   |  Số Vé Mua  |       Ngày Mua      |");
            Console.WriteLine("|_______________|________________|_____________|_____________________|");
            var chiphi = from v in ct select v;
            foreach (var ss in chiphi)
            {
                if (ss.SoLuongVeMua >= 2000)
                {
                    Console.WriteLine("|               |                |             |                     |");
                    Console.WriteLine($"|     {ss.MaCongTy}     |" +
                                      $"   {ss.TenCongTy}   |" +
                                      $"    {ss.SoLuongVeMua}     |" +
                                      $"      {ss.NgayMua.RandomDateTime():MM/dd/yyyy}     |");
                    Console.WriteLine("|_______________|________________|_____________|_____________________|");
                }
            }
        }

        //BÀI LÀM: Lê Trần Minh Nhựt - 19110257
        //1. Liệt kê danh sách các động vật ở chuồng nuôi "Thường"
        public static void MinhNhut1()
        {
            Console.WriteLine("|***************************************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 21: Liệt kê danh sách các động vật ở chuồng nuôi Thường  |");
            Console.WriteLine("|___________________________________________________________________________|");
            Console.WriteLine("|                              |                                            |");
            Console.WriteLine("|          Mã Động Vật         |                 Tên Động Vật               |");
            Console.WriteLine("|______________________________|____________________________________________|");
            var ds_dvcn_thuong = cn.Where(a => a.LoaiChuong == "Thường");
            foreach (var i in ds_dvcn_thuong)
            {
                foreach (var l in dv)
                {
                    if (i.MaDongVat == l.MaDongVat)
                    {
                        Console.WriteLine("|                              |                                            |");
                        Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                          $"                 {l.TenDongVat.PadRight(20)}       |");
                        Console.WriteLine("|______________________________|____________________________________________|");
                    }
                }
            }
        }

        //2. Cho biết những động vật có thời gian ra > 2 tháng và < 12 tháng
        public static void MinhNhut2()
        {
            Console.WriteLine("|***************************************************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 22: Cho biết những động vật có thời gian ra > 2 tháng và < 12 tháng  |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.WriteLine("|                              |                                                        |");
            Console.WriteLine("|          Mã Động Vật         |                    Tên Động Vật                        |");
            Console.WriteLine("|______________________________|________________________________________________________|");
            var ds_dv = dvcn.Where(a => a.TGRaChuong < 12 && a.TGRaChuong > 2);
            foreach (var j in dv)
                foreach (var i in ds_dv)
                    if (j.MaDongVat == i.MaDongVat)
                    {
                        Console.WriteLine("|                              |                                                        |");
                        Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                          $"                    {j.TenDongVat.PadRight(24)}            |");
                        Console.WriteLine("|______________________________|________________________________________________________|");
                    }
        }

        //3. Cho biết khách hàng có mã ? In ra những thông tin về khách hàng đó
        public static void MinhNhut3()
        {
            Console.WriteLine("|*********************************************************************************************|");
            Console.WriteLine("|    Bạn đã chọn câu 23: Cho biết khách hàng có mã ? In ra những thông tin về khách hàng đó   |");
            Console.WriteLine("|_____________________________________________________________________________________________|");
            Console.WriteLine("                                                                                              ");
            Console.Write("- Nhập mã khách {Kh01 - Kh30}: "); string mk = Console.ReadLine();
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("|            |                            |              |                   |");
            Console.WriteLine("|  Mã Khách  |         Tên Khách          |    Mã Vé     |    Ngày Vào Xem   |");
            Console.WriteLine("|____________|____________________________|______________|___________________|");
            var ds_kx = from kxem in kx select kxem;
            foreach (var a in ds_kx)
            {
                if (mk == a.MaKhach)
                {
                    Console.WriteLine("|            |                            |              |                   |");
                    Console.WriteLine($"|    {a.MaKhach}    |" +
                                      $"    {a.TenKhach.PadRight(23)} |" +
                                      $"      {a.MaVe.PadRight(4)}    |" +
                                      $"     {a.NgayVaoXem.RandomDateTime():MM/dd/yyyy}    |");
                    Console.WriteLine("|____________|____________________________|______________|___________________|");
                }
            }
        }

        //4. Liệt kê danh sách những động vật ăn cỏ
        public static void MinhNhut4()
        {
            Console.WriteLine("|*************************************************************|");
            Console.WriteLine("|   Bạn đã chọn câu 24: Liệt kê danh sách các động vật ăn cỏ  |");
            Console.WriteLine("|_____________________________________________________________|");
            Console.WriteLine("|                              |                              |");
            Console.WriteLine("|          Mã Động Vật         |          Tên Động Vật        |");
            Console.WriteLine("|______________________________|______________________________|");
            var ds_dv_an_thit = dv.Where(a => a.MaLoaiDongVat == "anco");
            foreach (var i in ds_dv_an_thit)
            {
                Console.WriteLine("|                              |                              |");
                Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                  $"          {i.TenDongVat.PadRight(20)}|");
                Console.WriteLine("|______________________________|______________________________|");
            }
        }

        //5. Cho biết thời gian vào/ra chuồng của tất cả động vật
        public static void MinhNhut5()
        {
            Console.WriteLine("|*******************************************************************************|");
            Console.WriteLine("|   Bạn đã chọn câu 25: Cho biết thời gian vào/ra chuồng của tất cả động vật    |");
            Console.WriteLine("|_______________________________________________________________________________|");
            Console.WriteLine("|                 |                      |                    |                 |");
            Console.WriteLine("|   Mã Động Vật   |     Tên Động Vật     |   Thời gian vào    |   Thời gian ra  |");
            Console.WriteLine("|_________________|______________________|____________________|_________________|");
            foreach (var i in dv)
            {
                foreach (var j in dvcn)
                {
                    if (i.MaDongVat == j.MaDongVat)
                    {
                        Console.WriteLine("|                 |                      |                    |                 |");
                        Console.WriteLine($"|       {i.MaDongVat.PadRight(2)}        |" +
                                          $"    {i.TenDongVat.PadRight(16)}  |" +
                                          $"     {j.NgayVaoChuong.RandomDateTime():MM/dd/yyyy}     |" +
                                          $"     {j.TGRaChuong.ToString().PadRight(2)} tháng    |");
                        Console.WriteLine("|_________________|______________________|____________________|_________________|");
                    }
                }
            }
        }

        //6. Liệt kê danh sách những động vật bò sát
        public static void MinhNhut6()
        {
            Console.WriteLine("|*************************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 26: Liệt kê danh sách các động vật bò sát  |");
            Console.WriteLine("|_____________________________________________________________|");
            Console.WriteLine("|                              |                              |");
            Console.WriteLine("|          Mã Động Vật         |          Tên Động Vật        |");
            Console.WriteLine("|______________________________|______________________________|");
            var ds_dv_an_thit = dv.Where(a => a.MaLoaiDongVat == "bosat");
            foreach (var i in ds_dv_an_thit)
            {
                Console.WriteLine("|                              |                              |");
                Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                  $"         {i.TenDongVat.PadRight(21)}|");
                Console.WriteLine("|______________________________|______________________________|");
            }
        }

        //7. Cho biết thông tin những động vật ở chuồng nuôi "đặc biệt"
        public static void MinhNhut7()
        {
            Console.WriteLine("|***************************************************************************|");
            Console.WriteLine("| Bạn đã chọn câu 27: Liệt kê danh sách các động vật ở chuồng nuôi Đặc Biệt |");
            Console.WriteLine("|___________________________________________________________________________|");
            Console.WriteLine("|                              |                                            |");
            Console.WriteLine("|          Mã Động Vật         |                 Tên Động Vật               |");
            Console.WriteLine("|______________________________|____________________________________________|");
            var ds_dvcn_thuong = cn.Where(a => a.LoaiChuong == "Đặc Biệt");
            foreach (var i in ds_dvcn_thuong)
            {
                foreach (var l in dv)
                {
                    if (i.MaDongVat == l.MaDongVat)
                    {
                        Console.WriteLine("|                              |                                            |");
                        Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                          $"                 {l.TenDongVat.PadRight(20)}       |");
                        Console.WriteLine("|______________________________|____________________________________________|");
                    }
                }
            }
        }

        //8. Cho biết thông tin những động vật có khẩu phần "hải sản"
        public static void MinhNhut8()
        {
            Console.WriteLine("|***************************************************************************|");
            Console.WriteLine("|  Bạn đã chọn câu 28: Liệt kê danh sách các động vật có khẩu phần Hải Sản  |");
            Console.WriteLine("|___________________________________________________________________________|");
            Console.WriteLine("|                              |                                            |");
            Console.WriteLine("|          Mã Động Vật         |                 Tên Động Vật               |");
            Console.WriteLine("|______________________________|____________________________________________|");
            var ds_kp_hai_san = kp.Where(a => a.MaThucAn == "HAISAN");
            foreach (var i in ds_kp_hai_san)
            {
                foreach (var l in dv)
                {
                    if (i.MaDongVat == l.MaDongVat)
                    {
                        Console.WriteLine("|                              |                                            |");
                        Console.WriteLine($"|             {i.MaDongVat.PadRight(16)} |" +
                                          $"                 {l.TenDongVat.PadRight(20)}       |");
                        Console.WriteLine("|______________________________|____________________________________________|");
                    }
                }
            }
        }

        //9. Sắp xếp danh sách khách xem theo chiều giảm dần của mã khách
        public static void MinhNhut9()
        {
            Console.WriteLine("|**********************************************************************************|");
            Console.WriteLine("| Bạn đã chọn câu 29: Sắp xếp danh sách khách xem theo chiều giảm dần của mã khách |");
            Console.WriteLine("|__________________________________________________________________________________|");
            Console.WriteLine("|            |                            |              |                         |");
            Console.WriteLine("|  Mã Khách  |         Tên Khách          |     Mã Vé    |        Ngày Mua         |");
            Console.WriteLine("|____________|____________________________|______________|_________________________|");
            var sapXepKhach = kx.OrderByDescending(x => x.MaKhach);
            foreach (var sapxep in sapXepKhach)
            {
                Console.WriteLine("|            |                            |              |                         |");
                Console.WriteLine($"|    {sapxep.MaKhach}    |" +
                                  $"   {sapxep.TenKhach.PadRight(25)}|" +
                                  $"     {sapxep.MaVe.PadRight(5)}    |" +
                                  $"       {sapxep.NgayVaoXem.RandomDateTime():MM/dd/yyyy}        |");
                Console.WriteLine("|____________|____________________________|______________|_________________________|");
            }
        }

        //10. Sắp xếp danh sách vé theo chiều giảm dần của mã vé
        public static void MinhNhut10()
        {
            Console.WriteLine("|************************************************************************|");
            Console.WriteLine("| Bạn đã chọn câu 30: Sắp xếp danh sách vé theo chiều giảm dần của mã vé |");
            Console.WriteLine("|________________________________________________________________________|");
            Console.WriteLine("|           |            |                          |                    |");
            Console.WriteLine("|   Mã Vé   |  Mã Khách  |        Tên Khách         |       Ngày Bán     |");
            Console.WriteLine("|___________|____________|__________________________|____________________|");
            var sapXepVe = kx.OrderByDescending(x => x.MaVe);
            foreach (var sapxep in sapXepVe)
            {
                Console.WriteLine("|           |            |                          |                    |");
                Console.WriteLine($"|    {sapxep.MaVe.PadRight(4)}   |" +
                                  $"    {sapxep.MaKhach.PadRight(4)}    |" +
                                  $" {sapxep.TenKhach.PadRight(25)}|" +
                                  $"      {sapxep.NgayVaoXem.RandomDateTime():MM/dd/yyyy}    |");
                Console.WriteLine("|___________|____________|__________________________|____________________|");
            }
        }

        private static void Main(string[] args)
        {
            //Khởi tạo dữ liệu cho LINQ
            TaoDSChuongNuoi();
            TaoDSDongVat();
            TaoDSKhauPhan();
            TaoDSLoaiDongVat();
            TaoDSDVChuongNuoi();
            TaoDSCongTyBanVe();
            TaoDSKhachXem();
            TaoDSNhanVien();
            TaoDSPhongBan();
            TaoDSThucAn();
            TaoDSVe();

            //Câu hỏi truy vấn LINQ
            while (true)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("                                                                                                               ");
                Console.WriteLine("                                            ĐỒ ÁN CUỐI KÌ OOP                                                  ");
                Console.WriteLine("_______________________________________________________________________________________________________________");
                Console.WriteLine("|                                                                                                             |");
                Console.WriteLine("|---------------------------------------------Lê Trần Minh Nhựt-----------------------------------------------|");
                Console.WriteLine("|_____________________________________________________________________________________________________________|");
                Console.WriteLine("|                                                                                                             |");
                Console.WriteLine("|     Câu 1:   Cho biết thông tin các khách đến xem có mã vé là ?                                             |");
                Console.WriteLine("|     Câu 2:   Liệt kê  danh sách các động vật ăn thịt                                                        |");
                Console.WriteLine("|     Câu 3:   In ra thông tin các động vật ăn trái cây                                                       |");
                Console.WriteLine("|     Câu 4:   Liệt kê các nhân viên bán vé                                                                   |");
                Console.WriteLine("|     Câu 5:   Liệt kê các động vật loài côn trùng có trong Sở Thú                                            |");
                Console.WriteLine("|     Câu 6:   Liệt kê danh sách các động vật sẽ nuôi từ 1 năm trở lên                                        |");
                Console.WriteLine("|     Câu 7:   Công ty mua nhiều vé nhất                                                                      |");
                Console.WriteLine("|     Câu 8:   Thông tin các nhân viên quản lý chuồng nuôi                                                    |");
                Console.WriteLine("|     Câu 9:   Doanh thu của công viên nếu giá vé là 50.000/lượt                                              |");
                Console.WriteLine("|     Câu 10:  Lượng khách đến xem                                                                            |");
                Console.WriteLine("|_____________________________________________________________________________________________________________|");
                Console.WriteLine("|                                                                                                             |");
                Console.WriteLine("|----------------------------------------------Lê Vũ Minh Hoàng-----------------------------------------------|");
                Console.WriteLine("|_____________________________________________________________________________________________________________|");
                Console.WriteLine("|                                                                                                             |");
                Console.WriteLine("|     Câu 11:  In thông tin nhân viên                                                                         |");
                Console.WriteLine("|     Câu 12:  Cho biết số nhân viên của từng phòng ban ?                                                     |");
                Console.WriteLine("|     Câu 13:  Sắp xếp số lượng vé được mua theo chiều giảm                                                   |");
                Console.WriteLine("|     Câu 14:  In thông tin nhân viên có chức vụ bảo vệ                                                       |");
                Console.WriteLine("|     Câu 15:  In thông tin nhân viên bán được nhiều vé nhất                                                  |");
                Console.WriteLine("|     Câu 16:  Cho biết phòng ban nào có nhiều nhân viên nhất                                                 |");
                Console.WriteLine("|     Câu 17:  Cho biết khách hàng mua nhiều vé nhất                                                          |");
                Console.WriteLine("|     Câu 18:  Cho biết phòng ban nào nằm tại phía đông Sở Thú                                                |");
                Console.WriteLine("|     Câu 19:  Tổng số vé công ty đã mua để bán                                                               |");
                Console.WriteLine("|     Câu 20:  In thông tin công ty mua từ 2000 vé trở lên                                                    |");
                Console.WriteLine("|_____________________________________________________________________________________________________________|");
                Console.WriteLine("|                                                                                                             |");
                Console.WriteLine("|---------------------------------------------Nguyễn Thanh Minh Đức-------------------------------------------|");
                Console.WriteLine("|_____________________________________________________________________________________________________________|");
                Console.WriteLine("|                                                                                                             |");
                Console.WriteLine("|     Câu 21:  Liệt kê danh sách các động vật ở chuồng nuôi Thường                                            |");
                Console.WriteLine("|     Câu 22:  Cho biết những động vật có thời gian ra > 2 tháng và < 12 tháng                                |");
                Console.WriteLine("|     Câu 23:  Cho biết khách hàng có mã ? In ra những thông tin về khách hàng đó                             |");
                Console.WriteLine("|     Câu 24:  Liệt kê danh sách những động vật ăn cỏ                                                         |");
                Console.WriteLine("|     Câu 25:  Cho biết thời gian vào/ra chuồng của tất cả động vật                                           |");
                Console.WriteLine("|     Câu 26:  Liệt kê danh sách những động vật bò sát                                                        |");
                Console.WriteLine("|     Câu 27:  Cho biết thông tin những động vật ở chuồng nuôi đặc biệt                                       |");
                Console.WriteLine("|     Câu 28:  Cho biết thông tin những động vật có khẩu phần hải sản                                         |");
                Console.WriteLine("|     Câu 29:  Sắp xếp danh sách khách xem theo chiều giảm dần của mã khách                                   |");
                Console.WriteLine("|     Câu 30:  Sắp xếp danh sách vé theo chiều giảm dần của mã vé                                             |");
                Console.WriteLine("|_____________________________________________________________________________________________________________|");
                Console.WriteLine("Nhấn phím 0 để thoát khỏi chương trình");
                Console.Write("-> Your choice: ");
                try
                {
                    int key = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (key)
                    {
                        case 1: MinhDuc1(); break;
                        case 2: MinhDuc2(); break;
                        case 3: MinhDuc3(); break;
                        case 4: MinhDuc4(); break;
                        case 5: MinhDuc5(); break;
                        case 6: MinhDuc6(); break;
                        case 7: MinhDuc7(); break;
                        case 8: MinhDuc8(); break;
                        case 9: MinhDuc9(); break;
                        case 10: MinhDuc10(); break;

                        case 11: MinhHoang1(); break;
                        case 12: MinhHoang2(); break;
                        case 13: MinhHoang3(); break;
                        case 14: MinhHoang4(); break;
                        case 15: MinhHoang5(); break;
                        case 16: MinhHoang6(); break;
                        case 17: MinhHoang7(); break;
                        case 18: MinhHoang8(); break;
                        case 19: MinhHoang9(); break;
                        case 20: MinhHoang10(); break;

                        case 21: MinhNhut1(); break;
                        case 22: MinhNhut2(); break;
                        case 23: MinhNhut3(); break;
                        case 24: MinhNhut4(); break;
                        case 25: MinhNhut5(); break;
                        case 26: MinhNhut6(); break;
                        case 27: MinhNhut7(); break;
                        case 28: MinhNhut8(); break;
                        case 29: MinhNhut9(); break;
                        case 30: MinhNhut10(); break;
                        case 0:
                            Console.WriteLine("==> Cảm ơn Thầy đã xem <3");
                            Console.WriteLine("Tạm biệt !!");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Không có thao tác này! Xin hãy nhập lại");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    if (key >= 1 && key <= 30)
                    {
                        Console.Write("\nEnter để tiếp tục. ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception E)
                {
                    Console.WriteLine($"Unexpected error: { E.Message }");
                    Console.WriteLine("Try again !!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}