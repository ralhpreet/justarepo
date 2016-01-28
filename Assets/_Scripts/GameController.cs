using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    //pubic instance variables
    public int cloudNumber=3;
    public CloudController cloud;
	// Use this for initialization
	void Start () {
        this._initialize();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //private methods
    private void _initialize(){
        //this.cloudNumber = 3;
        for (int cloudcount = 0; cloudcount < this.cloudNumber; cloudcount++)
        {
            Instantiate(cloud.gameObject);
        }
    }
}
