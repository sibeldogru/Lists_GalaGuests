
List<string> galaGuests = new List<string>();

galaGuests.Add("Bülent Ersoy");
galaGuests.Add("Ajda Pekkan");
galaGuests.Add("Ebru Gündeş");
galaGuests.Add("Hadise");
galaGuests.Add("Hande Yener");
galaGuests.Add("Tarkan");
galaGuests.Add("Funda Arar");
galaGuests.Add("Demet Akalın");


Console.WriteLine("**Davetli Listesi**");

int i = 1;
foreach (var guest in galaGuests)
{
    Console.WriteLine(i++ + " - " + guest);
}