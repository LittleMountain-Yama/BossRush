using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitLight : HoldCommand
{
    public HitLight(){ }

    public override void Execute(float val = 0)
    {
        base.Execute(val);
        Debug.Log("Hit: Executed but not implemented " + counter); 
    }

    public override void OnExit()
    {
        Debug.Log("Hit: Released with " + counter); 
    }
}
