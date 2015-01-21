using UnityEngine;
using System.Collections;

public class PlayerAttackCtrl : MonoBehaviour {

    InputManager inputManager;
    public AnimationClip attackAnim;
	// Use this for initialization
	void Start () {
        inputManager = FindObjectOfType<InputManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (inputManager.rightClicked)
        {
            if(animation.clip.name == attackAnim.name)
                return;
            animation.Play(attackAnim.name);
        }
	}
}
