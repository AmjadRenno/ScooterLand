using BlazorAppClientServer.Shared.Models;
using global::BlazorAppClientServer.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Server.Services
{
    public interface IMekanikerService
    {
        /// <summary>
        /// Retrieves all mechanics from the database.
        /// </summary>
        /// <returns>A list of all mechanics.</returns>
        Task<IEnumerable<Mekaniker>> GetAllMekanikers();

        /// <summary>
        /// Retrieves a single mechanic by their ID.
        /// </summary>
        /// <param name="mekanikerId">The ID of the mechanic.</param>
        /// <returns>The mechanic with the given ID, or null if not found.</returns>
        Task<Mekaniker> GetMekanikerById(int mekanikerId);

        /// <summary>
        /// Adds a new mechanic to the database.
        /// </summary>
        /// <param name="mekaniker">The mechanic to add.</param>
        /// <returns>The added mechanic.</returns>
        Task<Mekaniker> AddMekaniker(Mekaniker mekaniker);

        /// <summary>
        /// Updates an existing mechanic in the database.
        /// </summary>
        /// <param name="mekaniker">The mechanic with updated details.</param>
        /// <returns>True if the update was successful, otherwise false.</returns>
        Task<bool> UpdateMekaniker(Mekaniker mekaniker);

        /// <summary>
        /// Deletes a mechanic from the database by ID.
        /// </summary>
        /// <param name="mekanikerId">The ID of the mechanic to delete.</param>
        /// <returns>True if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteMekaniker(int mekanikerId);
    }
}
