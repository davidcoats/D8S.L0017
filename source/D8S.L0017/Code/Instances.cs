using System;


namespace D8S.L0017
{
    public static class Instances
    {
        public static ICharacters Characters => L0017.Characters.Instance;
        public static IIndexOperator IndexOperator => L0017.IndexOperator.Instance;
        public static IIndices Indices => L0017.Indices.Instance;
        public static IStrings Strings => L0017.Strings.Instance;
        public static IValues Values => L0017.Values.Instance;
    }
}