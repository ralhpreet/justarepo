using UnityEngine;
using System.Collections;

public class IslandController : MonoBehaviour {
    private Transform _transform;
    public float speed = 5f;
    private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition += new Vector2(0,-this.speed);
        this._transform.position = this._currentPosition;
        if (this._currentPosition.y <= -270)
        {
            this.Reset();
        }
       // Debug.Log(this._playerInput);
	
	}
    public void Reset()
    {
        float xPosition = Random.Range(-288f, 288f);
        this._transform.position = new Vector2(xPosition, 260f);

   }
}
