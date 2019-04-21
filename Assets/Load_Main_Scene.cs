using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Main_Scene : MonoBehaviour {

    public void Go_to_main()
    {
        SceneManager.LoadScene("Main");
    }
}
