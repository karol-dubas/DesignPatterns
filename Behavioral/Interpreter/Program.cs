using System;

// Interfejs Expression
public interface IExpression
{
    string Interpret(Context context);
}

// Konkretne klasy Expression
public class WhiteBloodCellExpression : IExpression
{
    public string Interpret(Context context)
    {
        double value = context.WhiteBloodCellCount;
        return $"{value} tys. leukocytów";
    }
}

public class RedBloodCellExpression : IExpression
{
    public string Interpret(Context context)
    {
        double value = context.RedBloodCellCount;
        return $"{value} mln erytrocytów";
    }
}

public class HemoglobinExpression : IExpression
{
    public string Interpret(Context context)
    {
        double value = context.HemoglobinLevel;
        return $"{value} g/dl hemoglobiny";
    }
}

public class HematocritExpression : IExpression
{
    public string Interpret(Context context)
    {
        double value = context.HematocritLevel;
        return $"{value}% hematokrytu";
    }
}

public class MeanCorpuscularVolumeExpression : IExpression
{
    public string Interpret(Context context)
    {
        double value = context.MeanCorpuscularVolume;
        return $"{value} średniej objętości krwinek czerwonych (w jednostkach fl)";
    }
}

public class GenderExpression : IExpression
{
    public string Interpret(Context context)
    {
        string gender = context.Gender;
        if (gender == "M")
        {
            return "u mężczyzny";
        }
        else if (gender == "F")
        {
            return "u kobiety";
        }
        return "";
    }
}

public class Context
{
    public double WhiteBloodCellCount { get; set; }
    public double RedBloodCellCount { get; set; }
    public double HemoglobinLevel { get; set; }
    public double HematocritLevel { get; set; }
    public double MeanCorpuscularVolume { get; set; }
    public string Gender { get; set; }

    public string Interpret(IExpression expression)
    {
        return expression.Interpret(this);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string input = "WBC 3.7; RBC 4.5; HGB 13.2; HCT 41; MCV 92; M";

        // Rozbijamy wyrażenie na poszczególne pary parametr-wartość
        string[] pairs = input.Split(';');

        // Tworzymy obiekt Context
        Context context = new Context();

        foreach (string pair in pairs)
        {
            // Rozbijamy parę parametr-wartość na nazwę parametru i wartość
            string[] parts = pair.Trim().Split(' ');

            if (parts.Length == 2)
            {
                string parameter = parts[0];
                double value = double.Parse(parts[1]);

                // Przypisujemy wartości parametrów do obiektu Context na podstawie nazwy parametru
                switch (parameter)
                {
                    case "WBC":
                        context.WhiteBloodCellCount = value;
                        break;
                    case "RBC":
                        context.RedBloodCellCount = value;
                        break;
                    case "HGB":
                        context.HemoglobinLevel = value;
                        break;
                    case "HCT":
                        context.HematocritLevel = value;
                        break;
                    case "MCV":
                        context.MeanCorpuscularVolume = value;
                        break;
                }
            }
        }

        // Ustawiamy płeć
        context.Gender = "M";

        // Tworzymy obiekty klas Expression
        IExpression wbcExpression = new WhiteBloodCellExpression();
        IExpression rbcExpression = new RedBloodCellExpression();
        IExpression hgbExpression = new HemoglobinExpression();
        IExpression hctExpression = new HematocritExpression();
        IExpression mcvExpression = new MeanCorpuscularVolumeExpression();
        IExpression genderExpression = new GenderExpression();

        // Interpretujemy i wyświetlamy wynik
        string result = $"{context.Interpret(wbcExpression)}, " +
                        $"{context.Interpret(rbcExpression)}, " +
                        $"{context.Interpret(hgbExpression)}, " +
                        $"{context.Interpret(hctExpression)} oraz " +
                        $"{context.Interpret(mcvExpression)}, " +
                        $"{context.Interpret(genderExpression)}";

        Console.WriteLine(result);
    }
}
