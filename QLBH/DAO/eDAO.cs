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


    }
}
