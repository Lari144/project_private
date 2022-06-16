using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SetNameController : MonoBehaviour
{
    public static string user = "";
    public TextMeshProUGUI user_name;
    public TMP_InputField user_inputField;

    public void SetName()
    {
        user = user_inputField.text;
        user_name.text = "Welcome " + user_inputField.text + " !";
    }
}
