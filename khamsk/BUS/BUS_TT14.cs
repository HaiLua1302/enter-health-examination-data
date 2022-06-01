using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace khamsk.BUS
{
    class BUS_TT14
    {
        //get data
        public static DataTable getDS_TT14()
        {
            DataTable _ds = DB.DB_TT14.getDSKSK();
            return _ds;
        }
        //them du lieu
        public static bool ThemBN(CLASS.thongtinBN bn,CLASS.thongtinSK sk)
        {
            bool kq = DB.DB_TT14.ThemBN(bn, sk);
            return kq;
        }

        //Xóa data bieu mau 1
        public static bool xoaBN(int idBN)
        {
            bool kq = DB.DB_TT14.xoaBN(idBN);
            return kq;
        }



        //Cập nhật data bn
        public static bool SuaBN(CLASS.thongtinBN bn, CLASS.thongtinSK sk)
        {
            bool kq = DB.DB_TT14.SuaBN(bn,sk);
            return kq;
        }


    }
}

