using Godot;
using System;

public partial class AsteroidBig : RigidBody2D
{
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        var random = new RandomNumberGenerator();

        Vector2 launchDirection = Vector2.Zero;

        // Randomly Generates the flight direction for the astreiod
        int launchPattern = 0;
        launchPattern = random.RandiRange(0, 7); 

        if (launchPattern == 0)
        {
            launchDirection = Vector2.Up; 
        }
        else if (launchPattern == 1)
        {
            launchDirection = new Vector2(0.5f, -0.5f); 
        }
        else if (launchPattern == 2)
        {
            launchDirection = Vector2.Right;
        }
        else if (launchPattern == 3)
        {
            launchDirection = new Vector2(0.5f, 0.5f); 
        }
        else if (launchPattern == 4)
        {
            launchDirection = Vector2.Down;
        }
        else if (launchPattern == 5)
        {
            launchDirection = new Vector2(-0.5f, 0.5f); 
        }
        else if (launchPattern == 6)
        {
            launchDirection = Vector2.Left;
        }
        else if (launchPattern == 7)
        {
            launchDirection = new Vector2(-0.5f, -0.5f); 
        }

        ApplyForce(launchDirection * 500); 

    }
}
