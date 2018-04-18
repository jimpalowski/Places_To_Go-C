using System.Collections.Generic;
using System;

namespace PlacesToGo.Models
{
  public class City
  {
    private string _country;
    private string _city;
    private string _image;
    private static List<City> _instances = new List<City> {};


    public City (string country, string city, string image)
    {
      _country = country;
      _city = city;
      _image = image;
    }


    public string GetImage()
    {
      return _image;
    }
    public void SetImage(string newImage)
    {
      _image = newImage;
    }
    public string GetCountry()
    {
      return _country;
    }
    public void SetCountry(string newCountry)
    {
      _country = newCountry;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string _newCity)
    {
      _city = _newCity;
    }
    public static List<City> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
