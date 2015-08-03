using System.Collections.Generic;

[System.Serializable]

/**
 * Data for the type of a building. Public variables are used for simplicity of serialization
 * but should not be modified directly.
 */ 
public class BuildingTypeData {
	
	public virtual string id {get; set;}						// Unique id of the building.
	public virtual string name {get; set;}						// Human readable name of the building.
	public virtual string description {get; set;}				// A human readable description of the building.
	public virtual string spriteName {get; set;}				// The name of the sprite used to represent this building.
	
	public virtual bool isObstacle {get; set;}					// If this is the true the building is an obstacle. It can't be built by players only cleared form the scene.
	public virtual bool isPath {get; set;}						// If this is the true the building is a path. It builds insantly and is handled by the Path Manager.

	public virtual int level {get; set;}						// Level required to build.

	public virtual int cost {get; set;}							// How many resources it costs to build this building. For obstacles the cost to clear.
	public virtual int buildTime {get; set;}					// How long in seconds it takes to build this building. For obstalces the time to clear.
	
	public virtual List<string> allowIds {get; set;}			// Ids of the buildings and units that this building allows.
	public virtual List<string> requireIds {get; set;}			// Ids of the buildings required before this building can be built.
	
	public virtual List<GridPosition> shape {get; set;}			// Shape of the building in the isometric grid.

	public virtual List<string> activities {get; set;}			// Types of activities this building allows.
	
	public virtual RewardType generationType {get; set;}		// Type of reward automatically generated by this building. Ignored if generation amount = 0. For obstacles this is reward type for clearing.
	public virtual int generationTime {get; set;}				// Time to generate the reward.			
	public virtual int generationAmount {get; set;}				// Amount of reward to generate each time interval. For obstacles this is reward amount for clearing.
	public virtual int generationStorage {get; set;}			// Maximum amount of generated reward to store in this building. Acknowledgement indicator will appear once this value is reached.
	
	public virtual int occupantStorage {get; set;}				// The space for holding occupants. Note that occupants size can be variable (for example a building could hold two tigers with a size of 1, but only one elephant whic has a size of 2).

	public virtual List<CustomResource> additionalCosts {get; set;}	// Additional resource costs for the building.
}