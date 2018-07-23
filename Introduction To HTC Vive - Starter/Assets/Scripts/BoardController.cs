using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class BoardController : MonoBehaviour {

    public string cardName = null;
    public char[] wordsChar;
    public char alphabetChar;
    public bool chkInboard = false;

    public void OnCollisionEnter(Collision coll)
    {
        Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == "Card")
        {
            if (!chkInboard)
            {
                chkInboard = true;
                cardName = coll.gameObject.name;
                Destroy(coll.gameObject);
                wordsChar = cardName.ToCharArray();
            }

        }
        else if (coll.gameObject.tag == "Alphabat")
        {
            if (chkInboard)
            {
                string alphabat = coll.gameObject.name;
                Debug.Log("Middle");
                Debug.Log(alphabat);
                if (cardName[0].Equals(alphabat))
                {
                    delcharicter(ref cardName);
                    Debug.Log("End");   
                }
            }
        }
    }

    private void delcharicter(ref string cardName)
    {
        throw new NotImplementedException();
        //    for (int i = 0; i <= wordsChar.Length; i++)
        //    {
        //        if (wordsChar[i] == alphabetChar)
        //        {

        //        }
        //    }

        //if (checkboard) //보드에 카드가 들어온 것을 체크 들어온 경우 true
        //{
        //    //BordPrtword(wordsChar[0]);
        //    //앞에 한글자 삭제
        //    if (BordPrtword(wordsChar[0]))
        //    {
        //        for (int i = 0; i < wordsChar.Length; i++)
        //        {
        //            wordsChar[i] = wordsChar[i + 1];
        //        }

        //    }

    }

    private bool BordPrtword(char v)//문자 출력
    {
        //카드의 가장 앞 글자가 들어온 알파벳과 매치하는지 체크
        //맞다면
        return true;
    }
}
