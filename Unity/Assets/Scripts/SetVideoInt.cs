using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVideoInt : MonoBehaviour
{
    public void SetNumber(int number)
    {
        PlayerPrefs.SetInt("SelectedNumber", number);
        PlayerPrefs.Save();
        Debug.Log("Number " + number + " has been saved.");
    }
}
