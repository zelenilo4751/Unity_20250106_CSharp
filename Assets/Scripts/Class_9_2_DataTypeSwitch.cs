using ROKU.Tools;
using UnityEngine;
using System;

namespace ROKU
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class Class_9_2_DataTypeSwitch:MonoBehaviour
    {
        private void Awake()
        {
            // 隱式轉換：不需要另外宣告轉換類型
            // 將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;
            LogSystem.LogWithColor(byte1, "#7f7");
            LogSystem.LogWithColor(byte1.GetType(), "#7f7");
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");
            // 隱式轉換：講比較小的 byte 放到大的 int
            int1 = byte1;
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");

            // 顯式轉換：需要宣告轉換類型
            // 將大的資料放到小的資料內
            int int2 = 100;
            byte byte2 = 0;
            LogSystem.LogWithColor(int2, "#7f7");
            LogSystem.LogWithColor(int2.GetType(), "#7f7");
            LogSystem.LogWithColor(byte2, "#7f7");
            LogSystem.LogWithColor(byte2.GetType(), "#7f7");
            // 顯式轉換：將比較大的 int 放到小的 byte
            // 添加(資料類型)
            byte2 = (byte)int2;
            LogSystem.LogWithColor(byte2, "#7f7");
            LogSystem.LogWithColor(byte2.GetType(), "#7f7");

            // 浮點數轉為整數型別，小數點後會遺失
            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogSystem.LogWithColor(byte3, "#f77");

            //範圍較大的轉為範圍較小的，會導致溢位
            int int3 = 257;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSystem.LogWithColor(byte4, "#f77");

            LogSystem.LogWithColor("----------", "#f77");
        }

        private void Start()
        {
            // 將整數轉為字串
            int count = 99;
            var intToString = Convert.ToString(count);
            LogSystem.LogWithColor(intToString.GetType(), "#f96");
            // 將布林值轉為字串
            bool isOver = false;
            var boolToString = Convert.ToString(isOver);
            LogSystem.LogWithColor(boolToString.GetType(), "#f96");

            float move = 3.5f;
            var floatToByte = Convert.ToByte(move);
            LogSystem.LogWithColor(floatToByte, "#f96");
            LogSystem.LogWithColor(floatToByte.GetType(), "#f96");

            // true = 1, false = 0
            bool isGrounded = true;
            var boolTOByte = Convert.ToByte(isGrounded);
            LogSystem.LogWithColor(boolTOByte, "#f96");
            LogSystem.LogWithColor(boolTOByte.GetType(), "#f96");


        }
    }
}
