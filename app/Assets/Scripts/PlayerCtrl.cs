using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {

    const float RayCastMaxDistance = 100f;
    InputManager inputManager;



	// Use this for initialization
	void Start () {
        inputManager = FindObjectOfType<InputManager>();
	}
	
	// Update is called once per frame
	void Update () {
        Walking();
	}

    private void Walking()
    {
        if (inputManager.Clicked())
        {
            Vector2 clickpos = inputManager.GetCursorPosition();
            // RayCastで対象物を調べる
            Ray ray = Camera.main.ScreenPointToRay(clickpos);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, RayCastMaxDistance, 1 << LayerMask.NameToLayer("Ground")))
            {
                SendMessage("SetDestination", hitInfo.point);
            }
        }
    }
}
