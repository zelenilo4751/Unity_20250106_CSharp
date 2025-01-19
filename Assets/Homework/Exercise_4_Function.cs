using UnityEngine;

public class Exercise_4_Function:MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"作業 1：{TrueA()}");
        Debug.Log($"作業 2：{FalseB()}");
    }

    /// <summary>
    /// 作業1：傳回True
    /// </summary>
    /// <returns>True</returns>
    private bool TrueA()
    {
        return true;
    }

    /// <summary>
    /// 作業2：傳回False
    /// </summary>
    /// <returns>False</returns>
    private bool FalseB()
    {
        return false;
    }
}
