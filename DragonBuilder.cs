using Godot;

// Собирает дракона из настроек, заданных в инспекторе.
[GlobalClass]
public partial class DragonBuilder : EnemyBuilder
{
    public override void BuildHp() => _product.Hp = Preset.Hp;
    public override void BuildDamage() => _product.Damage = Preset.Damage;
    public override void BuildSpeed() => _product.Speed = Preset.Speed;
    public override void BuildSprite() => _product.Sprite = Preset.Sprite;
}
