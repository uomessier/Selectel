using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipFlight : MonoBehaviour
{
    private List<Vector2> positions;
    private float step = 0.005f;
    private float current = 0f;
    private int curPositionNum = 0, destPositionNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        positions = new List<Vector2>();
        positions.Add(new Vector2(0, 0));
        positions.Add(new Vector2(0, 10));
        positions.Add(new Vector2(-10, 0));
        positions.Add(new Vector2(20, 0));
        positions.Add(new Vector2(5, 5));

        transform.position = positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(positions[curPositionNum], positions[destPositionNum], current);
        current += step;

        if (current > 1f)
        {
            curPositionNum = destPositionNum;
            destPositionNum = (destPositionNum + 1) % positions.Count;
            current = 0f;
        }
    }
}
