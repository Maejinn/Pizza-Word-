using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _20DTH1A_LT_WEB_BaiThuHoach_ThaiThanhDat_2000004681.Models
{
    public class Common
    {
        /// <summary>
        /// hàm lấy danh sách tất cả sản phẩm 
        /// </summary>
        /// <returns></returns>
        public static List<SanPham> getProducts()
        {
            List<SanPham> l = new List<SanPham>();
            //----Khai báo đối tượng đại diện
            DbContext cn = new DbContext("name=PizzaWorldConnect");
            //----Lấy dữ liệu.......
            l = cn.Set<SanPham>().ToList<SanPham>();
            return l;
        }
        public static List<SanPham> getProductsByLoaiSP(int maLoai)
        {
            List<SanPham> l = new List<SanPham>();
            //---khai báo đối tượng cn đại diện cho database
            DbContext cn = new DbContext("name=PizzaWorldConnect");
            //lấy dữ liệu 
            l = cn.Set<SanPham>().Where(m => m.maLoai == maLoai).ToList<SanPham>();
            return l;

        }

        public static List<TaiKhoan> getKhachHang()
        {
            return new DbContext("name=PizzaWorldConnect").Set<TaiKhoan>().ToList<TaiKhoan>();
        }
        /// <summary>
        /// hàm cho phép lấy ra danh sách các chủng loại hàng
        /// </summary>
        /// <returns></returns>
        public static List<LoaiSP> getCategories()
        {
            return new DbContext("name=PizzaWorldConnect").Set<LoaiSP>().ToList<LoaiSP>();
        }

    }
}