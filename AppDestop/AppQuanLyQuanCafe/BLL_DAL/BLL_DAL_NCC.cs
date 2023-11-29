using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NCC
    {
        QL_COFFEDataContext ql = new QL_COFFEDataContext();
        public BLL_DAL_NCC()
        {

        }

        public List<NHACUNGCAP> loadDataNCC()
        {
            List<NHACUNGCAP> lst = ql.NHACUNGCAPs.Select(t => t).ToList();
            return lst;
        }

    }
}
