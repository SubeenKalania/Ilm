using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NamesData", menuName = "ScriptableObjects/CustomData")]
public class MyScriptableObject : ScriptableObject
{
 
    [System.Serializable]
    public class NameData
    {
        public Sprite arabicName;
        public string transliteration;
        public string Meaning;
       

    }
     public List <NameData> nameList;
    
}
