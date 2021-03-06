﻿//-----------------------------------------------------------------------
// <copyright file="IHoconLineInfo.cs" company="Hocon Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/hocon>
// </copyright>
//-----------------------------------------------------------------------

namespace Hocon
{
    internal interface IHoconLineInfo
    {
        int LineNumber { get; }
        int LinePosition { get; }
    }
}
