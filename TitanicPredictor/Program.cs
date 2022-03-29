using Spectre.Console;
using TitanicPredictor;

Titanic.ModelInput input = new Titanic.ModelInput
{
    Name = AnsiConsole.Ask<string>("Name:\n"),
    Age = AnsiConsole.Ask<float>("Age:\n"),
    Fare = AnsiConsole.Ask<float>("Fare Payed:\n"),
    Parents_Children_Aboard = AnsiConsole.Ask<float>("Family Members Onboard:\n"),
    Pclass = AnsiConsole.Ask<float>("Class:\n"),
    Sex = AnsiConsole.Ask<string>("Sex:\n"),
    Siblings_Spouses_Aboard = AnsiConsole.Ask<float>("Siblings Aboard:\n"),
}; 

var result = Titanic.Predict(input);

string survived = result.Prediction == 1 ? "Survived" : "Died";
Console.WriteLine(survived);