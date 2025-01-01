using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace DeadCodeRemover
{
    internal class KnownTypesRepository : IKnownTypesRepository
    {
        private readonly Dictionary<string, string> allTypes = new Dictionary<string, string>();

        public KnownTypesRepository() { }

        public bool IsKnownType(INamedTypeSymbol type)
        {
            return type.Name == "TestClass";
        }

        public void LoadKnownTypes(string path) { }
    }
}
