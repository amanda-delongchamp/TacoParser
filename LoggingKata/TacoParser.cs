namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            //DONE: Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            //DONE: If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogWarning("Less than three items, incomplete data");

                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // DONE: grab the latitude from your array at index 0
            double latitude = double.Parse(cells[0]);

            // DONE: grab the longitude from your array at index 1
            double longitude = double.Parse(cells[1]);

            // DONE: grab the name from your array at index 2
            string name = cells[2];

            // DONE: Your going to need to parse your string as a `double`
            // DONE: which is similar to parsing a string as an `int`


            // DONE: You'll need to create a TacoBell class
            // DONE: that conforms to ITrackable

            // DONE:  Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            Point point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;

            TacoBell tacoBell  = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell;
        }
    }
}