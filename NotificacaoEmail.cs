namespace HerancaEx
{
    public class NotificacaoEmail : Notificacao
    {
        public override void EnviarNotificacao()
        {
            Console.WriteLine("Enviando notificação por e-mail...");
        }
    }
}