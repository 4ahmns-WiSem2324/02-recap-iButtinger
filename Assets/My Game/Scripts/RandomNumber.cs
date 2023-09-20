using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNumber : MonoBehaviour
{
    int randomNumb;
    public TMP_Text numberText;
    
    private void Start()
    {
        Random.Range(1, 7);
    }


}
