using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAll();
    }
}
