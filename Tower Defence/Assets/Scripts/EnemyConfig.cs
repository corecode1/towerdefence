﻿using System;
using UnityEngine;

[CreateAssetMenu]
public class EnemyConfig : ScriptableObject
{
    public Enemy Prefab;
    [FloatRangeSlider(0.5f, 2f)] public FloatRange Scale = new FloatRange(1f);
    [FloatRangeSlider(-0.4f, 0.4f)] public FloatRange PathOffset = new FloatRange(0f);
    [FloatRangeSlider(0.2f, 5f)] public FloatRange Speed = new FloatRange(1f);
    [FloatRangeSlider(10f, 1000f)] public FloatRange Health = new FloatRange(100f);
}