using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
// Debug.log(); ����Ƽ���� consoleâ�� log�� ���� �� �ִ� ��ɾ�
// ; ���α׷��� ����� ���� ���� �Ǵ� ��� ����� �������� �� �� �ֵ��� ��
public class Test : MonoBehaviour  // ����Ƽ �����ϱ� ���� �پ��ִ�
{
    int playerLevel = 10;

    string name;

    
    // Start is called before the first frame update

 /*private void Awake() //���� �ѹ� ����
  {

  }
 */
  /*private void OnEnable() // Ȱ��ȭ �� �� ����
  {
    Debug.Log(Random.Range(1,100)); // 1 �̻� 100 �̸��� ������ ���� ���� �ڴ�.
  }*/
 /* void Start() // �ѹ��� ����
  {
        void Start()
        {
            name += "���� �̸���";

            Debug.Log("���� ������ " + playerLevel + "�Դϴ�.");
            Debug.Log($"���� ������ {playerLevel}�Դϴ�.");
        }

        Debug.Log("�ѹ��� ����");
  }
*/
  // Update is called once per frame
  void Update() // �� �����Ӹ��� ����
  {

  }

}
/* �Ǽ���  ���� 1 ǥ���� 1�ڿ� f�� �ٿ��� ǥ�� 1f  �ε� �Ҽ���
 
 char ���ڸ� ���� �� �ִ� ����
 string�� ���ڿ��� ���� �� �ִ� ���� 
 ���ڿ� ������ ��� ���� ""�� ��� 
 
 4. ��/ ���� 
 boolean
 �� �ĺ��� ī�� ǥ��� ���ξ �ҹ��ڷ� ǥ�� �ܾ��� ���ξ �빮�ڷ�
 �Ľ�Į ǥ��� ��� ���ξ �빮�ڷ� ������ũ,�밡���� ǥ��� ��
 �����ȿ� ������������� ��� �Ұ� �Լ��� ���ǹ� �ȿ� ���ú��� �����ϴ� ����?
 
 
 ���� ������ public
 private Ŭ���� �ȿ� private ���� ����
 
 ���� ����
 public class Player
{
  private int playerLevel = 10;

-- public int Level() (�������� �Լ�)
{
  return playerLevel;
)
}

public class Monster
{
  private int monsterLevel;

  public void SetLevel(int _playerLevel)
  {
      monsterLevel = _playerLevel;
  }
}

public class Game
{
  Player A;
  Monster B;

  void MonsterSpawn() // ����
  {
      B.SetLevel(???); () �ȿ�<- A.Level
  }
}

���� ������ ++ a++ a ���� �� �� 1���� 
++a �� 1 ���� �� a ����

shift+\ = |

����
�õ� */