using ConsoleApp2_Noite;

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao() + " " + p1.getId() + "\n");

p1.setValor(11.85M);
p1.setDescricao("Cerveja litrão Skol");

Console.WriteLine(p1.getDescricao() + ": " + p1.getValor() + "\n\n");

Endereco endereco = new Endereco(
    "Rua Mario Bizaria",
    "91",
    "Sobral",
    "15906304",
    "Taquaritinga",
    "SP");

Endereco endereco2 = new Endereco(
    "Rua Mario Bizaria",
    "91",
    "Sobral",
    "15906304",
    "São Carlos",
    "SP");

Cliente c1 = new Cliente(1, "Gabriele", "991340447", endereco);
Cliente c2 = new Cliente(2, "Gabriela", "991340447", endereco);
Cliente c3 = new Cliente(3, "Ryan", "991340447", endereco);
Cliente c4 = new Cliente(4, "Fernanda", "991340447", endereco);
Cliente c5 = new Cliente(5, "Giovanni", "991340447", endereco2);

Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());

c2.getEndereco().setNumero("135");

Console.WriteLine(c2.getEndereco().getNumero());
Console.WriteLine(c2.getEndereco().getEndCompleto());