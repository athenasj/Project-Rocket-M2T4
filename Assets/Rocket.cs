using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour {

    Rigidbody _rigidBody;
    Vector3 pos;

	// Use this for initialization
	void Start () {
        _rigidBody = GetComponent<Rigidbody>();
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();

    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Rocket Boost");
            _rigidBody.AddRelativeForce(Vector3.up * 100 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
            //_rigidBody.AddRelativeForce(Vector3.left);
            print("Rocket A");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * 100 * Time.deltaTime);
            //_rigidBody.AddRelativeForce(Vector3.right);
            print("Rocket D");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Start")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
