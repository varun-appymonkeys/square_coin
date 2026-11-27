A. Initial Setup
	- Create a fresh Unity 3D Project
	- Import some free assets from Asset Store
		- A coin asset 
		- Some sound asset for spawning and despawning and collision
		
B. Rotator 
	- Create a scene called RotatorDemo
	- Create a script called Rotator
		- this script when attached to a gameObject needs to rotate the object at a particular speed in one or more axis
		- The script should have the ability to perform an action once the rotation is complete. 
		- Bonus: an ability to continiously rotate an object 
			- You are free to assume/implement how the action is called on a rotation complete.
	- Place an Object of choice in the Scene 
	- Demonstrate all the abilities of the Rotator. 
	- Review with Pratik 

C. Coin Demo - I 
	- Create a new scene called CoinDemo
	- Create a script called Coin. The coin posses the following behaviour
		- Should react to gravity 
		- Should collide to the ground 
		- Sound on Spawn 
		- Sound on colliding to the Ground 
		- Sound on despawning 
		- On mouse clicking on the coin, make the coin despawn 
		- Bonus: Coins should repel eachother at a particular force if they collide with each other 
	- Create a CoinSpawner Script, this script needs to spawn coins from a particular point. 
	- Create a Ui button that says Start 
		- Clicking on this button should spawn the coins
	- Review with Pratik 
	
D. Coin Demo - II 
	- Expand the CoinSpawner to spawn X number of coins in random locations in an area. 
		- There should be delay between spawning coins 
	- Expand the coin and associate a value to it. 
		- For example: 1 coin is 2 points, so 50 coins = 100 points. 
	- Expand the Ui and add a Text that says "Points"
		- On mouse click on the coin, the coin should disappear and the Points should be recorded and displayed. 
	- Review with Pratik 

E. Coin + Timer 
	- Create a script called Timer 
		- the timer script should have the ability to start a countdown. 
		- once the time is up, it should fire an event 
	- Add an Ui that displays the timer. 
	- Everything up until D should work with the Timer 
	- Once the Time is Up, stop the game. 
		- The points freeze 
		- Mouse doesn't do anything 
		
F. Scene Traversal 
	- Create an empty scene called MainMenu 
	- Add a button that says "Play" 
	- On clicking play, it should load the CoinDemo Scene 
	- Once the Time is up, after playing the game once. 
	- Show a panel with Points in the middle of the screen and a button called "MainMenu" 
	- On Clicking "MainMenu" take the player back to MainMenu Scene 
	- Bonus: Add a Loading screen between the loads
