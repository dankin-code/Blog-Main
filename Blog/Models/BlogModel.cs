using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Web.Mvc;
using System.ComponentModel;

namespace Blog.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        [DisplayName("Post Date")]
        public DateTimeOffset PostCreationDate { get; set; }
        [Required]
        [StringLength(500)]
        [DisplayName("Post Title")]
        public string PostTitle { get; set; }
        [Required]
        [AllowHtml]
        [StringLength(5000)]
        [DisplayName("Post Content")]
        public string PostContent { get; set; }
        public string MediaUrl { get; set; }
        public bool Published { get; set; }
        public string AuthorId { get; set; }
        [DisplayName("Post Update Date")]
        public DateTimeOffset PostUpdateDate { get; set; }
        [StringLength(500)]
        [DisplayName("Post Update Reason")]
        public string PostUpdateReason { get; set; }
        [DisplayName("Post Editor")]
        public string EditorId { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual ApplicationUser Editor { get; set; }

    }

    public partial class Comment
    {
        public int Id { get; set; }
        [Required]
        [AllowHtml]
        [StringLength(5000)]
        [DisplayName("Comment Content")]
        public string CommentContent { get; set; }
        [DisplayName("Comment Date")]
        public DateTimeOffset CommentCreationDate { get; set; }
        [DisplayName("Comment Author")]
        public string AuthorId { get; set; }
        public string PostId { get; set; }
        [DisplayName("Comment Update Date")]
        public DateTimeOffset CommentUpdateDate { get; set; }
        public bool MarkForDeletion { get; set; }
        [Required]
        [AllowHtml]
        [StringLength(500)]
        [DisplayName("Comment Update Reason")]
        public string CommentUpdateReason { get; set; }
        public string EditorId { get; set; }
        public virtual ApplicationUser CommentEditor { get; set; }
        public virtual ApplicationUser CommentAuthor { get; set; }

    }
}