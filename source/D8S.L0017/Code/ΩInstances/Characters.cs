using System;


namespace D8S.L0017
{
    public class Characters : ICharacters
    {
        #region Infrastructure

        public static ICharacters Instance { get; } = new Characters();


        private Characters()
        {
        }

        #endregion
    }
}
