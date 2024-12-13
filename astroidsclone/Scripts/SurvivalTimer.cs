using Godot;
using System;
using static System.Formats.Asn1.AsnWriter;

public partial class SurvivalTimer : Label
{
    float timeElapsed = 0.0f;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        timeElapsed += (float)delta;
        Text = $"Time Survived: {timeElapsed:n2}";

    }
}
