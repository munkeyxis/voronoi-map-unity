using UnityEngine;

public static class PolyContainers
{
    public static bool ContainsPoint (Vector2[] polyPoints, Vector2 p) { 
        var j = polyPoints.Length-1; 
        var inside = false; 
        for (int i = 0; i < polyPoints.Length; j = i++) { 
            if ( ((polyPoints[i].y <= p.y && p.y < polyPoints[j].y) || (polyPoints[j].y <= p.y && p.y < polyPoints[i].y)) && 
                 (p.x < (polyPoints[j].x - polyPoints[i].x) * (p.y - polyPoints[i].y) / (polyPoints[j].y - polyPoints[i].y) + polyPoints[i].x)) 
                inside = !inside; 
        } 
        return inside; 
    }
}
