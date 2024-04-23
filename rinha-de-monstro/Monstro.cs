class Monstro
{
    public string Nome { get; }
    public string TipoPrincipal { get; }
    public int Forca { get; }
    public int Defesa { get; }
    public int Nivel { get; private set; }
    public int ExperienciaTotal { get; private set; }

    public Monstro(string nome, string tipo, int forca, int defesa, int nivel, int experiencia)
    {
        Nome = nome;
        TipoPrincipal = tipo;
        Forca = forca;
        Defesa = defesa;
        Nivel = nivel <= 0 ? Nivel = 1 : Nivel += nivel;
        this.ExibirMonstro();
        Console.WriteLine(this.AdicionarExperiencia(experiencia));
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

    public void ExibirMonstro()
    {
        Console.WriteLine( $"Nome: {Nome} \n" +
            $"Tipo:{TipoPrincipal} \n" +
            $"Força:{Forca}\n" +
            $"Defesa:{Defesa}\n" +
            $"Nível:{Nivel} \n" +
            $"Experiência:{ExperienciaTotal}");
    }
}
