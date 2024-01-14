namespace WebApp.Models
{
    public class Joke
    {
        //for all the public property i typed prop and double tab.
        public int Id { get; set; } // it will have a by default public, int -> datatype,
                                      // my property -> data type which then i changed to "Id".
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        // for all the method i typed ctor and tab.
        public Joke()
        {
            
        }
    }
}
