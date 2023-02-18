using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualGenerator : MonoBehaviour
{
    [SerializeField] private Transform square;
    [SerializeField] private Transform individual;
    private void Start()
    {
        int i = 0;
        for (int y = 20; y >= -20; y -= 4)
        {
            for (int x = -20; x <= 20; x += 4)
            {
                Transform iTransform = Instantiate(square, individual);
                iTransform.position = new Vector3(x, y, 0);
                iTransform.gameObject.name = "Square" + i;
                i++;
            }
        }
    }
}
