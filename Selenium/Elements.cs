using OpenQA.Selenium;
using Selenium.Contracts;
using System.Collections.ObjectModel;

namespace Selenium
{
    public class Elements : IElementsList
    {
        private ReadOnlyCollection<IWebElement> _Elements;
        public Elements(ReadOnlyCollection<IWebElement> elements)//todo look into enumerators and getenumerable
        {
            _Elements = elements;
        }

        /// <summary>
        /// Getthe count of the elements in collection
        /// </summary>
        /// <returns>int</returns>
        public int Count()
        {
            return _Elements.Count;
        }

        //public IElement this[int i] => GetAndWaitWebDriverElements().ElementAt(i);
        //public IEnumerator<IElement> GetEnumerator() => GetAndWaitWebDriverElements().GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        //private IEnumerable<IElement> GetAndWaitWebDriverElements()
        //{
        //    var nativeElements = _Elements;
        //    foreach (var nativeElement in nativeElements)
        //    {
        //        IElement element = new Element(nativeElement);
        //        yield return element;
        //    }
        //}

        ///// <summary>
        ///// perform an action on each element
        ///// </summary>
        ///// <param name="action"></param>
        //public void ForEach(Action<IElement> action)
        //{
        //    foreach (var element in this)
        //    {
        //        action(element);
        //    }
        //}


        //public void AssertBackgroundColor(string expectedBackgroundColor)
        //{
        //    ForEach(e => e.AssertBackgroundColor(expectedBackgroundColor));
        //}
        //public void AssertBorderColor(string expectedBorderColor)
        //{
        //    ForEach(e => e.AssertBorderColor(expectedBorderColor));
        //}
        //public void AssertColor(string expectedColor)
        //{
        //    ForEach(e => e.AssertColor(expectedColor));
        //}
        //public void AssertFontFamily(string expectedFontFamily)
        //{
        //    ForEach(e => e.AssertFontFamily(expectedFontFamily));
        //}
        //public void AssertFontWeight(string expectedFontWeight)
        //{
        //    ForEach(e => e.AssertFontWeight(expectedFontWeight));
        //}
        //public void AssertFontSize(string expectedFontSize)
        //{
        //    ForEach(e => e.AssertFontSize(expectedFontSize));
        //}
        //public void AssertTextAlign(string expectedTextAlign)
        //{
        //    ForEach(e => e.AssertTextAlign(expectedTextAlign));
        //}
        //public void AssertVerticalAlign(string expectedVerticalAlign)
        //{
        //    ForEach(e => e.AssertVerticalAlign(expectedVerticalAlign));
        //}
    }
}
