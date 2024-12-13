using Godot;
using System;
using System.Drawing;

public partial class Player : RigidBody2D
{
    [Export]
    public int Speed = 200;

    [Export]
    public float RotationSpeed = 1000;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        // Vector2 to set up the movement of the player
        Vector2 facingDirection = new Vector2(0, 0);

        // 4 diagonal movements
        if (Rotation > 0 && Rotation < 1.5)
        {
            // North-East
            facingDirection = new Vector2(1, -1);
        }
        else if (Rotation > 1.5 && Rotation < 3.2)
        {
            // South-East
            facingDirection = new Vector2(1, 1);
        }
        else if (Rotation > -1.5 && Rotation < 0)
        {
            // North-West
            facingDirection = new Vector2(-1, -1);
        }
        else if (Rotation < -1.5 && Rotation > -3.2)
        {
            // South-West
            facingDirection = new Vector2(-1, 1);
        }

        // 4 horizontal & vertical movements
        if (Rotation == 0)
        {
            // North
            facingDirection = new Vector2(0, -1);
        }
        else if (Rotation == 1.5)
        {
            // East
            facingDirection = new Vector2(1, 0);
        }
        else if (Rotation == 3.2 || Rotation == -3.2)
        {
            // South
            facingDirection = new Vector2(0, 1);
        }
        else if (Rotation == -1.5)
        {
            // West
            facingDirection = new Vector2(-1, 0);
        }

        // Input to boost the player forward
        if (Input.IsActionPressed("forward", true))
        {
            ApplyCentralForce(facingDirection * Speed);
        }

        // Input to turn the player left and right 
        if (Input.IsActionPressed("right", true))
        {
            ApplyTorque(RotationSpeed);
        }

        if (Input.IsActionPressed("left", true))
        {
            ApplyTorque(-RotationSpeed);
        }
    }

    private void GameOver()
    {
        GetTree().Quit();
    }
}

