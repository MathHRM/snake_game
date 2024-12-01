using System;

class Program
{
    public static bool gameOver;
    public static int score = 0;
    public static int width = 20;
    public static int height = 20;
    public static int x, y, fruitX, fruitY;
    public static int[] tailX = new int[100];
    public static int[] tailY = new int[100];
    public static int nTail = 0;
    public static Random random = new Random();
    enum eDirection
    {
        STOP = 0,
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    public static void Setup()
    {
        Console.Clear();
        x = width / 2;
        y = height / 2;
        setFruitPosition();
        gameOver = false;
        score = 0;
    }

    public static void Draw()
    {
        Console.Clear();
        for (int i = 0; i < width + 2; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (i == 0 || j == 0)
                    Console.Write("#");

            }
        }
    }

    public static void Input()
    {

    }

    public static void Logic()
    {

    }

    public static void setFruitPosition()
    {
        fruitX = random.Next(1, width);
        fruitY = random.Next(1, height);
    }

    static void Main(string[] args)
    {
        Setup();
        while (!gameOver)
        {
            Draw();
            Input();
            Logic();
        }
    }
}