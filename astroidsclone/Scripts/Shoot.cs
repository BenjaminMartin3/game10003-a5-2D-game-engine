using Godot;
using System;

public partial class Shoot : Area2D
{
    [Export]
    private PackedScene Prefab;

    [Export]
    private Node2D PrefabParent;

    // Called when the node enters the scene tree for the first time.


    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        // Vector2 to shoot the bullet in the right direction
        Vector2 facingDirection = new Vector2(0, 0);

        // Full rotation of shooting
        if (GlobalRotation > -0.2 && GlobalRotation < 0.2)
        {
            // North
            facingDirection = new Vector2(0, -1);
        }
        else if (GlobalRotation > 0.2 && GlobalRotation < 0.5)
        {
            // North-East-West
            facingDirection = new Vector2(0.25f, -0.75f);
        }
        else if (GlobalRotation > 0.5 && GlobalRotation < 1)
        {
            // North-East
            facingDirection = new Vector2(0.5f, -0.5f);
        }
        else if (GlobalRotation > 1 && GlobalRotation < 1.3)
        {
            // North-East-East
            facingDirection = new Vector2(0.75f, -0.25f);
        }
        else if (GlobalRotation > 1.3 && GlobalRotation < 1.7)
        {
            // East
            facingDirection = new Vector2(1, 0);
        }
        else if (GlobalRotation > 1.7 && GlobalRotation < 2)
        {
            // South-East-East
            facingDirection = new Vector2(0.75f, 0.25f);
        }
        else if (GlobalRotation > 2 && GlobalRotation < 2.5)
        {
            // South-East
            facingDirection = new Vector2(0.5f, 0.5f);
        }
        else if (GlobalRotation > 2.5 && GlobalRotation < 3)
        {
            // South-East-West
            facingDirection = new Vector2(0.25f, 0.75f);
        }
        else if (GlobalRotation > 3 && GlobalRotation < 3.2 || GlobalRotation > -3.2 && GlobalRotation < -3)
        {
            // South
            facingDirection = new Vector2(0, 1);
        }
        else if (GlobalRotation > -3 && GlobalRotation < -2.5)
        {
            // South-West-East
            facingDirection = new Vector2(-0.25f, 0.75f);
        }
        else if (GlobalRotation > -2.5 && GlobalRotation < -2)
        {
            // South-West
            facingDirection = new Vector2(-0.5f, 0.5f);
        }
        else if (GlobalRotation > -2 && GlobalRotation < -1.7)
        {
            // South-West-West
            facingDirection = new Vector2(-0.75f, 0.25f);
        }
        else if (GlobalRotation > -1.7 && GlobalRotation < -1.3)
        {
            // West
            facingDirection = new Vector2(-1, 0);
        }
        else if (GlobalRotation > -1.3 && GlobalRotation < -1)
        {
            // North-West-West
            facingDirection = new Vector2(-0.75f, -0.25f);
        }
        else if (GlobalRotation > -1 && GlobalRotation < -0.5)
        {
            // North-West
            facingDirection = new Vector2(-0.5f, -0.5f);
        }
        else if (GlobalRotation > -0.5 && GlobalRotation < -0.2)
        {
            // North-West
            facingDirection = new Vector2(-0.25f, -0.75f);
        }

        if (Input.IsActionJustPressed("shoot", true))
        {
            RigidBody2D bullet = Prefab.Instantiate<RigidBody2D>();
            PrefabParent.AddChild(bullet);
            bullet.GlobalPosition = this.GlobalPosition;
            bullet.ApplyImpulse(facingDirection * 500); 
        }

        GD.Print(GlobalRotation); 
    }
}
