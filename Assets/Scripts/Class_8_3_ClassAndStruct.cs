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

        private void Start()
        {
            // var 不指定類型，可以儲存所有資料
            var testClass = new Class_8_4_Class("我是類別");
            var testSturct = new Class_8_4_Struct("我是結構");

            var testClass2 = new Class_8_4_Class("我是類別2");
            var testSturct2 = new Class_8_4_Struct("我是結構2");

            LogSystem.LogWithColor(testClass.name, "#79f");
            LogSystem.LogWithColor(testClass2.name, "#79f");
            LogSystem.LogWithColor(testSturct.name, "#79f");
            LogSystem.LogWithColor(testSturct2.name, "#79f");

            testClass2 = testClass;     // 傳址：這時候的 class 或 class2 指向同一地址
            testSturct2 = testSturct;   // 傳值：這時候的 Sturct 與 Sturct2 指向同一個值

            // 修改 class 或 class2 資調都會被同步
            testClass.name = "類別";
            LogSystem.LogWithColor(testClass.name, "#f79");
            LogSystem.LogWithColor(testClass2.name, "#f79");

            // 修改 sturct 或 sturct2 資料不會被同步
            testSturct.name = "結構";
            LogSystem.LogWithColor(testSturct.name, "#f79");
            LogSystem.LogWithColor(testSturct2.name, "#f79");


        }
    }

    // 類別：
    // 1. 繼承：允許繼承
    // 2. 建構子：可以有多個建構子
    // 4. 資料類型：參考型別 Reference Type
    public class Class_8_3_Class : MonoBehaviour
    {
        public Class_8_3_Class() { }

        public Class_8_3_Class(int test) { }
    }

    // 結構：
    // 1. 結構：不允許繼承
    // 2. 建構子：不能有無參數建構子
    // 4. 資料類型：實值型別 Value Type
    public struct Class_8_3_Struct
    {
        // public Class_8_3_Struct() { }

        public Class_8_3_Struct(int test) { }
    }
}
