
// Estagiario
Imposto objE = new Estagiario();
objE.valeAlimentacao(1000);
objE.valeTransporte(1000);
Console.WriteLine("---------------------------------------------");

// Gerente
Imposto objG = new Gerente();
objG.valeAlimentacao(5000);
objG.valeTransporte(5000); 
Console.WriteLine("---------------------------------------------");

// Atendente
Imposto objA = new Atendente();
objA.valeAlimentacao(4000);
objA.valeTransporte(4000); 
Console.WriteLine("---------------------------------------------");