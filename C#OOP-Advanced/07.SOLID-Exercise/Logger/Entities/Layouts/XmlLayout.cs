using System.Text;
using Logger.Interfaces;

namespace Logger.Entities.Layouts
{
    public class XmlLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            StringBuilder msg = new StringBuilder();

            return msg.AppendLine($"<log>")
                .AppendLine($"   <date>{timeStamp}</date>")
                .AppendLine($"   <level>{reportLevel}</level>")
                .AppendLine($"   <message>{message}</message>")
                .Append($"</log>")
                .ToString();
        }
    }
}
