using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerColor : MonoBehaviour
{
    public Color[] colors;
    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetRandomColor();
    }
    private void SetRandomColor()
    {
        sr.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<ColorSwitch>())
        {
            Destroy(collision.gameObject);
            SetRandomColor();
            SpawnerScript.canSpawn = true;
        }
    }
}
