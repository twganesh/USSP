using SLB.USSP.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Data.EntityClient;
using System.Data.Common;
using Devart.Data.Oracle;


namespace SLB.USSP.Repository
{
    /// <summary>
    /// http://dotnetspeak.com/2012/01/oracle-odp-and-entity-framework-code-first-4-2
    /// </summary>
    public class GCRCContext : DbContext
    {
        private readonly string _schemaName;
        private static string _connectionstring;

        public GCRCContext(string connStrName, string schemaName, int cmdTimeout)
            : base(GetConnection(),false)


          
        {
            _schemaName = schemaName;
                _connectionstring = connStrName;

            ///must be the last line to run so that the above varaiables are set correctly
            //((IObjectContextAdapter)this).ObjectContext.CommandTimeout = cmdTimeout;
            ((IObjectContextAdapter)this).ObjectContext.Connection.Open();
        }

        private static DbConnection GetConnection()
        {

            //EntityConnectionStringBuilder ecsb = new EntityConnectionStringBuilder();
            // ecsb.Provider = "Devart.Data.Oracle";
            // //ecsb.Metadata = "None"; // required
            // ecsb.ProviderConnectionString = _connectionstring;
            // EntityConnection conn = new EntityConnection(ecsb.ToString());
            // return conn;
            Devart.Data.Oracle.OracleConnection myConnection = null;

            try
            {

                Devart.Data.Oracle.OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
                oraCSB.Direct = true;
                oraCSB.Server = "nlxs1012.slb.atosorigin-asp.com";
                oraCSB.Port = 1521;
                oraCSB.Sid = "DGRC";
                oraCSB.UserId = "WERCS";
                oraCSB.Password = "Chem4all";
                myConnection = new Devart.Data.Oracle.OracleConnection(oraCSB.ConnectionString);
              //  myConnection.Open();


            }
            catch (Exception)
            {

                throw;
            }
            return myConnection;


        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ColumnTypeCasingConvention>();
            #region Tables
      
            MapEntityToTable<PickList>(modelBuilder, _schemaName);
            MapEntityToTable<TProdData>(modelBuilder, _schemaName);
            MapEntityToTable<WsseDotShip>(modelBuilder, _schemaName);
            MapEntityToTable<WsseMatShip>(modelBuilder, _schemaName);
            MapEntityToTable<WsseRadConfig>(modelBuilder, _schemaName);
            MapEntityToTable<WsseRadDetails>(modelBuilder, _schemaName);
            MapEntityToTable<WsseRadLabels>(modelBuilder, _schemaName);
            MapEntityToTable<WsseRadShip>(modelBuilder, _schemaName);
            MapEntityToTable<WsseShip>(modelBuilder, _schemaName);
            MapEntityToTable<WsseTMSProducts>(modelBuilder, _schemaName);
            MapEntityToTable<WsseUser>(modelBuilder, _schemaName);
            #endregion Tables

            #region Views                                                                      
            #endregion Views
        }

        #region DBSets Declarations

        #region Entities
                           
               
        public DbSet<PickList> PickList { get; set; }
        public DbSet<TProdData> TProdData { get; set; }
        public DbSet<WsseDotShip> WsseDotShip { get; set; }
        public DbSet<WsseMatShip> WsseMatShip { get; set; }
        public DbSet<WsseRadConfig> WsseRadConfig { get; set; }
        public DbSet<WsseRadDetails> WsseRadDetails { get; set; }
        public DbSet<WsseRadLabels> WsseRadLabels { get; set; }
        public DbSet<WsseRadShip> WsseRadShip { get; set; }
        public DbSet<WsseShip> WsseShip { get; set; }
        public DbSet<WsseTMSProducts> WsseTMSProducts { get; set; }
        public DbSet<WsseUser> WsseUser { get; set; }


        #endregion

        #region Views                                               

        // public DbSet<DocumentData> DocumentDatas { get; set; }//Amruta

        #endregion

        #region Relationships
        #endregion


        #endregion

        public int SaveChanges(string userName)
        {
            #region set creation time stamp

            var addedEntities = from e in ChangeTracker.Entries()
                                where e.State == EntityState.Added
                                select e;

            //foreach (var e in addedEntities)
            //{
            //    var entity = e.Entity as TimeStampedEntity;
            //    if (entity != null)
            //    {
            //        entity.CreateBy = userName;
            //        entity.CreateDate = DateTime.Now;
            //    }
            //}

            #endregion

            #region set modify time stamp

            var updatedEntities = from e in ChangeTracker.Entries()
                                  where e.State == EntityState.Modified
                                  select e;

            //foreach (var e in updatedEntities)
            //{
            //    var entity = e.Entity as TimeStampedEntity;
            //    if (entity != null)
            //    {
            //        entity.UpdateBy = userName;
            //        entity.UpdateDate = DateTime.Now;
            //    }
            //}

            #endregion
            return base.SaveChanges();
        }

        private static void MapEntityToTable<T>(DbModelBuilder modelBuilder, string schemaName) where T: class
        {
            var t = typeof(T);
            // Get instance of the attribute.
            var tableAttr = (TableAttribute)Attribute.GetCustomAttribute(t, typeof(TableAttribute));

            if (tableAttr == null)
            {
                throw new ArgumentNullException("Table attribute is missing from type {0}", t.AssemblyQualifiedName);
            }

            var name = tableAttr.Name;

            ///http://social.msdn.microsoft.com/Forums/en-US/fe6b6749-671e-4b31-8892-b78e3ca4b317/mvc-4-connecting-to-oracle-using-code-first
            modelBuilder.Entity<T>().ToTable(name, schemaName);
        }
    }
}
