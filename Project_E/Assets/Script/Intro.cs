using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IntroScript : MonoBehaviour
{
    private string name = "조형민";
    private int age = 27;
    private float height = 171.3f;
    private string bloodType = "A형";
    private string mbti = "ISFP";
    private int footSize = 260;
    private float weight = 58.1f;
    private string hobby = "쉬기";
    private string favoriteFood = "떡볶이";
    private string favoriteGame = "없음";



    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction(); // 자기 소개 호출
    
    }

  
    public void SelfIntroduction()
    {
        Debug.Log("저의 이름은" + name+ " 입니다.");
        Debug.Log("저의 나이는" + age+ "입니다.");
        Debug.Log("키는" + height + "입니다.");
        Debug.Log("혈액형은" + bloodType + "입니다.");
        Debug.Log($"발 사이즈는 {footSize} 입니다.");
        Debug.Log("mbti는" + mbti + "입니다.");
        Debug.Log("몸무게는" + weight + "입니다.");
        Debug.Log("취미는" + hobby + "입니다.");
        Debug.Log("음식은" + favoriteFood + "입니다");
        Debug.Log("게임은" + favoriteGame + "입니다");
    }
}
