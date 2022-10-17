// See https://aka.ms/new-console-template for more information

client myclient = new client();
Console.WriteLine(myclient.ToString());

public struct client
{
    String? name = null;
    long phonenumber;
    String? address = null;
    String? email = null;
    bool new_client = false;

    client(String name, long phonenumber, String address, String email, bool new_client)
    {
        this.name = name;
        this.phonenumber = phonenumber;
        this.address = address;
        this.email = email;
        this.new_client = new_client;
    }

    public String Name { get; set; }
    public long Phonenumber { get; set; }
    public String Address { get; set; }
    public String Email { get; set; }
    public bool NewClient { get; set; }

    public override string ToString() => $"({name} {address} {email} {new_client})";


}
