using Microsoft.AspNetCore.SignalR;

namespace simpleApi.Hubs;

public class MessageHub : Hub // bu class ro'yxatdan o'tgan clientlarni listini saqliydi
{
    public async Task SendMessage(string username, string message)
    {
        await Clients.All.SendAsync("GetMessage", username, message); // botta parametridigi getmessage metodini blazordan chaqirvotti va uni parametiga username bn messageni bervotti
    }
}