﻿using System;

namespace Nuget
{
    public class ClassFromNuget
    {
        public const int i = 1;
        public const string myString = "myString";
        public const string ConstStringFromNuget = $"{myString} {nameof(i)} - string";
    }
}
