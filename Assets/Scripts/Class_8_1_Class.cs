using UnityEngine;

namespace ROKU
{
    /// <summary>
    /// 類別 Class：用來定義一個物件以及他所擁有的資料與功能 (成員)
    /// </summary>
    public class Class_8_1_Class:MonoBehaviour
    {
        private void Awake()
        {
            // 實例化 NPC 並儲存在 npcJack 變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC("傑克");
            Class_8_1_NPC npcKID = new Class_8_1_NPC("KID", "Hello~");

            npcJack.LogName();
            npcKID.LogName();
            npcJack.Talk();
            npcKID.Talk();
        }
    }

}
