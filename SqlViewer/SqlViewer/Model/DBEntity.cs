using SqlViewer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlViewer.Model
{
    public class DBEntity
    {
        private readonly Lazy<IEnumerable<Column>> columns;

        public DBEntity()
        {
            columns = new Lazy<IEnumerable<Column>>(() => RepositoryFactory.GetRepository().GetDColumns(this));
        }

        public IList<Column> Columns
        {
            get => new List<Column>(columns.Value);
        }

        public string Schema { get; set; }
        public string Name { get; set; }
        public Databases Databases { get; set; }

        public override string ToString() => $"{Schema}.@{Name}";
    }
}
