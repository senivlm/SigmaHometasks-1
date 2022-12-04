using Hometask7.Implementations;
using Hometask2.Interfaces;

var problems = new List<IProblemSolver> { new Problem1Solver(), new Problem2Solver() };
foreach (var problem in problems) problem.Solve();