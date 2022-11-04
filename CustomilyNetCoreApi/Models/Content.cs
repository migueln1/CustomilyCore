using CustomilyNetCoreApi.Models.Common;

namespace CustomilyNetCoreApi.Models
{
    public class Content : BaseEntity<int>
    {
        public string X { get; set; }
        public string Y { get; set; }
    }
}