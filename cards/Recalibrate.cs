// Scripted by 0x4261756D
using CardGameCore;
using static CardGameUtils.GameConstants;
using static CardGameCore.CardUtils;

class Recalibrate : Spell
{
	public Recalibrate() : base(
		Name: "Recalibrate",
		CardClass: PlayerClass.Artificer,
		OriginalCost: 2,
		Text: "{Cast}: Take control of target creature. It gains [Brittle]."
		)
	{ }

	public override void Init()
	{
		RegisterCastTrigger(trigger: new CastTrigger(effect: CastEffect, condition: CastCondition), referrer: this);
	}

	private void CastEffect()
	{
		Card target = SelectSingleCard(player: Controller, GetFieldUsed(player: 1 - Controller), description: "Select card to recalibrate");
		MoveToField(choosingPlayer: Controller, targetPlayer: Controller, card: target);
	}

	private bool CastCondition()
	{
		return HasEmpty(GetField(Controller)) && HasUsed(GetField(1 - Controller));
	}
}