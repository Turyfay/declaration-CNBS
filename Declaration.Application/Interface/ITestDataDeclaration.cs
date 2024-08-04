using Declaration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Application.Interface
{
    public interface ITestDataDeclarationService
    {
        Task<TestDataDeclaration> GetTestDataDeclarationAsync(string requestParameter);
    }
}
