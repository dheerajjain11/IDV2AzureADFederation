// <auto-generated />
namespace Thinktecture.IdentityServer.Core.Repositories.Migrations.SqlServer
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class StoredGrants : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(StoredGrants));
        
        string IMigrationMetadata.Id
        {
            get { return "201307221744463_StoredGrants"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
