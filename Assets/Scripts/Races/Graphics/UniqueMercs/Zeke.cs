using System.Collections.Generic;
using UnityEngine;

class Zeke : BlankSlate
{
    public Zeke()
    {
        CanBeGender = new List<Gender>() { Gender.Male };
        GentleAnimation = true;
        Head = new SpriteExtraInfo(6, HeadSprite, WhiteColored);
        Body = new SpriteExtraInfo(5, BodySprite, WhiteColored);
        Belly = new SpriteExtraInfo(4, null, WhiteColored);
    }

    internal override void RandomCustom(Unit unit)
    {
        base.RandomCustom(unit);
        unit.Name = "Zeke";
    }

    protected override Sprite HeadSprite(Actor_Unit actor)
    {
        if (actor.IsAttacking || actor.IsOralVoring)
            return State.GameManager.SpriteDictionary.Zeke[3];

        return State.GameManager.SpriteDictionary.Zeke[2];
    }

    protected override Sprite BodySprite(Actor_Unit actor) => State.GameManager.SpriteDictionary.Zeke[0];

    internal override Sprite BellySprite(Actor_Unit actor, GameObject belly)
    {
        return (actor.HasBelly) ? State.GameManager.SpriteDictionary.Zeke[1] : null;
    }
}

