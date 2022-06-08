using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasegue : MonoBehaviour
{
	public Transform camera;
	private void Update()
	{
		transform.position = camera.position;
	}
}
