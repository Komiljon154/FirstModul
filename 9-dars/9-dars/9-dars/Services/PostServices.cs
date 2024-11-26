using _9_dars.Moduls;
using System;
using System.Collections.Generic;
namespace _9_dars.Services
{

    public class PostService
    {
        private List<Post> posts;
        public PostService()         {
            posts = new List<Post>();
        }

        public Post AddPost(Post post)
        {
            post.Id = Guid.NewGuid();
            posts.Add(post);
            return post;
        }
        public Post GetById(Guid postId)
        {
            foreach (var post in posts)
            {
                if (post.Id == postId)
                {
                    return post;
                }
            }
            return null;
        }

        public bool DeletePost(Guid postId)
        {
            var exsist = false;
            foreach (var post in posts)
            {
                if (post.Id == postId)
                {
                    posts.Remove(post);
                    exsist = true;
                    break;
                }
            }
            return exsist;
        }
        public bool UpdatePost(Post updatedPost)
        {
            for (var i = 0; i < posts.Count; i++)
            {
                if (posts[i].Id == updatedPost.Id)
                {
                    posts[i] = updatedPost;
                    return true;
                }
            }
            return false;
        }

        public List<Post> GetAllPosts()
        {
            return posts;
        }


    }
}

public Post GetMostVievedPost()
{
   
}

public Post GetMostLikedPost()
{

}
public Post GetMostCommentedPost()
{

}
public List<Post> GetPostsByComment(string comment)
{

}
public bool AddCommentToPost(Guid postId, string comment)
{

}
public bool AddVieverNameToPost(Guid postId, string vieverName)
{

}
public bool AddLikeTopost(Guid postId)
{

}

