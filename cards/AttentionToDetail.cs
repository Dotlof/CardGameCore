// Scripted by 0x4261756D
using CardGameCore;
using static CardGameUtils.GameConstants;

class AttentiontoDetail : Spell
{
	public AttentiontoDetail() : base(
		Name: "Attention to Detail",
		CardClass: PlayerClass.Artificer,
		OriginalCost: 2,
		Text: "{Cast}: Create a token copy of target creature. The copy gains [Brittle]."
		)
	{ }
	// TODO: implement functionality

	public override void Init()
	{
	}

}