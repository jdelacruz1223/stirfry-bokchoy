using Unity.VisualScripting;
using UnityEngine;

public class movingObject : MonoBehaviour
{
    private enum direction {
        up, down, left, right
    }
    [SerializeField] private float speed = 10f;
    [SerializeField] private direction moveDirection;
    [SerializeField] private float distance = 5f;
    private Vector2 startPos;
    private Vector2 endPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        switch (moveDirection) {
            case direction.up:
                endPos = new Vector2(startPos.x, startPos.y + distance);
                break;
            case direction.down:
                endPos = new Vector2(startPos.x, startPos.y - distance);
                break;
            case direction.right:
                endPos = new Vector2(startPos.x + distance, startPos.y);
                break;
            case direction.left:
                endPos = new Vector2(startPos.x - distance, startPos.y);
                break;
            default: 
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.GetKey(KeyCode.Space) ? Vector2.MoveTowards(transform.position, endPos, speed * Time.deltaTime) : Vector2.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
    }

}
