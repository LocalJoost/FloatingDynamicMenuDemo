public class WorldCoordinate
{
    public WorldCoordinate()
    {
    }

    public WorldCoordinate(float lat, float lon)
    {
        Lat = lat;
        Lon = lon;
    }

    public float Lon { get; set; }
    public float Lat { get; set; }


    public override string ToString()
    {
        return string.Format("lat={0},lon={1}", Lat, Lon);
    }
}
