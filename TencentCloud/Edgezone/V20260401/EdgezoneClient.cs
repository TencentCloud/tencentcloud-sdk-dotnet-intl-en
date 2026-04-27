/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Edgezone.V20260401
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Edgezone.V20260401.Models;

   public class EdgezoneClient : AbstractClient{

       private const string endpoint = "edgezone.intl.tencentcloudapi.com";
       private const string version = "2026-04-01";
       private const string sdkVersion = "SDK_NET_3.0.1304";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EdgezoneClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EdgezoneClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to submit a request for multiple IP addresses from the static IP pool to specify a public network instance (random allocation). Need to check user quota before applying.
        /// This API is applicable only to public network instances with `RouteMode=static`. Calling this API for BGP/OSPF instances will return an error.
        /// </summary>
        /// <param name="req"><see cref="ApplyPublicIpsRequest"/></param>
        /// <returns><see cref="ApplyPublicIpsResponse"/></returns>
        public Task<ApplyPublicIpsResponse> ApplyPublicIps(ApplyPublicIpsRequest req)
        {
            return InternalRequestAsync<ApplyPublicIpsResponse>(req, "ApplyPublicIps");
        }

        /// <summary>
        /// This API is used to submit a request for multiple IP addresses from the static IP pool to specify a public network instance (random allocation). Need to check user quota before applying.
        /// This API is applicable only to public network instances with `RouteMode=static`. Calling this API for BGP/OSPF instances will return an error.
        /// </summary>
        /// <param name="req"><see cref="ApplyPublicIpsRequest"/></param>
        /// <returns><see cref="ApplyPublicIpsResponse"/></returns>
        public ApplyPublicIpsResponse ApplyPublicIpsSync(ApplyPublicIpsRequest req)
        {
            return InternalRequestAsync<ApplyPublicIpsResponse>(req, "ApplyPublicIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a physical machine instance. The system automatically allocates physical machine resources and completes installation. If the user is not in the current availability zone, the system automatically enables billing. It supports concurrent allocation of physical machine resources and async execution of network assignment and installation tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// This API is used to create a physical machine instance. The system automatically allocates physical machine resources and completes installation. If the user is not in the current availability zone, the system automatically enables billing. It supports concurrent allocation of physical machine resources and async execution of network assignment and installation tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a private network instance. A user can only create one private network instance in an availability zone. The subnet range is collectively determined by both parameters: Network (network number) and Mask (bit number of the mask). Network must be a valid network address from one of the three RFC 1918 private address ranges: 10.0.0.0/8, 172.16.0.0/12, or 192.168.0.0/16, and all host bits must be 0 (meaning the combination of Network and Mask cannot have any host bits set, such as 10.0.0.1/24 is illegal, use 10.0.0.0/24 instead). The maximum Mask is unified as 28, and the minimum is determined by the address range it belongs to: 10.x.x.x allows 8–28, 172.16.x.x allows 12–28, and 192.168.x.x allows 16–28.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePrivateNetworkInstanceResponse"/></returns>
        public Task<CreatePrivateNetworkInstanceResponse> CreatePrivateNetworkInstance(CreatePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePrivateNetworkInstanceResponse>(req, "CreatePrivateNetworkInstance");
        }

        /// <summary>
        /// Create a private network instance. A user can only create one private network instance in an availability zone. The subnet range is collectively determined by both parameters: Network (network number) and Mask (bit number of the mask). Network must be a valid network address from one of the three RFC 1918 private address ranges: 10.0.0.0/8, 172.16.0.0/12, or 192.168.0.0/16, and all host bits must be 0 (meaning the combination of Network and Mask cannot have any host bits set, such as 10.0.0.1/24 is illegal, use 10.0.0.0/24 instead). The maximum Mask is unified as 28, and the minimum is determined by the address range it belongs to: 10.x.x.x allows 8–28, 172.16.x.x allows 12–28, and 192.168.x.x allows 16–28.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePrivateNetworkInstanceResponse"/></returns>
        public CreatePrivateNetworkInstanceResponse CreatePrivateNetworkInstanceSync(CreatePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePrivateNetworkInstanceResponse>(req, "CreatePrivateNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The user inputs the availability zone ID, public network instance name, network line, and routing mode to create a public network instance. A user can only create one public network instance in an availability zone.
        /// Public network instances in **static** routing mode require users to proactively apply for and release public IP addresses.
        /// Public network instances with routing mode set to **OSPF, BGP** automatically allocate public IP ranges when creating and auto release public IP ranges upon termination.
        /// </summary>
        /// <param name="req"><see cref="CreatePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePublicNetworkInstanceResponse"/></returns>
        public Task<CreatePublicNetworkInstanceResponse> CreatePublicNetworkInstance(CreatePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePublicNetworkInstanceResponse>(req, "CreatePublicNetworkInstance");
        }

        /// <summary>
        /// The user inputs the availability zone ID, public network instance name, network line, and routing mode to create a public network instance. A user can only create one public network instance in an availability zone.
        /// Public network instances in **static** routing mode require users to proactively apply for and release public IP addresses.
        /// Public network instances with routing mode set to **OSPF, BGP** automatically allocate public IP ranges when creating and auto release public IP ranges upon termination.
        /// </summary>
        /// <param name="req"><see cref="CreatePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePublicNetworkInstanceResponse"/></returns>
        public CreatePublicNetworkInstanceResponse CreatePublicNetworkInstanceSync(CreatePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePublicNetworkInstanceResponse>(req, "CreatePublicNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a private network instance
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePrivateNetworkInstanceResponse"/></returns>
        public Task<DeletePrivateNetworkInstanceResponse> DeletePrivateNetworkInstance(DeletePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePrivateNetworkInstanceResponse>(req, "DeletePrivateNetworkInstance");
        }

        /// <summary>
        /// Delete a private network instance
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePrivateNetworkInstanceResponse"/></returns>
        public DeletePrivateNetworkInstanceResponse DeletePrivateNetworkInstanceSync(DeletePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePrivateNetworkInstanceResponse>(req, "DeletePrivateNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify public network instance info
        /// </summary>
        /// <param name="req"><see cref="DeletePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePublicNetworkInstanceResponse"/></returns>
        public Task<DeletePublicNetworkInstanceResponse> DeletePublicNetworkInstance(DeletePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePublicNetworkInstanceResponse>(req, "DeletePublicNetworkInstance");
        }

        /// <summary>
        /// Modify public network instance info
        /// </summary>
        /// <param name="req"><see cref="DeletePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePublicNetworkInstanceResponse"/></returns>
        public DeletePublicNetworkInstanceResponse DeletePublicNetworkInstanceSync(DeletePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePublicNetworkInstanceResponse>(req, "DeletePublicNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the model quota list under the account by availability zone dimensionality based on AppId. If a Zone is input, it returns the model quota under the designated availability zone. If not, it returns the model quota of all AZs under the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public Task<DescribeInstanceTypesResponse> DescribeInstanceTypes(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes");
        }

        /// <summary>
        /// This API is used to query the model quota list under the account by availability zone dimensionality based on AppId. If a Zone is input, it returns the model quota under the designated availability zone. If not, it returns the model quota of all AZs under the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypesSync(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query physical machine instance list, support by instance ID, instance name, availability zone, instance status with conditional filtering, and support paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query physical machine instance list, support by instance ID, instance name, availability zone, instance status with conditional filtering, and support paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query private network instances, support through parameters such as private network instance ID, instance name, and availability zone id.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePrivateNetworkInstancesResponse"/></returns>
        public Task<DescribePrivateNetworkInstancesResponse> DescribePrivateNetworkInstances(DescribePrivateNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNetworkInstancesResponse>(req, "DescribePrivateNetworkInstances");
        }

        /// <summary>
        /// Query private network instances, support through parameters such as private network instance ID, instance name, and availability zone id.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePrivateNetworkInstancesResponse"/></returns>
        public DescribePrivateNetworkInstancesResponse DescribePrivateNetworkInstancesSync(DescribePrivateNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNetworkInstancesResponse>(req, "DescribePrivateNetworkInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the public network Ip information of the user. For public network instances with routing mode set to Static, return all applied public network Ip information. For public network instances with routing mode set to Ospf and Bgp, return Ip range information directly.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpsRequest"/></param>
        /// <returns><see cref="DescribePublicIpsResponse"/></returns>
        public Task<DescribePublicIpsResponse> DescribePublicIps(DescribePublicIpsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpsResponse>(req, "DescribePublicIps");
        }

        /// <summary>
        /// Query the public network Ip information of the user. For public network instances with routing mode set to Static, return all applied public network Ip information. For public network instances with routing mode set to Ospf and Bgp, return Ip range information directly.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpsRequest"/></param>
        /// <returns><see cref="DescribePublicIpsResponse"/></returns>
        public DescribePublicIpsResponse DescribePublicIpsSync(DescribePublicIpsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpsResponse>(req, "DescribePublicIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query public network instance list, support conditional filtering by instance ID, instance name, availability zone, and support paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkInstancesResponse"/></returns>
        public Task<DescribePublicNetworkInstancesResponse> DescribePublicNetworkInstances(DescribePublicNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkInstancesResponse>(req, "DescribePublicNetworkInstances");
        }

        /// <summary>
        /// Query public network instance list, support conditional filtering by instance ID, instance name, availability zone, and support paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkInstancesResponse"/></returns>
        public DescribePublicNetworkInstancesResponse DescribePublicNetworkInstancesSync(DescribePublicNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkInstancesResponse>(req, "DescribePublicNetworkInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query statistics by metric name. Data is aggregated at 1-minute intervals.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDataRequest"/></param>
        /// <returns><see cref="DescribeZoneDataResponse"/></returns>
        public Task<DescribeZoneDataResponse> DescribeZoneData(DescribeZoneDataRequest req)
        {
            return InternalRequestAsync<DescribeZoneDataResponse>(req, "DescribeZoneData");
        }

        /// <summary>
        /// Query statistics by metric name. Data is aggregated at 1-minute intervals.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDataRequest"/></param>
        /// <returns><see cref="DescribeZoneDataResponse"/></returns>
        public DescribeZoneDataResponse DescribeZoneDataSync(DescribeZoneDataRequest req)
        {
            return InternalRequestAsync<DescribeZoneDataResponse>(req, "DescribeZoneData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cross-regional aggregate query returns the AZ list for the specified AppId in ALL configured regions. The local region directly performs a database query, while remote regions send HTTP requests to each region's DescribeAppZones API and merge the results.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// Cross-regional aggregate query returns the AZ list for the specified AppId in ALL configured regions. The local region directly performs a database query, while remote regions send HTTP requests to each region's DescribeAppZones API and merge the results.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a physical machine instance, supporting modification of the instance name and update of the public IP address (IPv4/IPv6). At least one of InstanceName and NewPublicIp must be input.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributeResponse"/></returns>
        public Task<ModifyInstanceAttributeResponse> ModifyInstanceAttribute(ModifyInstanceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributeResponse>(req, "ModifyInstanceAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a physical machine instance, supporting modification of the instance name and update of the public IP address (IPv4/IPv6). At least one of InstanceName and NewPublicIp must be input.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributeResponse"/></returns>
        public ModifyInstanceAttributeResponse ModifyInstanceAttributeSync(ModifyInstanceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributeResponse>(req, "ModifyInstanceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify private network instance info
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPrivateNetworkInstanceResponse"/></returns>
        public Task<ModifyPrivateNetworkInstanceResponse> ModifyPrivateNetworkInstance(ModifyPrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNetworkInstanceResponse>(req, "ModifyPrivateNetworkInstance");
        }

        /// <summary>
        /// Modify private network instance info
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPrivateNetworkInstanceResponse"/></returns>
        public ModifyPrivateNetworkInstanceResponse ModifyPrivateNetworkInstanceSync(ModifyPrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNetworkInstanceResponse>(req, "ModifyPrivateNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify public network instance info
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPublicNetworkInstanceResponse"/></returns>
        public Task<ModifyPublicNetworkInstanceResponse> ModifyPublicNetworkInstance(ModifyPublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPublicNetworkInstanceResponse>(req, "ModifyPublicNetworkInstance");
        }

        /// <summary>
        /// Modify public network instance info
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPublicNetworkInstanceResponse"/></returns>
        public ModifyPublicNetworkInstanceResponse ModifyPublicNetworkInstanceSync(ModifyPublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPublicNetworkInstanceResponse>(req, "ModifyPublicNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch release IPv4 addresses assigned to STATIC public network instances but not bound to physical servers
        /// This API is applicable only to STATIC mode instances. The CIDR of BGP/OSPF instances is automatically returned during deletion with no need to manually release single IP addresses.
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicIpRequest"/></param>
        /// <returns><see cref="ReleasePublicIpResponse"/></returns>
        public Task<ReleasePublicIpResponse> ReleasePublicIp(ReleasePublicIpRequest req)
        {
            return InternalRequestAsync<ReleasePublicIpResponse>(req, "ReleasePublicIp");
        }

        /// <summary>
        /// Batch release IPv4 addresses assigned to STATIC public network instances but not bound to physical servers
        /// This API is applicable only to STATIC mode instances. The CIDR of BGP/OSPF instances is automatically returned during deletion with no need to manually release single IP addresses.
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicIpRequest"/></param>
        /// <returns><see cref="ReleasePublicIpResponse"/></returns>
        public ReleasePublicIpResponse ReleasePublicIpSync(ReleasePublicIpRequest req)
        {
            return InternalRequestAsync<ReleasePublicIpResponse>(req, "ReleasePublicIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a physical machine instance and free up resources. It synchronously releases network resources (IP recycling) and updates status to terminating, while performing disk cleanup asynchronously in the background. It supports partially successful operations.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// This API is used to terminate a physical machine instance and free up resources. It synchronously releases network resources (IP recycling) and updates status to terminating, while performing disk cleanup asynchronously in the background. It supports partially successful operations.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
