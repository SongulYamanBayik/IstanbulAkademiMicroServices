﻿namespace AkademiECommerce.Services.Catalog.Settings
{
    public class DatabaseSettings:IDatabaseSettings
    {
        public string ProductCollectionName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string ConnecitonString { get; set; }
        public string DatabaseName { get; set; }
    }
}
