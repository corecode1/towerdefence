﻿using UnityEngine;

public abstract class GameBehaviour : MonoBehaviour
{
    public virtual bool GameUpdate()
    {
        return true;
    }

    public abstract void Recycle();
}