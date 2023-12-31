using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{

    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        private DateTime? _createAt;

        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }
        private DateTime? _updateAt;

        public DateTime? UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value == null ? DateTime.UtcNow : value; }
        }
    }

}
