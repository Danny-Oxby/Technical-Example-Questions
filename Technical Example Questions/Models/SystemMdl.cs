namespace Technical_Example_Questions.Models
{
    //Node for a binary tree, 
    public class SystemMdl
    {

        #region properties
        //nullable children << normally make readonly, but not here for later 0(1) space transposition
        public SystemMdl? LeftChild { get; private set; }
        public SystemMdl? RightChild { get; private set; }

        //in production the sets would be private with an internal method for updating, but unneeded for this example
        public SystemStates CurrentState { get; set; } = SystemStates.Offline;
        //public string LastMessage { get; set; } = string.Empty;
        #endregion

        /// <summary>
        /// Assign children to this node, assign null to non-existing children
        /// </summary>
        /// <param name="Left"> the left child object </param>
        /// <param name="Right"> the right child object </param>
        public void ModifyChildren(SystemMdl? Left, SystemMdl? Right)
        {
            LeftChild = Left;
            RightChild = Right;
        }
    }
}
