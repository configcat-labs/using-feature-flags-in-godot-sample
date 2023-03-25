using Godot;
using System;
using ConfigCat.Client;

public partial class Sprite : Sprite2D
{
    // Initialization here.
    public override void _Ready()
    {
      var client = ConfigCatClient.Get("WC3bCC2efUaHXNSnavbn7A/5pFwOsqXAE-juwU3OfMkCw");
      var isMyAwesomeFeatureEnabled = client.GetValue("test", false);
		  GD.Print(isMyAwesomeFeatureEnabled);

      if(isMyAwesomeFeatureEnabled) {
        GD.Print("Your feature flag is enabled!!");
      } else {
        GD.Print("Your feature flag is disabled!!");
      }


    }
}
