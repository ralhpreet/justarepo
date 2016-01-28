﻿using UnityEngine;
using System.Collections;

public class planeController : MonoBehaviour {
    //private instance variables
    private float _playerInput;
    private Transform _transform;
    public float speed = 5f;
    private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._playerInput = Input.GetAxis("Horizontal");
        Debug.Log(this._playerInput);
        //if player input is positive move right
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }
        //if player input is negative move left
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }
        //check iff the plane is going out of bound and keep it inside wwindows boundary
        this._checkBounds();
	
	}
    //private methods############################
    private void _checkBounds()
    {
        if (this._currentPosition.x < -298)
        {
            this._currentPosition.x = -298;
        }
        if (this._currentPosition.x > 298)
        {
            this._currentPosition.x = 298;
        }
        this._transform.position = this._currentPosition;
    }
}
