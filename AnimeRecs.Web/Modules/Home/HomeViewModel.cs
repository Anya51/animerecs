﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeRecs.Web.Modules.Home
{
    public class HomeViewModel
    {
        public AlgorithmConfig Algorithm { get; set; }
        public IList<AlgorithmConfig> AvailableAlgorithms { get; set; }
        public bool DisplayDetailedResults { get; set; }
        public bool DebugModeOn { get; set; }

        public HomeViewModel(AlgorithmConfig algorithm, IList<AlgorithmConfig> availableAlgorithms, bool displayDetailedResults,
            bool debugModeOn)
        {
            Algorithm = algorithm;
            AvailableAlgorithms = availableAlgorithms;
            DisplayDetailedResults = displayDetailedResults;
            DebugModeOn = debugModeOn;
        }
    }
}

// Copyright (C) 2015 Greg Najda
//
// This file is part of AnimeRecs.Web.
//
// AnimeRecs.Web is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// AnimeRecs.Web is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with AnimeRecs.Web.  If not, see <http://www.gnu.org/licenses/>.