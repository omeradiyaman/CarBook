﻿using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CommentInterfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetCommentsByBlogId(int id);
        Task<int> GetCommentsCountByBlogId(int id);
        Task<List<Comment>> GetAllCommentsWithBlogTitleAsync();
    }
}
