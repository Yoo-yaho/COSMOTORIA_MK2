using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    private void GenerateData()
    {
        talkData.Add(10, new string[] {"��... �Ա���:0", "Zzz...:1" });

        talkData.Add(100, new string[] { "�ƹ��� ������� �ʴ� å���̴�."});
        talkData.Add(101, new string[] { "�ʹ� ���غ��� �����̴�." });

        portraitData.Add(10 + 0, portraitArr[0]);
        portraitData.Add(10 + 1, portraitArr[1]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
