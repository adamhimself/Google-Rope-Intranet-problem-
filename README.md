# Google-Rope-Intranet-problem-
####Google Code Jam - Round 1C 2010 - Problem A. Rope Intranet

###The Problem

A company is located in two very tall buildings. The company intranet connecting the buildings consists of many wires, each connecting a window on the first building to a window on the second building.

You are looking at those buildings from the side, so that one of the buildings is to the left and one is to the right. The windows on the left building are seen as points on its right wall, and the windows on the right building are seen as points on its left wall. Wires are straight segments connecting a window on the left building to a window on the right building.

<img src="https://code.google.com/codejam/contest/images/?image=RopeIntranet.png&p=599117&c=619102" /img>

You've noticed that no two wires share an endpoint (in other words, there's at most one wire going out of each window). However, from your viewpoint, some of the wires intersect midway. You've also noticed that exactly two wires meet at each intersection point.

On the above picture, the intersection points are the black circles, while the windows are the white circles.

How many intersection points do you see?

###My Solution

The purpose of the program.cs is to take an input file of '.in' filetype containing lines of strings pertaining to the number of test cases, number of ropes per case, and the position values of every rope. The program adds the rope values to a List<int> object to allow a private method to iterate through all the values, determining intersections using appropriate logic. The results of the findings are then written to a output.txt file. This code performs for both the small and large dataset input files provided by google code jam simply by changing the input filepath.
