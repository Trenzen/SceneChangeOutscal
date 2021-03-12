using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public void sceneChnage(int indexed)
    {
        SceneManager.LoadScene(indexed);
    }
}
