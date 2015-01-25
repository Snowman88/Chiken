using UnityEngine;
using System.Collections;

public class DropCoin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        // player
        if (other.tag != "Player")
            return;

        // Coin 処理
        CharacterStatus status = other.GetComponent<CharacterStatus>();
        status.GetItem();

        // 消滅
        Destroy(gameObject);
    }
}
