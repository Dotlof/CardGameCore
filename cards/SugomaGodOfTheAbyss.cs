// Scripted by 0x4261756D
using CardGameCore;
using static CardGameUtils.GameConstants;

class SugomaGodoftheAbyss : Creature
{
	public SugomaGodoftheAbyss() : base(
		Name: "Sugoma God of the Abyss",
		CardClass: PlayerClass.Cultist,
		OriginalCost: 12,
		Text: "[Collosal] +5.\nCannot be Discarded.\n{Activate}: Discard 1. Destroy target creature.\n{Revelation}: Take 1 damage then gain 1 Momentum.",
		OriginalPower: 15,
		OriginalLife: 15
		)
	{ }
	// TODO: implement functionality

	public override void Init()
	{
	}

}