using Godot;

// Готовый набор характеристик одного врага.
[GlobalClass]
public partial class EnemyData : Resource
{
	[Export] public int Hp { get; set; }
	[Export] public int Damage { get; set; }
	[Export] public float Speed { get; set; }
	[Export] public Texture2D Sprite { get; set; }

	// Передаём характеристики узлу и меняем его текстуру.
	public void ApplyTo(Enemy enemy)
	{
		enemy.Data = this;
		enemy.GetNode<Sprite2D>("Sprite2D").Texture = Sprite;
	}
}
