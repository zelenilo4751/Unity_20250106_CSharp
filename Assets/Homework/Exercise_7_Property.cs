using UnityEngine;

namespace ROKU
{
    /// <summary>
    /// 練習屬性
    /// </summary>
    public class Exercise_7_Property:MonoBehaviour
    {
        [SerializeField]
        private float _hp = 100;

        public float hp
        {
            get
            {
                if (_hp <= 0) Debug.Log("<color=#f33>玩家角色已死亡</color>");
                return _hp;
            }
        }

        private void Update()
        {
            Debug.Log(hp);
        }

    }
}
