// Scripted by 0x4261756D
using CardGameCore;
using static CardGameUtils.GameConstants;
using static CardGameCore.CardUtils;

class KillYourDarlings : Spell
{
	public KillYourDarlings() : base(
		Name: "Kill your Darlings",
		CardClass: PlayerClass.Artificer,
		OriginalCost: 3,
		Text: "{Cast}: Destroy your creature with the highest Cost. Draw cards equal to half its Cost (rounded down). Gain Momentum equal to its power."
		)
	{ }

	public override void Init()
	{
		RegisterCastTrigger(trigger: new CastTrigger(effect: CastEffect, condition: CastCondition), referrer: this);
	}

	private void CastEffect()
	{
		Card target = SelectSingleCard(Controller, GetFieldUsed(Controller), "Select darling");
		int drawAmount = target.BaseCost / 2;
		int momentumAmount = target.Power;
		Destroy(target);
		Draw(player: Controller, amount: drawAmount);
		PlayerChangeMomentum(player: Controller, amount: momentumAmount);
	}

	private bool CastCondition()
	{
		return HasUsed(GetField(Controller));
	}
}