using PersonalAgenda;

List<Appuntamento> meetingsList = new List<Appuntamento>();


Console.WriteLine("Quanti appuntamenti vuoi inserire?");
int numberOfMeetings = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numberOfMeetings; i++)
{
    
    Console.WriteLine("Inserisci il nome dell'appuntamento numero " + (i + 1));
    string meetingName = Console.ReadLine();
    Console.WriteLine("Inserisci l'indirizzo dell'appuntamento numero " + (i + 1));
    string meetingAddress = Console.ReadLine();

    try
    {
        Console.WriteLine("Inserisci la data dell'appuntamento numero " + (i + 1));
        DateTime meetingDate = DateTime.Parse(Console.ReadLine());
        meetingsList.Add(new Appuntamento(meetingDate, meetingName, meetingAddress));
    } catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("Hai inserito una data troppo vecchia");
    }
    

    
}
