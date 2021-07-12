using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGiris : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Restart();
    }


    private void Restart()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
