using HerancaEx;

//! Exercício 1
// Carro  carro1 = new Carro("nissan", "Gtr", 2);

// Motocicleta moto1 = new Motocicleta("kawasaki", "ninja", 1000);

// carro1.ExibirInformacoes();
// moto1.ExibirInformacoes();

//? Exercício 2

// Ebook pd1  = new Ebook ("O senhor dos aneis", 50, 1000);

// CursoOnline pd2 = new CursoOnline ("Curso de C#", 100, 40);

// pd1.ExibirInformacoes();
// pd2.ExibirInformacoes();

//! Exercício 3

// JogoDigital jogo1 = new JogoDigital("The Witcher 3", "PC", 50);

// JogoFisico jogo2 = new JogoFisico("The Last of Us", "PS4", 90);

// jogo1.ExibirInformacoes();
// jogo2.ExibirInformacoes();

//? Exercício 4

// NotificacaoEmail email = new NotificacaoEmail();
// NotificacaoSms sms = new NotificacaoSms();
// NotificacaoPush push = new NotificacaoPush();

// email.EnviarNotificacao();
// sms.EnviarNotificacao();
// push.EnviarNotificacao();

//! Exercício 5

// List<Entrega> entregas = new List<Entrega>
// {
//     new EntregaExpressa(50), 
//     new EntregaEconomica(50), 
//     new RetiradaLocal()       
// };

// foreach (var entrega in entregas)
// {
//     Console.WriteLine($"Frete: R$ {entrega.CalcularFrete():F2}");
// }

//? Exercício 6

Relatorio relatorio = new Relatorio();
Contrato contrato = new Contrato();

relatorio.Imprimir();
relatorio.Exportar();

contrato.Imprimir();