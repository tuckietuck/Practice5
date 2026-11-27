using Godot;

// Описывает шаги, общие для всех строителей.
[GlobalClass]
public abstract partial class EnemyBuilder : Resource
{
	[Export] public EnemyData Preset { get; set; }

	protected EnemyData _product = new();

	public abstract void BuildHp();
	public abstract void BuildDamage();
	public abstract void BuildSpeed();
	public abstract void BuildSprite();

	// Следующая сборка начнётся с нового ресурса.
	public EnemyData GetResult()
	{
		EnemyData result = _product;
		_product = new EnemyData();
		return result;
	}
}
