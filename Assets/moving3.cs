using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving3 : MonoBehaviour
{
    public float speed = 2;
    public float minZ = 1;
    public float maxZ = 6;
    private bool left = false;

    void Update()
    {
        Vector3 v = transform.position;
        float sz = speed * Time.deltaTime;

        if (left)
        {
            v.z = v.z - sz;
            if (v.z <= minZ)
            {
                v.z = minZ;
                left = false;
            }
        }
        else
        {
            v.z = v.z + sz;
            if (v.z >= maxZ)
            {
                v.z = maxZ;
                left = true;
            }
        }

        transform.position = v;
    }
}
