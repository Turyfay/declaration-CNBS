using Declaration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Core.Interfaces
{
    public interface IDataDeclarationService
    {
        Task<TestDataDeclaration> GetTestDataDeclarationAsync(string requestParameter);
    }
}
