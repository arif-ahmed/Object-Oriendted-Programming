﻿namespace Example_03.Manuscripts
{
    using System;
    using System.Collections.Generic;

    using Example_03.Formatters;

    internal class Faq : Manuscript
    {
        public Faq(IFormatter formatter)
            : base(formatter)
        {
            this.Questions = new Dictionary<string, string>();
        }

        public string Title { get; set; }

        public Dictionary<string, string> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine(this.Formatter.Format("Title", this.Title));
            foreach (var question in this.Questions)
            {
                Console.WriteLine(this.Formatter.Format("   Question", question.Key));
                Console.WriteLine(this.Formatter.Format("   Answer", question.Value));
            }

            Console.WriteLine();
        }
    }
}
