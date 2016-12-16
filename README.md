# RuptureDecember2016

Rupture is a real-time strategy game of network management where the goal is to accumulate revenue to grow a business while managing internal corruption between bureaucrats. The player works to minimize the disparity between projected revenue and actual revenue.

Rules and Instructions:

1. Players must build offices and supply them with bureaucrats. Once an office is connected to a network with a path of supervision that returns to the main office (the first one present in the game), the bureacrats in that office will begin generating revenue that fills the player’s funds. Revenue-generating bureaucrats will periodically produce a green particle effect. Bureaucrats have levels that increase over time (this information is hidden from the player); the higher their level, the more revenue they generate.

2. Bureaucrats may become corrupt at random and attempt to distribute their illicit gains across their peer network, recruiting ever more bureaucrats into their conspiracy. The algorithm that determines this is based on the research of Romain Ferrali, PhD candidate in Politics at Princeton University. Indeed, demonstrating this research is the purpose of the game.

3. All bureaucrats can witness the behavior of their officemates and their supervisors; supervisors, indicated by the color blue, are special bureaucrats that can see both their officemates and the bureaucrats in offices whose network connection originates with their office.

4. Hold the mouse over an office for one second for a pop-up table indicating the office’s projected revenue (over the course of 60 seconds) and what its actual production is. Discrepancies may indicate that corruption is taking place.

5. The game screen area will darken in direct proportion to the proportion of the workforce that is corrupt. 

6. If you suspect that a bureaucrat is corrupt, enter Investigation mode and click on a bureaucrat to fire them. A cursory investigation removes the bureaucrat; a thorough investigation, which is many times more costly, will both remove the corrupt bureaucrat and recover all of the money they have stolen. If you choose to Investigate a bureaucrat that is actually clean, there are no consequences other than the waste of money.

7. To enter “Developer Mode” and have the states of the bureaucrats revealed, hit the space bar any time after 90 seconds have passed. Corrupt bureaucrats will be highlighted in red; corrupt supervisor nodes will be highlighted in magenta; and witnesses will be highlighted in green. If you hit the space bar before 90 seconds have passed, this will initiate the corruption process, too.

Good luck growing your business and keeping it clean!

For further detail, see our design document here.

Development Issues to be Resolved:

The game is currently in beta v2.0. Below is a list of known issues to be resolved :

1. Win and lose conditions are not coded into the game; it plays on an infinite loop until the program is closed.

1. Likewise, while the core gameplay and most UI features are complete, the game lacks all manner of usability features: there is no start screen, pause function, or exit screen.

2. The game does not prevent players from building offices too close together or even on top of each other. Be mindful of this when arranging your offices and networks.

3. Unlike other player actions, the cost of investigations does not pop up on screen when one is taken. 

4. Considering whether or not to display the levels of individual bureaucrats and their corresponding revenue-generation rates.

