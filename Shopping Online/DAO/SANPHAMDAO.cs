using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Shopping_Online.DTO;
namespace Shopping_Online.DAO
{
    internal class SANPHAMDAO
    {
        private static SANPHAMDAO instance;

        private SANPHAMDAO() { }

        internal static SANPHAMDAO Instance
        {
            get { if (instance == null) instance = new SANPHAMDAO(); return SANPHAMDAO.instance; }
            private set { SANPHAMDAO.instance = value; }
        }

        public List<SANPHAM> LayTatCaSanPham()
        {
            List<SANPHAM> result = new List<SANPHAM>();
            string query = "select * from SANPHAM";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SANPHAM temp = new SANPHAM(item);
                result.Add(temp);
            }

            return result;
        }

        public List<SANPHAM> SearchSPByName(string name)
        {
            List<SANPHAM> list = new List<SANPHAM>();

            string query = string.Format("SELECT * FROM SANPHAM WHERE dbo.fuConvertToUnsign1(TenSP) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SANPHAM SP = new SANPHAM(item);
                list.Add(SP);
            }

            return list;
        }

        public SANPHAM ChiTietSanPham(string name)
        {
            string query = "Select * from SANPHAM where TenSP = '" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                SANPHAM result = new SANPHAM(item);
                return result;
            }

            return null;
        }
    }
}
