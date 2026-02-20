//Pede ao usuario os valores dos coeficientes de A,B e C

Console.WriteLine("Digite o número para o coeficiente A");
double Coef_A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o número para o coeficiente B");
double Coef_B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o número para o coeficiente C");
double Coef_C = Convert.ToDouble(Console.ReadLine());




//Parte do calculo de Delta
double Delta = (Coef_B * Coef_B) - (4 * Coef_A * Coef_C);


//Calculo da raiz
double Raiz_Positiva = (-Coef_B + Math.Sqrt(Delta)) / (2 * Coef_A);
double Raiz_Negativa = (-Coef_B - Math.Sqrt(Delta)) / (2 * Coef_A);




//Mostra os resultados na tela
Console.WriteLine($"O valor do seu Delta é {Delta}");
Console.WriteLine($"O valor de bhaskara é {Raiz_Positiva} e {Raiz_Negativa}");

