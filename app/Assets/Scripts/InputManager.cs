﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    Vector2 slideStartPosition;
    Vector2 prevPosition;
    Vector2 delta = Vector2.zero;
    bool moved = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(1))
        //    rightClicked = true;
        //else
        //    rightClicked = false;

        //if (Input.GetKeyDown(KeyCode.Space))
        //    Jumped = true;
        //else
        //    Jumped = false;

	    // スライド開始地点
        if (Input.GetButtonDown("Fire1"))
            slideStartPosition = GetCursorPosition();

        // 画面の1割以上移動させたらスライド開始と判断する
        if (Input.GetButton("Fire1"))
        {
            if (Vector2.Distance(slideStartPosition, GetCursorPosition()) >= (Screen.width * 0.1f))
                moved = true;
        }

        // スライド操作が終了したか
        if (!Input.GetButtonUp("Fire1") && !Input.GetButton("Fire1"))
            moved = false;

        // 移動量を求める
        if (moved)
            delta = GetCursorPosition() - prevPosition;
        else
            delta = Vector2.zero;

        // カーソル位置を更新。
        prevPosition = GetCursorPosition();
	}


    // クリックされたか
    public bool Clicked()
    {
        if (!moved && Input.GetButtonUp("Fire1"))
            return true;
        else
            return false;
    }

    // スライド時のカーソルの移動量
    public Vector2 GetDeltaPosition()
    {
        return delta;
    }

    // スライド中か
    public bool Moved()
    {
        return moved;
    }


    public Vector2 GetCursorPosition()
    {
        return Input.mousePosition;
    }

    //public bool rightClicked { get; set; }

    //public bool Jumped { get; set; }
}
