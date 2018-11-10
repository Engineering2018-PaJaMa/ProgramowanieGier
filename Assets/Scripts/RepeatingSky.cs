using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingSky : MonoBehaviour
{

    public float Speed = 1;
    public List<SpriteRenderer> spritesDown = new List<SpriteRenderer>();
    public List<SpriteRenderer> spritesLeft = new List<SpriteRenderer>();
    


    private float heightCamera;
    private float widthCamera;

    private Vector3 PositionCam;
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
        heightCamera = 2f * cam.orthographicSize;
        widthCamera = heightCamera * cam.aspect;
    }

    void Update()
    {
        foreach (var item in spritesDown)
        {
            //Down
            if (item.transform.position.y + item.bounds.size.y / 2 < cam.transform.position.y - heightCamera / 2)
            {
                SpriteRenderer sprite = spritesDown[0];
                foreach (var i in spritesDown)
                {
                    if (i.transform.position.y > sprite.transform.position.y)
                        sprite = i;
                }

                item.transform.position = new Vector2(sprite.transform.position.x, (sprite.transform.position.y + (sprite.bounds.size.y / 2) + (item.bounds.size.y / 2)));

                item.transform.Translate(new Vector2(0, Time.deltaTime * Speed * -1));
            }
        }
        foreach (var item in spritesLeft)
        {
            //Left
            if (item.transform.position.x + item.bounds.size.x / 2 < cam.transform.position.x - widthCamera / 2)
            {
                SpriteRenderer sprite = spritesLeft[0];
                foreach (var i in spritesLeft)
                {
                    if (i.transform.position.x > sprite.transform.position.x)
                        sprite = i;
                }

                item.transform.position = new Vector2((sprite.transform.position.x + (sprite.bounds.size.x / 2) + (item.bounds.size.x / 2)), sprite.transform.position.y);
            }
            item.transform.Translate(new Vector2(Time.deltaTime * Speed * -1, 0));
        }
          
    }
       
}