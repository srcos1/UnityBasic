using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StarDot : MonoBehaviour
{
    string star;
    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
   
        star = string.Empty;

        for (int i = 0; i <= 5; i++) // ��
        {
            for (int j = 0; j < i; j++) //�� ��� ��
            {

                star += "��";
            }

            star += "\n"; // �ٹٲ�
                          // ������ 1
        }
                Debug.Log($"Phase 1 : {star}");
            }



    public void Phase2()
    {
        star = string.Empty;
        for (int i = 0; i <= 5; i++) // ��
        {

            for (int k = 0; k < i; k++) //����
            {
                star += "��";
            }
            for (int j = 5; j > i; j--) //�� ��� ��
            {
                star += "��";
                
            }
            star += "\n";   //�ٹٲ�
                            // ������ 2


            Debug.Log(star);
        }
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5


        Debug.Log(star);
    }
}
