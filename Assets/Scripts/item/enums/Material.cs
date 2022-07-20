using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material
{

    private MaterialType type;
    private Sprite sprite;
    public Material(Sprite[] sprites, MaterialType type)
    {
        this.type = type;
        sprite = sprites[(int)type];
    }

    public int GetCode()
    {
        return (int)type;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    public new MaterialType GetType()
    {
        return type;
    }
}

public enum MaterialType {
    STONE = 0,
    STONE2 = 1,
    DIRT = 2,
    GRASS = 3
}
