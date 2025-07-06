namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.Entities;

    public interface IWalkService
    {
        /// <summary>
        /// Saves the walk.
        /// </summary>
        /// <param name="walk">The walk.</param>
        /// <returns>True = walk saved ok</returns>
        bool SaveWalk(Walk walk);

        /// <summary>
        /// Gets all walks.
        /// </summary>
        /// <returns></returns>
        List<Walk> GetAllWalks();

        /// <summary>
        /// Gets the walk.
        /// </summary>
        /// <param name="walkId">The walk identifier.</param>
        /// <returns>Walk found</returns>
        Walk GetWalk(long walkId);

        /// <summary>
        /// Updates the walk.
        /// </summary>
        /// <param name="walk">The walk.</param>
        /// <returns>True = walk updated ok</returns>
        bool UpdateWalk(Walk walk);

        /// <summary>
        /// Deletes the walk.
        /// </summary>
        /// <param name="walkId">The walk identifier.</param>
        /// <returns>True = walk deleted ok</returns>
        bool DeleteWalk(long walkId);
    }
}
