using ROKU.Tools;
using UnityEngine;

namespace ROKU
{
    /// <summary>
    /// 作業 9
    /// </summary>
    public class Exercise_9:MonoBehaviour
    {
        private void Awake()
        {
            float number = -999.321f;
            sbyte byteNumber = (sbyte)number;
            LogSystem.LogWithColor(byteNumber, "#6f6");
        }
    }
}
