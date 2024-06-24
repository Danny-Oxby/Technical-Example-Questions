using Technical_Example_Questions.Models;

namespace Technical_Example_Questions.SupportingMethods
{
    public class GenerateBinaryTrees
    {

        #region properties
        //create root node
        private SystemMdl RootNode = new() { CurrentState = SystemStates.Active };

        //create the mid level nodes
        private SystemMdl Row1Right = new() { CurrentState = SystemStates.Active };
        private SystemMdl Row1Left = new() { CurrentState= SystemStates.Active };

        //create the bottom level nodes
        private SystemMdl Row2Rigth2 = new() { CurrentState = SystemStates.Partying };
        private SystemMdl Row2Left2 = new() { CurrentState = SystemStates.Sync };

        private SystemMdl Row2Right1 = new() { CurrentState = SystemStates.Sync };
        private SystemMdl Row2Left1 = new() { CurrentState = SystemStates.Partying };
        #endregion

        public SystemMdl GenerateSymetricalTree()
        {
            //I know these values are not null due to hardcoding the values hence the ! to remove the warnings
            RootNode.ModifyChildren(Row1Left!, Row1Right!);
            Row1Left!.ModifyChildren(Row2Left1!, Row2Right1!);
            Row1Right!.ModifyChildren(Row2Left2!, Row2Rigth2!);

            return RootNode;
        }

        public SystemMdl GenerateNonSymetricalTree()
        {
            //I know these values are not null due to hardcoding the values hence the ! to remove the warnings
            RootNode.ModifyChildren(Row1Left!, Row1Right);
            Row1Left!.ModifyChildren(Row2Left1!, Row2Right1!);
            Row1Right!.ModifyChildren(Row2Left2!, null);

            return RootNode;
        }
    }
}
