using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneM : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scene0()
    {
        SceneManager.LoadScene(0);
    }
    public void Scene1()
    {
        SceneManager.LoadScene(1);
    }
    public void Scene2()
    {
        SceneManager.LoadScene(2);
    }
    public void Scene3()
    {
        SceneManager.LoadScene(3);
    }
    public void Scene4()
    {
        SceneManager.LoadScene(4);
    }
    public void AppOut()
    {
        Application.Quit();
    }


}
