using System.ComponentModel.DataAnnotations.Schema;

namespace CustomilyNetCoreApi.Models.Common
{
    public class BaseEntity<T> where T : struct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; init; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; init; }

        public DateTime? ModifiedDate { get; init; }
    }
}