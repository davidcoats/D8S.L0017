using System;


namespace D8S.L0017
{
    public class IndexOperator : IIndexOperator
    {
        #region Infrastructure

        public static IIndexOperator Instance { get; } = new IndexOperator();


        private IndexOperator()
        {
        }

        #endregion
    }
}
