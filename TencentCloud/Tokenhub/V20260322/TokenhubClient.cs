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

namespace TencentCloud.Tokenhub.V20260322
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tokenhub.V20260322.Models;

   public class TokenhubClient : AbstractClient{

       private const string endpoint = "tokenhub.intl.tencentcloudapi.com";
       private const string version = "2026-03-22";
       private const string sdkVersion = "SDK_NET_3.0.1384";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TokenhubClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TokenhubClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Create an API key.
        /// 
        /// Create a new API key. Upon successful creation, return the API Key ID. Specify the platform kind, binding method, and initial state.
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public Task<CreateApiKeyResponse> CreateApiKey(CreateApiKeyRequest req)
        {
            return InternalRequestAsync<CreateApiKeyResponse>(req, "CreateApiKey");
        }

        /// <summary>
        /// Create an API key.
        /// 
        /// Create a new API key. Upon successful creation, return the API Key ID. Specify the platform kind, binding method, and initial state.
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public CreateApiKeyResponse CreateApiKeySync(CreateApiKeyRequest req)
        {
            return InternalRequestAsync<CreateApiKeyResponse>(req, "CreateApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Termbase.
        /// 
        /// Create a new Termbase in this application for custom definition source to target language terminology mapping. Return the Termbase ID upon success, which can be used to carry out other management operations on terminology entries.
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryRequest"/></param>
        /// <returns><see cref="CreateGlossaryResponse"/></returns>
        public Task<CreateGlossaryResponse> CreateGlossary(CreateGlossaryRequest req)
        {
            return InternalRequestAsync<CreateGlossaryResponse>(req, "CreateGlossary");
        }

        /// <summary>
        /// Create a Termbase.
        /// 
        /// Create a new Termbase in this application for custom definition source to target language terminology mapping. Return the Termbase ID upon success, which can be used to carry out other management operations on terminology entries.
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryRequest"/></param>
        /// <returns><see cref="CreateGlossaryResponse"/></returns>
        public CreateGlossaryResponse CreateGlossarySync(CreateGlossaryRequest req)
        {
            return InternalRequestAsync<CreateGlossaryResponse>(req, "CreateGlossary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create terminology entries in batches.
        /// 
        /// Create terminology entries in batches under the designated Termbase. You can create up to 100 entries at a time.
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryEntriesRequest"/></param>
        /// <returns><see cref="CreateGlossaryEntriesResponse"/></returns>
        public Task<CreateGlossaryEntriesResponse> CreateGlossaryEntries(CreateGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<CreateGlossaryEntriesResponse>(req, "CreateGlossaryEntries");
        }

        /// <summary>
        /// Create terminology entries in batches.
        /// 
        /// Create terminology entries in batches under the designated Termbase. You can create up to 100 entries at a time.
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryEntriesRequest"/></param>
        /// <returns><see cref="CreateGlossaryEntriesResponse"/></returns>
        public CreateGlossaryEntriesResponse CreateGlossaryEntriesSync(CreateGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<CreateGlossaryEntriesResponse>(req, "CreateGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch create TokenPlan API Keys.
        /// 
        /// Import a name prefix and quantity to automatically generate names in the `{Api Key Name}-{serial number}` format (for example, aaa-1, aaa-2). Duplicate names are allowed. Partial success is supported for up to 100 entries.
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanApiKeysRequest"/></param>
        /// <returns><see cref="CreateTokenPlanApiKeysResponse"/></returns>
        public Task<CreateTokenPlanApiKeysResponse> CreateTokenPlanApiKeys(CreateTokenPlanApiKeysRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanApiKeysResponse>(req, "CreateTokenPlanApiKeys");
        }

        /// <summary>
        /// Batch create TokenPlan API Keys.
        /// 
        /// Import a name prefix and quantity to automatically generate names in the `{Api Key Name}-{serial number}` format (for example, aaa-1, aaa-2). Duplicate names are allowed. Partial success is supported for up to 100 entries.
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanApiKeysRequest"/></param>
        /// <returns><see cref="CreateTokenPlanApiKeysResponse"/></returns>
        public CreateTokenPlanApiKeysResponse CreateTokenPlanApiKeysSync(CreateTokenPlanApiKeysRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanApiKeysResponse>(req, "CreateTokenPlanApiKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Purchase a package (This API is also used to reactivate and renew expired packages. The teamId of the expired package is required. After the renewal is successful, the total cycle count of the package will include historical cycles. The actual effective cycle of the package is determined by the effective time and expiration time.)
        /// 
        /// Initiate an order for a TokenPlan package and complete payment. Return the order ID and associated sub-orders and resource information upon success.
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanTeamOrderAndBuyRequest"/></param>
        /// <returns><see cref="CreateTokenPlanTeamOrderAndBuyResponse"/></returns>
        public Task<CreateTokenPlanTeamOrderAndBuyResponse> CreateTokenPlanTeamOrderAndBuy(CreateTokenPlanTeamOrderAndBuyRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanTeamOrderAndBuyResponse>(req, "CreateTokenPlanTeamOrderAndBuy");
        }

        /// <summary>
        /// Purchase a package (This API is also used to reactivate and renew expired packages. The teamId of the expired package is required. After the renewal is successful, the total cycle count of the package will include historical cycles. The actual effective cycle of the package is determined by the effective time and expiration time.)
        /// 
        /// Initiate an order for a TokenPlan package and complete payment. Return the order ID and associated sub-orders and resource information upon success.
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanTeamOrderAndBuyRequest"/></param>
        /// <returns><see cref="CreateTokenPlanTeamOrderAndBuyResponse"/></returns>
        public CreateTokenPlanTeamOrderAndBuyResponse CreateTokenPlanTeamOrderAndBuySync(CreateTokenPlanTeamOrderAndBuyRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanTeamOrderAndBuyResponse>(req, "CreateTokenPlanTeamOrderAndBuy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete specified api keys and clean up associated model binding relationships.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public Task<DeleteApiKeyResponse> DeleteApiKey(DeleteApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteApiKeyResponse>(req, "DeleteApiKey");
        }

        /// <summary>
        /// This API is used to delete specified api keys and clean up associated model binding relationships.
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public DeleteApiKeyResponse DeleteApiKeySync(DeleteApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteApiKeyResponse>(req, "DeleteApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a termbase.
        /// 
        /// This API is used to delete specified Termbase and ALL terminology entries under it. The deletion is idempotent and returns a successful result for non-existing Termbase. After calling the API, if the corresponding Termbase cannot be found via DescribeGlossaries, it indicates successful deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryRequest"/></param>
        /// <returns><see cref="DeleteGlossaryResponse"/></returns>
        public Task<DeleteGlossaryResponse> DeleteGlossary(DeleteGlossaryRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryResponse>(req, "DeleteGlossary");
        }

        /// <summary>
        /// Delete a termbase.
        /// 
        /// This API is used to delete specified Termbase and ALL terminology entries under it. The deletion is idempotent and returns a successful result for non-existing Termbase. After calling the API, if the corresponding Termbase cannot be found via DescribeGlossaries, it indicates successful deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryRequest"/></param>
        /// <returns><see cref="DeleteGlossaryResponse"/></returns>
        public DeleteGlossaryResponse DeleteGlossarySync(DeleteGlossaryRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryResponse>(req, "DeleteGlossary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete terminology entries in batches.
        /// 
        /// Delete terminology entries in batches under the specified Termbase. You can delete up to 200 entries at a time. If the Termbase is nonexistent or NOT_IN this application, it returns a ResourceNotFound error.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DeleteGlossaryEntriesResponse"/></returns>
        public Task<DeleteGlossaryEntriesResponse> DeleteGlossaryEntries(DeleteGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryEntriesResponse>(req, "DeleteGlossaryEntries");
        }

        /// <summary>
        /// Delete terminology entries in batches.
        /// 
        /// Delete terminology entries in batches under the specified Termbase. You can delete up to 200 entries at a time. If the Termbase is nonexistent or NOT_IN this application, it returns a ResourceNotFound error.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DeleteGlossaryEntriesResponse"/></returns>
        public DeleteGlossaryEntriesResponse DeleteGlossaryEntriesSync(DeleteGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryEntriesResponse>(req, "DeleteGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the Token Plan API key.
        /// 
        /// Simultaneously delete the limit center sub-limit package and notify the Notification Gateway to purge cache.
        /// </summary>
        /// <param name="req"><see cref="DeleteTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DeleteTokenPlanApiKeyResponse"/></returns>
        public Task<DeleteTokenPlanApiKeyResponse> DeleteTokenPlanApiKey(DeleteTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteTokenPlanApiKeyResponse>(req, "DeleteTokenPlanApiKey");
        }

        /// <summary>
        /// Delete the Token Plan API key.
        /// 
        /// Simultaneously delete the limit center sub-limit package and notify the Notification Gateway to purge cache.
        /// </summary>
        /// <param name="req"><see cref="DeleteTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DeleteTokenPlanApiKeyResponse"/></returns>
        public DeleteTokenPlanApiKeyResponse DeleteTokenPlanApiKeySync(DeleteTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteTokenPlanApiKeyResponse>(req, "DeleteTokenPlanApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query API Key details based on API Key ID or key value, and return the plaintext key. At least one of ApiKeyId and ApiKey must be input, with priority given to ApiKeyId.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public Task<DescribeApiKeyResponse> DescribeApiKey(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey");
        }

        /// <summary>
        /// This API is used to query API Key details based on API Key ID or key value, and return the plaintext key. At least one of ApiKeyId and ApiKey must be input, with priority given to ApiKeyId.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public DescribeApiKeyResponse DescribeApiKeySync(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query API key list.
        /// 
        /// Query the API key list of the current user with key values in masking display. Support pagination, filtering, and sorting.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeApiKeyListResponse"/></returns>
        public Task<DescribeApiKeyListResponse> DescribeApiKeyList(DescribeApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyListResponse>(req, "DescribeApiKeyList");
        }

        /// <summary>
        /// Query API key list.
        /// 
        /// Query the API key list of the current user with key values in masking display. Support pagination, filtering, and sorting.
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeApiKeyListResponse"/></returns>
        public DescribeApiKeyListResponse DescribeApiKeyListSync(DescribeApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyListResponse>(req, "DescribeApiKeyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the terminology repository list.
        /// 
        /// Query the Termbase list under this application. Support paginate, filter, and sort.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossariesRequest"/></param>
        /// <returns><see cref="DescribeGlossariesResponse"/></returns>
        public Task<DescribeGlossariesResponse> DescribeGlossaries(DescribeGlossariesRequest req)
        {
            return InternalRequestAsync<DescribeGlossariesResponse>(req, "DescribeGlossaries");
        }

        /// <summary>
        /// Query the terminology repository list.
        /// 
        /// Query the Termbase list under this application. Support paginate, filter, and sort.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossariesRequest"/></param>
        /// <returns><see cref="DescribeGlossariesResponse"/></returns>
        public DescribeGlossariesResponse DescribeGlossariesSync(DescribeGlossariesRequest req)
        {
            return InternalRequestAsync<DescribeGlossariesResponse>(req, "DescribeGlossaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the terminology entry list.
        /// 
        /// Query specified entries in a Termbase. Support pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DescribeGlossaryEntriesResponse"/></returns>
        public Task<DescribeGlossaryEntriesResponse> DescribeGlossaryEntries(DescribeGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DescribeGlossaryEntriesResponse>(req, "DescribeGlossaryEntries");
        }

        /// <summary>
        /// Query the terminology entry list.
        /// 
        /// Query specified entries in a Termbase. Support pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DescribeGlossaryEntriesResponse"/></returns>
        public DescribeGlossaryEntriesResponse DescribeGlossaryEntriesSync(DescribeGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DescribeGlossaryEntriesResponse>(req, "DescribeGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the TokenPlan package details.
        /// 
        /// Return the package basic info and the remaining quota of the package.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanResponse"/></returns>
        public Task<DescribeTokenPlanResponse> DescribeTokenPlan(DescribeTokenPlanRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanResponse>(req, "DescribeTokenPlan");
        }

        /// <summary>
        /// Query the TokenPlan package details.
        /// 
        /// Return the package basic info and the remaining quota of the package.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanResponse"/></returns>
        public DescribeTokenPlanResponse DescribeTokenPlanSync(DescribeTokenPlanRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanResponse>(req, "DescribeTokenPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query TokenPlan APIKey details.
        /// 
        /// Return the complete APIKey information (including the plaintext key) and the remaining quota of the sub-quota package.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyResponse"/></returns>
        public Task<DescribeTokenPlanApiKeyResponse> DescribeTokenPlanApiKey(DescribeTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyResponse>(req, "DescribeTokenPlanApiKey");
        }

        /// <summary>
        /// Query TokenPlan APIKey details.
        /// 
        /// Return the complete APIKey information (including the plaintext key) and the remaining quota of the sub-quota package.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyResponse"/></returns>
        public DescribeTokenPlanApiKeyResponse DescribeTokenPlanApiKeySync(DescribeTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyResponse>(req, "DescribeTokenPlanApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of Token Plan API keys.
        /// 
        /// Returns the API key list under a specified package. Keys are masked. Root accounts can view all keys, while sub-accounts can only view keys created by themselves.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyListResponse"/></returns>
        public Task<DescribeTokenPlanApiKeyListResponse> DescribeTokenPlanApiKeyList(DescribeTokenPlanApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyListResponse>(req, "DescribeTokenPlanApiKeyList");
        }

        /// <summary>
        /// Query the list of Token Plan API keys.
        /// 
        /// Returns the API key list under a specified package. Keys are masked. Root accounts can view all keys, while sub-accounts can only view keys created by themselves.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyListResponse"/></returns>
        public DescribeTokenPlanApiKeyListResponse DescribeTokenPlanApiKeyListSync(DescribeTokenPlanApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyListResponse>(req, "DescribeTokenPlanApiKeyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the TokenPlan APIKey (plaintext).
        /// 
        /// Return the plaintext key value of the designated APIKey. Keep it safe.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeySecretResponse"/></returns>
        public Task<DescribeTokenPlanApiKeySecretResponse> DescribeTokenPlanApiKeySecret(DescribeTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeySecretResponse>(req, "DescribeTokenPlanApiKeySecret");
        }

        /// <summary>
        /// Query the TokenPlan APIKey (plaintext).
        /// 
        /// Return the plaintext key value of the designated APIKey. Keep it safe.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeySecretResponse"/></returns>
        public DescribeTokenPlanApiKeySecretResponse DescribeTokenPlanApiKeySecretSync(DescribeTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeySecretResponse>(req, "DescribeTokenPlanApiKeySecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Token Plan APIKey call detail.
        /// 
        /// This API is used to query call details under a package from CLS log service, filter by team_id, and support cursor-based pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyUsageDetailRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyUsageDetailResponse"/></returns>
        public Task<DescribeTokenPlanApiKeyUsageDetailResponse> DescribeTokenPlanApiKeyUsageDetail(DescribeTokenPlanApiKeyUsageDetailRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyUsageDetailResponse>(req, "DescribeTokenPlanApiKeyUsageDetail");
        }

        /// <summary>
        /// Query the Token Plan APIKey call detail.
        /// 
        /// This API is used to query call details under a package from CLS log service, filter by team_id, and support cursor-based pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyUsageDetailRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyUsageDetailResponse"/></returns>
        public DescribeTokenPlanApiKeyUsageDetailResponse DescribeTokenPlanApiKeyUsageDetailSync(DescribeTokenPlanApiKeyUsageDetailRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyUsageDetailResponse>(req, "DescribeTokenPlanApiKeyUsageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of Token Plan package options.
        /// 
        /// Supports pagination, filtering, and sorting. Root accounts can view all packages, while sub-accounts can only view packages created by themselves. Returned results include the main limit package details associated with each package in the limit center.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanListResponse"/></returns>
        public Task<DescribeTokenPlanListResponse> DescribeTokenPlanList(DescribeTokenPlanListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanListResponse>(req, "DescribeTokenPlanList");
        }

        /// <summary>
        /// Query the list of Token Plan package options.
        /// 
        /// Supports pagination, filtering, and sorting. Root accounts can view all packages, while sub-accounts can only view packages created by themselves. Returned results include the main limit package details associated with each package in the limit center.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanListResponse"/></returns>
        public DescribeTokenPlanListResponse DescribeTokenPlanListSync(DescribeTokenPlanListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanListResponse>(req, "DescribeTokenPlanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refresh API key information.
        /// 
        /// This API is used to update the remark information, IP allowlist and Token quota of an API key (recommended to use QuotaDesired parameter for quota modification). Passing no optional parameters means no modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiKeyInfoRequest"/></param>
        /// <returns><see cref="ModifyApiKeyInfoResponse"/></returns>
        public Task<ModifyApiKeyInfoResponse> ModifyApiKeyInfo(ModifyApiKeyInfoRequest req)
        {
            return InternalRequestAsync<ModifyApiKeyInfoResponse>(req, "ModifyApiKeyInfo");
        }

        /// <summary>
        /// Refresh API key information.
        /// 
        /// This API is used to update the remark information, IP allowlist and Token quota of an API key (recommended to use QuotaDesired parameter for quota modification). Passing no optional parameters means no modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiKeyInfoRequest"/></param>
        /// <returns><see cref="ModifyApiKeyInfoResponse"/></returns>
        public ModifyApiKeyInfoResponse ModifyApiKeyInfoSync(ModifyApiKeyInfoRequest req)
        {
            return InternalRequestAsync<ModifyApiKeyInfoResponse>(req, "ModifyApiKeyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable the status of an api key.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiKeyStatusRequest"/></param>
        /// <returns><see cref="ModifyApiKeyStatusResponse"/></returns>
        public Task<ModifyApiKeyStatusResponse> ModifyApiKeyStatus(ModifyApiKeyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApiKeyStatusResponse>(req, "ModifyApiKeyStatus");
        }

        /// <summary>
        /// This API is used to enable or disable the status of an api key.
        /// </summary>
        /// <param name="req"><see cref="ModifyApiKeyStatusRequest"/></param>
        /// <returns><see cref="ModifyApiKeyStatusResponse"/></returns>
        public ModifyApiKeyStatusResponse ModifyApiKeyStatusSync(ModifyApiKeyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApiKeyStatusResponse>(req, "ModifyApiKeyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify terminology entries.
        /// 
        /// This API is used to batch modify terminology entries in a designated Termbase. You can modify up to 200 entries at a time.
        /// </summary>
        /// <param name="req"><see cref="ModifyGlossaryEntriesRequest"/></param>
        /// <returns><see cref="ModifyGlossaryEntriesResponse"/></returns>
        public Task<ModifyGlossaryEntriesResponse> ModifyGlossaryEntries(ModifyGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<ModifyGlossaryEntriesResponse>(req, "ModifyGlossaryEntries");
        }

        /// <summary>
        /// Batch modify terminology entries.
        /// 
        /// This API is used to batch modify terminology entries in a designated Termbase. You can modify up to 200 entries at a time.
        /// </summary>
        /// <param name="req"><see cref="ModifyGlossaryEntriesRequest"/></param>
        /// <returns><see cref="ModifyGlossaryEntriesResponse"/></returns>
        public ModifyGlossaryEntriesResponse ModifyGlossaryEntriesSync(ModifyGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<ModifyGlossaryEntriesResponse>(req, "ModifyGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the Token Plan APIKey configuration (field that the gateway focuses on).
        /// 
        /// After modification, automatically notify the gateway to update the cache and sync the limit center.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeyResponse"/></returns>
        public Task<ModifyTokenPlanApiKeyResponse> ModifyTokenPlanApiKey(ModifyTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeyResponse>(req, "ModifyTokenPlanApiKey");
        }

        /// <summary>
        /// Modify the Token Plan APIKey configuration (field that the gateway focuses on).
        /// 
        /// After modification, automatically notify the gateway to update the cache and sync the limit center.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeyResponse"/></returns>
        public ModifyTokenPlanApiKeyResponse ModifyTokenPlanApiKeySync(ModifyTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeyResponse>(req, "ModifyTokenPlanApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reset the TokenPlan API Key.
        /// 
        /// Regenerate the key value. The key version increments and the old key expires immediately. The API Key ID remains unchanged. After resetting, the new key can be queried through DescribeTokenPlanApiKeySecret.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeySecretResponse"/></returns>
        public Task<ModifyTokenPlanApiKeySecretResponse> ModifyTokenPlanApiKeySecret(ModifyTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeySecretResponse>(req, "ModifyTokenPlanApiKeySecret");
        }

        /// <summary>
        /// Reset the TokenPlan API Key.
        /// 
        /// Regenerate the key value. The key version increments and the old key expires immediately. The API Key ID remains unchanged. After resetting, the new key can be queried through DescribeTokenPlanApiKeySecret.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeySecretResponse"/></returns>
        public ModifyTokenPlanApiKeySecretResponse ModifyTokenPlanApiKeySecretSync(ModifyTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeySecretResponse>(req, "ModifyTokenPlanApiKeySecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renew a package.
        /// 
        /// Initiate a renewal order for an existing Token Plan package and complete payment. Return the order ID and associated sub-orders and resource information upon success.
        /// </summary>
        /// <param name="req"><see cref="RenewTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="RenewTokenPlanTeamOrderResponse"/></returns>
        public Task<RenewTokenPlanTeamOrderResponse> RenewTokenPlanTeamOrder(RenewTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<RenewTokenPlanTeamOrderResponse>(req, "RenewTokenPlanTeamOrder");
        }

        /// <summary>
        /// Renew a package.
        /// 
        /// Initiate a renewal order for an existing Token Plan package and complete payment. Return the order ID and associated sub-orders and resource information upon success.
        /// </summary>
        /// <param name="req"><see cref="RenewTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="RenewTokenPlanTeamOrderResponse"/></returns>
        public RenewTokenPlanTeamOrderResponse RenewTokenPlanTeamOrderSync(RenewTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<RenewTokenPlanTeamOrderResponse>(req, "RenewTokenPlanTeamOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Upgrade the package.
        /// 
        /// Initiate an upgrade order for an existing Token Plan package and complete payment to expand point or token limits. Return the order ID and associated sub-orders and resource information upon success. The new limit must be greater than the current limit.
        /// </summary>
        /// <param name="req"><see cref="UpgradeTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="UpgradeTokenPlanTeamOrderResponse"/></returns>
        public Task<UpgradeTokenPlanTeamOrderResponse> UpgradeTokenPlanTeamOrder(UpgradeTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<UpgradeTokenPlanTeamOrderResponse>(req, "UpgradeTokenPlanTeamOrder");
        }

        /// <summary>
        /// Upgrade the package.
        /// 
        /// Initiate an upgrade order for an existing Token Plan package and complete payment to expand point or token limits. Return the order ID and associated sub-orders and resource information upon success. The new limit must be greater than the current limit.
        /// </summary>
        /// <param name="req"><see cref="UpgradeTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="UpgradeTokenPlanTeamOrderResponse"/></returns>
        public UpgradeTokenPlanTeamOrderResponse UpgradeTokenPlanTeamOrderSync(UpgradeTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<UpgradeTokenPlanTeamOrderResponse>(req, "UpgradeTokenPlanTeamOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
