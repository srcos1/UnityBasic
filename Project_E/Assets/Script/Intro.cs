using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IntroScript : MonoBehaviour
{
    private string name = "������";
    private int age = 27;
    private float height = 171.3f;
    private string bloodType = "A��";
    private string mbti = "ISFP";
    private int footSize = 260;
    private float weight = 58.1f;
    private string hobby = "����";
    private string favoriteFood = "������";
    private string favoriteGame = "����";



    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction(); // �ڱ� �Ұ� ȣ��
    
    }

  
    public void SelfIntroduction()
    {
        Debug.Log("���� �̸���" + name+ " �Դϴ�.");
        Debug.Log("���� ���̴�" + age+ "�Դϴ�.");
        Debug.Log("Ű��" + height + "�Դϴ�.");
        Debug.Log("��������" + bloodType + "�Դϴ�.");
        Debug.Log($"�� ������� {footSize} �Դϴ�.");
        Debug.Log("mbti��" + mbti + "�Դϴ�.");
        Debug.Log("�����Դ�" + weight + "�Դϴ�.");
        Debug.Log("��̴�" + hobby + "�Դϴ�.");
        Debug.Log("������" + favoriteFood + "�Դϴ�");
        Debug.Log("������" + favoriteGame + "�Դϴ�");
    }
}
