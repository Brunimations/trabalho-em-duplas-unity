using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameranova : MonoBehaviour
{
	public float sensibilidadex;
	public float sensibilidadey;
	public Transform orientacao;
	float rotacaoX;
	float rotacaoY;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void Update()
	{
		float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensibilidadex;
		float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensibilidadey;
		rotacaoY += mouseX;
		rotacaoX -= mouseY;
		rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);

		transform.rotation = Quaternion.Euler(rotacaoX, rotacaoY, 0);
		orientacao.rotation = Quaternion.Euler(0, rotacaoY, 0);

	}

}
