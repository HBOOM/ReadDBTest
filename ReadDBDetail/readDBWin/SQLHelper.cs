using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace readDBWin
{
    public class SQLHelper:DBHelper
    {
        /// <summary>
        /// sql查询
        /// </summary>
        // void Query()
        //{
        //    //ReadDBEntities red = new ReadDBEntities();
           
        //    throw new NotImplementedException();
        //}
        #region 普通实现未使用接口
        public DataTable DQuery()
        {
            string con = ConfigurationManager.ConnectionStrings["ReadDB"].ToString();
          
            string sql = @"SELECT (case when a.colorder=1 then d.name else null end) 表名,
a.colorder 字段序号,a.name 字段名,
(case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then '√'else '' end) 标识,
(case when (SELECT count(*) FROM sysobjects
WHERE (name in (SELECT name FROM sysindexes
WHERE (id = a.id) AND (indid in
(SELECT indid FROM sysindexkeys
WHERE (id = a.id) AND (colid in
(SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name)))))))
AND (xtype = 'PK'))>0 then '√' else '' end) 主键,b.name 类型,a.length 占用字节数,
COLUMNPROPERTY(a.id,a.name,'PRECISION') as 长度,
isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as 小数位数,(case when a.isnullable=1 then '√'else '' end) 允许空,
isnull(e.text,'') 默认值,isnull(g.[value], ' ') AS [说明]
FROM syscolumns a
left join systypes b on a.xtype=b.xusertype
inner join sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties'
left join syscomments e on a.cdefault=e.id
left join sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id
left join sys.extended_properties f on d.id=f.class and f.minor_id=0
where b.name is not null
--WHERE d.name='要查询的表' --如果只查询指定表,加上此条件
order by a.id,a.colorder";
             DataSet ds = new DataSet();
             SqlConnection strcon = new SqlConnection(con);
             strcon.Open();
             SqlDataAdapter sda = new SqlDataAdapter(sql,strcon);
             sda.Fill(ds);
             DataTable table = new DataTable();
             table= ds.Tables[0];
             return table;
            
           
        }
        #endregion

        #region 继承DBHelper接口实现查询
        public  DataTable Query()
        {
            string con = ConfigurationManager.ConnectionStrings["ReadDB"].ToString();

            string sql = @"SELECT (case when a.colorder=1 then d.name else null end) 表名,
a.colorder 字段序号,a.name 字段名,
(case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then '√'else '' end) 标识,
(case when (SELECT count(*) FROM sysobjects
WHERE (name in (SELECT name FROM sysindexes
WHERE (id = a.id) AND (indid in
(SELECT indid FROM sysindexkeys
WHERE (id = a.id) AND (colid in
(SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name)))))))
AND (xtype = 'PK'))>0 then '√' else '' end) 主键,b.name 类型,a.length 占用字节数,
COLUMNPROPERTY(a.id,a.name,'PRECISION') as 长度,
isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as 小数位数,(case when a.isnullable=1 then '√'else '' end) 允许空,
isnull(e.text,'') 默认值,isnull(g.[value], ' ') AS [说明]
FROM syscolumns a
left join systypes b on a.xtype=b.xusertype
inner join sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties'
left join syscomments e on a.cdefault=e.id
left join sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id
left join sys.extended_properties f on d.id=f.class and f.minor_id=0
where b.name is not null
--WHERE d.name='要查询的表' --如果只查询指定表,加上此条件
order by a.id,a.colorder";
            DataSet ds = new DataSet();
            SqlConnection strcon = new SqlConnection(con);
            strcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, strcon);
            sda.Fill(ds);
            DataTable table = new DataTable();
            table = ds.Tables[0];
            return table;
        }
        #endregion

        #region excel表格导出
       public  void  excelport(string fileName, System.Windows.Forms.DataGridView gridview)
        {
            string saveFileName = "";
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.DefaultExt = "xls";
            savedialog.Filter = "Excel文件|*.xls";
            savedialog.FileName = fileName;
            savedialog.ShowDialog();
            saveFileName = savedialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return;
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            if (xlapp == null)
            {
                MessageBox.Show("无法创建excel对象，可能是您未安装office");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlapp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            for (int i = 0; i < gridview.ColumnCount; i++)
            {

                worksheet.Cells[1, i + 1] = gridview.Columns[i].HeaderText;
            }
            for (int r = 0; r < gridview.Rows.Count; r++)
            {
                for (int i = 0; i < gridview.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = gridview.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();
            if (saveFileName != "") 
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("导出文件出错，文件可能正在被打开\n" + e.Message);

                }
            }
            xlapp.Quit();
            GC.Collect();
            MessageBox.Show("文件:" + fileName + ".xls保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


       
    }
}
