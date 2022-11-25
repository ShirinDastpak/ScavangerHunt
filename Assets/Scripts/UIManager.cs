using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.FindGameObjectWithTag("StartButton").GetComponent<Button>();

        if (startButton == null)
        {
            Debug.Log("No object tagged as start button!");
            return;
        }
        
        startButton.onClick.AddListener(StartHunt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartHunt()
    {
        SceneManager.LoadScene("3-ImageTargets");
    }
}
