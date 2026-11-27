using Godot;

// Все типы врагов используют одну сцену.
public partial class Enemy : Area2D
{
    public EnemyData Data { get; set; }

    public override void _PhysicsProcess(double delta)
    {
        Position += Vector2.Right * (Data?.Speed ?? 0f) * (float)delta;
    }
}
