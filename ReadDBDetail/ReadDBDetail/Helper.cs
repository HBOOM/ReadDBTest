using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadDBDetail
{
    public  class Helper
    {
        public string getdata()
        {
            var  redDB = new ReadDBEntities();
          
            int arr = redDB.Database.ExecuteSqlCommand("select name from sysobjects where xtype='u'", null);
            return "string";
        }

  
}
    

}