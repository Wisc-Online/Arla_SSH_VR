using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question1Commander : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;

    public void HideAnswer(int answerNumber)
    {
        if (answerNumber == 1)
        {
            answer1.SetActive(false);
        }else if (answerNumber == 2)
        {
            answer2.SetActive(false);
        }
        else if (answerNumber == 3)
        {
            answer3.SetActive(false);
        }
    }

}
