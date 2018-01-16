using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour {
    string move = "down";
    Vector3 tempPos;
    float speed = 2;
	// Use this for initialization
	void Start () {
        tempPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(move == "up")
        {
            tempPos.y += speed * Time.deltaTime;
            transform.position = tempPos;
        }
        else if (move == "down")
        {
            tempPos.y -= speed * Time.deltaTime;
            transform.position = tempPos;
        }
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Top")
        {
            move = "down";
        }
        else if (collision.gameObject.tag == "Bottom")
        {
            move = "up";
        }
    }
}
