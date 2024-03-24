using Builder.Models.EntityParts;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public interface IEnemyBuilder: IHumanoidEntityBuilder
    {
        public IEnemyBuilder SetEnemyListOfBadThingsDone(List<string> listOfThings);
    }
}
