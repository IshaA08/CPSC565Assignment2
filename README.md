# Quidditch Simulation
Student Name: Isha Afzaal (UCID 30016250)

Course: CPSC 565 - Emergent Computing

Date: February 26th, 2021

Made using Unity 3D, this project repository contains a simple Quidditch match simulation from the Harry Potter series.
The simplified version of the game involves two teams (Gryffindors vs. Slytherin) of five players to compete in catching the golden snitch.
Players gain one point for catching the snitch, and two points for consecutive catches.

# Implementation Details

Camera Control: In play mode, the camera can be moved using the space (jump or move up), up, down, left and right keys.

Basic Text UI: Created using TextMeshPro

Snitch Movement: The snitch randomly glides throughout the set field boundaries. Attracts players

Players: Agents that are compelled by two forces - attraction to catch the snitch and repulsion from tackling other players or the terrain. Players have specific traits such as mass and velocity and can become unconcious if tackled by others or bumping into terrain. Once unconcious, players become affected by gravity, fall and respawn in their team's start location after a cooldown time.



