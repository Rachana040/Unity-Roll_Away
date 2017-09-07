using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    private Vector3 offset;
	void Start () {
        offset = transform.position;
	}

    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
