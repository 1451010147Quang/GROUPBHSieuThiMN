using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
namespace DAO
{
    public class eDAO
    {
        DataProvider da = new DataProvider();

        //khach hang
        public DataTable Load()
        {
            return da.Laydulieu("select * from KhachHang");
        }

        public DataTable Tim(Khachang p)
        {
            int para = 1;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@MaKH";
            value[0] = p.MaKH;
            return da.Laydulieu("select * from KhachHang where MaKH = @MaKH", name, value, para);
        }
        public DataTable TimKH(Khachang p)
        {
            int para = 1;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@TenKH";
            value[0] = p.TenKH;
            return da.Laydulieu("select * from KhachHang where TenKH = @TenKH", name, value, para);
        }
        public int Them(Khachang p)
        {
            int para = 5;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@MaKH"; value[0] = p.MaKH;
            name[1] = "@TenKH"; value[1] = p.TenKH;
            name[2] = "@DiaChi"; value[2] = p.DiaChi;
            name[3] = "@DienThoai"; value[3] = p.DienThoai;
            name[4] = "@Fax"; value[4] = p.Fax;
            return da.ADD("insert into KhachHang(MaKH, TenKH, DiaChi, DienThoai, Fax)values(@MaKH,@TenKH,@DiaChi,@DienThoai,@Fax)", name, value, para);

        }

        public int Xoa(Khachang p)
        {
            int para = 1;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@MaKH"; value[0] = p.MaKH;
            return da.ADD("delete from KhachHang where MaKH = @MaKH", name, value, para);

        }

        public int Sua(Khachang p)
        {
            int para = 5;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@MaKH"; value[0] = p.MaKH;
            name[1] = "@TenKH"; value[1] = p.TenKH;
            name[2] = "@DiaChi"; value[2] = p.DiaChi;
            name[3] = "@DienThoai"; value[3] = p.DienThoai;
            name[4] = "@Fax"; value[4] = p.Fax;
            return da.ADD("update KhachHang set TenKH= @TenKH, DiaChi= @DiaChi, DienThoai= @DienThoai, Fax= @Fax where MaKH=@MaKH", name, value, para);

        }

        //hang hoa
        public DataTable LoadHH()
        {
            return da.Laydulieu("select * from ThucDon");
        }


        public int ThemHH(Hanghoa p)
        {
            int para = 5;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@MaSp"; value[0] = p.MaSP;
            name[1] = "@TenSP"; value[1] = p.TenSP;
            name[2] = "@Donvitinh"; value[2] = p.Donvitinh;
            name[3] = "@Dongia"; value[3] = p.Dongia;
            name[4] = "@MaLoaiSP"; value[4] = p.MaLoaiSP;
            return da.ADD("insert into ThucDon(MaSp, TenSP, Donvitinh, Dongia, MaLoaiSP)values(@MaSP,@TenSP,@Donvitinh,@Dongia,@MaLoaiSP)", name, value, para);

        }

        public int XoaHH(Hanghoa p)
        {
            int para = 1;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@MaSP"; value[0] = p.MaSP;
            return da.ADD("delete from ThucDon where MaSP = @MaSP", name, value, para);

        }

        public int SuaHH(Hanghoa p)
        {
            int para = 5;
            string[] name = new string[para];
            object[] value = new object[para];
            name[0] = "@MaSp"; value[0] = p.MaSP;
            name[1] = "@TenSP"; value[1] = p.TenSP;
            name[2] = "@Donvitinh"; value[2] = p.Donvitinh;
            name[3] = "@Dongia"; value[3] = p.Dongia;
            name[4] = "@MaLoaiSP"; value[4] = p.MaLoaiSP;
            return da.ADD("update ThucDon set TenSP= @TenSP, Donvitinh= @Donvitinh, Dongia= @Dongia, MaLoaiSP= @MaLoaiSP where MaSP=@MaSP", name, value, para);

        }

    }
}
