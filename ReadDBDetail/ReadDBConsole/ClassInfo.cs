//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReadDBConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClassInfo
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public Nullable<System.DateTime> ClassTime { get; set; }
        public string UserID { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
