namespace HerancaEx
{
    public class NotificacaoSms : Notificacao
    {
        public override void EnviarNotificacao()
        {
            Console.WriteLine("Enviando notificação por SMS...");
        }
    }
}