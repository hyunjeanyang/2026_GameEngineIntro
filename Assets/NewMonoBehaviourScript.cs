using UnityEngine;
using UnityEngine.InputSystem;

public class playercontrol : MonoBehaviour
{
    private Vector2 moveinput;
    public float moveSpeed = 7f;

    // 입력 받기
    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();
        Debug.Log(moveinput);
    }

    void Update()
    {
        // 좌우 이동
        transform.Translate(Vector3.right * moveSpeed * moveinput.x * Time.deltaTime);

        // 방향에 따라 캐릭터 뒤집기
        if (moveinput.x != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveinput.x), 1, 1);
        }
    }
}