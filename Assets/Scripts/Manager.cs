using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class Manager : MonoBehaviour
{
    public MyScriptableObject dataList;
    public Image arabicNameTextImg;
    public Button nextButton;
    public Button previousButton;
    public int indexCounter;
    public TextMeshProUGUI transliterationText;
    public TextMeshProUGUI meaningText;
    public TextMeshProUGUI numberText;



    

    public void Start()
    {
        
        UpdateValues();
    }

    public void NextButtonCall()
    {
        print("pressed");
        
        if (indexCounter < dataList.nameList.Count-1)
        {
            indexCounter++;
     
        }
        
        else
        {
            indexCounter = 0;
        }
        UpdateValues();
        
    }

    public void PreviousButtonCall()
    {
        print("pressed");
        if(indexCounter > 0)
        {
            indexCounter--;
        }
        else
        {
            indexCounter = dataList.nameList.Count - 1;
        }
        UpdateValues();
        
    }


    public void UpdateValues()
    {
        arabicNameTextImg.sprite = dataList.nameList[indexCounter].arabicName;
        transliterationText.text = dataList.nameList[indexCounter].transliteration;
        meaningText.text = dataList.nameList[indexCounter].Meaning;
        numberText.text = (indexCounter + 1).ToString();
    }
}
