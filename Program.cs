using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("======================================================");
Console.WriteLine("              Aparelho: Smartphone Nókia");
Console.WriteLine("======================================================\n");

Nokia nk = new Nokia("81655320234", "Nókia-PRO","IMOOIMIDDD0125S",50);
nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("Instagran");

Console.WriteLine("======================================================");


Console.WriteLine("\n======================================================");
Console.WriteLine("              Aparelho: Smartphone Iphone");
Console.WriteLine("======================================================");

Smartphone fone =  new Iphone("81966321458","Mdo1523","ImeiDDO1256",200);
fone.Ligar();
fone.ReceberLigacao();
fone.InstalarAplicativo("WhatsApp");

Console.WriteLine("======================================================\n");
