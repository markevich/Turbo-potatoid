using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public Transform targetObject;

    public float xSpread;
    public float zSpread;
    public float yOffset;

    public float rotationSpeed;

    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * rotationSpeed;

        Rotate(timer);
    }

    void Rotate(float timer)
    {
        var x = -Mathf.Cos(timer) * xSpread;
        var z = Mathf.Sin(timer) * zSpread;

        transform.LookAt(targetObject);

        transform.position = new Vector3(x, yOffset, z) + targetObject.position;
    }
}
