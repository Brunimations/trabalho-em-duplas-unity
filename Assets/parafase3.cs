using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class parafase3 : MonoBehaviour
{
    public Transform jogadorbrabo;
    void OnTriggerEnter (Collider jogadorbrabo)
    {
        SceneManager.LoadScene("fase3");
    }
}
