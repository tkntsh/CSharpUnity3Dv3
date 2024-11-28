using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class storeUsername : MonoBehaviour
{
    //game objects
    public GameObject usernameInputField;
    public GameObject successStorageText;
    public GameObject failedStorageText;

    //storage items/objects
    public string username;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //void method to check if the user entered a valid input
    public void storeButton()
    {
        username = usernameInputField.GetComponent<Text>().text;
        //checking if input field isnt empty and displaying text
        if(string.IsNullOrEmpty(username))
        {
            successStorageText.SetActive(false);
            failedStorageText.SetActive(true);
        }
        else
        {
            failedStorageText.SetActive(false);
            successStorageText.SetActive(true);
        }
    }
}
