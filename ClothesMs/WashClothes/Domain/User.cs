using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WashClothes.Domain
{
    public class User
    {
        public User()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Clothes> Clothes { get; set; }
    }
}
