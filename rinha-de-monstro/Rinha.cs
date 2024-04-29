using System.Reflection.Metadata.Ecma335;

public class Rinha
{
    public Rinha(Monstro monstro1, Monstro monstro2)
    {
        Monstro1 = monstro1;
        Monstro2 = monstro2;
        Round = this.AdicionarRound(0);
    }

    public Monstro Monstro1 { get; private set; }
    public Monstro Monstro2 { get; private set; }
    public int Round { get; private set; }

    public void AtacarMonstro(Monstro monstroAtacante, Monstro monstroDefensor)
    {
        int dano = monstroAtacante.Forca - monstroDefensor.Defesa;
        monstroDefensor.RemoverVida(dano);
    }

    public Monstro VerificarQualMaisForte(Monstro monstro1, Monstro monstro2)
    { 
        Monstro movimentaPrimeiro;
        movimentaPrimeiro = monstro1.Forca >= monstro2.Forca ? movimentaPrimeiro = monstro1 : movimentaPrimeiro = monstro2;
        return movimentaPrimeiro;
    }

    public int AdicionarRound(int round)
    {
        round++;
        return round;
    }


}