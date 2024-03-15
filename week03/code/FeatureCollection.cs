public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string type { get; set; }
    public Metadata metadata {get; set;}
    public Feature[] features { get; set; }
}

public class Feature {
    public string type { get; set; }
    public FeatureProperties properties { get; set; }
    public Geometry geometry { get; set; }
    public string id { get; set; }
}
public class FeatureProperties {
    public double mag { get; set; }
    public string place { get; set; }
    public long time { get; set; }
    public long updated { get; set; }
    public object tz { get; set; }
    public string url { get; set; }
    public string detail { get; set; }
    public object felt { get; set; }
    public object cdi { get; set; }
    public object mmi { get; set; }
    public object alert { get; set; }
    public string status { get; set; }
    public int tsunami { get; set; }
    public int sig { get; set; }
    public string net { get; set; }
    public string code { get; set; }
    public string ids { get; set; }
    public string sources { get; set; }
    public string types { get; set; }
    public int? nst { get; set; }
    public double? dmin { get; set; }
    public double? rms { get; set; }
    public double? gap { get; set; }
    public string magType { get; set; }
    public string type { get; set; }
    public string title { get; set; }
}
public class Geometry 
{
    public string type { get; set; }
    public List<double> coordinates { get; set; }
}

public class Metadata {
    public long generated;
    public string url;
    public string title;
    public string api;
    public int count;
    public int status;
}