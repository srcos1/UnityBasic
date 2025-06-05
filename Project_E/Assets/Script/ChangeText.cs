using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTextScript : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;

    public string NextText = "zzzz";

    public void OnClickButton()
    {
        Txt_Text.text = NextText;
        }
    }
