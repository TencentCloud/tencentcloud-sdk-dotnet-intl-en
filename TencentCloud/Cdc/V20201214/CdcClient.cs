/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdc.V20201214
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdc.V20201214.Models;

   public class CdcClient : AbstractClient{

       private const string endpoint = "cdc.tencentcloudapi.com";
       private const string version = "2020-12-14";
       private const string sdkVersion = "SDK_NET_3.0.1042";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a CDC.
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterResponse"/></returns>
        public Task<CreateDedicatedClusterResponse> CreateDedicatedCluster(CreateDedicatedClusterRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterResponse>(req, "CreateDedicatedCluster");
        }

        /// <summary>
        /// This API is used to create a CDC.
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterResponse"/></returns>
        public CreateDedicatedClusterResponse CreateDedicatedClusterSync(CreateDedicatedClusterRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterResponse>(req, "CreateDedicatedCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CDC order.
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterOrderRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterOrderResponse"/></returns>
        public Task<CreateDedicatedClusterOrderResponse> CreateDedicatedClusterOrder(CreateDedicatedClusterOrderRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterOrderResponse>(req, "CreateDedicatedClusterOrder");
        }

        /// <summary>
        /// This API is used to create a CDC order.
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterOrderRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterOrderResponse"/></returns>
        public CreateDedicatedClusterOrderResponse CreateDedicatedClusterOrderSync(CreateDedicatedClusterOrderRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterOrderResponse>(req, "CreateDedicatedClusterOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a site.
        /// </summary>
        /// <param name="req"><see cref="CreateSiteRequest"/></param>
        /// <returns><see cref="CreateSiteResponse"/></returns>
        public Task<CreateSiteResponse> CreateSite(CreateSiteRequest req)
        {
            return InternalRequestAsync<CreateSiteResponse>(req, "CreateSite");
        }

        /// <summary>
        /// This API is used to create a site.
        /// </summary>
        /// <param name="req"><see cref="CreateSiteRequest"/></param>
        /// <returns><see cref="CreateSiteResponse"/></returns>
        public CreateSiteResponse CreateSiteSync(CreateSiteRequest req)
        {
            return InternalRequestAsync<CreateSiteResponse>(req, "CreateSite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CDC.
        /// </summary>
        /// <param name="req"><see cref="DeleteDedicatedClustersRequest"/></param>
        /// <returns><see cref="DeleteDedicatedClustersResponse"/></returns>
        public Task<DeleteDedicatedClustersResponse> DeleteDedicatedClusters(DeleteDedicatedClustersRequest req)
        {
            return InternalRequestAsync<DeleteDedicatedClustersResponse>(req, "DeleteDedicatedClusters");
        }

        /// <summary>
        /// This API is used to delete a CDC.
        /// </summary>
        /// <param name="req"><see cref="DeleteDedicatedClustersRequest"/></param>
        /// <returns><see cref="DeleteDedicatedClustersResponse"/></returns>
        public DeleteDedicatedClustersResponse DeleteDedicatedClustersSync(DeleteDedicatedClustersRequest req)
        {
            return InternalRequestAsync<DeleteDedicatedClustersResponse>(req, "DeleteDedicatedClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteSitesRequest"/></param>
        /// <returns><see cref="DeleteSitesResponse"/></returns>
        public Task<DeleteSitesResponse> DeleteSites(DeleteSitesRequest req)
        {
            return InternalRequestAsync<DeleteSitesResponse>(req, "DeleteSites");
        }

        /// <summary>
        /// This API is used to delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteSitesRequest"/></param>
        /// <returns><see cref="DeleteSitesResponse"/></returns>
        public DeleteSitesResponse DeleteSitesSync(DeleteSitesRequest req)
        {
            return InternalRequestAsync<DeleteSitesResponse>(req, "DeleteSites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Cloud Object Storage (COS) capacity of the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterCosCapacityRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterCosCapacityResponse"/></returns>
        public Task<DescribeDedicatedClusterCosCapacityResponse> DescribeDedicatedClusterCosCapacity(DescribeDedicatedClusterCosCapacityRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterCosCapacityResponse>(req, "DescribeDedicatedClusterCosCapacity");
        }

        /// <summary>
        /// This API is used to query the Cloud Object Storage (COS) capacity of the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterCosCapacityRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterCosCapacityResponse"/></returns>
        public DescribeDedicatedClusterCosCapacityResponse DescribeDedicatedClusterCosCapacitySync(DescribeDedicatedClusterCosCapacityRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterCosCapacityResponse>(req, "DescribeDedicatedClusterCosCapacity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the statistic information of the host in the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostStatisticsResponse"/></returns>
        public Task<DescribeDedicatedClusterHostStatisticsResponse> DescribeDedicatedClusterHostStatistics(DescribeDedicatedClusterHostStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterHostStatisticsResponse>(req, "DescribeDedicatedClusterHostStatistics");
        }

        /// <summary>
        /// This API is used to query the statistic information of the host in the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostStatisticsResponse"/></returns>
        public DescribeDedicatedClusterHostStatisticsResponse DescribeDedicatedClusterHostStatisticsSync(DescribeDedicatedClusterHostStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterHostStatisticsResponse>(req, "DescribeDedicatedClusterHostStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query host information of the CDC
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostsResponse"/></returns>
        public Task<DescribeDedicatedClusterHostsResponse> DescribeDedicatedClusterHosts(DescribeDedicatedClusterHostsRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterHostsResponse>(req, "DescribeDedicatedClusterHosts");
        }

        /// <summary>
        /// This API is used to query host information of the CDC
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostsResponse"/></returns>
        public DescribeDedicatedClusterHostsResponse DescribeDedicatedClusterHostsSync(DescribeDedicatedClusterHostsRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterHostsResponse>(req, "DescribeDedicatedClusterHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instance types supported by the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterInstanceTypesResponse"/></returns>
        public Task<DescribeDedicatedClusterInstanceTypesResponse> DescribeDedicatedClusterInstanceTypes(DescribeDedicatedClusterInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterInstanceTypesResponse>(req, "DescribeDedicatedClusterInstanceTypes");
        }

        /// <summary>
        /// This API is used to query instance types supported by the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterInstanceTypesResponse"/></returns>
        public DescribeDedicatedClusterInstanceTypesResponse DescribeDedicatedClusterInstanceTypesSync(DescribeDedicatedClusterInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterInstanceTypesResponse>(req, "DescribeDedicatedClusterInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of CDC orders.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOrdersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOrdersResponse"/></returns>
        public Task<DescribeDedicatedClusterOrdersResponse> DescribeDedicatedClusterOrders(DescribeDedicatedClusterOrdersRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterOrdersResponse>(req, "DescribeDedicatedClusterOrders");
        }

        /// <summary>
        /// This API is used to query the list of CDC orders.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOrdersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOrdersResponse"/></returns>
        public DescribeDedicatedClusterOrdersResponse DescribeDedicatedClusterOrdersSync(DescribeDedicatedClusterOrdersRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterOrdersResponse>(req, "DescribeDedicatedClusterOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview of the CDC
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOverviewRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOverviewResponse"/></returns>
        public Task<DescribeDedicatedClusterOverviewResponse> DescribeDedicatedClusterOverview(DescribeDedicatedClusterOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterOverviewResponse>(req, "DescribeDedicatedClusterOverview");
        }

        /// <summary>
        /// This API is used to query the overview of the CDC
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOverviewRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOverviewResponse"/></returns>
        public DescribeDedicatedClusterOverviewResponse DescribeDedicatedClusterOverviewSync(DescribeDedicatedClusterOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterOverviewResponse>(req, "DescribeDedicatedClusterOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration list of the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterTypesResponse"/></returns>
        public Task<DescribeDedicatedClusterTypesResponse> DescribeDedicatedClusterTypes(DescribeDedicatedClusterTypesRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterTypesResponse>(req, "DescribeDedicatedClusterTypes");
        }

        /// <summary>
        /// This API is used to query the configuration list of the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterTypesResponse"/></returns>
        public DescribeDedicatedClusterTypesResponse DescribeDedicatedClusterTypesSync(DescribeDedicatedClusterTypesRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClusterTypesResponse>(req, "DescribeDedicatedClusterTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CDC list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClustersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClustersResponse"/></returns>
        public Task<DescribeDedicatedClustersResponse> DescribeDedicatedClusters(DescribeDedicatedClustersRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClustersResponse>(req, "DescribeDedicatedClusters");
        }

        /// <summary>
        /// This API is used to query the CDC list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClustersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClustersResponse"/></returns>
        public DescribeDedicatedClustersResponse DescribeDedicatedClustersSync(DescribeDedicatedClustersRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedClustersResponse>(req, "DescribeDedicatedClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of AZs supported by the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedSupportedZonesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedSupportedZonesResponse"/></returns>
        public Task<DescribeDedicatedSupportedZonesResponse> DescribeDedicatedSupportedZones(DescribeDedicatedSupportedZonesRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedSupportedZonesResponse>(req, "DescribeDedicatedSupportedZones");
        }

        /// <summary>
        /// This API is used to query the list of AZs supported by the CDC.
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedSupportedZonesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedSupportedZonesResponse"/></returns>
        public DescribeDedicatedSupportedZonesResponse DescribeDedicatedSupportedZonesSync(DescribeDedicatedSupportedZonesRequest req)
        {
            return InternalRequestAsync<DescribeDedicatedSupportedZonesResponse>(req, "DescribeDedicatedSupportedZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the site list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesRequest"/></param>
        /// <returns><see cref="DescribeSitesResponse"/></returns>
        public Task<DescribeSitesResponse> DescribeSites(DescribeSitesRequest req)
        {
            return InternalRequestAsync<DescribeSitesResponse>(req, "DescribeSites");
        }

        /// <summary>
        /// This API is used to query the site list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesRequest"/></param>
        /// <returns><see cref="DescribeSitesResponse"/></returns>
        public DescribeSitesResponse DescribeSitesSync(DescribeSitesRequest req)
        {
            return InternalRequestAsync<DescribeSitesResponse>(req, "DescribeSites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query site details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesDetailRequest"/></param>
        /// <returns><see cref="DescribeSitesDetailResponse"/></returns>
        public Task<DescribeSitesDetailResponse> DescribeSitesDetail(DescribeSitesDetailRequest req)
        {
            return InternalRequestAsync<DescribeSitesDetailResponse>(req, "DescribeSitesDetail");
        }

        /// <summary>
        /// This API is used to query site details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesDetailRequest"/></param>
        /// <returns><see cref="DescribeSitesDetailResponse"/></returns>
        public DescribeSitesDetailResponse DescribeSitesDetailSync(DescribeSitesDetailRequest req)
        {
            return InternalRequestAsync<DescribeSitesDetailResponse>(req, "DescribeSitesDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the CDC information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDedicatedClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDedicatedClusterInfoResponse"/></returns>
        public Task<ModifyDedicatedClusterInfoResponse> ModifyDedicatedClusterInfo(ModifyDedicatedClusterInfoRequest req)
        {
            return InternalRequestAsync<ModifyDedicatedClusterInfoResponse>(req, "ModifyDedicatedClusterInfo");
        }

        /// <summary>
        /// This API is used to modify the CDC information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDedicatedClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDedicatedClusterInfoResponse"/></returns>
        public ModifyDedicatedClusterInfoResponse ModifyDedicatedClusterInfoSync(ModifyDedicatedClusterInfoRequest req)
        {
            return InternalRequestAsync<ModifyDedicatedClusterInfoResponse>(req, "ModifyDedicatedClusterInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of large and small orders.
        /// </summary>
        /// <param name="req"><see cref="ModifyOrderStatusRequest"/></param>
        /// <returns><see cref="ModifyOrderStatusResponse"/></returns>
        public Task<ModifyOrderStatusResponse> ModifyOrderStatus(ModifyOrderStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrderStatusResponse>(req, "ModifyOrderStatus");
        }

        /// <summary>
        /// This API is used to modify the status of large and small orders.
        /// </summary>
        /// <param name="req"><see cref="ModifyOrderStatusRequest"/></param>
        /// <returns><see cref="ModifyOrderStatusResponse"/></returns>
        public ModifyOrderStatusResponse ModifyOrderStatusSync(ModifyOrderStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrderStatusResponse>(req, "ModifyOrderStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the information about devices in the equipment room.
        /// </summary>
        /// <param name="req"><see cref="ModifySiteDeviceInfoRequest"/></param>
        /// <returns><see cref="ModifySiteDeviceInfoResponse"/></returns>
        public Task<ModifySiteDeviceInfoResponse> ModifySiteDeviceInfo(ModifySiteDeviceInfoRequest req)
        {
            return InternalRequestAsync<ModifySiteDeviceInfoResponse>(req, "ModifySiteDeviceInfo");
        }

        /// <summary>
        /// This API is used to modify the information about devices in the equipment room.
        /// </summary>
        /// <param name="req"><see cref="ModifySiteDeviceInfoRequest"/></param>
        /// <returns><see cref="ModifySiteDeviceInfoResponse"/></returns>
        public ModifySiteDeviceInfoResponse ModifySiteDeviceInfoSync(ModifySiteDeviceInfoRequest req)
        {
            return InternalRequestAsync<ModifySiteDeviceInfoResponse>(req, "ModifySiteDeviceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the equipment room information.
        /// </summary>
        /// <param name="req"><see cref="ModifySiteInfoRequest"/></param>
        /// <returns><see cref="ModifySiteInfoResponse"/></returns>
        public Task<ModifySiteInfoResponse> ModifySiteInfo(ModifySiteInfoRequest req)
        {
            return InternalRequestAsync<ModifySiteInfoResponse>(req, "ModifySiteInfo");
        }

        /// <summary>
        /// This API is used to modify the equipment room information.
        /// </summary>
        /// <param name="req"><see cref="ModifySiteInfoRequest"/></param>
        /// <returns><see cref="ModifySiteInfoResponse"/></returns>
        public ModifySiteInfoResponse ModifySiteInfoSync(ModifySiteInfoRequest req)
        {
            return InternalRequestAsync<ModifySiteInfoResponse>(req, "ModifySiteInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
