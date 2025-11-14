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

namespace TencentCloud.Vod.V20240718
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vod.V20240718.Models;

   public class VodClient : AbstractClient{

       private const string endpoint = "vod.intl.tencentcloudapi.com";
       private const string version = "2024-07-18";
       private const string sdkVersion = "SDK_NET_3.0.1238";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Create an incremental migration strategy for the storage of the professional application.
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationStrategyResponse"/></returns>
        public Task<CreateIncrementalMigrationStrategyResponse> CreateIncrementalMigrationStrategy(CreateIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationStrategyResponse>(req, "CreateIncrementalMigrationStrategy");
        }

        /// <summary>
        /// Create an incremental migration strategy for the storage of the professional application.
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationStrategyResponse"/></returns>
        public CreateIncrementalMigrationStrategyResponse CreateIncrementalMigrationStrategySync(CreateIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationStrategyResponse>(req, "CreateIncrementalMigrationStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create storage for professional applications.
        /// 
        /// Note:
        /// - This API is exclusively for professional applications.
        /// - When a customer creates a VOD professional application, the system automatically enables storage in certain regions by default. If the customer needs to enable storage in other regions, they can do so using this API.
        /// - All storage regions and the regions where storage have already been enabled can be queried using the [DescribeStorageRegions](https://cloud.tencent.com/document/product/266/72480) API.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public Task<CreateStorageResponse> CreateStorage(CreateStorageRequest req)
        {
            return InternalRequestAsync<CreateStorageResponse>(req, "CreateStorage");
        }

        /// <summary>
        /// This API is used to create storage for professional applications.
        /// 
        /// Note:
        /// - This API is exclusively for professional applications.
        /// - When a customer creates a VOD professional application, the system automatically enables storage in certain regions by default. If the customer needs to enable storage in other regions, they can do so using this API.
        /// - All storage regions and the regions where storage have already been enabled can be queried using the [DescribeStorageRegions](https://cloud.tencent.com/document/product/266/72480) API.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public CreateStorageResponse CreateStorageSync(CreateStorageRequest req)
        {
            return InternalRequestAsync<CreateStorageResponse>(req, "CreateStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API is used to generate access credentials for VOD professional applications, such as generating credentials for client uploads.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageCredentialsRequest"/></param>
        /// <returns><see cref="CreateStorageCredentialsResponse"/></returns>
        public Task<CreateStorageCredentialsResponse> CreateStorageCredentials(CreateStorageCredentialsRequest req)
        {
            return InternalRequestAsync<CreateStorageCredentialsResponse>(req, "CreateStorageCredentials");
        }

        /// <summary>
        /// The API is used to generate access credentials for VOD professional applications, such as generating credentials for client uploads.
        /// </summary>
        /// <param name="req"><see cref="CreateStorageCredentialsRequest"/></param>
        /// <returns><see cref="CreateStorageCredentialsResponse"/></returns>
        public CreateStorageCredentialsResponse CreateStorageCredentialsSync(CreateStorageCredentialsRequest req)
        {
            return InternalRequestAsync<CreateStorageCredentialsResponse>(req, "CreateStorageCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the incremental migration strategy.
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationStrategyResponse"/></returns>
        public Task<DeleteIncrementalMigrationStrategyResponse> DeleteIncrementalMigrationStrategy(DeleteIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationStrategyResponse>(req, "DeleteIncrementalMigrationStrategy");
        }

        /// <summary>
        /// Delete the incremental migration strategy.
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationStrategyResponse"/></returns>
        public DeleteIncrementalMigrationStrategyResponse DeleteIncrementalMigrationStrategySync(DeleteIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationStrategyResponse>(req, "DeleteIncrementalMigrationStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe the information of the incremental migration strategy.
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationStrategyInfosRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationStrategyInfosResponse"/></returns>
        public Task<DescribeIncrementalMigrationStrategyInfosResponse> DescribeIncrementalMigrationStrategyInfos(DescribeIncrementalMigrationStrategyInfosRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationStrategyInfosResponse>(req, "DescribeIncrementalMigrationStrategyInfos");
        }

        /// <summary>
        /// Describe the information of the incremental migration strategy.
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationStrategyInfosRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationStrategyInfosResponse"/></returns>
        public DescribeIncrementalMigrationStrategyInfosResponse DescribeIncrementalMigrationStrategyInfosSync(DescribeIncrementalMigrationStrategyInfosRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationStrategyInfosResponse>(req, "DescribeIncrementalMigrationStrategyInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query bucket information in the professional application, and it also supports paginated queries.
        /// Note:
        /// - This API is exclusively for use in the professional application.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRequest"/></param>
        /// <returns><see cref="DescribeStorageResponse"/></returns>
        public Task<DescribeStorageResponse> DescribeStorage(DescribeStorageRequest req)
        {
            return InternalRequestAsync<DescribeStorageResponse>(req, "DescribeStorage");
        }

        /// <summary>
        /// This API is used to query bucket information in the professional application, and it also supports paginated queries.
        /// Note:
        /// - This API is exclusively for use in the professional application.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRequest"/></param>
        /// <returns><see cref="DescribeStorageResponse"/></returns>
        public DescribeStorageResponse DescribeStorageSync(DescribeStorageRequest req)
        {
            return InternalRequestAsync<DescribeStorageResponse>(req, "DescribeStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the information of incremental migration strategy.
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationStrategyResponse"/></returns>
        public Task<ModifyIncrementalMigrationStrategyResponse> ModifyIncrementalMigrationStrategy(ModifyIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationStrategyResponse>(req, "ModifyIncrementalMigrationStrategy");
        }

        /// <summary>
        /// Modify the information of incremental migration strategy.
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationStrategyResponse"/></returns>
        public ModifyIncrementalMigrationStrategyResponse ModifyIncrementalMigrationStrategySync(ModifyIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationStrategyResponse>(req, "ModifyIncrementalMigrationStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
