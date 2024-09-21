﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class DeleteAuthorCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteAuthorCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
