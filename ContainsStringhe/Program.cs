string testoPrincipale, stringaDaCercare;
bool trovato = false, corrispondenzaTrovata; // inizializzazione della variabile che terrà traccia del risultato finale

Console.WriteLine("inserisci il testo principale: ");
testoPrincipale = Console.ReadLine();

Console.WriteLine("inserisci la sequenza di caratteri da cercare: ");
stringaDaCercare = Console.ReadLine();

for (int i = 0; i < testoPrincipale.Length; i++) // serve per scorrere ogni carattere del testo principale
{
    if (i + stringaDaCercare.Length > testoPrincipale.Length) // se la parte rimanente del testo è più corta della stringa da cercare, interrompe il ciclo
    {
        break;
    }
    
    // presuppone che ci siano abbastanza caratteri nel testo principale per poter contenere per intero la parola che stiamo cercando
    corrispondenzaTrovata = true;

    for (int j = 0; j < stringaDaCercare.Length; j++) // serve per confrontare carattere per carattere la stringa cercata
    {
        // (i + j) scorre lettera per lettera: parte da 'i' e scorre le lettere con 'j'
        // se i caratteri sono diversi, la corrispondenza fallisce e interrompe il ciclo interno
        if (testoPrincipale[i + j] != stringaDaCercare[j])
        {
            corrispondenzaTrovata = false;
            break;
        }
    }
    // l'intera sequenza di caratteri è stata trovata all'interno del testo principale
    if (corrispondenzaTrovata)
    {
        trovato = true; // registra che la parola è stata trovata 
        break; // interrompiamo anche il ciclo esterno perché è inutile continuare a cercare nel resto del testo visto che l'abbiamo già trovata.
    }
}

if (trovato == true)
{
    Console.WriteLine("la sequenza di stringhe è stata trovata nel testo principale");
}
else
{
    Console.WriteLine("la sequenza di stringhe non è stata trovata nel testo principale");
}