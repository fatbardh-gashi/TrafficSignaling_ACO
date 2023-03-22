using TrafficSignaling_ACO.Entities;

int D, I, S, V, F;

string filePath = "C:\\Users\\fatba\\OneDrive\\Documents\\TrafficSignaling_ACO\\TrafficSignaling_ACO\\InputDataSet\\a_an_example.in.txt";

using (StreamReader reader = new StreamReader(filePath))
{
    // Read the first line of the input
    string[] firstLine = reader.ReadLine().Split(" ").ToArray();
    D = int.Parse(firstLine[0]);
    I = int.Parse(firstLine[1]);
    S = int.Parse(firstLine[2]);
    V = int.Parse(firstLine[3]);
    F = int.Parse(firstLine[4]);

    // Initialize the intersections
    Intersection[] intersections = new Intersection[I];
    for (int i = 0; i < I; i++)
    {
        intersections[i] = new Intersection { Id = i, Streets = new List<Street>() };
    }

    // Read the streets
    for (int i = 0; i < S; i++)
    {
        string[] streetLine = reader.ReadLine().Split(" ").ToArray();
        int startID = int.Parse(streetLine[0]);
        int endID = int.Parse(streetLine[1]);
        string name = streetLine[2];
        int duration = int.Parse(streetLine[3]);

        Street street = new Street { Name = name, Duration = duration, StartIntersection = intersections[startID], EndIntersection = intersections[endID] };
        intersections[startID].Streets.Add(street);
    }

    // Read the cars
    Car[] cars = new Car[V];
    for (int i = 0; i < V; i++)
    {
        string[] carLine = reader.ReadLine().Split(" ").ToArray();
        int numStreets = int.Parse(carLine[0]);
        List<string> path = new List<string>();
        for (int j = 1; j <= numStreets; j++)
        {
            path.Add(carLine[j]);
        }
        string firstStreet = path[0];
        Intersection startIntersection = intersections.First(x => x.Streets.Any(s => s.Name == firstStreet));

        Car car = new Car { NumStreets = numStreets, Path = path, StartIntersection = startIntersection };
        cars[i] = car;
    }
}

Dictionary<int, List<Tuple<string, int>>> trafficLightSchedules = new Dictionary<int, List<Tuple<string, int>>>();

