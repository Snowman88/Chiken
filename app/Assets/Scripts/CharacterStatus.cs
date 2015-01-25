using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour {
    CoinCounter coinCounter;

	// Use this for initialization
	void Start () {
        coinCounter = FindObjectOfType<CoinCounter>() as CoinCounter;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GetItem()
    {
        Debug.Log("GET ITEM");

        // Coint Count up
        coinCounter.Up();
    }
}
