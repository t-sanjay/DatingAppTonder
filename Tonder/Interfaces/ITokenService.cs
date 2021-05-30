using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tonder.Models;

namespace Tonder.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
