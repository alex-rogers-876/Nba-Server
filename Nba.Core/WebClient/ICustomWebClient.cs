using System;
using System.Collections.Generic;
using System.Text;
 
namespace Nba.Core.CustomWebClient
{
    public interface ICustomWebClient
    {
        string GetResponse(string url);
    }
}
