using System.Media;


public class Monstro
{
    public string Nome { get; }
    public string TipoPrincipal { get; }
    public int Forca { get; }
    public int Defesa { get; }
    public int Nivel { get; private set; }
    public int ExperienciaTotal { get; private set; }
    public static int Vida { get; private set; }
    


    public Monstro(string nome, string tipo, int forca, int defesa, int nivel, int experiencia)
    {
       
        Nome = nome;
        TipoPrincipal = tipo;
        Forca = forca;
        Defesa = defesa;
        Nivel = nivel <= 0 ? Nivel = 1 : Nivel += nivel;
        
        this.ExibirMonstro();
        Console.WriteLine(this.AdicionarExperiencia(experiencia));
        this.RemoverVida(200);
    }

    public string AdicionarExperiencia(int experiencia)
    {

        if (experiencia > 0)
        {
            this.ExperienciaTotal = ExperienciaTotal + experiencia;
            return $"{Nome} está no nível {Nivel} e possui {ExperienciaTotal}";
        }
        else
        {
            return "Nenhuma experiência adquirida";
        }
    }
    public bool ChecarSeEstaVivo() 
    {
        if (Vida > 0)
        {
            Console.WriteLine($"Vida:{Vida}");
            return true;
        }
        else
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Stream=(rinha_de_monstro.Properties.Resources.masjamorreuwav);
            sound.Play();
            Console.WriteLine($"Monstro: {Nome} Morreu");
            return false;
        }
    }
    public int AdicionarVida(int valor)
    {
        Monstro.Vida = Vida + valor;
        this.ChecarSeEstaVivo();
        return Monstro.Vida;
    }
    public int RemoverVida(int valor)
    {
        Monstro.Vida = Vida - valor;
        this.ChecarSeEstaVivo();
        return Monstro.Vida;
    }
    public void ExibirMonstro()
    {
        Console.WriteLine( $"Nome: {Nome} \n" +
            $"Tipo:{TipoPrincipal} \n" +
            $"Força:{Forca}\n" +
            $"Defesa:{Defesa}\n" +
            $"Nível:{Nivel} \n" +
            $"Experiência:{ExperienciaTotal} \n" +
            $"Vida: {Vida}");
    }
}
