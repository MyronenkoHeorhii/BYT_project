using BYT_project;
using System.Text.Json.Nodes;
using System.Text.Json;

class Hotel {
    private string location;
    private string name;

    private int rate;
    private List<Building> buildings = new List<Building>();

    private List<Hotel> hotelExtent = new List<Hotel>();

    public Hotel(string loc, string name, int rating, params Building[] buildings) { 
        this.location = loc; 
        this.name = name;

        if (rating > 5 || rating < 1) {
            throw new ArithmeticException("Hotel rate must be in range of [1-5]");
        }
        else {
            this.rate = rating;
        }

        foreach (Building b in buildings) {
            this.buildings.Add(b);
        }

        hotelExtent.Add(this);
    }

    private void saveToExtent(Hotel obj) {
        FileStream fs = null;
        if (!File.Exists("Hotel.json"))
        {
            fs = File.Create("Hotel.json");
        }
        JsonSerializer.SerializeAsync(fs, obj);
    }



}