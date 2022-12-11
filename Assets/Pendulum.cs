using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pendulum
{
    public Transform bob_tr;
    public Tether tether;
    public Arm arm;
    public Bob bob;

    public void Initialize()
    {
        bob_tr.transform.parent = tether.tether_tr;
        arm.length = Vector3.Distance(bob_tr.transform.localPosition, tether.position);
    }

    internal Vector3 MoveBob(Vector3 pos, float time)
    {
        bob.ApplyGravity();

        pos += bob.velocity * time;

        return pos;
    }
}