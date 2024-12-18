using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public abstract void OnStateEnter();

    public abstract void OnStateLeave();

    public abstract void OnStateUpdate();
}
