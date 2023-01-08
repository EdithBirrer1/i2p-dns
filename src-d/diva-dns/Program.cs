﻿

using diva_dns;

public class Program
{
    private static readonly DivaServer _server = new("http://localhost:8080/", "http://127.19.72.21:17468/");

    private static readonly DivaClient _client = new();

    static void Main(string[] args)
    {

        // Todo: Handle command line arguments
        // Possible arguments:
        // - Diva URL (IP + Port)
        // = Port for localhost server (currently 8080)

        Console.WriteLine("Hello Diva!");

        _server.Start();

        if (_server.IsConnected())
        {
            Console.WriteLine("Is connected to Diva");
        } else
        {
            Console.WriteLine("Has no connection to Diva");
        }

        // Todo(siro) handle input from console and forward get/post to DivaClient
        // DivaClient should then send a get or post/put to DivaServer on http://localhost:8080/
        // DivaServer will respond to diva client

        // Todo(siro) report responses from back to user
        // Todo(siro) handle input from console, when to terminate program and close server

        _server.Stop();

        Console.WriteLine("Bye, Diva!");
    }
}