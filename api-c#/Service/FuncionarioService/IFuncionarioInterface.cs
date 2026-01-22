using api_c_.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace api_c_.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>>GetFuncionarios();
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);


    }
}
