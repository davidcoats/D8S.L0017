using System;


namespace D8S.L0017
{
    public class Indices : IIndices
    {
        #region Infrastructure

        public static IIndices Instance { get; } = new Indices();


        private Indices()
        {
        }

        #endregion
    }
}
