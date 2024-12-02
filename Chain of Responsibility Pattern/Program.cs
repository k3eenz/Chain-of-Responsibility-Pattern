
using Chain_of_Responsibility_Pattern;
using Chain_of_Responsibility_Pattern.Handlers;

Handler restart = new RestartHandler();
Handler check = new CheckHandler();
Handler update = new UpdateHandler();

restart.SetNextHandler(check);
check.SetNextHandler(update);

var request = new Request("Перезапуск");

restart.HandleRequest(request);
