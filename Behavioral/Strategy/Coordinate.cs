namespace Strategy
{
    public class Coordinate
    {
        public Coordinate(double @long, double lat)
        {
            Long = @long;
            Lat = lat;
        }

        // Długość i szerokość geograficzna

        public double Long { get; set; }
        public double Lat { get; set; }
    }
}