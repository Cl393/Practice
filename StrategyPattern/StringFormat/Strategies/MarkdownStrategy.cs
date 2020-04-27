using System.Text;
using StringFormat.Core;

namespace StringFormat.Strategies
{
    public class MarkdownStrategy : IListStrategy
    {
        public void Start(StringBuilder sb)
        {
        }

        public void End(StringBuilder sb)
        {
        }

        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }

    }
}