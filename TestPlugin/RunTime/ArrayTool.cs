using System.Collections;

namespace GSTool.Array//指定命名空间
{
    public static class ArrayTool
    {
        public static string ToOneString(this ICollection collection)//扩展方法
        {
            var info = "";
            foreach (var item in collection)
            {
                info += item.ToString() + " ";
            }
            return info;
        }
    }
}