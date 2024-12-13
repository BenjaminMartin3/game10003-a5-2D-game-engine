using Godot;
using System;

public partial class AsteroidSpawnArea : Area2D
{
    [Export]
    private PackedScene Prefab;

    [Export]
    private Node2D PrefabParent;

    public override void _Ready()
    {
        var spawnTimer = GetNode<Timer>("SpawnTimer");
        spawnTimer.Start(2.5);
        spawnTimer.Timeout += OnTimerTimeout;
    }

    // Make the "asteroids" spawn every 2.5 secs
    private void OnTimerTimeout()
    {
        RigidBody2D asteroid = Prefab.Instantiate<RigidBody2D>();
        PrefabParent.AddChild(asteroid);
        asteroid.GlobalPosition = this.GlobalPosition;
    }
}
