using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butt : MonoBehaviour
{
    public void playgame()  {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("yeeeehawww");


    }

    
}
