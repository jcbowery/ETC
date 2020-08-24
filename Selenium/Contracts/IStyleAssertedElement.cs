namespace Selenium.Contracts
{
    public interface IStyleAssertedElement
    {
        void AssertBackgroundColor(string expectedBackgroundColor);
        void AssertBorderColor(string expectedBorderColor);
        void AssertColor(string expectedColor);
        void AssertFontFamily(string expectedFontFamily);
        void AssertFontWeight(string expectedFontWeight);
        void AssertFontSize(string expectedFontSize);
        void AssertTextAlign(string expectedTextAlign);
        void AssertVerticalAlign(string expectedVerticalAlign);
    }
}
