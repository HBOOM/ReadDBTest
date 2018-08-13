using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readDBWin
{
  public   interface DBHelper
    {
      /// <summary>
      /// 不同数据库实现查询语句
      /// </summary>
      DataTable Query();
      void excelport(string fileName, DataGridView girdview);

    }
}
