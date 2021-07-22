using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class BlockStringBuilder
    {
        private abstract class Node
        {
            public abstract String Compile();
        }

        private class StringNode : Node
        {
            public readonly String StringValue;

            public StringNode(String stringValue) => StringValue = stringValue;

            public override String Compile() => StringValue;
        }

        private class BlockNode : Node
        {
            public readonly BlockNode Parent;

            public List<Node> Children = new List<Node>();

            public readonly Int32 Depth;

            public readonly String Tabs;

            public readonly String NestedTabs;

            public BlockNode(BlockNode parent) => (Parent, Depth, Tabs, NestedTabs) = (parent, parent.Depth + 1,
                new String(' ', (parent.Depth) * 4), new String(' ', (parent.Depth + 1) * 4));

            public BlockNode() => (Parent, Depth, Tabs, NestedTabs) = (null, 0, String.Empty, String.Empty);

            public override String Compile()
            {
                var builder = new StringBuilder();

                if (Depth != 0)
                {
                    builder.Append($"{{\n");
                }

                foreach (var child in Children)
                {
                    builder.Append($"{NestedTabs}{child.Compile()}");
                }

                if (Depth != 0)
                {
                    builder.Append($"{Tabs}}}\n");
                }

                return builder.ToString();
            }
        }

        private readonly BlockNode _root = new BlockNode();

        private BlockNode _current;

        public BlockStringBuilder() => _current = _root;

        public BlockStringBuilder Begin()
        {
            var lastCurrent = _current;
            _current = new BlockNode(_current);
            lastCurrent.Children.Add(_current);
            return this;
        }

        public BlockStringBuilder End()
        {
            _current = _current.Parent;
            return this;
        }

        public BlockStringBuilder Append(String value)
        {
            _current.Children.Add(new StringNode(value));
            return this;
        }

        public BlockStringBuilder AppendLine(String value = "")
        {
            _current.Children.Add(new StringNode(value + '\n'));
            return this;
        }

        public override String ToString()
        {
            return _root.Compile();
        }
    }
}