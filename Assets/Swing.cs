using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField]
    private Pendulum pendulum;

    // Start is called before the first frame update
    void Start()
    {
        pendulum.Initialize();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localPosition = pendulum.MoveBob(transform.localPosition, Time.deltaTime);
    }
}
