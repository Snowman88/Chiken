using UnityEngine;
using System.Collections;

public class CoinGui : MonoBehaviour {

    CoinCounter coinCounter;

    float baseWidth = 854f;
    float baseHeight = 480f;

    public Texture timerIcon;
    public GUIStyle timerLabelStyle;

    void Awake()
    {
        coinCounter = GameObject.FindObjectOfType(typeof(CoinCounter)) as CoinCounter;
    }


    void OnGUI()
    {
        // 解像度対応
        GUI.matrix = Matrix4x4.TRS(
            Vector3.zero,
            Quaternion.identity,
            new Vector3(Screen.width / baseWidth, Screen.height / baseHeight, 1f));

        string coinStr = string.Format("Score: {0}", coinCounter.Coins.ToString("0"));
        // タイマー
        GUI.Label(
            new Rect(8f, 60f, 128f, 48f),
            new GUIContent(coinStr),
            timerLabelStyle);
    }
}
