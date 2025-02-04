using Facade;

var score = new ScoreClienteFacade();

var scoreResult = score.Score("12345678910", "12345678910");

Console.WriteLine("O Score do cliente é: " + scoreResult);

