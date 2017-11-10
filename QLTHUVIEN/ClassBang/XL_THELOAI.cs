using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace QLTHUVIEN.ClassBang
{
    class XL_THELOAI: XL_BANG
    {
        #region Các hàm khởi tạo
        public XL_THELOAI() : base("THELOAI") { }
        public XL_THELOAI(string pChuoi_SQL): base("THELOAI", pChuoi_SQL) { }
        #endregion
        #region Các hàm xử lí sự kiện
        public void Tim(DataRow p_Dong_dieu_kien)
        {
            string chuoi_DK = "";
            ArrayList mang_DK = new ArrayList();
            if (p_Dong_dieu_kien["MaTL"] != null)
                mang_DK.Add("MaTL LIKE '*" + p_Dong_dieu_kien["MaTL"] + "*'");
            if (p_Dong_dieu_kien["TenTL"] != null)
                mang_DK.Add("TenTL LIKE '*" + p_Dong_dieu_kien["TenTL"] + "*'");
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
