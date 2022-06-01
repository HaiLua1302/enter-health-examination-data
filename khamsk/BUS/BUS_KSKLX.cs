using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace khamsk.BUS
{
    class BUS_KSKLX
    {
        //get data
        public static DataTable getDS_KSKLX()
        {
            DataTable _ds = DB.DB_KSKLX.getDSKSKLX();
            return _ds;
        }
        //them du lieu
        public static bool ThemBNLX(CLASS.thongtinBN bn, CLASS.thongtinXN xn)
        {
            bool kq = DB.DB_KSKLX.ThemBNLX(bn, xn);
            return kq;
        }

        //Xóa data bieu mau 1
        public static bool xoaBNLX(int idBN)
        {
            bool kq = DB.DB_KSKLX.xoaBNLX(idBN);
            return kq;
        }



        //Cập nhật data bn
        public static bool SuaBNLX(CLASS.thongtinBN bn, CLASS.thongtinXN xn)
        {
            bool kq = DB.DB_KSKLX.SuaBNLX(bn, xn);
            return kq;
        }
    }
}
