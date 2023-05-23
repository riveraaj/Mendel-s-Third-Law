namespace Laboratorio_III.Models
{
    public class ModelImage
    {
        public Dictionary<int, Organic> OrganicCompounds = new();
        public ModelImage()
        {
            OrganicCompounds.Add(1
                , new Organic("ACRILAMIDA", "resource/Acrilamida.png"));
            OrganicCompounds.Add(2
                , new Organic("ALDEHIDO", "resource/Aldehído.png"));
            OrganicCompounds.Add(3
                , new Organic("ALMIDON", "resource/Almidón.svg"));
            OrganicCompounds.Add(4
                , new Organic("ALQUINO", "resource/Alquino.png"));
            OrganicCompounds.Add(5
                , new Organic("CELULOSA", "resource/Celulosa.png"));
            OrganicCompounds.Add(6
                , new Organic("ESTIRENO", "resource/Estireno.svg"));
            OrganicCompounds.Add(7
                , new Organic("ETILENO", "resource/Etileno.png"));
            OrganicCompounds.Add(8
                , new Organic("FIBROINA", "resource/Fibroína.svg"));
            OrganicCompounds.Add(9
                , new Organic("FRUCTOSA", "resource/Fructosa.svg"));
            OrganicCompounds.Add(10
                , new Organic("GLUCOSA", "resource/Glucosa.svg"));
            OrganicCompounds.Add(11
                , new Organic("HIDROXILO", "resource/hidroxilo.png"));
            OrganicCompounds.Add(12
                , new Organic("LACTOSA", "resource/Lactosa.svg"));
            OrganicCompounds.Add(13
                , new Organic("MALTOSA", "resource/Maltosa.svg"));
            OrganicCompounds.Add(14
                , new Organic("MALTOTRIOSA", "resource/Maltotriosa.svg"));
            OrganicCompounds.Add(15
                , new Organic("POLIETILENO", "resource/Polietileno.svg"));
            OrganicCompounds.Add(16
                , new Organic("PROPILENO", "resource/Propileno.png"));
            OrganicCompounds.Add(17
                , new Organic("RAFINOSA", "resource/Rafinosa.svg"));
            OrganicCompounds.Add(18
                , new Organic("RIBOSA", "resource/Ribosa.svg"));
            OrganicCompounds.Add(19
                , new Organic("SACAROSA", "resource/Sacarosa.svg"));
            OrganicCompounds.Add(20
                , new Organic("ACIDO ALGINICO", "resource/Ácido algínico.svg"));
        }
    }

    public class Organic
    {
        public string name;
        public string path;
        public Organic(string name, string path)
        {
            this.name = name;
            this.path = path;
        }
    }

}
