using Microsoft.AspNet.SignalR;

namespace BattleShip.Hubs
{
    public class BattleHub : Hub
    {
        public void Send(string name, string row, string column)
        {
            Clients.All.addNewMessageToPage(name, row, column);
        }
    }
}