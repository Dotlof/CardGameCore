// Scripted by 0x4261756D
using CardGameCore;
using static CardGameUtils.GameConstants;
using static CardGameCore.CardUtils;

class Reforge : Spell
{
	public Reforge() : base(
		Name: "Reforge",
		CardClass: PlayerClass.Artificer,
		OriginalCost: 1,
		Text: "{Cast}: Return your target non-token creature to your hand. Create a token copy of it."
		)
	{ }

	public override void Init()
	{
		RegisterCastTrigger(trigger: new CastTrigger(effect: CastEffect, condition: CastCondition), referrer: this);
	}

	private void CastEffect()
	{
		Card target = SelectSingleCard(player: Controller, FilterValid(cards: GetFieldUsed(player: Controller), isValid: (card) => !card.Keywords.ContainsKey(Keyword.Token)), description: "Select card to reforge");
		Card token = CreateTokenCopy(player: Controller, card: target);
		MoveToHand(player: Controller, card: target);
		MoveToField(choosingPlayer: Controller, targetPlayer: Controller, card: token);
	}

	private bool CastCondition()
	{
		return ContainsValid(cards: GetFieldUsed(Controller), isValid: (card) => !card.Keywords.ContainsKey(Keyword.Token));
	}
}