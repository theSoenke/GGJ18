﻿using UnityEngine;

public class Player
{
    public int Id;
    public string Name;
    public Texture2D Photo;
    public Server Server;

    public Color Color
    {
        get
        {
            var colorID = PlayerColor.Instance.colors.Count % Id;
            var color = PlayerColor.Instance.colors[colorID];
            return color;
        }
    }

    public static bool operator==(Player p1, Player p2)
    {
        if (ReferenceEquals(p1, p2)) return true;
        if (p1 == null || p2 == null) return false;
        return p1.Id == p2.Id;
    }

    public static bool operator !=(Player p1, Player p2)
    {
        if (ReferenceEquals(p1, p2)) return false;
        if (p1 == null || p2 == null) return true;
        return p1.Id != p2.Id;
    }
}
