using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string sceneName;

    void OnMouseDown()
    {
        Application.LoadLevel(sceneName);
    }

    void OnMouseOver()
    {

    }
}
