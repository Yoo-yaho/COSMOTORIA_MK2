using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameManager : MonoBehaviour
{
    public float textSpeed;
    public bool isAction = false;

    public Text talkText;
    public GameObject scanObject;
    public GameObject talkPanel;

    public void Awake()
    {
        talkPanel.SetActive(isAction);
    }

    public void Scan(GameObject scanObj)
    {
        if (isAction) // 대화창 나갈 때
        {
            isAction = false;
        }
        else // 대화창 나올 때
        {
            isAction = true;
            scanObject = scanObj;
            talkText.text = "이것은 " + scanObject.name + "이다.";
        }

        talkPanel.SetActive(isAction);
    }
}
