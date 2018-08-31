using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizServer
{
    public class QuestionHub : Hub
    {
        public Task Send(string question)
        {
            Console.WriteLine("This is the", question);
            return Clients.All.SendAsync("Send", question);
        }
    }
}
