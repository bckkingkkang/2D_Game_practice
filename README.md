- [에셋 다운로드 및 배치, 중력 구현](https://blog.naver.com/bc_pokemonmaster/223566431376)
- [MonoBehaviour](https://blog.naver.com/bc_pokemonmaster)
- [Player 이동](https://blog.naver.com/bc_pokemonmaster/223567945263)
- [Player 점프](https://blog.naver.com/bc_pokemonmaster/223569781918)
- [충돌 감지 이벤트](https://blog.naver.com/bc_pokemonmaster/223583642200)

- [Prefab(프리팹)](https://blog.naver.com/bc_pokemonmaster/223595481156)
- [Instantiate & Destroy](https://blog.naver.com/bc_pokemonmaster/223595488115)

![1](https://github.com/user-attachments/assets/f9925f3f-e132-4d5d-af7d-81d66d5dc766)

* DOTween
* Lerp


# 2D_Game_practice

* Scene View
: 작업 중인 씬 내부에 모든 오브젝트를 표시, 배치하는 공간
* Game View
: 카메라에서 렌더링되는, 최종적으로 퍼블리시된 애플리케이션을 보여주는 공간
* Hierarchy
: 작업 중인 씬 내부에 존재한 모든 오브젝트를 관리하는 공간
* Inspector
: 오브젝트, 에셋 등과 같이 Unity 에디터의 거의 모든 요소에 대한 프로퍼티를 확인 및 편집하는 공간
* Project
: 프로젝트와 관련된 모든 파일이 표시되는 공간
* Console
: 코드를 활용한 디버깅을 표시하는 공간

### 단축키   
Hierarchy_(W) : 오브젝트의 Position 값을 변경   
Hierarchy_(E) : 오브젝트의 Rotation 값을 변경   
Hierarchy_(R) : 오브젝트의 Scale(크기) 값 변경   
Hierarchy_(T) : 오브젝트의 위치, 크기 변경   

### 변수와 연산자
**변수**
> * 변할 수 있는 값   
> * 프로그래밍적 의미로는 데이터를 저장하는 곳

### 메소드와 접근자
* 접근자 : 접근 범위를 결정
    * default
    * private : 선언한 클래스 내부에서만 접근 가능
    * public : 모든 곳에서 해당 변수나 메소드에 접근이 가능
    * internal : 같은 어셈블리에서만 public으로 접근 가능
    * protected : 상속 관계에서만 접근 가능
----------------------------------------------------------------------
### Unity의 변수
#### Unity의 변수 1. Game Object
> 'GameObject'는 Unity에서 게임을 구성하는 기본적인 요소로, 게임 내 모든 객체를 나타낸다.    
>> 게임에 등장하는 캐릭터, 배경, 아이템 등 모든 물체는 'GameObject'로 표현된다.    
>> 그러나 'GameObject' 자체는 단순히 빈 껍데기 역할만 하며, 이 오브젝트에 의미를 부여하기 위해서는 다양한 컴포넌트를 추가해야 한다.    
>> 컴포넌트는 'GameObject'에 기능을 더해주는 요소로 'Transform', 'Collider', 'Rigidbody'와 같은 물리적 시각적 속성을 추가할 수 있다. 이러한 컴포넌트를 통해 게임 오브젝트는 특정한 동작이나 외형을 가지게 된다.   

##### GameObject의 주요 기능
**1. SetActive(bool state)**   
GameObject의 활성화 상태를 변경한다. 'GameObject'는 활성화 상태일 때만 게임 내에서 동작하며, 비활성화 상태일 때는 모든 컴포넌트가 동작을 멈춘다.   
> true : 오브젝트를 활성화한다. 즉, 게임에서 보이고 동작한다.   
> false : 오브젝트를 비활성화한다. 즉, 게임에서 보이지 않으며 동작하지 않는다.

`예를 들어 어떤 NPC가 특정 조건에서만 등장해야 하는 경우 NPC의 'GameObject'를 비활성화 상태로 두었다가 조건이 충족되면 활성화할 수 있다.`     

```C#
GameObject a;
a.SetActive(true);
a.setActive(false);
```

**2. GetComponent<T>()**    
이 함수는 해당 'GameObject'가 가지고 있는 특정 컴포넌트를 반환한다. 'T'는 찾고자 하는 컴포넌트의 타입을 지정한다.
예를 들어 'SpriteRenderer' 컴포넌트를 얻고 싶다면 'GetComponent<SpriteRenderer>()'를 사용한다. 이 방법을 통해 오브젝트에 부착된 컴포넌트에 접근하여 다양한 동작을 제어할 수 있다.    

```C#
public class FirstScript : MonoBehaviour

{
    public GameObject a;

    private void Start()
    {
        a.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
```

#### Unity의 변수 2. Transform
'Transform' 컴포넌트는 Unity에서 모든 게임 오브젝트에 기본적으로 포함되는 필수 컴포넌트이다. 
UI 요소를 제외한 모든 게임 오브젝트는 'Transform'을 가지고 있으며, 이 컴포넌트를 통해 오브젝트의 위치(Position), 회전(Rotation), 크기(Scale)를 조정할 수 있다.
Transform 변수를 선언하여 오브젝트의 위치, 회전, 크기를 쉽게 관리할 수 있다.
Vector3 변수를 사용하여 'Transform'의 위치, 회전, 크기를 정의한 후 Start() 메서드에서 적용한다.

```C#
public class FirstScript : MonoBehaviour
{
    public Transform a;

    public Vector3 a_position;
    public Vector3 a_rotation;
    public Vector3 a_scale;

    private void Start()
    {
        a.position = a_position;
        a.eulerAngles = a_rotation;
        a.localScale = a_scale;
    }
```

> * a.position : 오브젝트의 현재 위치
> * a.eulerAngles : 오브젝트의 회전 각도
> * a.localScale : 오브젝트의 크기

`이렇게 되면 Trnasform 컴포넌트의 위치, 회전, 크기가 a_position, a_rotation, a_scale 에 지정된 값으로 설정된다. 이와 같이 Transform을 사용하여 게임 오브젝트의 움직임이나 크기 변화를 손쉽게 제어할 수 있다.`

또한 Transform은 게임 오브젝트의 계층 구조를 관리하는 데에도 중요한 역할을 한다.
부모-자식 관계를 설정하면 부모 오브젝트의 Transform 변화가 자식 오브젝트에도 영향을 미치게 된다.

#### Unity의 변수 3. Vector
> Vector는 Unity에서 좌표를 표현하는 데 사용되는 중요한 개념으로 2D와 3D 공간에서 오브젝트의 위치, 방향, 크기 등을 정의할 수 있는 다양한 벡터 타입이 있다.

* Vector2   
2D 좌표계를 나타내며, x축과 y축을 포함한다. 주로 2D 게임에서 사용되며, 평면 상의 위치를 표현할 때 유용하다.
Vector2 position2D = new Vector2(3.0f, 5.0f);
여기서 postion2D 는 x=3.0, y=5.0의 좌표를 가지는 2D 벡터이다.

* Vector3   
3D 좌표계를 나타내며 x, y, z축을 포함한다. 3D 게임에서 주로 사용되며, 공간상의 위치뿐만 아니라 오브젝트의 회전, 크기를 정의할 때도 사용된다.
Vector3 position3D = new Vector3(2.0f, 4.0f, 6.0f);
postion3D 는  x=2.0, y=4.0, z=6.0의 좌표를 가지는 3D 벡터를 정의한다.
Vector3는 게임 오브젝트의 위치뿐만 아니라 Transform 컴포넌트의 위치, 회전, 크기 값을 정의할 때도 자주 사용된다.


---------
## Monobehaviour
> Unity 엔진을 사용해 게임을 개발할 때, 스크립트를 작성하기 위해 기본적으로 상속받아야 하는 클래스
>> Unity의 모든 스크립트는 이 'MonoBehaviour' 클래스를 기반으로 동작하며, 이를 통해 Unity 엔진과 상호작용할 수 있다.

MonoBehaviour는 Unity에서 제공하는 C# 클래스 중 하나로, Unity의 게임 오브젝트에 동작을 추가할 때 사용된다.   
Unity에서 스크립트를 작성할 때, 이 클래스를 상속받음으로써 Unity의 생명 주기 이벤트를 활용할 수 있으며, 이를 통해 게임 오브젝트의 상태를 업데이트하거나 특정 동작을 구현할 수 있다.   

```C#
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // 동작 구현
}
```

### MonoBehaviour의 주요 기능
Unity 엔진과의 상호작용을 돕기 위해 다양한 기능과 메서드를 제공한다. 이를 통해 게임 개발자는 복잡한 게임 로직을 구현할 수 있다.   
* [생명 주기 메서드 - Lifecycle Methods](https://blog.naver.com/bc_pokemonmaster/223559219577)
* Unity 이벤트 메서드
    * OnCollisionEnter() : 충돌이 발생했을 때 호출
    * OnTriggerEnter() : 트리거 충돌이 발생했을 때 호출
    * OnMouseDown() : 오브젝트가 클릭되었을 때 호출

### MonoBehaviour 활용 시 주의사항
1. 스크립트 활성화/비활성화
   * MonoBehaviour를 상속받은 스크립트는 게임 오브젝트의 활성화 상태에 따라 동작이 달라진다. 게임 오브젝트가 비활성화되면 'update()'와 같은 메서드가 호출되지 않는다. 이를 통해 불필요한 연산을 줄일 수 있다.
2. Coroutine (코루틴)
   * MonoBehaviour는 Coroutine을 통해 비동기 작업을 처리할 수 있게 해준다. 코루틴은 게임 루프와 별개로 실행되면서, 일정 시간 후에 동작을 수행하거나 반복 작업을 처리할 때 유용하다.
3. 일부 경우에는 MonoBehaviour를 상속받지 않는 클래스가 필요할 수 있다.
   * 예를 들어 단순히 데이터만을 저장하는 클래스이거나, 다른 로직을 처리하는 일반적인 C# 클래스를 구현할 경우네는 MonoBehaviour를 상속받지 않아도 된다.



















