using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReadDBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadDBEntities red = new ReadDBEntities();
        // System.Type t=
            //Type t = typeof(ClassInfo);
            //object o = Activator.CreateInstance(t);
            //foreach (var item in t.GetProperties())
            //{
            //    Console.WriteLine(item.GetValue(o));
            //    //Console.WriteLine(item.Name);
            //    Console.WriteLine(item.PropertyType);
            //}
            Type t = typeof(ReadDBEntities);
            System.Reflection.MemberInfo[] meb = t.GetMembers();
            foreach (MemberInfo item in meb)
            {
                if (item.MemberType == MemberTypes.Property)
                {
                    System.Reflection.PropertyInfo propertyInfo = t.GetType().GetProperty(item.Name);
                    //string val = propertyInfo.GetValue(item.Name, null).ToString();
                    Console.WriteLine(propertyInfo.Name);
                }

            }
           
            Console.ReadKey();
        }
    }
}
