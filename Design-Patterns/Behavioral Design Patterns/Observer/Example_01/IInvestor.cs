namespace Observer.Example_01
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(object sender, ChangeEventArgs e);
    }
}
