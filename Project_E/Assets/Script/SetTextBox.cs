using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetTextBox : MonoBehaviour
{

    public TextMeshProUGUI Txt_Text; // �ؽ�Ʈ�� ���� ��
    [SerializeField] TMP_InputField Input_Text; // ��� �ؽ�Ʈ�� ������ ���� 

    public void OnClickButton()
    { 
        Txt_Text.text = Input_Text.text; 
    
    }
}


