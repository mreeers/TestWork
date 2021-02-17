using Models.Model;
using Models.Model.JSON;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.Interface
{
    public interface IJsonLanguage
    {
        void AddJsonLanguage<T>(T entity, string lang, string path) where T : class;
        //void Task<Language> AddJsonLanguage(Language json, string path);
    }
}
