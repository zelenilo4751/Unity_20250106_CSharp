using ROKU.Tools;
using UnityEngine;

namespace ROKU
{
    /// <summary>
    /// 裝箱 Boxing 與拆箱 Unboxing
    /// </summary>
    public class Class_9_1_Boxing:MonoBehaviour
    {
        // 實值型別的資料類型
        // 結構、列舉、整數、浮點數、布林值、字元
        // 實值型別的資料會儲存在 Stack 記憶體內
        private int number = 100;

        // 物件資料類型為參考型別
        private object box;

        private void Awake()
        {
            // 裝箱
            // 將實值型別資料放到參考型別資料內
            box = number;

            LogSystem.LogWithColor(box.ToString(), "#f33");
        }
    }
}
