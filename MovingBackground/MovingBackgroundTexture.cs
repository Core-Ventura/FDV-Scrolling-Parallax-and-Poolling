using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackgroundTexture : MonoBehaviour
{

    public float moveAmount;
    private Renderer rend;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = Time.time * moveAmount;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
