using UnityEngine;

// 三條斜線是摘要(XML 語言) 用來做簡短說明，可加在類別或變數上方
/// <summary>
/// 認識 C# 資料類型
/// </summary>
public class Class_2_DataType : MonoBehaviour 
{
    // 變數語法:
    // 修飾詞 變數資料類型 變數名稱 指定 預設值;
    // 四大常用資料類型
    // 整  數 int : 儲存無小數的數字
    // 浮點數 float : 儲存有小數的數字
    // 字  串 string : 儲存文字，需用雙引號
    // 布林值 bool : 儲存 true/false
    public int count = 7;
    public float moveSpeed = 3.5f;          //浮點數需添加f後綴
    public float turnSpeed = 30.7F;         // f可用大小寫，習慣上是小寫
    public string character = "蓋倫";
    public bool isDead = false;
    public bool gameOver = true;

    // 整數資料類型
    public byte lv = 16;                    // byte 型別，範圍 0 ~ 255，大小 8 byte
    public uint coin = 9999;                // uint 型別，範圍 0 ~ 很大，大小 32 byte
    public long items = 3000;               // long 型別，範圍 0 ~ 更大，大小 64 byte

    // 字串與字元
    public string playerName = "Roku";      //字串，儲存多個字元，使用雙引號
    public char a = 'a';                    //字元，儲存單個字元，使用單引號

    // 溢位
    // public sbyte number = 128;
}
