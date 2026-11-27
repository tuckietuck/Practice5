using Godot;
using Godot.Collections;

// Директор выбирает строителя и задаёт порядок сборки.
public partial class EnemySpawner : Node2D
{
    [Export] private PackedScene _enemyScene;
    [Export] private Array<EnemyBuilder> _builders = new();
    [Export] private Timer _spawnTimer;
    [Export] private float _spawnSpread = 150f;

    public override void _Ready()
    {
        _spawnTimer.Timeout += OnTimeout;
        OnTimeout();
        _spawnTimer.Start();
    }

    private void OnTimeout()
    {
        int index = GD.RandRange(0, _builders.Count - 1);
        SpawnEnemy(Construct(_builders[index]));
    }

    // Для каждого типа врага выполняются одни и те же шаги.
    private EnemyData Construct(EnemyBuilder builder)
    {
        builder.BuildHp();
        builder.BuildDamage();
        builder.BuildSpeed();
        builder.BuildSprite();
        return builder.GetResult();
    }

    private void SpawnEnemy(EnemyData data)
    {
        Enemy enemy = _enemyScene.Instantiate<Enemy>();
        enemy.Position = new Vector2(0, (float)GD.RandRange(-_spawnSpread, _spawnSpread));
        data.ApplyTo(enemy);
        AddChild(enemy);
    }
}
