using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHp : MonoBehaviour
{

    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_Text;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // 최소체력은 0

    public int Damage;
    public int HealPoint;

    void Awake() //스크립트가 로딩 될 때 한번 호출
    {
        nowHP = MaxHP;
        Initialize();
       
    }

    void Initialize()
    {
        RefreshUI();

    }
    public void OnClickDamage() // 데미지
    {
        Damage = Random.Range(5, 21); // 5~20 무작위 데미지
        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        {
            nowHP = 0;
        }
        Txt_Text.text = $"{Damage}의 데미지를 입었다.";
      RefreshUI();
    }

    public void OnClickHeal() // 회복
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }
        RefreshUI();
  
}

    void RefreshUI() // 함수 생성
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // nowHP / MaxHP : 50 / 100
    }
}