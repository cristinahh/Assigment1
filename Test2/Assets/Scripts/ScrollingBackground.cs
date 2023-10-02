using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer bgRenderer;

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if (Input.GetAxisRaw("Horizontal")>0)
        {

            bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
        }
=======
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
>>>>>>> Stashed changes
    }
}
