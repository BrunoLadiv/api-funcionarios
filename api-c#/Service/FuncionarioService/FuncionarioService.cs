using api_c_.DataContext;
using api_c_.Models;

namespace api_c_.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {   private readonly ApplicationDbContext _context;

        public FuncionarioService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();
            try
            {
                if(novoFuncionario == null)
                {
                    serviceResponse.Sucesso = false;
                    serviceResponse.Mensagens = "Funcionário inválido.";
                    return serviceResponse;
                }
                _context.Add(novoFuncionario);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Funcionarios.ToList();


            }
            catch (Exception ex)
            {

                throw;
            }
            return serviceResponse
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();
            try
            {
                serviceResponse.Dados = _context.Funcionarios.ToList();

                if(serviceResponse.Dados.Count == 0)
                {
                    
                    serviceResponse.Mensagens = "Nenhum funcionário encontrado.";
                }
                
                

            }
            catch (Exception ex)
            {

               serviceResponse.Sucesso = false;
               serviceResponse.Mensagens = ex.Message;
            }
            return serviceResponse;
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
