using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace QLTHUVIEN.ClassBang
{
    class XL_SACH: XL_BANG
    {
        #region Các hàm khởi tạo
        public XL_SACH() : base("SACH") { }
        public XL_SACH(string pChuoi_SQL): base("SACH", pChuoi_SQL) { }
        #endregion
        #region Các hàm xử lí sự kiện
        public void Tim(DataRow p_Dong_dieu_kien)
        {
            string chuoi_DK = "";
            ArrayList mang_DK = new ArrayList();
            if (p_Dong_dieu_kien["MaSach"] != null)
                mang_DK.Add("MaSach LIKE '*" + p_Dong_dieu_kien["MaSach"] + "*'");
            if (p_Dong_dieu_kien["TuaDe"] != null)
                mang_DK.Add("TuaDe LIKE '*" + p_Dong_dieu_kien["TuaDe"] + "*'");
            if (p_Dong_dieu_kien["MaNXB"] != null)
                mang_DK.Add("MaNXB LIKE '*" + p_Dong_dieu_kien["MaNXB"] + "*'");
            if (p_Dong_dieu_kien["TacGia"] != null)
                mang_DK.Add("TacGia LIKE '*" + p_Dong_dieu_kien["TacGia"] + "*'");
            if (p_Dong_dieu_kien["SoLuong"] != null)
                mang_DK.Add("SoLuong LIKE '*" + p_Dong_dieu_kien["SoLuong"] + "*'");
            if (p_Dong_dieu_kien["NgayNhap"] != null)
                mang_DK.Add("NgayNhap LIKE '*" + p_Dong_dieu_kien["NgayNhap"] + "*'");
            if (p_Dong_dieu_kien["MaTL"] != null)
                mang_DK.Add("MaTL LIKE '*" + p_Dong_dieu_kien["MaTL"] + "*'");
            if (mang_DK.Count > 0)
            {
                for (int i = 0; i < mang_DK.Count; i++)
                    if (i == 0) chuoi_DK = mang_DK[i].ToString();
                    else chuoi_DK += "AND" + mang_DK[i];
            }
            Loc_du_lieu(chuoi_DK);
        }
        #endregion

    }
}
