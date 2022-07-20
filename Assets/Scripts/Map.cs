using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Sprite[] sprites;

    void Start()
    {
        
        for (int i = -5; i < 5; i++)
        {
            Material material = new Material(sprites, MaterialType.STONE);
            Block block = new Block(material, i, 0);
            block.AplplyBoxCollider();
            block.SetParent(transform);
        }

        for (int i = -5; i < 5; i++)
        {
            Material material = new Material(sprites, MaterialType.STONE);
            Block block = new Block(material, i, 1);
            block.AplplyBoxCollider();
            block.SetParent(transform);
        }
        for (int i = -5; i < 5; i++)
        {
            Material material = new Material(sprites, MaterialType.GRASS);
            Block block = new Block(material, i, 2);
            block.AplplyBoxCollider();
            block.SetParent(transform);
        }

    }

}
