using Technical_Example_Questions.Models;

namespace Technical_Example_Questions.Sections
{
    public class STPathFinding
    {
        public List<TownMdl> Map { get; private set; }  // the map of the area to be searched
        private int MaxPathLength;  // the maxium distance to find a cinema in the map
        private List<TownMdl>? ShortestPath; // what is the path to the nearest cinema

        public STPathFinding()
        {
            Map = CreateAllTowns();
            AssignRoads(Map);
        }

        #region SetUpMethods
        //create a maps of all towns and their potential cinemas
        private static List<TownMdl> CreateAllTowns()
        {
            return new List<TownMdl> {
                new TownMdl("A1"),
                new TownMdl("A2"),
                new TownMdl("A3", true),
                new TownMdl("A4"),
                new TownMdl("B1"),
                new TownMdl("B2", true),
                new TownMdl("B3"),
                new TownMdl("B4"),
                new TownMdl("C1"),
                new TownMdl("C2"),
                new TownMdl("C3", true),
                new TownMdl("C4", true),
            };
            //return new List<TownMdl> {
            //    new TownMdl("A1"),
            //    new TownMdl("A2"),
            //    new TownMdl("A3", new CinemaMdl("Vue")),
            //    new TownMdl("A4"),
            //    new TownMdl("B1"),
            //    new TownMdl("B2", new CinemaMdl("Oden")),
            //    new TownMdl("B3"),
            //    new TownMdl("B4"),
            //    new TownMdl("C1"),
            //    new TownMdl("C2"),
            //    new TownMdl("C3", new CinemaMdl("Cin-e-World")),
            //    new TownMdl("C4", new CinemaMdl("Arts Center")),
            //};
        }
        private static void AssignRoads(List<TownMdl> Towns)
        {
            /*
             A1 - A2   A3 - A4
             |       \ |    |
             B1 - B2   B3   B4
             |  / |  /    \ |
             C1 - C2   C3 - C4
             */

            //Row A
            Towns[0].Roads.Add(new RoadMdl(Towns[1], 2)); //A1 > A2
            Towns[0].Roads.Add(new RoadMdl(Towns[4], 2)); //A1 > B1
            Towns[1].Roads.Add(new RoadMdl(Towns[0], 2)); //A2 > A1
            Towns[1].Roads.Add(new RoadMdl(Towns[6], 3)); //A2 > B3
            Towns[2].Roads.Add(new RoadMdl(Towns[3], 2)); //A3 > A4
            Towns[2].Roads.Add(new RoadMdl(Towns[6], 2)); //A3 > B3
            Towns[3].Roads.Add(new RoadMdl(Towns[2], 2)); //A4 > A3
            Towns[3].Roads.Add(new RoadMdl(Towns[7], 2)); //A4 > B4

            //Row B
            Towns[4].Roads.Add(new RoadMdl(Towns[0], 2)); //B1 > A1
            Towns[4].Roads.Add(new RoadMdl(Towns[5], 2)); //B1 > B2
            Towns[4].Roads.Add(new RoadMdl(Towns[8], 2)); //B1 > C1
            Towns[5].Roads.Add(new RoadMdl(Towns[4], 2)); //B2 > B1
            Towns[5].Roads.Add(new RoadMdl(Towns[8], 3)); //B2 > C1
            Towns[5].Roads.Add(new RoadMdl(Towns[9], 2)); //B2 > C2
            Towns[6].Roads.Add(new RoadMdl(Towns[1], 3)); //B3 > A2
            Towns[6].Roads.Add(new RoadMdl(Towns[2], 2)); //B3 > A3
            Towns[6].Roads.Add(new RoadMdl(Towns[9], 3)); //B3 > C2
            Towns[6].Roads.Add(new RoadMdl(Towns[11], 3)); //B3 > C4
            Towns[7].Roads.Add(new RoadMdl(Towns[3], 2)); //B4 > A4
            Towns[7].Roads.Add(new RoadMdl(Towns[11], 2)); //B4 > C4

            //Row C
            Towns[8].Roads.Add(new RoadMdl(Towns[4], 2)); //C1 > B1
            Towns[8].Roads.Add(new RoadMdl(Towns[5], 3)); //C1 > B2
            Towns[8].Roads.Add(new RoadMdl(Towns[9], 2)); //C1 > C2
            Towns[9].Roads.Add(new RoadMdl(Towns[5], 2)); //C2 > B2
            Towns[9].Roads.Add(new RoadMdl(Towns[6], 3)); //C2 > B3
            Towns[9].Roads.Add(new RoadMdl(Towns[8], 2)); //C2 > C1
            Towns[10].Roads.Add(new RoadMdl(Towns[11], 2)); //C3 > C4
            Towns[11].Roads.Add(new RoadMdl(Towns[6], 3)); //C4 > B3
            Towns[11].Roads.Add(new RoadMdl(Towns[7], 2)); //C4 > B4
            Towns[11].Roads.Add(new RoadMdl(Towns[10], 2)); //C4 > C3
        }
        #endregion

        public string FindNearestCinema(string startingTownName, int MaxExceptibleDistance = 99)
        {
            if (Map.Find(o => o.Name == startingTownName) == null)
                return "There is no town with that name";
            else 
            {
                MaxPathLength = MaxExceptibleDistance;
                SearchTownMap(Map.Find(o => o.Name == startingTownName), new List<TownMdl>());
                if (ShortestPath == null)
                    return "There is no town with a cinema within this distance";
                else
                    return "Your nearest Cinema is at : " + ShortestPath.Last().Name;
            }
        }

        /// <summary>
        /// Finds the nearest Town with a cinema itterativly
        /// </summary>
        /// <param name="CurrentPosition"> what town your currently in </param>
        /// <param name="CurrentPathLength"> how long the current path is </param>
        /// <param name="Visited"> the list of all visited towns to revents a circular search </param>
        /// <returns>The found town with a cinema or null if none is found</returns>
        private void SearchTownMap(TownMdl CurrentPosition, List<TownMdl> Visited, int CurrentPathLength = 0)
        {
            //add the current town to the visited list
            Visited.Add(CurrentPosition);

            //if a cinema is found in this town
            if (CurrentPosition.Cimema)
            {
                MaxPathLength = CurrentPathLength; //update the max path to now bw this length
                ShortestPath = new List<TownMdl>(Visited); //update the visited list
                return;
            }
            else //look for a new town
            {
                foreach(RoadMdl road in CurrentPosition.Roads)
                {
                    //if there is still more length to allot and the next town is unvisited
                    if (CurrentPathLength + road.Disatance < MaxPathLength && !Visited.Contains(road.ToTown)) {
                        SearchTownMap(road.ToTown, Visited, CurrentPathLength + road.Disatance);

                        //once the path have been checked remove this town of the checked list
                        Visited.Remove(road.ToTown);
                    }
                }
            }
        }

    }
}
