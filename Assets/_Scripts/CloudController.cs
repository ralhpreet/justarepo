using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {
    private Transform _transform;
    public float minVerticalSpeed = 5f;
    public float maxVerticalSpeed = 10f;
    private Vector2 _currentPosition;
    private float _verticalSpeed;
    public float minHorizontalSpeed=-2f;
    public float maxHorizontalSpeed=2f;
    private float _horizontalDrift;
    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalDrift, this._verticalSpeed);
        this._transform.position = this._currentPosition;
        if (this._currentPosition.y <= -270)
        {
            this.Reset();
        }
        // Debug.Log(this._playerInput);

    }
    public void Reset()
    {
        this._verticalSpeed = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        Debug.Log(this._verticalSpeed);
        this._horizontalDrift = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        float xPosition = Random.Range(-270f, 270f);
        this._transform.position = new Vector2(xPosition, 330f);


    }
}
