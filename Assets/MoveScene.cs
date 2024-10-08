using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    SaveBuffer sb;
    public SaveFile3 tutorialDefaultSave;
    void Start()
    {
        sb = GameObject.Find("SaveData").GetComponent<SaveBuffer>();
    }
    public void Click(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
    public void Youtube()
    {
        Application.OpenURL("https://www.youtube.com/@user-vb9by5mp9f");
    }
    public void OfficalSite()
    {
        Application.OpenURL("https://1392year.pythonanywhere.com/w/d7ByHgoruh");
    }
    public void Tutorial()
    {
        sb.tutorial = true;
        tutorialDefaultSave.startTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        sb.save = tutorialDefaultSave;
        UnityEngine.SceneManagement.SceneManager.LoadScene("GlobalScene");
    }
}
