using System.Collections.Generic;
using UnityEngine;

class Brutus : BlankSlate
{
    Sprite[] _sprites = State.GameManager.SpriteDictionary.Brutus;

    public Brutus()
    {
        CanBeGender = new List<Gender>() { Gender.Male };
        BodySizes = 8;
        Body = new SpriteExtraInfo(1, BodySprite, WhiteColored);
    }

    internal override void RandomCustom(Unit unit)
    {
        base.RandomCustom(unit);
        unit.Name = "Brutus";
        unit.BodySize = 0;
    }

    protected override Sprite BodySprite(Actor_Unit actor)
    {
        int body = GetSize(actor) * 2;
        body += (actor.IsOralVoring) ? 1 : 0;

        AddOffset(Body, 0, 50);

        return _sprites[body];
    }

    private int GetSize(Actor_Unit actor)
    {
        return Mathf.Max(actor.GetUniversalSize(8), actor.GetBodyWeight());
    }
}

