using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class eBUS
    {
        eDAO da = new eDAO();

        //khach hang
        public DataTable LoadKH()
        {
            return da.Load();
        }

        public DataTable TimKH(Khachang p)
        {
            return da.Tim(p);
        }

        public DataTable TimaKH(Khachang p)
        {
            return da.TimKH(p);
        }

        public int Them(Khachang p)
        {
            return da.Them(p);
        }

        public int Xoap(Khachang p)
        {
            return da.Xoa(p);
        }

        public int Sua(Khachang p)
        {
            return da.Sua(p);
        }


        //hang hoa
        public DataTable LoadHH()
        {
            return da.LoadHH();
        }


        public int ThemHH(Hanghoa n)
        {
            if (n.MaSP == "")
            {
                MessageBox.Show("vui long nhap ma sp");
                return -2;
            }
            if (n.MaLoaiSP != "1" && n.MaLoaiSP != "2" && n.MaLoaiSP != "3" && n.MaLoaiSP != "4" && n.MaLoaiSP != "5")
            {
                MessageBox.Show("vui long nhap ma loai thich hop (1,2,3,4,5)");
                return -2;
            }

            try
            {
                return da.ThemHH(n);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int XoaHH(Hanghoa n)
        {
            if (n.MaSP == "")
            {
                MessageBox.Show("vui long nhap ma sp can xoa");
                return -2;
            }
            try
            {
                return da.XoaHH(n);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int SuaHH(Hanghoa n)
        {

            if (n.MaSP == "")
            {
                MessageBox.Show("vui long nhap ma sp can sua");
                return -2;
            }
            try
            {
                return da.SuaHH(n);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //nhanvien
        public DataTable LoadNV()
        {
            return da.LoadNV();
        }

        public DataTable TimNV(NVien n)
        {
            return da.TimNV(n);
        }
        public DataTable TimtheotenNV(NVien n)
        {
            return da.TimtheotenNV(n);
        }

        public int ThemNV(NVien n)
        {

            return da.ThemNV(n);

        }

        public int XoaNV(NVien n)
        {
            return da.XoaNV(n);
        }

        public int SuaNV(NVien n)
        {
            return da.SuaNV(n);
        }

        //hoadon
        public DataTable LoadHD()
        {
            return da.LoadHD();
        }


        public int ThemHD(Hoadon n)
        {

            return da.ThemHD(n);

        }

        public int XoaHD(Hoadon n)
        {
            return da.XoaHD(n);
        }

        public int SuaHD(Hoadon n)
        {
            return da.SuaHD(n);
        }
    }
}
