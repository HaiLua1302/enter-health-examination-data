using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace khamsk.DB
{
    class DB_KSKLX
    {
        //Rút trích dữ liêu: select 
        public static DataTable getDSKSKLX()
        {
            string sql = "select right('0000' + convert(varchar(4),bn.idBN), 4) as IDBN , bn.hoten,bn.gioitinh,bn.namsinh,bn.cmnd,bn.ngaycap,bn.diachi,bn.lydo, " +
                "xn.morphin,xn.amphe,xn.metham,xn.cansa,xn.nongdocon,xn.ketluan,xn.nguoiKL,xn.ngaykham " +
                "from thongtinBN bn left join xetnghiem xn on bn.idBN = xn.idBN " +
                "where bn.idBN = xn.idbn " +
                "order by xn.ngaykham desc; ";
            DataTable dt = getDB.ExecuteQuery(sql);
            return dt;
        }
        //them bieu mau 
        public static bool ThemBNLX(CLASS.thongtinBN bn, CLASS.thongtinXN xn)
        {
            bool kq;
            string sql = string.Format("insert into thongtinBN (hoten, gioitinh, namsinh, cmnd, ngaycap, diachi, lydo) values (N'{0}',N'{1}',{2},N'{3}',N'{4}',N'{5}',N'{6}') " +
                "insert into xetnghiem(idBN, morphin,amphe,metham,cansa,nongdocon,ketluan, nguoiKL, ngaykham)" +
                "values((select IDENT_CURRENT('thongtinBN') as idBN), N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}'); ",
               bn.hoten, bn.gioitinh, bn.namsinh, bn.cmnd, bn.ngaycap, bn.diachi, bn.lydo, xn.morphin, xn.amphe, xn.metham, xn.cansa, xn.nongdocon, xn.ketluan, xn.nguoiKL, xn.ngaykham);
            kq = getDB.ExecuteNonQuery(sql);
            return kq;
        }
        //xoa bn
        public static bool xoaBNLX(int idBN)
        {
            bool kq;
            string sql = string.Format("delete from xetnghiem where idBN = {0};" +
                "delete from thongtinBN where idBN = {1}; ", idBN, idBN);
            kq = getDB.ExecuteNonQuery(sql);
            return kq;
        }

        //sửa bn
        public static bool SuaBNLX(CLASS.thongtinBN bn, CLASS.thongtinXN xn)
        {
            bool kq;
            string sql = string.Format("update thongtinBN set hoten = N'{0}', gioitinh = N'{1}', namsinh = {2}, " +
                "cmnd = N'{3}', ngaycap = N'{4}', diachi = N'{5}', lydo = N'{6}' " +
                "where idBN = {7};" +
                "update thongtinkham set morphin = N'{8}',amphe = N'{9}',metham = N'{10}',cansa = N'{11}',nongdocon = N'{12}',ketluan = N'{13}' ,nguoiKL = N'{14}',ngaykham = N'{15}'" +
                "where idBN = {16}; ", bn.hoten, bn.gioitinh, bn.namsinh, bn.cmnd, bn.ngaycap, bn.diachi, bn.lydo, bn.idBN,
                xn.morphin, xn.amphe, xn.metham, xn.cansa, xn.nongdocon, xn.ketluan, xn.nguoiKL, xn.ngaykham, bn.idBN);
            kq = getDB.ExecuteNonQuery(sql);
            return kq;
        }
    }
}
