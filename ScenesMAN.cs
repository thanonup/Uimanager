using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMAN : MonoBehaviour
{
    public void LoadScence(string names)
    {
        SceneManager.LoadScene(names);
    }

}
