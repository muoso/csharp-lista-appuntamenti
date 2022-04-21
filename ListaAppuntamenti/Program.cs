using PersonalAgenda;
using MeetingExceptions;

List<Appuntamento> meetingsList = new List<Appuntamento>();


Console.WriteLine("Quanti appuntamenti vuoi inserire?");
int numberOfMeetings = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numberOfMeetings; i++)
{
    
    Console.WriteLine("Inserisci il nome dell'appuntamento numero " + (i + 1));
    string meetingName = Console.ReadLine();
    Console.WriteLine("Inserisci l'indirizzo dell'appuntamento numero " + (i + 1));
    string meetingAddress = Console.ReadLine();
    Console.WriteLine("Inserisci la data dell'appuntamento numero " + (i + 1));

    bool isDateCorrect = false;

    while (isDateCorrect == false)
    {
        try
        {
            DateTime meetingDate = DateTime.Parse(Console.ReadLine());
            Appuntamento NewMeeting = new Appuntamento(meetingDate, meetingName, meetingAddress);
            isDateCorrect = true;
            meetingsList.Add(NewMeeting);
        }
        catch (DateTooOldException ex1)
        {
            Console.WriteLine("Hai inserito una data troppo vecchia");
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Il formato della data è errato");
        }
    }   
}
printMeetings(meetingsList);

Console.WriteLine("Vuoi modificare un evento?");
string answer = Console.ReadLine().ToLower();

if (answer == "si")
{
    Console.WriteLine("Qual è il nome dell'evento da modificare?");
    string eventName = Console.ReadLine();

    foreach (Appuntamento meeting in meetingsList)
    {
        if (meeting.Name == eventName)
        {
            Console.WriteLine("Inserisci la nuova data dell'evento: ");
            bool isDateCorrect = false;

            while (isDateCorrect == false)
            {
                try
                {
                    DateTime NewMeetingDate = DateTime.Parse(Console.ReadLine());
                    isDateCorrect = true;
                    meeting.SetDate(NewMeetingDate);
                }
                catch (DateTooOldException ex1)
                {
                    Console.WriteLine("Hai inserito una data troppo vecchia");
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Il formato della data è errato");
                }
            }
        }
    }
    Console.WriteLine("Ecco la lista aggiornata: ");
    printMeetings(meetingsList);
}






void printMeetings(List<Appuntamento> meetingsListToPrint)
{
    foreach (Appuntamento meeting in meetingsListToPrint)
    {
        Console.WriteLine("Nome Appuntamento: " + meeting.Name + "| Indirizzo: " + meeting.MeetingAddress + "| Data: " + meeting.GetDate());
    }
}