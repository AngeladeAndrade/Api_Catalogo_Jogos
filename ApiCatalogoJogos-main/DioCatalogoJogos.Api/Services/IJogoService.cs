using DioCatalogoJogos.Api.InputModel;
using DioCatalogoJogos.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioCatalogoJogos.Api.Services
{
    public interface IJogoService: IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
        Task Inserir(JogoInputModel jogoInputModel);
        Task Atualizar(Guid idJogo, JogoInputModel jogoInputModel);
    }
}
