using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class PathFinder
{
    private static int GetHeuristicPathLength(Vector2Int from, Vector2Int to)
    {
        return Math.Abs(from.x - to.x) + Math.Abs(from.y - to.y);
    }

    private static int GetDistanceBetweenNeighbours()
    {
        return 1;
    }

    private static Collection<PathFinderNode> GetNeighbours(PathFinderNode pathNode, Vector2Int goal, bool[,] map)
    {
        var result = new Collection<PathFinderNode>();

        // Соседними точками являются соседние по стороне клетки.
        Vector2Int[] neighbourPoints = new Vector2Int[4];
        neighbourPoints[0] = new Vector2Int(pathNode.Position.x + 1, pathNode.Position.y);
        neighbourPoints[1] = new Vector2Int(pathNode.Position.x - 1, pathNode.Position.y);
        neighbourPoints[2] = new Vector2Int(pathNode.Position.x, pathNode.Position.y + 1);
        neighbourPoints[3] = new Vector2Int(pathNode.Position.x, pathNode.Position.y - 1);

        foreach (var point in neighbourPoints)
        {
            // Проверяем, что не вышли за границы карты.
            if (point.x < 0 || point.x >= 10)
                continue;
            if (point.y < 0 || point.y >= 10)
                continue;
            // Проверяем, что по клетке можно ходить.
            if (map[point.x, point.y] != true)
                continue;
            // Заполняем данные для точки маршрута.
            var neighbourNode = new PathFinderNode()
            {
                Position = point,
                CameFrom = pathNode,
                PathLengthFromStart = pathNode.PathLengthFromStart + GetDistanceBetweenNeighbours(),
                HeuristicEstimatePathLength = GetHeuristicPathLength(point, goal)
            };
            result.Add(neighbourNode);
        }
        return result;
    }

    private static List<Vector2Int> GetPathForNode(PathFinderNode pathNode)
    {
        var result = new List<Vector2Int>();
        var currentNode = pathNode;
        while (currentNode != null)
        {
            result.Add(currentNode.Position);
            currentNode = currentNode.CameFrom;
        }
        result.Reverse();
        return result;
    }

    public List<Vector2Int> FindPath(bool[,] map, Vector2Int startPos, Vector2Int goal)
    {
        // Шаг 1.
        var closedSet = new Collection<PathFinderNode>();
        var openSet = new Collection<PathFinderNode>();
        // Шаг 2.
        PathFinderNode startNode = new PathFinderNode()
        {
            Position = startPos,
            CameFrom = null,
            PathLengthFromStart = 0,
            HeuristicEstimatePathLength = GetHeuristicPathLength(startPos, goal)
        };
        openSet.Add(startNode);
        while (openSet.Count > 0)
        {
            // Шаг 3.
            var currentNode = openSet.OrderBy(node => node.EstimateFullPathLength).First();
            // Шаг 4.
            if (currentNode.Position == goal)
                return GetPathForNode(currentNode);
            // Шаг 5.
            openSet.Remove(currentNode);
            closedSet.Add(currentNode);
            // Шаг 6.
            foreach (var neighbourNode in GetNeighbours(currentNode, goal, map))
            {
                // Шаг 7.
                if (closedSet.Count(node => node.Position == neighbourNode.Position) > 0)
                    continue;
                var openNode = openSet.FirstOrDefault(node => node.Position == neighbourNode.Position);
                // Шаг 8.
                if (openNode == null)
                    openSet.Add(neighbourNode);
                else
                  if (openNode.PathLengthFromStart > neighbourNode.PathLengthFromStart)
                {
                    // Шаг 9.
                    openNode.CameFrom = currentNode;
                    openNode.PathLengthFromStart = neighbourNode.PathLengthFromStart;
                }
            }
        }
        // Шаг 10.
        return null;
    }
}
