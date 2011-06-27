﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AegisBorn.Models.Base;
using FluentNHibernate.Mapping;

namespace AegisBorn.Models.Map
{
    public class SfGuardUserMap : ClassMap<SfGuardUser>
    {
        public SfGuardUserMap()
        {
            Id(x => x.Id).Column("id");
            Map(x => x.Username).Column("username");
            Map(x => x.Password).Column("password");
            Map(x => x.Salt).Column("salt");
            Table("sf_guard_user");
        }
    }
}