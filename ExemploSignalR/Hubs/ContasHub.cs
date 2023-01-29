using ExemploSignalR.Models;
using Microsoft.AspNetCore.SignalR;

namespace Projeto04.Presentation.Mvc.Hubs
{
    //Hub do SignalR
    public class ContasHub : Hub
    {
        //método para que os clientes deste HUB possam enviar
        //notificações (avisos / mensagens)
        public async Task SendMessage(ContasViewModel viewModel)
        {
            //gerando um ID para o registro
            viewModel.Id = Guid.NewGuid();

            //função de RECEIVER
            await Clients.All.SendAsync("ReceiveMessage", viewModel);
        }
    }
}
