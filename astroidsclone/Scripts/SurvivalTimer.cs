using Godot;
using System;
using static System.Formats.Asn1.AsnWriter;

public partial class SurvivalTimer : Label
{
    // Setup Timer
    float timeElapsed = 0.0f;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        // Increase timer every delta frame
        timeElapsed += (float)delta;
        Text = $"Hyperdrive Warming Up: {timeElapsed:n2}";

        if (timeElapsed >= 60.0f)
        {
            Text = "Hyperdrive Ready";
            if (timeElapsed >= 62.0f)
            {
                GetTree().Quit();
            }
        }
    }
}
