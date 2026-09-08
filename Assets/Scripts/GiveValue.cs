using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveValue : MonoBehaviour
{
    [SerializeField] Text myText;

    //
    public void Start()
    {
        string newText = StaticData.valueToKeep;
        myText.text = newText;
    }



}
