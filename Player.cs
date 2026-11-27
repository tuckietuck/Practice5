using Godot;

// Игрок перемещается стрелками по экрану.
public partial class Player : CharacterBody2D
{
    [Export] public float Speed { get; set; } = 240f;

    public override void _PhysicsProcess(double delta)
    {
        Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        Velocity = direction * Speed;
        MoveAndSlide();
        GlobalPosition = GlobalPosition.Clamp(Vector2.Zero, GetViewportRect().Size);
    }
}
