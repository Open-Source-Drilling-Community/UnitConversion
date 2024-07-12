using System.Net.Http.Headers;
using OSDC.UnitConversion.ModelShared;

namespace OSDC.UnitConversion.ServiceTest
{
    public class Tests
    {
        // testing outside Visual Studio requires using http port (https faces authentication issues both in console and on github)
        private static string host = "http://localhost:8080/";
        //private static string host = "https://localhost:44368/";
        //private static string host = "http://localhost:54949/";
        private static HttpClient httpClient;
        private static Client nSwagClient;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(host + "UnitConversion/api/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            nSwagClient = new Client(httpClient.BaseAddress.ToString(), httpClient);
        }

        [Test]
        public async Task Test_UnitConversionSet_Get()
        {
            #region post a UnitConversionSet
            Guid guid = Guid.NewGuid();
            MetaInfo metaInfo = new() { ID = guid };
            UnitConversionSet unitConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitConversionSet for Get",
                QuantityUnitConversionList = []
            };
            try
            {
                await nSwagClient.PostUnitConversionSetAsync(unitConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post given UnitConversionSet\n" + ex.Message);
            }
            #endregion

            #region GetAllUnitConversionSetId
            List<Guid> idList = [];
            try
            {
                idList = (List<Guid>)await nSwagClient.GetAllUnitConversionSetIdAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get all UnitConversionSet ids\n" + ex.Message);
            }
            Assert.That(idList, Is.Not.Null);
            Assert.That(idList, Does.Contain(guid));
            #endregion

            #region GetAllUnitConversionSetMetaInfo
            List<MetaInfo> metaInfoList = [];
            try
            {
                metaInfoList = (List<MetaInfo>)await nSwagClient.GetAllUnitConversionSetMetaInfoAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get all UnitConversionSet metainfos\n" + ex.Message);
            }
            Assert.That(metaInfoList, Is.Not.Null);
            IEnumerable<MetaInfo> metaInfoList2 =
                from elt in metaInfoList
                where elt.ID == guid
                select elt;
            Assert.That(metaInfoList2, Is.Not.Null);
            Assert.That(metaInfoList2, Is.Not.Empty);
            #endregion

            #region GetAllUnitConversionSetById
            UnitConversionSet? unitConversionSet2 = null;
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            #endregion


            #region GetAllUnitConversionSet
            List<UnitConversionSet> unitConversionSetList = new();
            try
            {
                unitConversionSetList = (List<UnitConversionSet>)await nSwagClient.GetAllUnitConversionSetAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the list of UnitConversionSet\n" + ex.Message);
            }
            Assert.That(unitConversionSetList, Is.Not.Null);
            IEnumerable<UnitConversionSet> unitConversionSetList2 =
                from elt in unitConversionSetList
                where elt.MetaInfo.ID == guid
                select elt;
            Assert.That(unitConversionSetList2, Is.Not.Null);
            Assert.That(unitConversionSetList2, Is.Not.Empty);
            #endregion

            #region finally delete the new ID
            unitConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitConversionSet_Post()
        {
            #region trying to post an empty guid
            Guid guid = Guid.Empty;
            MetaInfo metaInfo = new MetaInfo { ID = guid };
            UnitConversionSet unitConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitConversionSet for Post",
                QuantityUnitConversionList = []
            };
            UnitConversionSet? unitConversionSet2 = null;
            try
            {
                await nSwagClient.PostUnitConversionSetAsync(unitConversionSet);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(400));
                TestContext.WriteLine("Impossible to Post UnitConversionSet with empty Guid\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(Guid.Empty);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(400));
                TestContext.WriteLine("Impossible to Get UnitConversionSet identified by an empty Guid\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Null);
            #endregion

            #region post some corrupted data
            // post data with missing input that fails the calculation process
            #endregion

            #region posting a new ID in a valid state
            guid = Guid.NewGuid();
            metaInfo = new MetaInfo { ID = guid };
            unitConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitConversionSet for Post",
                QuantityUnitConversionList = []
            };
            try
            {
                await nSwagClient.PostUnitConversionSetAsync(unitConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitConversionSet although it is in a valid state\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            Assert.That(unitConversionSet2.Name, Is.EqualTo(unitConversionSet.Name));
            #endregion

            #region trying to repost the same ID
            unitConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitConversionSet for Post with modified name",
                QuantityUnitConversionList = []
            };
            bool conflict = false;
            try
            {
                await nSwagClient.PostUnitConversionSetAsync(unitConversionSet);
            }
            catch (ApiException ex)
            {
                conflict = true;
                Assert.That(ex.StatusCode, Is.EqualTo(409));
                TestContext.WriteLine("Impossible to Post existing UnitConversionSet\n" + ex.Message);
            }
            Assert.That(conflict, Is.True);
            #endregion

            #region finally delete the new ID
            unitConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitConversionSet_Put()
        {
            #region posting a new ID
            Guid guid = Guid.NewGuid();
            MetaInfo metaInfo = new MetaInfo { ID = guid };
            UnitConversionSet unitConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitConversionSet for Put",
                QuantityUnitConversionList = []
            };
            UnitConversionSet? unitConversionSet2 = null;
            try
            {
                await nSwagClient.PostUnitConversionSetAsync(unitConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitConversionSet\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            Assert.That(unitConversionSet2.Name, Is.EqualTo(unitConversionSet.Name));
            #endregion

            #region updating the new Id
            unitConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitConversionSet for Put with modified name",
                QuantityUnitConversionList = []
            };
            try
            {
                await nSwagClient.PutUnitConversionSetByIdAsync(unitConversionSet.MetaInfo.ID, unitConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Put UnitConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the updated UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            Assert.That(unitConversionSet2.Name, Is.EqualTo(unitConversionSet.Name));
            #endregion

            #region finally delete the new ID
            unitConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitConversionSet_Delete()
        {
            #region posting a new ID
            Guid guid = Guid.NewGuid();
            MetaInfo metaInfo = new MetaInfo { ID = guid };
            UnitConversionSet unitConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitConversionSet for Delete",
                QuantityUnitConversionList = []
            };
            UnitConversionSet? unitConversionSet2 = null;
            try
            {
                await nSwagClient.PostUnitConversionSetAsync(unitConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitConversionSet\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            #endregion

            #region finally delete the new ID
            unitConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitConversionSet2 = await nSwagClient.GetUnitConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystemConversionSet_Get()
        {
            #region post a UnitSystemConversionSet
            Guid guid = Guid.NewGuid();
            MetaInfo metaInfo = new MetaInfo { ID = guid };
            UnitSystemConversionSet unitSystemConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitSystemConversionSet for Get",
                UnitSystemInID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4"),
                UnitSystemOutID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769"),
                QuantityConversionList = []
            };
            try
            {
                await nSwagClient.PostUnitSystemConversionSetAsync(unitSystemConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post given UnitSystemConversionSet\n" + ex.Message);
            }
            #endregion

            #region GetAllUnitSystemConversionSetId
            List<Guid> idList = [];
            try
            {
                idList = (List<Guid>)await nSwagClient.GetAllUnitSystemConversionSetIdAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get all UnitSystemConversionSet ids\n" + ex.Message);
            }
            Assert.That(idList, Is.Not.Null);
            Assert.That(idList, Does.Contain(guid));
            #endregion

            #region GetAllUnitSystemConversionSetMetaInfo
            List<MetaInfo> metaInfoList = [];
            try
            {
                metaInfoList = (List<MetaInfo>)await nSwagClient.GetAllUnitSystemConversionSetMetaInfoAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get all UnitSystemConversionSet metainfos\n" + ex.Message);
            }
            Assert.That(metaInfoList, Is.Not.Null);
            IEnumerable<MetaInfo> metaInfoList2 =
                from elt in metaInfoList
                where elt.ID == guid
                select elt;
            Assert.That(metaInfoList2, Is.Not.Null);
            Assert.That(metaInfoList2, Is.Not.Empty);
            #endregion

            #region GetAllUnitSystemConversionSetById
            UnitSystemConversionSet? unitSystemConversionSet2 = null;
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            #endregion


            #region GetAllUnitSystemConversionSet
            List<UnitSystemConversionSet> unitSystemConversionSetList = new();
            try
            {
                unitSystemConversionSetList = (List<UnitSystemConversionSet>)await nSwagClient.GetAllUnitSystemConversionSetAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the list of UnitSystemConversionSet\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSetList, Is.Not.Null);
            IEnumerable<UnitSystemConversionSet> unitSystemConversionSetList2 =
                from elt in unitSystemConversionSetList
                where elt.MetaInfo.ID == guid
                select elt;
            Assert.That(unitSystemConversionSetList2, Is.Not.Null);
            Assert.That(unitSystemConversionSetList2, Is.Not.Empty);
            #endregion

            #region finally delete the new ID
            unitSystemConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystemConversionSet_Post()
        {
            #region trying to post an empty guid
            Guid guid = Guid.Empty;
            MetaInfo metaInfo = new MetaInfo { ID = guid };
            UnitSystemConversionSet unitSystemConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitSystemConversionSet for Post",
                UnitSystemInID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4"),
                UnitSystemOutID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769"),
                QuantityConversionList = []
            };
            UnitSystemConversionSet? unitSystemConversionSet2 = null;
            try
            {
                await nSwagClient.PostUnitSystemConversionSetAsync(unitSystemConversionSet);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(400));
                TestContext.WriteLine("Impossible to Post UnitSystemConversionSet with empty Guid\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(Guid.Empty);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(400));
                TestContext.WriteLine("Impossible to Get UnitSystemConversionSet identified by an empty Guid\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Null);
            #endregion

            #region post some corrupted data
            // post data with missing input that fails the calculation process
            #endregion

            #region posting a new ID in a valid state
            guid = Guid.NewGuid();
            metaInfo = new MetaInfo { ID = guid };
            unitSystemConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitSystemConversionSet for Post",
                UnitSystemInID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4"),
                UnitSystemOutID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769"),
                QuantityConversionList = []
            };
            try
            {
                await nSwagClient.PostUnitSystemConversionSetAsync(unitSystemConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitSystemConversionSet although it is in a valid state\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            Assert.That(unitSystemConversionSet2.Name, Is.EqualTo(unitSystemConversionSet.Name));
            #endregion

            #region trying to repost the same ID
            unitSystemConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitSystemConversionSet for Post with modified name",
                UnitSystemInID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4"),
                UnitSystemOutID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769"),
                QuantityConversionList = []
            };
            bool conflict = false;
            try
            {
                await nSwagClient.PostUnitSystemConversionSetAsync(unitSystemConversionSet);
            }
            catch (ApiException ex)
            {
                conflict = true;
                Assert.That(ex.StatusCode, Is.EqualTo(409));
                TestContext.WriteLine("Impossible to Post existing UnitSystemConversionSet\n" + ex.Message);
            }
            Assert.That(conflict, Is.True);
            #endregion

            #region finally delete the new ID
            unitSystemConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystemConversionSet_Put()
        {
            #region posting a new ID
            Guid guid = Guid.NewGuid();
            MetaInfo metaInfo = new MetaInfo { ID = guid };
            UnitSystemConversionSet unitSystemConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitSystemConversionSet for Put",
                UnitSystemInID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4"),
                UnitSystemOutID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769"),
                QuantityConversionList = []
            };
            UnitSystemConversionSet? unitSystemConversionSet2 = null;
            try
            {
                await nSwagClient.PostUnitSystemConversionSetAsync(unitSystemConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitSystemConversionSet\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            Assert.That(unitSystemConversionSet2.Name, Is.EqualTo(unitSystemConversionSet.Name));
            #endregion

            #region updating the new Id
            unitSystemConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitSystemConversionSet for Put with modified name",
                UnitSystemInID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4"),
                UnitSystemOutID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769"),
                QuantityConversionList = []
            };
            try
            {
                await nSwagClient.PutUnitSystemConversionSetByIdAsync(unitSystemConversionSet.MetaInfo.ID, unitSystemConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Put UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the updated UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            Assert.That(unitSystemConversionSet2.Name, Is.EqualTo(unitSystemConversionSet.Name));
            #endregion

            #region finally delete the new ID
            unitSystemConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystemConversionSet_Delete()
        {
            #region posting a new ID
            Guid guid = Guid.NewGuid();
            MetaInfo metaInfo = new MetaInfo { ID = guid };
            UnitSystemConversionSet unitSystemConversionSet = new()
            {
                MetaInfo = metaInfo,
                Name = "My test UnitSystemConversionSet for Delete",
                UnitSystemInID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4"),
                UnitSystemOutID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769"),
                QuantityConversionList = []
            };
            UnitSystemConversionSet? unitSystemConversionSet2 = null;
            try
            {
                await nSwagClient.PostUnitSystemConversionSetAsync(unitSystemConversionSet);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitSystemConversionSet\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo, Is.Not.Null);
            Assert.That(unitSystemConversionSet2.MetaInfo.ID, Is.EqualTo(guid));
            #endregion

            #region finally delete the new ID
            unitSystemConversionSet2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            try
            {
                unitSystemConversionSet2 = await nSwagClient.GetUnitSystemConversionSetByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitSystemConversionSet of given Id\n" + ex.Message);
            }
            Assert.That(unitSystemConversionSet2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystem_Get()
        {
            #region post a UnitSystem
            Guid guid = Guid.NewGuid();
            UnitSystem unitSystem = new()
            {
                ID = guid,
                Name = "My test UnitSystem for Get",
                IsDefault = false,
                IsSI = false
            };
            try
            {
                await nSwagClient.PostUnitSystemAsync(unitSystem);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post given UnitSystem\n" + ex.Message);
            }
            #endregion

            #region GetAllUnitSystemId
            List<Guid> idList = [];
            try
            {
                idList = (List<Guid>)await nSwagClient.GetAllUnitSystemIdAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get all UnitSystem ids\n" + ex.Message);
            }
            Assert.That(idList, Is.Not.Null);
            Assert.That(idList, Does.Contain(guid));
            #endregion

            #region GetAllUnitSystemById
            UnitSystem? unitSystem2 = null;
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Not.Null);
            Assert.That(unitSystem2.ID, Is.EqualTo(guid));
            #endregion

            #region GetAllUnitSystem
            List<UnitSystem> unitSystemList = [];
            try
            {
                unitSystemList = (List<UnitSystem>)await nSwagClient.GetAllUnitSystemAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the list of UnitSystem\n" + ex.Message);
            }
            Assert.That(unitSystemList, Is.Not.Null);
            IEnumerable<UnitSystem> unitSystemList2 =
                from elt in unitSystemList
                where elt.ID == guid
                select elt;
            Assert.That(unitSystemList2, Is.Not.Null);
            Assert.That(unitSystemList2, Is.Not.Empty);
            #endregion

            #region GetAllUnitSystemLight
            List<UnitSystemLight> unitSystemLightList = [];
            try
            {
                unitSystemLightList = (List<UnitSystemLight>)await nSwagClient.GetAllUnitSystemLightAsync();
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the list of UnitSystemLight\n" + ex.Message);
            }
            Assert.That(unitSystemLightList, Is.Not.Null);
            Assert.That(unitSystemLightList, Is.Not.Empty);
            IEnumerable<UnitSystemLight> unitSystemLightList2 =
                from elt in unitSystemLightList
                where elt.Name == unitSystem.Name
                select elt;
            Assert.That(unitSystemLightList2, Is.Not.Null);
            Assert.That(unitSystemLightList2, Is.Not.Empty);
            #endregion

            #region finally delete the new ID
            unitSystem2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystem of given Id\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystem_Post()
        {
            #region trying to post an empty guid
            Guid guid = Guid.Empty;
            UnitSystem unitSystem = new()
            {
                ID = guid,
                Name = "My test UnitSystem for Post",
                IsDefault = false,
                IsSI = false
            };
            UnitSystem? unitSystem2 = null;
            try
            {
                await nSwagClient.PostUnitSystemAsync(unitSystem);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(400));
                TestContext.WriteLine("Impossible to Post UnitSystem with empty Guid\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(Guid.Empty);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(400));
                TestContext.WriteLine("Impossible to Get UnitSystem identified by an empty Guid\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Null);
            #endregion

            #region post some corrupted data
            // post data with missing input that fails the calculation process
            #endregion

            #region posting a new ID in a valid state
            guid = Guid.NewGuid();
            unitSystem = new()
            {
                ID = guid,
                Name = "My test UnitSystem for Post",
                IsDefault = false,
                IsSI = false
            };
            try
            {
                await nSwagClient.PostUnitSystemAsync(unitSystem);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitSystem although it is in a valid state\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Not.Null);
            Assert.That(unitSystem2.ID, Is.EqualTo(guid));
            Assert.That(unitSystem2.Name, Is.EqualTo(unitSystem.Name));
            #endregion

            #region trying to repost the same ID
            unitSystem = new()
            {
                ID = guid,
                Name = "My test UnitSystem for Post with modified name",
                IsDefault = false,
                IsSI = false
            };
            bool conflict = false;
            try
            {
                await nSwagClient.PostUnitSystemAsync(unitSystem);
            }
            catch (ApiException ex)
            {
                conflict = true;
                Assert.That(ex.StatusCode, Is.EqualTo(409));
                TestContext.WriteLine("Impossible to Post existing UnitSystem\n" + ex.Message);
            }
            Assert.That(conflict, Is.True);
            #endregion

            #region finally delete the new ID
            unitSystem2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystem of given Id\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystem_Put()
        {
            #region posting a new ID
            Guid guid = Guid.NewGuid();
            UnitSystem unitSystem = new()
            {
                ID = guid,
                Name = "My test UnitSystem for Put",
                IsDefault = false,
                IsSI = false
            };
            UnitSystem? unitSystem2 = null;
            try
            {
                await nSwagClient.PostUnitSystemAsync(unitSystem);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitSystem\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Not.Null);
            Assert.That(unitSystem2.ID, Is.EqualTo(guid));
            Assert.That(unitSystem2.Name, Is.EqualTo(unitSystem.Name));
            #endregion

            #region updating the new Id
            unitSystem = new()
            {
                ID = guid,
                Name = "My test UnitSystem for Put with modified name",
                IsDefault = false,
                IsSI = false
            };
            try
            {
                await nSwagClient.PutUnitSystemByIdAsync(unitSystem.ID, unitSystem);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Put UnitSystem of given Id\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the updated UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Not.Null);
            Assert.That(unitSystem2.ID, Is.EqualTo(guid));
            Assert.That(unitSystem2.Name, Is.EqualTo(unitSystem.Name));
            #endregion

            #region finally delete the new ID
            unitSystem2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystem of given Id\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Null);
            #endregion
        }

        [Test]
        public async Task Test_UnitSystem_Delete()
        {
            #region posting a new ID
            Guid guid = Guid.NewGuid();
            UnitSystem unitSystem = new()
            {
                ID = guid,
                Name = "My test UnitSystem for delete",
                IsDefault = false,
                IsSI = false
            };
            UnitSystem? unitSystem2 = null;
            try
            {
                await nSwagClient.PostUnitSystemAsync(unitSystem);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Post UnitSystem\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Get the UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Not.Null);
            Assert.That(unitSystem2.ID, Is.EqualTo(guid));
            #endregion

            #region finally delete the new ID
            unitSystem2 = null;
            try
            {
                await nSwagClient.DeleteUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                TestContext.WriteLine("Impossible to Delete UnitSystem of given Id\n" + ex.Message);
            }
            try
            {
                unitSystem2 = await nSwagClient.GetUnitSystemByIdAsync(guid);
            }
            catch (ApiException ex)
            {
                Assert.That(ex.StatusCode, Is.EqualTo(404));
                TestContext.WriteLine("Impossible to Get deleted UnitSystem of given Id\n" + ex.Message);
            }
            Assert.That(unitSystem2, Is.Null);
            #endregion
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            httpClient?.Dispose();
        }
    }
}