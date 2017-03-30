using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class VrAutoWalk : MonoBehaviour {

    public float Speed = 3f;
    public bool MoveForward;
    private CharacterController controller;
    private GvrViewer gvrViewer;
    private Transform vrHead;
	// Use this for initialization
	void Start () {

        controller = GetComponent<CharacterController>();
        gvrViewer = transform.GetChild(0).GetComponent<GvrViewer>();
        vrHead = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            MoveForward = !MoveForward;
        }
        if (MoveForward)
        {
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * Speed);
        }
		
	}
}
