using UnityEngine;

public class BackkgroundScript : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 startPosition;
    private float repeatWidth;

    void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }
    
    void Update()
    {
        if (!GameManager.Instance.IsPlaying())
            return;
        
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
