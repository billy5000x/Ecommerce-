﻿using E_Commerce.Models;
namespace E_Commerce.Repositories.Interfaces
{
    public interface IRespuestaFAQ
    {
        Task<List<RespuestasFAQ>> GetRespuestasFAQ();
        Task<bool> PostRespuestaFAQ(RespuestasFAQ respuestasFAQ);
        Task<bool> PutRespuestasFAQ(RespuestasFAQ respuestasFAQ);
        Task<bool> DeleteRespuestasFAQ(RespuestasFAQ respuestasFAQ);
    }
}
