using System.Collections;

namespace GSTool.Array//ָ�������ռ�
{
    public static class ArrayTool
    {
        public static string ToOneString(this ICollection collection)//��չ����
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