using UnityEngine;
using System.Collections;

public class GameRuleCtrl : MonoBehaviour {

    // 残り時間　
    public float timeRemaining = 5.0f * 60.0f;
    // ゲームオーバーフラグ
    public bool gameOver = false;
    // ゲームクリア
    public bool gameClear = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;
        // 残り時間がなくなったらゲームオーバー
        if (timeRemaining <= 0.0f)
            GameOver();
	}

    private void GameOver()
    {
        Debug.Log("GameOver");
        gameOver = true;
    }


    public void GameClear()
    {
        Debug.Log("GameClear");
        gameClear = true;
    }
}
