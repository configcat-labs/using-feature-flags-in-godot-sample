using Godot;
using System;
using ConfigCat.Client;

public partial class Sprite : Sprite2D
{
  private int speed = 400;
  private int AngularSpeed = (int)Mathf.Pi;

  // Initialize ConfigCat client
  private IConfigCatClient configCatClient = ConfigCatClient.Get("bzTbCEPv_E6GL6COig1QRQ/uZTJPJvsgUuyI8kCvbmXjg");

  private bool isRotateSpriteEnabled;

  public override void _Ready()
  {
    isRotateSpriteEnabled = configCatClient.GetValue("rotatesprite", false);

    if (isRotateSpriteEnabled)
    {
      GD.Print("Your feature flag is enabled!!");
    }
    else
    {
      GD.Print("Your feature flag is disabled!!");
    }


  }

  public override void _Process(double delta)
  {
    if (isRotateSpriteEnabled)
    {
      Rotation += AngularSpeed * (float)delta;
    }
  }
}
