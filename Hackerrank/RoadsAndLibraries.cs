using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            long x = Convert.ToInt64(tokens_n[2]);
            long y = Convert.ToInt64(tokens_n[3]);
            
            var roads = new List<Road>();
                
            for(int a1 = 0; a1 < m; a1++){
                string[] tokens_city_1 = Console.ReadLine().Split(' ');
                int city_1 = Convert.ToInt32(tokens_city_1[0]);
                int city_2 = Convert.ToInt32(tokens_city_1[1]);
                roads.Add(new Road(city_1, city_2));
            }
            
            Solve(n, roads, x, y);
        }
    }
    
    static void Solve(int numberOfCities, IEnumerable<Road> roads, long libraryCost, long roadCost) {
        if(roadCost >= libraryCost) {
            Console.WriteLine(libraryCost * numberOfCities);
        } else {
            var cities = CreateCities(numberOfCities);
            CreateConnections(cities, roads);
            Console.WriteLine(CalculateCost(cities, libraryCost, roadCost));    
        }
    }
    
    static IEnumerable<City> CreateCities(int numberOfCities) {
        City[] cities = new City[numberOfCities+1];
        for(int i=0; i<=numberOfCities; i++)
            cities[i] = new City(i);
        return cities;
    }
    
    
    static void CreateConnections(IEnumerable<City> cities, IEnumerable<Road> roads) {
        foreach(var road in roads) {
            var city1 = cities.ElementAt(road.City1);
            var city2 = cities.ElementAt(road.City2);
            
            city1.AddConnection(city2);
            city2.AddConnection(city1);
        }
    }
    
    static long CalculateCost(IEnumerable<City> cities, long libraryCost, long roadCost) {
        
        var connectedSubGraphs = new List<ConnectedSubGraph>();
        var visited = new bool[cities.Count()];
        foreach(var city in cities) {
            if(visited[city.ID] || city.ID == 0)
                continue;

            int numberOfNodesInSubTree = DFS(city, visited);
            connectedSubGraphs.Add(new ConnectedSubGraph(numberOfNodesInSubTree));
        }
        
        return connectedSubGraphs.Select(s => s.CalculateMinimumBuildCost(libraryCost, roadCost)).Sum();;
    }
    
    static int DFS(City city, bool[] visited) {
        if(visited[city.ID]) return 0;
        visited[city.ID] = true;
        return 1 + city.ConnectedCities.Select(c => DFS(c, visited)).Sum();
    }
    
}

class City {
    
    private List<City> _connectedCities = new List<City>();
    
    public City(int id) {
        ID = id;
    }
    
    public int ID { get; private set; }
    
    public IEnumerable<City> ConnectedCities => _connectedCities;
    
    public void AddConnection(City city) {
        if(!ConnectedCities.Contains(city))
            _connectedCities.Add(city);
    }
}

public class Road {
    
    public Road(int city1, int city2) {
        City1 = city1;
        City2 = city2;
    }
    
    public int City1 {get;}
    
    public int City2 {get;}
}

public class ConnectedSubGraph {
    private long _numberOfCities = 0;
    public ConnectedSubGraph(long numberOfCities) {
        _numberOfCities = numberOfCities;
    }
    
    public long CalculateMinimumBuildCost(long libraryCost, long roadCost) {
        
        long costOfLibraryInEachCity = _numberOfCities * libraryCost;
        long costOfOneLibraryAndRoads = libraryCost + (roadCost * (_numberOfCities-1));
        
        return Math.Min(costOfLibraryInEachCity, costOfOneLibraryAndRoads);
    }
}


