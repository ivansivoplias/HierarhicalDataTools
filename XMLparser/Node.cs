using System.Collections.Generic;
using System.Linq;

namespace TreeLoader
{
    public class Node
    {
        public string ElementName { get; set; }

        public IDictionary<string, string> Attributes { get; set; }

        public string Value { get; set; }

        public Node Parent { get; internal set; }

        public IList<Node> Children { get; internal set; }

        public override string ToString()
        {
            var attributes = Attributes?.Select(x => $"{x.Key} = {x.Value}") ?? new[] { "" };
            var attributesStr = string.Join(" ", attributes);
            return $"ElementName = {ElementName}, Attributes = {attributesStr}, Value = {Value}";
        }
    }
}