﻿namespace Eron.core.DataModel.Location
{
    public class Language:EntityBase<int>
    {
        public string LocalName { get; set; }

        public string EnglishName { get; set; }

        public string FlagUrl { get; set; }

        public string LanguageCode { get; set; }
    }
}