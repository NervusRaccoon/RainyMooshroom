using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class PathFinderNode
{
    // Координаты точки на карте.
    public Vector2Int Position { get; set; }
    // Длина пути от старта (G).
    public int PathLengthFromStart { get; set; }
    // Точка, из которой пришли в эту точку.
    public PathFinderNode CameFrom { get; set; }
    // Примерное расстояние до цели (H).
    public int HeuristicEstimatePathLength { get; set; }
    // Ожидаемое полное расстояние до цели (F).
    public int EstimateFullPathLength
    {
        get
        {
            return this.PathLengthFromStart + this.HeuristicEstimatePathLength;
        }
    }
}
