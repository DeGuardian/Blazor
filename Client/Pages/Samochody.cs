@page "/samochody"

<PageTitle>Samochody</PageTitle>

<h1>Lista Samcohodow</h1>

< h1 > Lista(@Liœcie.Count(Lista => !Lista.ZROBIONE)) </ h1 >

    @foreach(var Lista in Liœcie)
    {
        < li >
            < input type = "checkbox" @bind = "Lista.ZROBIONE" />
            < input @bind = "Lista.TYTU£" />
        </ li >


    }
< p > Podaj imiê i nazwisko poni¿ej </p>


<input placeholder="Imiê i Nazwisko" @bind="newLista" />

<button @onclick="AddLista" class= "btn btn-primary mt 3" > Zapisz </ button >





@code {
    private List<ListaItem> Liœcie = new();
private string newLista;

private void AddLista()
{
if (!string.IsNullOrWhiteSpace(newLista))
{
Liœcie.Add(new ListaItem { TYTU£ = newLista });
newLista = string.Empty;
}
}
}
[17:34]
public class ListaItem
{

    public int ID { get; set; }

    public string IMIE { get; set; }

    public string NAZWISKO { get; set; }

    public string TYTU£ { get; set; }

    public bool ZROBIONE { get; set; }

}