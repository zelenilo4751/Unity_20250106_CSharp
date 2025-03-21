using UnityEngine;

namespace ROKU
{
    /// <summary>
    /// 練習類別
    /// </summary>
    public class Exercise_8_Class:MonoBehaviour
    {
        private void Awake()
        {
            Exercise_8_Boss boss1 = new Exercise_8_Boss("boss1", "fire", 99);
            Exercise_8_Boss boss2 = new Exercise_8_Boss("boss2", "wind", 199);

            Debug.Log($"<color=#f93>{boss1.name},招式：{boss1.skill}</color>");
            Debug.Log($"<color=#f93>{boss2.name},招式：{boss2.skill}</color>");

        }
    }

    /// <summary>
    /// 大魔王類別
    /// </summary>
    public class Exercise_8_Boss
    {
        public string name;
        public string skill;
        public float hp;

        public Exercise_8_Boss(string _name, string _skill, float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }
    }

}
