using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetNameController : MonoBehaviour
{
    public TextMeshProUGUI user_name;
    public TMP_InputField user_inputField;

    public void SetName(){

        user_name.text = "Welcome " + user_inputField.text;
    }

    public void ResetName(){

        user_name.text = "";
    }
}
