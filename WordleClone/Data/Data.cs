namespace WordleClone.Data
{
    public class Data
    {
    }

    public class RandomWords1
    {
        public async Task<string> GetWords() {  
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://random-words5.p.rapidapi.com/getMultipleRandom?count=5&wordLength=5"),
                Headers =
                    {
                        { "x-rapidapi-host", "random-words5.p.rapidapi.com" },
                        { "x-rapidapi-key", "f5541f1923msh471c8a5350dedf0p1e20d0jsn14fdfc21f08b" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
            return (body);
        }
        }
    }
}
