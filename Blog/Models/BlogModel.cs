using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Web.Mvc;

namespace Blog.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public DateTimeOffset PostCreationDate { get; set; }
        [Required]
        [StringLength(500)]
        public string PostTitle { get; set; }
        [Required]
        [AllowHtml]
        [StringLength(5000)]
        public string PostContent { get; set; }
        public string MediaUrl { get; set; }
        public bool Published { get; set; }
        public string AuthorId { get; set; }
        public DateTimeOffset PostUpdateDate { get; set; }
        [StringLength(500)]
        public string PostUpdateReason { get; set; }
        public string EditorId { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }

    public partial class Comment
    {
        public Comment()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        [Required]
        [AllowHtml]
        [StringLength(5000)]
        public string CommentContent { get; set; }
        public DateTimeOffset CommentCreationDate { get; set; }
        public string AuthorId { get; set; }
        public string PostId { get; set; }
        public DateTimeOffset CommentUpdateDate { get; set; }
        public bool MarkForDeletion { get; set; }
        [Required]
        [AllowHtml]
        [StringLength(500)]
        public string CommentUpdateReason { get; set; }
        public string EditorId { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}