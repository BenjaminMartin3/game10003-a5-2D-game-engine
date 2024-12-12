using Godot;
using System;

public partial class BulletRemoveArea : Area2D
{
	private void OnBodyEntered(RigidBody2D body)
	{
		body.QueueFree();
		GD.Print($"Destory object: {body.Name}");
    }
}
