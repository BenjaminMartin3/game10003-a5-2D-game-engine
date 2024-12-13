using Godot;
using System;

public partial class AsteroidRemoveArea : Area2D
{
    private void OnBodyEntered(RigidBody2D body)
    {
        body.QueueFree();
    }
}
