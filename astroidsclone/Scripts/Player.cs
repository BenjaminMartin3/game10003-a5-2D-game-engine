using Godot;
using System;

public partial class Player : RigidBody2D
{
	[Export]
	public float Speed = 300;

	[Export]
	public float RotationSpeed = 1.5f;



	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		
	}
}
