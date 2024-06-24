using Technical_Example_Questions.Models;

namespace Technical_Example_Questions.Sections
{
    public static class TreeSymmetry
    {

        /// <summary>
        /// given the root of a tree find if it's components states are symmetrical
        /// </summary>
        /// <param name="Root"> the start of the tree </param>
        /// <returns> true if all systems states match their refelction </returns>
        public static bool IsTreeSymmetrical(SystemMdl Root)
        {
            return CompareStates(Root.LeftChild, Root.RightChild);
        }

        /// <summary>
        /// recursavily chech the state of each child in the tree
        /// </summary>
        /// <param name="LeftChild"></param>
        /// <param name="RightChild"></param>
        /// <returns> true if all child node states are matching </returns>
        private static bool CompareStates(SystemMdl? LeftChild, SystemMdl? RightChild)
        {
            //if both nodes are null return true
            //if both nodes have a matching value check child
            //if one node is null and the other isn't return false

            //if both are null return true
            if (LeftChild == null && RightChild == null) return true;

            //check values
            if (LeftChild != null && RightChild != null) //if both not null check values
                if(LeftChild.CurrentState == RightChild.CurrentState) //if both values match compare children
                    return CompareStates(LeftChild.LeftChild, RightChild.RightChild) &&
                            CompareStates(LeftChild.RightChild, RightChild.LeftChild);

            //if one is null and the other isn't return false
            return false;
        }
    }
}
