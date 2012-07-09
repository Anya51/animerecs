﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using AnimeRecs.MalApi;
using System.Web.Mvc;

namespace AnimeRecs.Web
{
    public static class ViewHelpers
    {
        public static IHtmlString GetRecommendedMalAnimeHtml(this HtmlHelper html, int malAnimeId, string animeTitle)
        {
            // TODO: Could add icon links to Crunchyroll, Hulu, Funimation, Anime Network, etc if the anime is available for streaming on one of those sites
            string encodedString = string.Format(@"<a href=""{0}"" class=""recommendation"">{1}</a>", html.AttributeEncode(GetMalAnimeUrl(malAnimeId, animeTitle)), html.Encode(animeTitle));
            return new HtmlString(encodedString);
        }
        
        public static string GetMalAnimeUrl(int malAnimeId, string animeTitle)
        {
            // TODO: Add url-sanitized anime name at end for a friendlier URL
            return string.Format("http://myanimelist.net/anime/{0}", malAnimeId.ToString(CultureInfo.InvariantCulture));
        }

        public static IHtmlString GetRecommenderHtml(this HtmlHelper html, string username)
        {
            string encodedString = string.Format(@"<a href=""{0}"" class=""recommender"">{1}</a>", html.AttributeEncode(GetMalListUrl(username)), html.Encode(username));
            return new HtmlString(encodedString);
        }

        public static string GetMalListUrl(string username)
        {
            return string.Format("http://myanimelist.net/animelist/{0}", Uri.EscapeUriString(username));
        }

        public static string MalAnimeTypeAsString(this HtmlHelper html, MalAnimeType type)
        {
            switch (type)
            {
                case MalAnimeType.Tv:
                    return "TV";
                case MalAnimeType.Movie:
                    return "Movie";
                case MalAnimeType.Ova:
                    return "OVA";
                case MalAnimeType.Ona:
                    return "ONA";
                case MalAnimeType.Special:
                    return "Special";
                default:
                    return "???";
            }
        }

        public static string MalAnimeStatusAsString(this HtmlHelper html, CompletionStatus status)
        {
            switch (status)
            {
                case CompletionStatus.Completed:
                    return "Completed";
                case CompletionStatus.Dropped:
                    return "Dropped";
                case CompletionStatus.OnHold:
                    return "On Hold";
                case CompletionStatus.PlanToWatch:
                    return "Plan to Watch";
                case CompletionStatus.Watching:
                    return "Watching";
                default:
                    return "???";
            }
        }
    }
}

// Copyright (C) 2012 Greg Najda
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