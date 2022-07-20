using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Item
{

    private string id;
    private GameObject gameObject;
    private SpriteRenderer render;
    private int x;
    private int y;

    public bool placable = false;
    public Material material;

    public Item(Material material, int x, int y, bool placable)
    {
        gameObject = new GameObject("Block_" + material.GetType().ToString());
        render = gameObject.AddComponent<SpriteRenderer>();
        this.material = material;
        this.x = x;
        this.y = y;
        this.placable = placable;

        Render();
    }

    private void Render()
    {
        gameObject.transform.position = new Vector2(x, y);
        render.sprite = material.GetSprite();
    }

    public void SetPosition(int x, int y)
    {
        this.x = x;
        this.y = y;

        gameObject.transform.position = new Vector2(x, y);
    }

    public void AplplyBoxCollider()
    {
        gameObject.AddComponent<BoxCollider2D>();
    }

    public void SetParent(Transform transform)
    {
        gameObject.transform.parent = transform;
    }
}
