using Godot;
using System;

public partial class PlayerRemoveArea : Area2D
{
   private void OnBodyEntered(RigidBody2D body)
    {
        body.QueueFree();
    }
}
