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

      

    }
}
