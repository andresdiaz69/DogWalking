namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.Entities;

    public interface IWalkService
    {
        bool SaveWalk(Walk walk);

        List<Walk> GetAllWalks();

        Walk GetWalk(long walkId);

        bool UpdateWalk(Walk walk);

        bool DeleteWalk(long walkId);
    }
}
