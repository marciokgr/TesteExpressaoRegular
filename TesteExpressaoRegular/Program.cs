using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {

        #region encontrando arquivos .sql


        Console.WriteLine("-=-=-=- Testando AD -=-=-=-\n");

        // Expressão regular
        string regex = @"^(?!.*(?:DDL|Dispose|Seed)\.sql$).*\.sql$";

        // Array de arquivos
        string[] arquivos = { "C:\\repositorios\\F8N.Tesouraria\\database\\scripts\\aglutinador\\drop_aglutinador.sql", "C:\\repositorios\\F8N.Tesouraria\\src\\Ailos.Tesouraria.Api\\appsettings.json", "database\\script.sql", "DDL.sql", "data.sql", "Dispose.sql", "xpto\\Seed.sql", "ComprovantesServiceFake.cs" };

        // Testar a expressão regular em cada arquivo
        foreach (string arquivo in arquivos)
        {
            if (Regex.IsMatch(arquivo, regex))
            {
                Console.WriteLine(arquivo + " corresponde à expressão regular.");
            }
            else
            {
                Console.WriteLine(arquivo + " não corresponde à expressão regular.");
            }
        }
        #endregion

        Console.WriteLine("\n-=-=-=- Testando C4E -=-=-=-\n");

        // Expressão regular
        string regexC4E = @"^(?!.*\.sql$).*$";

        // Testar a expressão regular em cada arquivo
        foreach (string arquivoC4E in arquivos)
        {
            if (Regex.IsMatch(arquivoC4E, regexC4E))
            {
                Console.WriteLine(arquivoC4E + " corresponde à expressão regular C4E.");
            }
            else
            {
                Console.WriteLine(arquivoC4E + " não corresponde à expressão regular C4E.");
            }
        }
    }
}