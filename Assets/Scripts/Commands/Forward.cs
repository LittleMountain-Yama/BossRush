using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : ICommand
{
    Transform _t;

    public Forward(Transform t)
    {
        _t = t;
    }

    public void Execute(float val)
    {
        _t.position += new Vector3(val, 0, 0);
    }
}
