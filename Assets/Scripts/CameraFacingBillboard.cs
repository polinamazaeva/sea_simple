using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingBillboard : MonoBehaviour 
{
	private Transform mainCameraTransform;

	void Start()
	{
		mainCameraTransform = GameObject.FindGameObjectWithTag ("MainCamera").transform;
	}

	void Update()
	{
		transform.LookAt (mainCameraTransform);
	}
}
