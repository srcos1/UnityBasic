using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
// Debug.log(); 유니티에서 console창에 log를 남길 수 있는 명령어
// ; 프로그래밍 언어의 문장 끝을 판단 어디서 명령이 끝나는지 알 수 있도록 함
public class Test : MonoBehaviour  // 유니티 동작하기 위해 붙어있는
{
    int playerLevel = 10;

    string name;

    
    // Start is called before the first frame update

 /*private void Awake() //최초 한번 실행
  {

  }
 */
  /*private void OnEnable() // 활성화 될 떄 실행
  {
    Debug.Log(Random.Range(1,100)); // 1 이상 100 미만의 랜덤한 값을 만들 겠다.
  }*/
 /* void Start() // 한번만 실행
  {
        void Start()
        {
            name += "나의 이름은";

            Debug.Log("나의 레벨은 " + playerLevel + "입니다.");
            Debug.Log($"나의 레벨은 {playerLevel}입니다.");
        }

        Debug.Log("한번만 실행");
  }
*/
  // Update is called once per frame
  void Update() // 매 프레임마다 실행
  {

  }

}
/* 실수형  정수 1 표현시 1뒤에 f를 붙여서 표기 1f  부동 소수점
 
 char 문자를 담을 수 있는 변수
 string은 문자열을 담을 수 있는 변수 
 문자열 변수에 담기 위해 ""을 사용 
 
 4. 참/ 거짓 
 boolean
 ㅣ 식별자 카멜 표기법 접두어를 소문자로 표기 단어의 접두어를 대문자로
 파스칼 표기법 모든 접두어를 대문자로 스네이크,헝가리안 표기법 등
 범위안에 들어있지않으면 사용 불가 함수나 조건문 안에 로컬변수 선언하는 개념?
 
 
 접근 지정자 public
 private 클래스 안에 private 생략 가능
 
 돌발 질문
 public class Player
{
  private int playerLevel = 10;

-- public int Level() (정보전달 함수)
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

  void MonsterSpawn() // 몬스터
  {
      B.SetLevel(???); () 안에<- A.Level
  }
}

증감 연산자 ++ a++ a 실행 후 값 1증가 
++a 값 1 증가 후 a 실행

shift+\ = |

난수
시드 */