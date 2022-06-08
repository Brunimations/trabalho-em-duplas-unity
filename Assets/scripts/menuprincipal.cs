using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuprincipal : MonoBehaviour
{
	public void Jogar()
	{
		SceneManager.LoadScene("fase1");
	}

	public void Sair()
	{
		Application.Quit();
	}

		public void fas1()
	{
		SceneManager.LoadScene("fase1");
	}
		public void fas2()
	{
		SceneManager.LoadScene("fase2");
	}
		public void fas3()
	{
		SceneManager.LoadScene("fase3");
	}
		public void fas4()
	{
		SceneManager.LoadScene("fase4");
	}
		public void voltamenu()
	{
		SceneManager.LoadScene("menu");
	}
}
