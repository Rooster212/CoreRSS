namespace CoreRSS.Concrete
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public static class Extensions
    {
        public static IEnumerable<XElement> ElementsByName(this XElement targetElement, string name)
        {
            return targetElement?.Elements()?.Where(e => string.Equals(e.Name.LocalName, name, System.StringComparison.OrdinalIgnoreCase));
        }

        public static XElement ElementByName(this XElement targetElement, string name)
        {
            return targetElement?.Elements()?.FirstOrDefault(e => string.Equals(e.Name.LocalName, name, System.StringComparison.OrdinalIgnoreCase));
        }

        public static string ElementValueByName(this XElement targetElement, string name)
        {
            return ElementByName(targetElement, name)?.Value;
        }
    }
}
