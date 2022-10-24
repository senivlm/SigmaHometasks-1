using Hometask2;
using Hometask2.Implementations;
using Hometask2.Interfaces;

IProblemSolver problem1 = new Problem1Solver();
IProblemSolver problem2 = new Problem2Solver();

problem1.Solve();
problem2.Solve();