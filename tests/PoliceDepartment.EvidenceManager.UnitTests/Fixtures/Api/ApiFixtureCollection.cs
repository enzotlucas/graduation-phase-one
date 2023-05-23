﻿namespace PoliceDepartment.EvidenceManager.UnitTests.Fixtures.Api
{
    [CollectionDefinition(nameof(ApiFixtureCollection))]
    public class ApiFixtureCollection : ICollectionFixture<ApiFixture> { }

    public class ApiFixture
    {
        public AuthorizationFixture Authorization { get; set; }

        public ApiFixture()
        {
            Authorization = new();
        }
    }
}
