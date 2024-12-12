using Godot;
using System;

public partial class AsteroidSpawnArea : Area2D
{
    [Export]
    private PackedScene Prefab;

    [Export]
    private Node2D PrefabParent;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        var random = new RandomNumberGenerator();

        float xLaunch = random.Randf();
        float yLaunch = random.Randf();

        Vector2 launchDirection = new Vector2(xLaunch, yLaunch);

        RigidBody2D asteroid = Prefab.Instantiate<RigidBody2D>();
        PrefabParent.AddChild(asteroid);
        asteroid.GlobalPosition = this.GlobalPosition;
        asteroid.ApplyForce(launchDirection * 50);

    }
}
