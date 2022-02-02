namespace ChainOfResponsibilityDemo.Example_04
{
    /// <summary>
    /// Record with request details
    /// </summary>
    public record Purchase
    {
        public required double Amount { get; init; }
        public required string Purpose { get; init; }
        public required int Number { get; init; }
    }
}
