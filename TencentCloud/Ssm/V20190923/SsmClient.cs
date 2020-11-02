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

namespace TencentCloud.Ssm.V20190923
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ssm.V20190923.Models;

   public class SsmClient : AbstractClient{

       private const string endpoint = "ssm.tencentcloudapi.com";
       private const string version = "2019-09-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SsmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SsmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create a KMS-encrypted Secret. You can create and store up to 1,000 Secrets in each region.
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public async Task<CreateSecretResponse> CreateSecret(CreateSecretRequest req)
        {
             JsonResponseModel<CreateSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a KMS-encrypted Secret. You can create and store up to 1,000 Secrets in each region.
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public CreateSecretResponse CreateSecretSync(CreateSecretRequest req)
        {
             JsonResponseModel<CreateSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Secret. You can set whether to delete the Secret immediately or on schedule using the `RecoveryWindowInDays` parameter. For a Secret to be deleted on schedule, its status will be `PendingDelete` before the scheduled deletion time. You can use `RestoreSecret` to restore a deleted Secret during this time. A deleted Secret will not be restorable after the scheduled deletion time. A Secret can only be deleted after being disabled using `DisableSecret`.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public async Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest req)
        {
             JsonResponseModel<DeleteSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Secret. You can set whether to delete the Secret immediately or on schedule using the `RecoveryWindowInDays` parameter. For a Secret to be deleted on schedule, its status will be `PendingDelete` before the scheduled deletion time. You can use `RestoreSecret` to restore a deleted Secret during this time. A deleted Secret will not be restorable after the scheduled deletion time. A Secret can only be deleted after being disabled using `DisableSecret`.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public DeleteSecretResponse DeleteSecretSync(DeleteSecretRequest req)
        {
             JsonResponseModel<DeleteSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a version of a Secret. The deletion takes effect immediately. Secret versions in any status can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretVersionRequest"/></param>
        /// <returns><see cref="DeleteSecretVersionResponse"/></returns>
        public async Task<DeleteSecretVersionResponse> DeleteSecretVersion(DeleteSecretVersionRequest req)
        {
             JsonResponseModel<DeleteSecretVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecretVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a version of a Secret. The deletion takes effect immediately. Secret versions in any status can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretVersionRequest"/></param>
        /// <returns><see cref="DeleteSecretVersionResponse"/></returns>
        public DeleteSecretVersionResponse DeleteSecretVersionSync(DeleteSecretVersionRequest req)
        {
             JsonResponseModel<DeleteSecretVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecretVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the detailed attribute information of a Secret.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public async Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest req)
        {
             JsonResponseModel<DescribeSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the detailed attribute information of a Secret.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public DescribeSecretResponse DescribeSecretSync(DescribeSecretRequest req)
        {
             JsonResponseModel<DescribeSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a Secret and will change its status to `Disabled`. The plaintext of a disabled Secret cannot be obtained through APIs.
        /// </summary>
        /// <param name="req"><see cref="DisableSecretRequest"/></param>
        /// <returns><see cref="DisableSecretResponse"/></returns>
        public async Task<DisableSecretResponse> DisableSecret(DisableSecretRequest req)
        {
             JsonResponseModel<DisableSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a Secret and will change its status to `Disabled`. The plaintext of a disabled Secret cannot be obtained through APIs.
        /// </summary>
        /// <param name="req"><see cref="DisableSecretRequest"/></param>
        /// <returns><see cref="DisableSecretResponse"/></returns>
        public DisableSecretResponse DisableSecretSync(DisableSecretRequest req)
        {
             JsonResponseModel<DisableSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a Secret and will change its status to `Enabled`. You can call the `GetSecretValue` API to obtain the plaintext of this Secret. Secrets in `PendingDelete` status can only be enabled after being restored by using `RestoreSecret`.
        /// </summary>
        /// <param name="req"><see cref="EnableSecretRequest"/></param>
        /// <returns><see cref="EnableSecretResponse"/></returns>
        public async Task<EnableSecretResponse> EnableSecret(EnableSecretRequest req)
        {
             JsonResponseModel<EnableSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a Secret and will change its status to `Enabled`. You can call the `GetSecretValue` API to obtain the plaintext of this Secret. Secrets in `PendingDelete` status can only be enabled after being restored by using `RestoreSecret`.
        /// </summary>
        /// <param name="req"><see cref="EnableSecretRequest"/></param>
        /// <returns><see cref="EnableSecretResponse"/></returns>
        public EnableSecretResponse EnableSecretSync(EnableSecretRequest req)
        {
             JsonResponseModel<EnableSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of regions displayed on Console.
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public async Task<GetRegionsResponse> GetRegions(GetRegionsRequest req)
        {
             JsonResponseModel<GetRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of regions displayed on Console.
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public GetRegionsResponse GetRegionsSync(GetRegionsRequest req)
        {
             JsonResponseModel<GetRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the plaintext of a specified Secret and version. Only plaintext of an enabled Secret can be obtained.
        /// </summary>
        /// <param name="req"><see cref="GetSecretValueRequest"/></param>
        /// <returns><see cref="GetSecretValueResponse"/></returns>
        public async Task<GetSecretValueResponse> GetSecretValue(GetSecretValueRequest req)
        {
             JsonResponseModel<GetSecretValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the plaintext of a specified Secret and version. Only plaintext of an enabled Secret can be obtained.
        /// </summary>
        /// <param name="req"><see cref="GetSecretValueRequest"/></param>
        /// <returns><see cref="GetSecretValueResponse"/></returns>
        public GetSecretValueResponse GetSecretValueSync(GetSecretValueRequest req)
        {
             JsonResponseModel<GetSecretValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the SecretsManager service status of a user.
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public async Task<GetServiceStatusResponse> GetServiceStatus(GetServiceStatusRequest req)
        {
             JsonResponseModel<GetServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the SecretsManager service status of a user.
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public GetServiceStatusResponse GetServiceStatusSync(GetServiceStatusRequest req)
        {
             JsonResponseModel<GetServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain list of versions of a Secret.
        /// </summary>
        /// <param name="req"><see cref="ListSecretVersionIdsRequest"/></param>
        /// <returns><see cref="ListSecretVersionIdsResponse"/></returns>
        public async Task<ListSecretVersionIdsResponse> ListSecretVersionIds(ListSecretVersionIdsRequest req)
        {
             JsonResponseModel<ListSecretVersionIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSecretVersionIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretVersionIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain list of versions of a Secret.
        /// </summary>
        /// <param name="req"><see cref="ListSecretVersionIdsRequest"/></param>
        /// <returns><see cref="ListSecretVersionIdsResponse"/></returns>
        public ListSecretVersionIdsResponse ListSecretVersionIdsSync(ListSecretVersionIdsRequest req)
        {
             JsonResponseModel<ListSecretVersionIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSecretVersionIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretVersionIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the detailed information list of all Secrets. You can specify the filter fields and sorting order as needed.
        /// </summary>
        /// <param name="req"><see cref="ListSecretsRequest"/></param>
        /// <returns><see cref="ListSecretsResponse"/></returns>
        public async Task<ListSecretsResponse> ListSecrets(ListSecretsRequest req)
        {
             JsonResponseModel<ListSecretsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSecrets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the detailed information list of all Secrets. You can specify the filter fields and sorting order as needed.
        /// </summary>
        /// <param name="req"><see cref="ListSecretsRequest"/></param>
        /// <returns><see cref="ListSecretsResponse"/></returns>
        public ListSecretsResponse ListSecretsSync(ListSecretsRequest req)
        {
             JsonResponseModel<ListSecretsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSecrets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a new version to a specified Secret. Each Secret supports up to 10 versions. You can only add versions to Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="PutSecretValueRequest"/></param>
        /// <returns><see cref="PutSecretValueResponse"/></returns>
        public async Task<PutSecretValueResponse> PutSecretValue(PutSecretValueRequest req)
        {
             JsonResponseModel<PutSecretValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a new version to a specified Secret. Each Secret supports up to 10 versions. You can only add versions to Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="PutSecretValueRequest"/></param>
        /// <returns><see cref="PutSecretValueResponse"/></returns>
        public PutSecretValueResponse PutSecretValueSync(PutSecretValueRequest req)
        {
             JsonResponseModel<PutSecretValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a `PendingDelete` Secret, canceling its scheduled deletion. The restored Secret will be in `Disabled` status. You can call the `EnableSecret` API to enable this Secret again.
        /// </summary>
        /// <param name="req"><see cref="RestoreSecretRequest"/></param>
        /// <returns><see cref="RestoreSecretResponse"/></returns>
        public async Task<RestoreSecretResponse> RestoreSecret(RestoreSecretRequest req)
        {
             JsonResponseModel<RestoreSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a `PendingDelete` Secret, canceling its scheduled deletion. The restored Secret will be in `Disabled` status. You can call the `EnableSecret` API to enable this Secret again.
        /// </summary>
        /// <param name="req"><see cref="RestoreSecretRequest"/></param>
        /// <returns><see cref="RestoreSecretResponse"/></returns>
        public RestoreSecretResponse RestoreSecretSync(RestoreSecretRequest req)
        {
             JsonResponseModel<RestoreSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the description of a Secret. This API can only update Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="UpdateDescriptionRequest"/></param>
        /// <returns><see cref="UpdateDescriptionResponse"/></returns>
        public async Task<UpdateDescriptionResponse> UpdateDescription(UpdateDescriptionRequest req)
        {
             JsonResponseModel<UpdateDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the description of a Secret. This API can only update Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="UpdateDescriptionRequest"/></param>
        /// <returns><see cref="UpdateDescriptionResponse"/></returns>
        public UpdateDescriptionResponse UpdateDescriptionSync(UpdateDescriptionRequest req)
        {
             JsonResponseModel<UpdateDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the name and version ID of a Secret. Calling this API encrypts the new Secret content and overwrites the old content. This API can only update Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="UpdateSecretRequest"/></param>
        /// <returns><see cref="UpdateSecretResponse"/></returns>
        public async Task<UpdateSecretResponse> UpdateSecret(UpdateSecretRequest req)
        {
             JsonResponseModel<UpdateSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the name and version ID of a Secret. Calling this API encrypts the new Secret content and overwrites the old content. This API can only update Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="UpdateSecretRequest"/></param>
        /// <returns><see cref="UpdateSecretResponse"/></returns>
        public UpdateSecretResponse UpdateSecretSync(UpdateSecretRequest req)
        {
             JsonResponseModel<UpdateSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
