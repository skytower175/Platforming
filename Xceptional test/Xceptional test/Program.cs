using System;
using System.Collections.Generic;



public class Platformer
{
    public int _pos;
    public List<int> tiles;
    public Platformer(int numberOfTiles, int position)
    {
        tiles = new List<int>();
        _pos = position;
        for(int i = 0; i < numberOfTiles; i++)
        {
            tiles.Add(i);
        }
        //Console.WriteLine(position);


    }

    public void JumpLeft()
    {
        int temp = _pos;
        _pos = tiles[tiles.IndexOf(_pos) - 2];
        tiles.Remove(temp);
    }

    public void JumpRight()
    {
        int temp = _pos;
        _pos = tiles[tiles.IndexOf(_pos)+2];
        tiles.Remove(temp);
    }

    public int Position()
    {
        return _pos;
    }

    public static void Main(string[] args)
    {
        Platformer platformer = new Platformer(6, 3);
        Console.WriteLine(platformer.Position()); // should print 3

        platformer.JumpLeft();
        Console.WriteLine(platformer.Position()); // should print 1

        platformer.JumpRight();
        Console.WriteLine(platformer.Position()); // should print 4

    }
}