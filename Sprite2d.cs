using Godot;
using System;
using ConfigCat.Client;

public partial class Sprite2d : Sprite2D
{
  // Initialize the ConfigCat client
  private IConfigCatClient configCatClient = ConfigCatClient.Get("YOUR-CONFIGCAT-SDK-KEY");

  private bool isMyGodotFeatureFlagEnabled;
  private float angularSpeed = Mathf.Pi;

  public override async void _Ready()
  {
	base._Ready();

	isMyGodotFeatureFlagEnabled = await configCatClient.GetValueAsync("myGodotFeatureFlag", false);

	if (isMyGodotFeatureFlagEnabled)
	{
	  GD.Print("Your feature flag is enabled!");
	} else
	{
	  GD.Print("Your feature flag is disabled!");
	}
  }

	public override void _Process(double delta)
  {
	if (isMyGodotFeatureFlagEnabled)
	{
	  Rotation += angularSpeed * (float) delta;
	}
  }
}
