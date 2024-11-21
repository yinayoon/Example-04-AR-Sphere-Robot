using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    // Animator 컴포넌트를 참조하는 변수임 Animator Controller와 연결되어 있어야 함
    public Animator animator;

    // 애니메이션 상태 이름을 저장하는 문자열 배열
    // Animator Controller에 있는 상태 이름과 정확히 일치해야 작동
    public string[] animationNames;

    // UI 버튼 배열 이며 각 버튼은 특정 애니메이션 상태를 실행하도록 설정됨
    public Button[] buttons;

    // 애니메이션 전환 시간 (초 단위)
    // 애니메이션의 부드러운 전환을 위해 사용
    public float transitionDuration = 0.2f;

    void Start()
    {
        // 초기화
        // 버튼 배열을 반복하며 각 버튼에 클릭 이벤트를 추가
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;

            // 버튼 클릭 이벤트에 PlayAnimation(index) 함수 연결
            buttons[i].onClick.AddListener(() => PlayAnimation(index));
        }
    }

    void PlayAnimation(int index)
    {
        // 배열 인덱스가 유효한지 검사 (0 이상이고 animationNames 배열 크기보다 작아야 함)
        if (index >= 0 && index < animationNames.Length)
        {
            // Animator의 CrossFade 메서드를 사용하여 지정된 애니메이션 상태로 부드럽게 전환
            // 첫 번째 인자: 전환할 애니메이션 상태 이름
            // 두 번째 인자: 전환 시간
            animator.CrossFade(animationNames[index], transitionDuration);
        }
    }
}