﻿using AegisBorn.Models.Base;
using FluentNHibernate.Mapping;

namespace AegisBorn.Models.Map
{
    public class AegisBornCharacterMap : ClassMap<AegisBornCharacter>
    {
        public AegisBornCharacterMap()
        {
            Id(x => x.Id).Column("id");
            Map(x => x.Name).Column("name");
            Map(x => x.Level).Column("level");
            Map(x => x.Class).Column("class");
            Map(x => x.Sex).Column("sex");
            Map(x => x.PositionX).Column("position_x");
            Map(x => x.PositionY).Column("position_y");
            References(x => x.UserId).Column("user_id");
            Table("aegis_born_character");
        }
    }
}
