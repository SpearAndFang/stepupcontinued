using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace stepupcontinued
{
    public class stepupcontinuedModSystem : ModSystem
    {
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.World.Logger.Event("started 'StepUp (continued)' mod");
        }


        public override void StartClientSide(ICoreClientAPI api)
        {
            api.Event.PlayerEntitySpawn += player => player.Entity.GetBehavior<EntityBehaviorControlledPhysics>().StepHeight = 1.2F;
        }
    }
}