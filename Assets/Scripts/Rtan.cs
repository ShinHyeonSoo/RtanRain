using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float _Direction = 0.05f;

    SpriteRenderer _SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        _SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _Direction *= -1f;
            _SpriteRenderer.flipX = !_SpriteRenderer.flipX;
        }

        if(transform.position.x > 2.6f)
        {
            _Direction = -0.05f;
            _SpriteRenderer.flipX = true;
        }
        else if(transform.position.x < -2.6f)
        {
            _Direction = 0.05f;
            _SpriteRenderer.flipX = false;
        }

        transform.position += Vector3.right * _Direction;
    }
}
