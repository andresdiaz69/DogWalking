namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IWalkRepository
    {
        bool SaveWalk(Walk walk);

        List<Walk> GetAllWalks();

        Walk GetWalk(long walkId);

        bool UpdateWalk(Walk walk);

        bool DeleteWalk(Walk walk);
    }
}
