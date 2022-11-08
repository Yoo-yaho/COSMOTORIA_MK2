using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameManager : MonoBehaviour
{
    public float textSpeed;
    public bool isAction = false;
    public int talkIndex;

    public Image portraitImage;
    public TalkManager talkManager;
    public Text talkText;
    public GameObject scanObject;
    public GameObject talkPanel;

    public void Awake()
    {
        talkPanel.SetActive(isAction);
    }

    public void Scan(GameObject scanObj)
    {      
        scanObject = scanObj;
        ObjectData objectData = scanObject.GetComponent<ObjectData>();
        Talk(objectData.id, objectData.isNpc);

        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            //talkPanel.GetComponent<Animator>().SetTrigger("isText");
            isAction = false;
            talkIndex = 0;
            return;
        }

        if (isNpc)
        {
            //talkPanel.GetComponent<Animator>().SetTrigger("isText");
            talkText.text = talkData.Split(':')[0];

            portraitImage.sprite = talkManager.GetPortrait(id, int.Parse(talkData.Split(':')[1]));
            portraitImage.color = new Color(1, 1, 1, 1);
        } 
        else
        {
            //talkPanel.GetComponent<Animator>().SetTrigger("isText");
            talkText.text = talkData;

            portraitImage.color = new Color(1, 1, 1, 0);
        }

        isAction = true;
        talkIndex++;
    }

    public void TalkEnd()
    {
        isAction = false;
    }
}
