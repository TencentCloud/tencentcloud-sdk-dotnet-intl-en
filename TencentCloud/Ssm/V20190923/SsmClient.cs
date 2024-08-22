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
       private const string sdkVersion = "SDK_NET_3.0.967";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SsmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a Tencent Cloud service credential.
        /// </summary>
        /// <param name="req"><see cref="CreateProductSecretRequest"/></param>
        /// <returns><see cref="CreateProductSecretResponse"/></returns>
        public Task<CreateProductSecretResponse> CreateProductSecret(CreateProductSecretRequest req)
        {
            return InternalRequestAsync<CreateProductSecretResponse>(req, "CreateProductSecret");
        }

        /// <summary>
        /// This API is used to create a Tencent Cloud service credential.
        /// </summary>
        /// <param name="req"><see cref="CreateProductSecretRequest"/></param>
        /// <returns><see cref="CreateProductSecretResponse"/></returns>
        public CreateProductSecretResponse CreateProductSecretSync(CreateProductSecretRequest req)
        {
            return InternalRequestAsync<CreateProductSecretResponse>(req, "CreateProductSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a secret that hosts SSH keys.
        /// </summary>
        /// <param name="req"><see cref="CreateSSHKeyPairSecretRequest"/></param>
        /// <returns><see cref="CreateSSHKeyPairSecretResponse"/></returns>
        public Task<CreateSSHKeyPairSecretResponse> CreateSSHKeyPairSecret(CreateSSHKeyPairSecretRequest req)
        {
            return InternalRequestAsync<CreateSSHKeyPairSecretResponse>(req, "CreateSSHKeyPairSecret");
        }

        /// <summary>
        /// This API is used to create a secret that hosts SSH keys.
        /// </summary>
        /// <param name="req"><see cref="CreateSSHKeyPairSecretRequest"/></param>
        /// <returns><see cref="CreateSSHKeyPairSecretResponse"/></returns>
        public CreateSSHKeyPairSecretResponse CreateSSHKeyPairSecretSync(CreateSSHKeyPairSecretRequest req)
        {
            return InternalRequestAsync<CreateSSHKeyPairSecretResponse>(req, "CreateSSHKeyPairSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a KMS-encrypted Secret. You can create and store up to 1,000 Secrets in each region.
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public Task<CreateSecretResponse> CreateSecret(CreateSecretRequest req)
        {
            return InternalRequestAsync<CreateSecretResponse>(req, "CreateSecret");
        }

        /// <summary>
        /// This API is used to create a KMS-encrypted Secret. You can create and store up to 1,000 Secrets in each region.
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public CreateSecretResponse CreateSecretSync(CreateSecretRequest req)
        {
            return InternalRequestAsync<CreateSecretResponse>(req, "CreateSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Secret. You can set whether to delete the Secret immediately or on schedule using the `RecoveryWindowInDays` parameter. For a Secret to be deleted on schedule, its status will be `PendingDelete` before the scheduled deletion time. You can use `RestoreSecret` to restore a deleted Secret during this time. A deleted Secret will not be restorable after the scheduled deletion time. A Secret can only be deleted after being disabled using `DisableSecret`.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest req)
        {
            return InternalRequestAsync<DeleteSecretResponse>(req, "DeleteSecret");
        }

        /// <summary>
        /// This API is used to delete a Secret. You can set whether to delete the Secret immediately or on schedule using the `RecoveryWindowInDays` parameter. For a Secret to be deleted on schedule, its status will be `PendingDelete` before the scheduled deletion time. You can use `RestoreSecret` to restore a deleted Secret during this time. A deleted Secret will not be restorable after the scheduled deletion time. A Secret can only be deleted after being disabled using `DisableSecret`.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public DeleteSecretResponse DeleteSecretSync(DeleteSecretRequest req)
        {
            return InternalRequestAsync<DeleteSecretResponse>(req, "DeleteSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to directly delete a single credential version under the specified credential. The deletion takes effect immediately, and the credential version in all status can be deleted.
        /// This API is only applicable to user-defined credentials but not Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretVersionRequest"/></param>
        /// <returns><see cref="DeleteSecretVersionResponse"/></returns>
        public Task<DeleteSecretVersionResponse> DeleteSecretVersion(DeleteSecretVersionRequest req)
        {
            return InternalRequestAsync<DeleteSecretVersionResponse>(req, "DeleteSecretVersion");
        }

        /// <summary>
        /// This API is used to directly delete a single credential version under the specified credential. The deletion takes effect immediately, and the credential version in all status can be deleted.
        /// This API is only applicable to user-defined credentials but not Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretVersionRequest"/></param>
        /// <returns><see cref="DeleteSecretVersionResponse"/></returns>
        public DeleteSecretVersionResponse DeleteSecretVersionSync(DeleteSecretVersionRequest req)
        {
            return InternalRequestAsync<DeleteSecretVersionResponse>(req, "DeleteSecretVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution result of an async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// This API is used to query the execution result of an async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a credential rotation policy.
        /// This API is only applicable to Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationDetailRequest"/></param>
        /// <returns><see cref="DescribeRotationDetailResponse"/></returns>
        public Task<DescribeRotationDetailResponse> DescribeRotationDetail(DescribeRotationDetailRequest req)
        {
            return InternalRequestAsync<DescribeRotationDetailResponse>(req, "DescribeRotationDetail");
        }

        /// <summary>
        /// This API is used to query the details of a credential rotation policy.
        /// This API is only applicable to Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationDetailRequest"/></param>
        /// <returns><see cref="DescribeRotationDetailResponse"/></returns>
        public DescribeRotationDetailResponse DescribeRotationDetailSync(DescribeRotationDetailRequest req)
        {
            return InternalRequestAsync<DescribeRotationDetailResponse>(req, "DescribeRotationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the historical versions of a rotated credential.
        /// This API is only applicable to Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationHistoryRequest"/></param>
        /// <returns><see cref="DescribeRotationHistoryResponse"/></returns>
        public Task<DescribeRotationHistoryResponse> DescribeRotationHistory(DescribeRotationHistoryRequest req)
        {
            return InternalRequestAsync<DescribeRotationHistoryResponse>(req, "DescribeRotationHistory");
        }

        /// <summary>
        /// This API is used to query the historical versions of a rotated credential.
        /// This API is only applicable to Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationHistoryRequest"/></param>
        /// <returns><see cref="DescribeRotationHistoryResponse"/></returns>
        public DescribeRotationHistoryResponse DescribeRotationHistorySync(DescribeRotationHistoryRequest req)
        {
            return InternalRequestAsync<DescribeRotationHistoryResponse>(req, "DescribeRotationHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the detailed attribute information of a Secret.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest req)
        {
            return InternalRequestAsync<DescribeSecretResponse>(req, "DescribeSecret");
        }

        /// <summary>
        /// This API is used to obtain the detailed attribute information of a Secret.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public DescribeSecretResponse DescribeSecretSync(DescribeSecretRequest req)
        {
            return InternalRequestAsync<DescribeSecretResponse>(req, "DescribeSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of supported Tencent Cloud services.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedProductsRequest"/></param>
        /// <returns><see cref="DescribeSupportedProductsResponse"/></returns>
        public Task<DescribeSupportedProductsResponse> DescribeSupportedProducts(DescribeSupportedProductsRequest req)
        {
            return InternalRequestAsync<DescribeSupportedProductsResponse>(req, "DescribeSupportedProducts");
        }

        /// <summary>
        /// This API is used to query the list of supported Tencent Cloud services.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedProductsRequest"/></param>
        /// <returns><see cref="DescribeSupportedProductsResponse"/></returns>
        public DescribeSupportedProductsResponse DescribeSupportedProductsSync(DescribeSupportedProductsRequest req)
        {
            return InternalRequestAsync<DescribeSupportedProductsResponse>(req, "DescribeSupportedProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a Secret and will change its status to `Disabled`. The plaintext of a disabled Secret cannot be obtained through APIs.
        /// </summary>
        /// <param name="req"><see cref="DisableSecretRequest"/></param>
        /// <returns><see cref="DisableSecretResponse"/></returns>
        public Task<DisableSecretResponse> DisableSecret(DisableSecretRequest req)
        {
            return InternalRequestAsync<DisableSecretResponse>(req, "DisableSecret");
        }

        /// <summary>
        /// This API is used to disable a Secret and will change its status to `Disabled`. The plaintext of a disabled Secret cannot be obtained through APIs.
        /// </summary>
        /// <param name="req"><see cref="DisableSecretRequest"/></param>
        /// <returns><see cref="DisableSecretResponse"/></returns>
        public DisableSecretResponse DisableSecretSync(DisableSecretRequest req)
        {
            return InternalRequestAsync<DisableSecretResponse>(req, "DisableSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a Secret and will change its status to `Enabled`. You can call the `GetSecretValue` API to obtain the plaintext of this Secret. Secrets in `PendingDelete` status can only be enabled after being restored by using `RestoreSecret`.
        /// </summary>
        /// <param name="req"><see cref="EnableSecretRequest"/></param>
        /// <returns><see cref="EnableSecretResponse"/></returns>
        public Task<EnableSecretResponse> EnableSecret(EnableSecretRequest req)
        {
            return InternalRequestAsync<EnableSecretResponse>(req, "EnableSecret");
        }

        /// <summary>
        /// This API is used to enable a Secret and will change its status to `Enabled`. You can call the `GetSecretValue` API to obtain the plaintext of this Secret. Secrets in `PendingDelete` status can only be enabled after being restored by using `RestoreSecret`.
        /// </summary>
        /// <param name="req"><see cref="EnableSecretRequest"/></param>
        /// <returns><see cref="EnableSecretResponse"/></returns>
        public EnableSecretResponse EnableSecretSync(EnableSecretRequest req)
        {
            return InternalRequestAsync<EnableSecretResponse>(req, "EnableSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of regions displayed on Console.
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public Task<GetRegionsResponse> GetRegions(GetRegionsRequest req)
        {
            return InternalRequestAsync<GetRegionsResponse>(req, "GetRegions");
        }

        /// <summary>
        /// This API is used to obtain the list of regions displayed on Console.
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public GetRegionsResponse GetRegionsSync(GetRegionsRequest req)
        {
            return InternalRequestAsync<GetRegionsResponse>(req, "GetRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the plaintext value of the SSH key secret.
        /// </summary>
        /// <param name="req"><see cref="GetSSHKeyPairValueRequest"/></param>
        /// <returns><see cref="GetSSHKeyPairValueResponse"/></returns>
        public Task<GetSSHKeyPairValueResponse> GetSSHKeyPairValue(GetSSHKeyPairValueRequest req)
        {
            return InternalRequestAsync<GetSSHKeyPairValueResponse>(req, "GetSSHKeyPairValue");
        }

        /// <summary>
        /// This API is used to obtain the plaintext value of the SSH key secret.
        /// </summary>
        /// <param name="req"><see cref="GetSSHKeyPairValueRequest"/></param>
        /// <returns><see cref="GetSSHKeyPairValueResponse"/></returns>
        public GetSSHKeyPairValueResponse GetSSHKeyPairValueSync(GetSSHKeyPairValueRequest req)
        {
            return InternalRequestAsync<GetSSHKeyPairValueResponse>(req, "GetSSHKeyPairValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// For user-defined credentials, this API is used to get the plaintext information of a credential by specifying the credential name and version.
        /// For Tencent Cloud service credentials such as MySQL credentials, this API is used to get the plaintext information of a previously rotated credential by specifying the credential name and historical version number. If you want to get the plaintext of the credential version currently in use, you need to specify the version number as `SSM_Current`.
        /// </summary>
        /// <param name="req"><see cref="GetSecretValueRequest"/></param>
        /// <returns><see cref="GetSecretValueResponse"/></returns>
        public Task<GetSecretValueResponse> GetSecretValue(GetSecretValueRequest req)
        {
            return InternalRequestAsync<GetSecretValueResponse>(req, "GetSecretValue");
        }

        /// <summary>
        /// For user-defined credentials, this API is used to get the plaintext information of a credential by specifying the credential name and version.
        /// For Tencent Cloud service credentials such as MySQL credentials, this API is used to get the plaintext information of a previously rotated credential by specifying the credential name and historical version number. If you want to get the plaintext of the credential version currently in use, you need to specify the version number as `SSM_Current`.
        /// </summary>
        /// <param name="req"><see cref="GetSecretValueRequest"/></param>
        /// <returns><see cref="GetSecretValueResponse"/></returns>
        public GetSecretValueResponse GetSecretValueSync(GetSecretValueRequest req)
        {
            return InternalRequestAsync<GetSecretValueResponse>(req, "GetSecretValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the SecretsManager service status of a user.
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public Task<GetServiceStatusResponse> GetServiceStatus(GetServiceStatusRequest req)
        {
            return InternalRequestAsync<GetServiceStatusResponse>(req, "GetServiceStatus");
        }

        /// <summary>
        /// This API is used to obtain the SecretsManager service status of a user.
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public GetServiceStatusResponse GetServiceStatusSync(GetServiceStatusRequest req)
        {
            return InternalRequestAsync<GetServiceStatusResponse>(req, "GetServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain list of versions of a Secret.
        /// </summary>
        /// <param name="req"><see cref="ListSecretVersionIdsRequest"/></param>
        /// <returns><see cref="ListSecretVersionIdsResponse"/></returns>
        public Task<ListSecretVersionIdsResponse> ListSecretVersionIds(ListSecretVersionIdsRequest req)
        {
            return InternalRequestAsync<ListSecretVersionIdsResponse>(req, "ListSecretVersionIds");
        }

        /// <summary>
        /// This API is used to obtain list of versions of a Secret.
        /// </summary>
        /// <param name="req"><see cref="ListSecretVersionIdsRequest"/></param>
        /// <returns><see cref="ListSecretVersionIdsResponse"/></returns>
        public ListSecretVersionIdsResponse ListSecretVersionIdsSync(ListSecretVersionIdsRequest req)
        {
            return InternalRequestAsync<ListSecretVersionIdsResponse>(req, "ListSecretVersionIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the detailed information list of all Secrets. You can specify the filter fields and sorting order as needed.
        /// </summary>
        /// <param name="req"><see cref="ListSecretsRequest"/></param>
        /// <returns><see cref="ListSecretsResponse"/></returns>
        public Task<ListSecretsResponse> ListSecrets(ListSecretsRequest req)
        {
            return InternalRequestAsync<ListSecretsResponse>(req, "ListSecrets");
        }

        /// <summary>
        /// This API is used to obtain the detailed information list of all Secrets. You can specify the filter fields and sorting order as needed.
        /// </summary>
        /// <param name="req"><see cref="ListSecretsRequest"/></param>
        /// <returns><see cref="ListSecretsResponse"/></returns>
        public ListSecretsResponse ListSecretsSync(ListSecretsRequest req)
        {
            return InternalRequestAsync<ListSecretsResponse>(req, "ListSecrets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API adds the new version of the credential content under the specified credential. One credential can have up to 10 versions. New versions can be added to credentials only in `Enabled` or `Disabled` status.
        /// This API is only applicable to user-defined credentials but not Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="PutSecretValueRequest"/></param>
        /// <returns><see cref="PutSecretValueResponse"/></returns>
        public Task<PutSecretValueResponse> PutSecretValue(PutSecretValueRequest req)
        {
            return InternalRequestAsync<PutSecretValueResponse>(req, "PutSecretValue");
        }

        /// <summary>
        /// This API adds the new version of the credential content under the specified credential. One credential can have up to 10 versions. New versions can be added to credentials only in `Enabled` or `Disabled` status.
        /// This API is only applicable to user-defined credentials but not Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="PutSecretValueRequest"/></param>
        /// <returns><see cref="PutSecretValueResponse"/></returns>
        public PutSecretValueResponse PutSecretValueSync(PutSecretValueRequest req)
        {
            return InternalRequestAsync<PutSecretValueResponse>(req, "PutSecretValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restore a `PendingDelete` Secret, canceling its scheduled deletion. The restored Secret will be in `Disabled` status. You can call the `EnableSecret` API to enable this Secret again.
        /// </summary>
        /// <param name="req"><see cref="RestoreSecretRequest"/></param>
        /// <returns><see cref="RestoreSecretResponse"/></returns>
        public Task<RestoreSecretResponse> RestoreSecret(RestoreSecretRequest req)
        {
            return InternalRequestAsync<RestoreSecretResponse>(req, "RestoreSecret");
        }

        /// <summary>
        /// This API is used to restore a `PendingDelete` Secret, canceling its scheduled deletion. The restored Secret will be in `Disabled` status. You can call the `EnableSecret` API to enable this Secret again.
        /// </summary>
        /// <param name="req"><see cref="RestoreSecretRequest"/></param>
        /// <returns><see cref="RestoreSecretResponse"/></returns>
        public RestoreSecretResponse RestoreSecretSync(RestoreSecretRequest req)
        {
            return InternalRequestAsync<RestoreSecretResponse>(req, "RestoreSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rotate secrets for Tencent Cloud services or Tencent Cloud API key pairs.
        /// Note that only the secrets with the "Enabled" status can be rotated.
        /// </summary>
        /// <param name="req"><see cref="RotateProductSecretRequest"/></param>
        /// <returns><see cref="RotateProductSecretResponse"/></returns>
        public Task<RotateProductSecretResponse> RotateProductSecret(RotateProductSecretRequest req)
        {
            return InternalRequestAsync<RotateProductSecretResponse>(req, "RotateProductSecret");
        }

        /// <summary>
        /// This API is used to rotate secrets for Tencent Cloud services or Tencent Cloud API key pairs.
        /// Note that only the secrets with the "Enabled" status can be rotated.
        /// </summary>
        /// <param name="req"><see cref="RotateProductSecretRequest"/></param>
        /// <returns><see cref="RotateProductSecretResponse"/></returns>
        public RotateProductSecretResponse RotateProductSecretSync(RotateProductSecretRequest req)
        {
            return InternalRequestAsync<RotateProductSecretResponse>(req, "RotateProductSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the description of a Secret. This API can only update Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="UpdateDescriptionRequest"/></param>
        /// <returns><see cref="UpdateDescriptionResponse"/></returns>
        public Task<UpdateDescriptionResponse> UpdateDescription(UpdateDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateDescriptionResponse>(req, "UpdateDescription");
        }

        /// <summary>
        /// This API is used to update the description of a Secret. This API can only update Secrets in `Enabled` or `Disabled` status.
        /// </summary>
        /// <param name="req"><see cref="UpdateDescriptionRequest"/></param>
        /// <returns><see cref="UpdateDescriptionResponse"/></returns>
        public UpdateDescriptionResponse UpdateDescriptionSync(UpdateDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateDescriptionResponse>(req, "UpdateDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set a Tencent Cloud service credential rotation policy, including the following parameters:
        /// Specifies whether to enable rotation
        /// Rotation frequency
        /// Rotation start time
        /// </summary>
        /// <param name="req"><see cref="UpdateRotationStatusRequest"/></param>
        /// <returns><see cref="UpdateRotationStatusResponse"/></returns>
        public Task<UpdateRotationStatusResponse> UpdateRotationStatus(UpdateRotationStatusRequest req)
        {
            return InternalRequestAsync<UpdateRotationStatusResponse>(req, "UpdateRotationStatus");
        }

        /// <summary>
        /// This API is used to set a Tencent Cloud service credential rotation policy, including the following parameters:
        /// Specifies whether to enable rotation
        /// Rotation frequency
        /// Rotation start time
        /// </summary>
        /// <param name="req"><see cref="UpdateRotationStatusRequest"/></param>
        /// <returns><see cref="UpdateRotationStatusResponse"/></returns>
        public UpdateRotationStatusResponse UpdateRotationStatusSync(UpdateRotationStatusRequest req)
        {
            return InternalRequestAsync<UpdateRotationStatusResponse>(req, "UpdateRotationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the credential content of the specified credential name and version number. Calling this API will encrypt the content of the new credential and overwrite the old content. Only credentials in `Enabled` or `Disabled` status can be updated.
        /// This API is only applicable to user-defined credentials but not Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="UpdateSecretRequest"/></param>
        /// <returns><see cref="UpdateSecretResponse"/></returns>
        public Task<UpdateSecretResponse> UpdateSecret(UpdateSecretRequest req)
        {
            return InternalRequestAsync<UpdateSecretResponse>(req, "UpdateSecret");
        }

        /// <summary>
        /// This API is used to update the credential content of the specified credential name and version number. Calling this API will encrypt the content of the new credential and overwrite the old content. Only credentials in `Enabled` or `Disabled` status can be updated.
        /// This API is only applicable to user-defined credentials but not Tencent Cloud service credentials.
        /// </summary>
        /// <param name="req"><see cref="UpdateSecretRequest"/></param>
        /// <returns><see cref="UpdateSecretResponse"/></returns>
        public UpdateSecretResponse UpdateSecretSync(UpdateSecretRequest req)
        {
            return InternalRequestAsync<UpdateSecretResponse>(req, "UpdateSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
