using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime RegisterDate { get; set; }
        public byte Avatar { get; set; }
        public int PhoneActiveCode { get; set; }
        public string EmailActiveCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }












        public List<UserProductFavorite> UserProductFavorites { get; set; }
        public List<UserAddress> UserAddresses { get; set; }
        public List<Comment> Comments { get; set; }
        public List<CommentLike>  CommentLikes { get; set; }
    }
}
