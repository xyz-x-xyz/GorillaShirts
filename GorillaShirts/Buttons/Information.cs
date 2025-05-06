﻿using GorillaShirts.Behaviours;
using GorillaShirts.Interfaces;
using GorillaShirts.Models;
using System;

namespace GorillaShirts.Buttons
{
    internal class Information : IStandButton
    {
        public ButtonType Type => ButtonType.Info;
        public Action<Main> Function => (Main constructor) =>
        {
            constructor.UseInfoPanel ^= true;
            constructor.SetInfoVisibility.Invoke(constructor.UseInfoPanel);
        };
    }
}
