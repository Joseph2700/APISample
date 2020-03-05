using APISample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Services
{
    public interface IApiService
    {
        Task<Track> GetTrackInfo(string id);
    }
}
