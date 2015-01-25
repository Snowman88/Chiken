using UnityEngine;
using System.Collections;

public class CoinCounter : MonoBehaviour {

    public int Coins { get; set; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Up()
    {
        Coins += 1;
    }

    public void Down()
    {
        Coins -= 1;
    }
}
