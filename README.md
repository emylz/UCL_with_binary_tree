# UCL_with_binary_tree

# Project ADSA : 

# Presentation

This project has been created by YALAZ Emin, SCHOESER Matthieu and SY Xavier, students from ESILV.


Our project is to develop a football match game that run automatically. We were inspired of
Champion's League team to create the algorithm. You have the choice between select each teams 
among 40 or to randomly choose the teams.

The system works like Champion's league system. There are 8 pool with 4 teams in each pool then
we pass to the eight of final next the quarter final, the semi final and the final.

We wrote a JSON File to stock the 40 teams with 5 parameters.Their name, their attack, defense,
the teamcohesion, the country and the UEFA coefficient.

# The algorithm

Like we said earlier, we needed to define what a team would be made of. We choose to add five 
different attributes: attack, defense, teamcohesion, a coefficient and the country. Those attributes
are variating depending on the team.

Then, we've created pools and matches. Each pool is form of a list of 4 teams and a match of 2 (for
obvious reasons). Depending on the attack and the teamcohesion we'll decide at random which team will
attack first, second and so on. We then decide if a goal is scored according to the defense of the 
opposing team. In the end, we'll end up with either a win, a loss or a draw.

We've also created a tournament class which is made of a list of 8 pools and 4 "hats" in order to do
the random picking. During the random picking of the teams, we made it so 2 teams of the same country
cannot be affected to the same pool. Also, the teams are sorted before being affected to a particular
hat. They are sorted according to their coefficient, the eighth first teams being affected to the 
first hat and so on.

Because we're mimicing the Champion's League, at the end of each match during the "pool phase" we're
assigning points, goals etc to the different teams.

Now, we'll proceed to the explanation of the "final phase". First, we're creating a binary tree with 
a height of 4. Each node of this tree correponds to a match. The 8 leaves of our tree are filled with 
matches. Then, the winners of each match are "climbing" the tree till the end (the root of our binary 
tree) where we can finally define an "ultimate" winner (the winner of the final match).

# The interface

The interface of our project is pretty simple. We're starting with an homepage which let the user 
choose between selecting the teams manually or at random.

If the user selects the random option, we'll create the different pools and select the teams at random
using and reading a json file we've created. He will also be directed to a page displaying the pools
created.

If the user selects to add the teams manually to the tournament, he will be directed to a team
selecting screen where he will be able to choose 32 teams within the 40 available on the page. Also,
once a team is chosen the area covering the selected team is shaded and this specifical team won't 
be able to be selected again.

In between the final phase and the selections of the teams we're displaying the pools sorted in terms
of wins and losses in order to retrieve the teams that would participate to the final phase of the
tournament.

Finally, we're displaying a wallchart showing the final phase of the tournament.
