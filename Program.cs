string stringa="";
int contaVocali=0;
Console.WriteLine("inserisci una stringa");
stringa= Console.ReadLine();
 for (int i=0;i<stringa.Length;i++)
{
    Console.WriteLine(stringa[i]+ "\n");

    if (stringa[i] == 'a' || stringa[i] == 'e'|| stringa[i] == 'i' || stringa[i] == 'o' || stringa[i] == 'u')
    {
        contaVocali++; 
    }
 
}
Console.WriteLine($"le vocali sono {contaVocali}");