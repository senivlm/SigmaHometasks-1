using Hometask2.Implementations;
using Hometask2.Interfaces;
// не стандартна подача, але є нюанси з реалізацією. Уточню усно.
var problems = new List<IProblemSolver> { new Problem1Solver(), new Problem2Solver() };
foreach (var problem in problems) problem.Solve();
