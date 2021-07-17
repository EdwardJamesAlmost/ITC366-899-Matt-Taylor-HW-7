using System;
using System.Collections.Generic;
using System.Text;

class Room
{
    public enum LWH
    {
        length = 1,
        width,
        height
    } // length width height enum


    /// <summary> Room class properties
    /// 
    /// </summary>
    public int Length { get; set; }
    public int Width { get; set; }

    public int Height { get; set; }

    public readonly int WallArea;

    public readonly int PaintQty;



    /// <summary> Room Class constructor. Takes room dimensions and sets readonly properties
    /// 
    /// </summary>
    /// <param name="length"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public Room(int length, int width, int height)
    {
        LWH lwh1 = new LWH();

        /**
        for (int i = 0; i < 3; i++)
        {
            lwh1 = (LWH)i;
            String entry;

            switch (i)
            {
                case 1:
                    Console.Write($"Enter {lwh1.ToString()}");
                    entry = Console.ReadLine();
                    this.Length = int.Parse(entry);
                    break;
                case 2:
                    Console.Write($"Enter {lwh1.ToString()}");
                    entry = Console.ReadLine();
                    this.Width = int.Parse(entry);
                    break;
                case 3:
                    Console.Write($"Enter {lwh1.ToString()}");
                    entry = Console.ReadLine();
                    this.Height = int.Parse(entry);
                    break;
                default:
                    break;
            } // record length, width, and height based on loop index

        } // loop through 3 dimensions
        */
        this.Length = length;
        this.Width = width;
        this.Height = height;
        this.WallArea = computeWallArea(length, width, height);
        this.PaintQty = computePaintQty(this.WallArea);

        //constructor debug
        //Console.WriteLine("\nConstructor Debug");
        //Console.WriteLine($"length {this.Length} width {this.Width} height {this.Height} wallArea {this.WallArea} paintQty {this.PaintQty}");
    }  // room constructor 

    /// <summary> computeWallArea method. takes dimensional input, computes the wall area, and returns that value as an int
    /// 
    /// </summary>
    /// <param name="length"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    private static int computeWallArea(int length, int width, int height)
    {
        int paintArea = 2 * (length * height + width * height);
        return paintArea;
    } // compute wall area, used to set class property

    /// <summary> compute the number of gallons required to cover the wall area
    /// 
    /// </summary>
    /// <param name="wallArea"></param>
    /// <returns></returns>
    private static int computePaintQty(int wallArea)
    {
        int paintQty;
        
        if(wallArea < 350)
        {
            paintQty = 1;
        }
        else
        {
            paintQty = (wallArea / 350 ) + 1;

        }

        return paintQty;
    } // compute paint quantity, used to set class property

}// Room class

