using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace khamsk.DB
{
    class DB_TT14
    {
        //Rút trích dữ liêu: select 
        public static DataTable getDSKSK()
        {
            string sql = "select right('0000' + convert(varchar(4),bn.idBN), 4) as IDBN, bn.hoten,bn.gioitinh,bn.namsinh,bn.cmnd,bn.ngaycap,bn.diachi,bn.lydo," +
                "p.chieucao,p.cannang,p.bmi,p.mach,p.huyetap," +
                "p.pltl,p.plsk,p.benhkhac,p.nguoiKL,p.ngaykham " +
                "from thongtinBN bn left join thongtinkham p on bn.idBN = p.idBN " +
                "order by p.ngaykham desc; ";
            DataTable dt = getDB.ExecuteQuery(sql);
            return dt;
        }
        //them bieu mau 
        public static bool ThemBN(CLASS.thongtinBN bn, CLASS.thongtinSK sk)
        {
            bool kq;
            string sql = string.Format("insert into thongtinBN (hoten, gioitinh, namsinh, cmnd, ngaycap, diachi, lydo) values (N'{0}',N'{1}',{2},N'{3}',N'{4}',N'{5}',N'{6}') " +
                "insert into thongtinkham(idBN, chieucao, cannang, bmi, mach, huyetap, pltl, plsk, benhkhac, nguoiKL, ngaykham)" +
                "values((select IDENT_CURRENT('thongtinBN') as idBN), {7}, {8}, {9}, {10}, {11}, N'{12}', N'{13}', N'{14}', N'{15}', N'{16}'); ",
               bn.hoten,bn.gioitinh, bn.namsinh, bn.cmnd, bn.ngaycap, bn.diachi, bn.lydo, sk.chieucao, sk.cannang, sk.bmi, sk.mach, sk.huyetap, sk.pltl, sk.plsk, sk.benhkhac, sk.nguoiKL, sk.ngaykham);
            kq = getDB.ExecuteNonQuery(sql);
            return kq;
        }
        //xoa bn
        public static bool xoaBN(int idBN)
        {
            bool kq;
            string sql = string.Format("delete from thongtinkham where idBN = {0};" +
                "delete from thongtinBN where idBN = {1}; ", idBN,idBN);
            kq = getDB.ExecuteNonQuery(sql);
            return kq;
        }

        //sửa bn
        public static bool SuaBN(CLASS.thongtinBN bn,CLASS.thongtinSK sk)
        {
            bool kq;
            string sql = string.Format("update thongtinBN set hoten = N'{0}', gioitinh = N'{1}', namsinh = {2}, " +
                "cmnd = N'{3}', ngaycap = N'{4}', diachi = N'{5}', lydo = N'{6}' " +
                "where idBN = {7};" +
                "update thongtinkham set chieucao = {8}, cannang = {9}, bmi = {10}, mach = {11}, huyetap = N'{12}'," +
                "pltl = N'{13}' ,plsk = N'{14}',benhkhac = N'{15}',nguoiKL = N'{16}',ngaykham = N'{17}'" +
                "where idBN = {18}; ", bn.hoten, bn.gioitinh, bn.namsinh, bn.cmnd, bn.ngaycap, bn.diachi, bn.lydo, bn.idBN,
                sk.chieucao, sk.cannang, sk.bmi, sk.mach, sk.huyetap, sk.pltl, sk.plsk, sk.benhkhac, sk.nguoiKL, sk.ngaykham,bn.idBN);
            kq = getDB.ExecuteNonQuery(sql);
            return kq;
        }
    }
}
