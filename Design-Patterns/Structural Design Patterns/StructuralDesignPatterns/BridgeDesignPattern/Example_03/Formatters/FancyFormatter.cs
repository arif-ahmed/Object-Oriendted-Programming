﻿namespace Example_03.Formatters
{
    internal class FancyFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("-= {0} ----- =- {1}", key, value);
        }
    }
}
