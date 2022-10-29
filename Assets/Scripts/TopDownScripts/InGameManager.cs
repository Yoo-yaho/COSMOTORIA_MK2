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
        if (isAction) // ��ȭâ ���� ��
        {
            isAction = false;
        }
        else // ��ȭâ ���� ��
        {
            isAction = true;
            scanObject = scanObj;
            talkText.text = "�̰��� " + scanObject.name + "�̴�.";
        }

        talkPanel.SetActive(isAction);
    }
}
