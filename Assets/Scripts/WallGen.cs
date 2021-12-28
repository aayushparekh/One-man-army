/*
Name: Harshil Patel
NSID: hap793
Student #11290942
Course: CMPT 306 
Description: Class that generates and visualizes the walls around the dungeon world generated by the simple random dungeon gen.
Version:
--------1.0 creation
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WallGen 
{
    public static void createWalls(HashSet<Vector2Int> floorPos, TilemapVisual visualizer){
        var basicWallPos = FindWallsInDir(floorPos, Direction2D.cardinalDirectionL);
        foreach (var position in basicWallPos)
        {
            visualizer.PaintSingleBasicWall(position);
        }
    }

    private static HashSet<Vector2Int> FindWallsInDir(HashSet<Vector2Int> floorPos, List<Vector2Int> dirList){
        HashSet<Vector2Int> wallPositions = new HashSet<Vector2Int>();
        foreach (var position in floorPos)
        {
            foreach (var dir in dirList)
            {
                var neighbourPos = position + dir;
                if (floorPos.Contains(neighbourPos) == false)
                {
                    wallPositions.Add(neighbourPos);
                }
            }
        }
        return wallPositions;
    }
}