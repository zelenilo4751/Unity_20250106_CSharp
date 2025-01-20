using Unity.VisualScripting;
using UnityEngine;

// 命名空間：
// 將類別分類，類似倉庫的概念，不同倉庫可以有相同的名稱類別
// 語法：namespace 命名空間名稱 { 內容 }
namespace ROKU
{
    /// <summary>
    /// 選取陳述式
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour
    {
        #region if 判斷式
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        #endregion
        #region switch判斷式
        [SerializeField, Header("武器")]
        private string weapon;
        #endregion
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp = 100;

        private void Awake()
        {
            // if 判斷式
            // if (布林值) { 陳述式 }
            if (true)
            {
                Debug.Log("當布林值為 True，會執行這裡");
            }
            // 快速完成：輸入 if > 選取 if 陳述式 > 按Enter
            if (false)
            {
                Debug.Log("當布林值為 False，不會執行這裡而且會有綠蚯蚓");

            }
        }

        // 更新事件：一秒鐘執行約 60 次(60FPS) Frame Per Second
        private void Update()
        {
            // 格式化(排版)：ctrl+K D
            #region if判斷式
            Debug.Log("<color=#f79>更新事件</color>");

            // 如果 isOpen 布林值等於 True，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            // 否則 isOpen 布林值等於 False，就顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }
            // 比較運算子、邏輯運算子結果為布林值
            // if 會在最上方，else 在最下方，中間可以有多個 else if
            // 如果分數 >= 60，通過
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你</color>");
            }
            // 否則 如果 分數 >= 40，補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>參加補考</color>");
            }
            // 否則 如果 分數 >= 20，補考並做小專題
            else if (score >= 20)
            {
                Debug.Log("<color=#f9a>參加補考 + 專題</color>");

            }
            // 否則 當掉
            else
            {
                Debug.Log("<color=#f33>下次努力</color>");
            }
            #endregion
            #region switch 判斷式
            // switch 判斷式
            // switch ( 要判斷的值 ) { 陳述式 }
            switch (weapon)
            {
                // case 值：
                // 當判斷的值等於值時會執行這裡
                // break; 跳出判斷式

                // 如果武器等於小刀，攻擊力等於20
                // 蝴蝶刀與小刀一樣
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力：20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color=#ff3>攻擊力：10</color>");
                    break;
                case "屠龍刀":
                    Debug.Log("<color=#ff3>攻擊力：999</color>");
                    break;
                case "":
                    Debug.Log("<color=#ff3>沒有武器</color>");
                    break;
                // 當 weapon 的值不等於上面的值，會執行這裡
                default:
                    Debug.Log("<color=#ff3>這是不能使用的武器</color>");
                    break; 
            }
            #endregion
            //判斷式只會執行一個陳述式
            #region 課間練習
            if (hp >= 10 && hp <= 39)
            {
                Debug.Log("<color=#f79>快死掉了</color>");
            }
            else if (hp >= 40 && hp <= 59)
            {
                Debug.Log("<color=#f79>警告，快喝水</color>");
            }
            else if (hp >= 60 && hp <= 79)
            {
                Debug.Log("<color=#f79>健康狀態有狀況</color>");
            }
            else if (hp >= 80)
            {
                Debug.Log("<color=#f79>血量安全</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#f79>YOU ARE DIE</color>");
            } 
            #endregion

        }
    }

}
