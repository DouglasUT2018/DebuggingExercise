using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu5 : MonoBehaviour
{
    public bool allowProgress = true;
    GameObject startButton;
    TextMeshProUGUI textComponent;

    string[] congratulatoryMessage = new string[] {
        "Well, that was an easy one. Lets see how you get on here.",
        "That last solution was art worthy of the fridge door!",
        "You best stock up on magnets to show off this glorious work!",
        "1337 skills!",
        "{insert student name}, master of problem solving!" };

    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("StartButton");
        textComponent = startButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        int level = SceneManager.GetActiveScene().buildIndex+3;

        if (level > -1)
        {
            Debug.Log(congratulatoryMessage[level]);
        }

        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            textComponent.text = "Finish";
        }

    }

    public void LoadNextScene()
    {
        Debug.Log($"The {startButton.name} is working");

        if (allowProgress)
        {
            if(textComponent.text != "Finish")
            {
                SceneManager.LoadScene($"Scene{SceneManager.GetActiveScene().buildIndex + 2}");
            }
            else
            {
                Debug.Log("Winner winner, chicken dinner!");
            }
        }
    }
}
