using ROKU.Tools;
using UnityEngine;

namespace ROKU
{
    /// <summary>
    /// 類別與結構的差異
    /// </summary>
    public class Class_8_3_ClassAndStruct:MonoBehaviour
    {
        private void Awake()
        {
            // 3. 空值：類別可以空值，結構不行
            Class_8_3_Class class1 = new Class_8_3_Class();     // 有實例化
            Class_8_3_Class class2 = null;     // 空值

            Class_8_3_Struct class3 = new Class_8_3_Struct();       // 有實例化
            // Class_8_3_Struct class4 = null;        // 空值

            LogSystem.LogWithColor(class1.ToString(), "#f96");
            // LogSystem.LogWithColor(class2.ToString(), "#f96");
            LogSystem.LogWithColor(class3.ToString(), "#f96");

        }
    }

    // 類別：
    // 1. 繼承：允許繼承
    // 2. 建構子：可以有多個建構子
    public class Class_8_3_Class : MonoBehaviour
    {
        public Class_8_3_Class() { }

        public Class_8_3_Class(int test) { }
    }

    // 結構：
    // 1. 結構：不允許繼承
    // 2. 建構子：不能有無參數建構子
    public struct Class_8_3_Struct
    {
        // public Class_8_3_Struct() { }

        public Class_8_3_Struct(int test) { }
    }
}
