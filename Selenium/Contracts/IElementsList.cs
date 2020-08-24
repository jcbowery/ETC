namespace Selenium.Contracts
{
    public interface IElementsList /*: IEnumerable<IElement>, IStyleAssertedElement*/ //todo fix elements
    {
        //IElement this[int i] { get; }
        int Count();
        //void ForEach(Action<IElement> action);
    }
}
