using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    float _Size = 1f;
    int _Score = 1;
    SpriteRenderer _Renderer;

    // Start is called before the first frame update
    void Start()
    {
        _Renderer = GetComponent<SpriteRenderer>();

         float x = Random.Range(-2.4f, 2.4f);
         float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        int type = Random.Range(1, 4);

        if (type == 1)
        {
            _Size = 0.8f;
            _Score = 1;
            _Renderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
        }
        else if (type == 2)
        {
            _Size = 1.0f;
            _Score = 2;
            _Renderer.color = new Color(130 / 255f, 130 / 255f, 1f, 1f);
        }
        else if (type == 3)
        {
            _Size = 1.2f;
            _Score = 3;
            _Renderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
        }

        transform.localScale = new Vector3(_Size, _Size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        //else if (collision.gameObject.CompareTag("Player"))
        //{

        //}
    }
}
