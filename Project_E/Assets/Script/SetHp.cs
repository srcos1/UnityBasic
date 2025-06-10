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
    // �ּ�ü���� 0

    public int Damage;
    public int HealPoint;

    void Awake() //��ũ��Ʈ�� �ε� �� �� �ѹ� ȣ��
    {
        nowHP = MaxHP;
        Initialize();
       
    }

    void Initialize()
    {
        RefreshUI();

    }
    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 21); // 5~20 ������ ������
        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }
        Txt_Text.text = $"{Damage}�� �������� �Ծ���.";
      RefreshUI();
    }

    public void OnClickHeal() // ȸ��
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }
        RefreshUI();
  
}

    void RefreshUI() // �Լ� ����
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // nowHP / MaxHP : 50 / 100
    }
}