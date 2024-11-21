using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    // Animator ������Ʈ�� �����ϴ� ������ Animator Controller�� ����Ǿ� �־�� ��
    public Animator animator;

    // �ִϸ��̼� ���� �̸��� �����ϴ� ���ڿ� �迭
    // Animator Controller�� �ִ� ���� �̸��� ��Ȯ�� ��ġ�ؾ� �۵�
    public string[] animationNames;

    // UI ��ư �迭 �̸� �� ��ư�� Ư�� �ִϸ��̼� ���¸� �����ϵ��� ������
    public Button[] buttons;

    // �ִϸ��̼� ��ȯ �ð� (�� ����)
    // �ִϸ��̼��� �ε巯�� ��ȯ�� ���� ���
    public float transitionDuration = 0.2f;

    void Start()
    {
        // �ʱ�ȭ
        // ��ư �迭�� �ݺ��ϸ� �� ��ư�� Ŭ�� �̺�Ʈ�� �߰�
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;

            // ��ư Ŭ�� �̺�Ʈ�� PlayAnimation(index) �Լ� ����
            buttons[i].onClick.AddListener(() => PlayAnimation(index));
        }
    }

    void PlayAnimation(int index)
    {
        // �迭 �ε����� ��ȿ���� �˻� (0 �̻��̰� animationNames �迭 ũ�⺸�� �۾ƾ� ��)
        if (index >= 0 && index < animationNames.Length)
        {
            // Animator�� CrossFade �޼��带 ����Ͽ� ������ �ִϸ��̼� ���·� �ε巴�� ��ȯ
            // ù ��° ����: ��ȯ�� �ִϸ��̼� ���� �̸�
            // �� ��° ����: ��ȯ �ð�
            animator.CrossFade(animationNames[index], transitionDuration);
        }
    }
}