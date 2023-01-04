using SqlViewer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlViewer.Model
{
    public class Procedure
    {
        private readonly Lazy<IEnumerable<ProceduresParams>> proceduresParams;

        public Procedure()
        {
            proceduresParams = new Lazy<IEnumerable<ProceduresParams>>(() => RepositoryFactory.GetRepository().GetParams(this));
        }

        public IList<ProceduresParams> ProceduresParams
        {
            get => new List<ProceduresParams>(proceduresParams.Value);
        }

        public string Name { get; set; }
        public string Definition { get; set; }
        public Databases Databases { get; set; }

        public override string ToString() => Name;
    }
}
