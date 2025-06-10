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

        for (int i = 0; i <= 5; i++) // 줄
        {
            for (int j = 0; j < i; j++) //별 찍는 수
            {

                star += "★";
            }

            star += "\n"; // 줄바꿈
                          // 페이즈 1
        }
                Debug.Log($"Phase 1 : {star}");
            }



    public void Phase2()
    {
        star = string.Empty;
        for (int i = 0; i <= 5; i++) // 줄
        {

            for (int k = 0; k < i; k++) //공백
            {
                star += "　";
            }
            for (int j = 5; j > i; j--) //별 찍는 수
            {
                star += "★";
                
            }
            star += "\n";   //줄바꿈
                            // 페이즈 2


            Debug.Log(star);
        }
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5


        Debug.Log(star);
    }
}
