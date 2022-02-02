namespace Observer.CriminalSurveillanceSystem
{
    public struct Message
    {
        string text;

        public Message(string newText)
        {
            text = newText;
        }

        public string Text
        {
            get
            {
                return text;
            }
        }
    }
}