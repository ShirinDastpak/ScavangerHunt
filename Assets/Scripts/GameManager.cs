using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> huntList;

    public void OnTargetFound(GameObject target)
    {
        huntList.Remove(target);

        if (huntList.Count <= 0)
            SceneManager.LoadScene(2);
    }
}
