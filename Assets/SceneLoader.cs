using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLoader : MonoBehaviour
{


    public void Load(string Scene)
    {
        
        SceneManager.LoadScene($"{Scene}");
    }
}
