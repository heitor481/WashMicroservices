using System.ComponentModel.DataAnnotations.Schema;

namespace WashClothes.Domain
{
    public class Clothes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Color { get; set; }

        public ClotheType Type { get; set; }
        public int UserId { get; set; }
    }
}
