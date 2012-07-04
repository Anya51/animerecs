﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimeRecs.RecEngine;
using AnimeRecs.RecEngine.MAL;
using AnimeRecs.RecService.DTO;

namespace AnimeRecs.RecService.RecSources
{
    internal class MostPopularJsonRecSource : TrainableJsonRecSource<MalMostPopularRecSource, MalUserListEntries,
        IEnumerable<RecEngine.MostPopularRecommendation>, RecEngine.MostPopularRecommendation, GetMalRecsResponse<DTO.MostPopularRecommendation>,
        DTO.MostPopularRecommendation>
    {
        public MostPopularJsonRecSource(MalMostPopularRecSource underlyingRecSource)
            : base(underlyingRecSource)
        {
            ;
        }

        protected override MalUserListEntries GetRecSourceInputFromRequest(MalUserListEntries animeList, GetMalRecsRequest recRequest, RecRequestCaster caster)
        {
            return animeList;
        }

        protected override void SetSpecializedRecommendationProperties(DTO.MostPopularRecommendation dtoRec, RecEngine.MostPopularRecommendation engineRec)
        {
            dtoRec.NumRatings = engineRec.NumRatings;
            dtoRec.PopularityRank = engineRec.PopularityRank;
        }

        protected override string RecommendationType { get { return RecommendationTypes.MostPopular; } }
        public override string RecSourceType { get { return RecSourceTypes.MostPopular; } }
    }
}

// Copyright (C) 2012 Greg Najda
//
// This file is part of AnimeRecs.RecService.
//
// AnimeRecs.RecService is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// AnimeRecs.RecService is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with AnimeRecs.RecService.  If not, see <http://www.gnu.org/licenses/>.