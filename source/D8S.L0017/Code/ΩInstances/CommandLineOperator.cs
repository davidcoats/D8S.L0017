using System;


namespace D8S.L0017
{
    public class CommandLineOperator : ICommandLineOperator
    {
        #region Infrastructure

        public static ICommandLineOperator Instance { get; } = new CommandLineOperator();


        private CommandLineOperator()
        {
        }

        #endregion
    }
}
