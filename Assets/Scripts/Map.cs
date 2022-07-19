using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Texture2D material;
    private Sprite mySprite;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Awake()
    {
        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;

        transform.position = new Vector2(-1, 0);
    }

    void Start()
    {
        sr.sprite = Sprite.Create(material, new Rect(0.0f, 0.0f, 512, 512), new Vector2(0, 0), 512);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
