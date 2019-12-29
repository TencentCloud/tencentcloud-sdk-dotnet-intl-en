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

namespace TencentCloud.Kms.V20190118
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Kms.V20190118.Models;

   public class KmsClient : AbstractClient{

       private const string endpoint = "kms.tencentcloudapi.com";
       private const string version = "2019-01-18";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public KmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public KmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 取消CMK的计划删除操作
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletion(CancelKeyDeletionRequest req)
        {
             JsonResponseModel<CancelKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户管理数据密钥的主密钥CMK（Custom Master Key）。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
        public async Task<CreateKeyResponse> CreateKey(CreateKeyRequest req)
        {
             JsonResponseModel<CreateKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于解密密文，得到明文数据。
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
        public async Task<DecryptResponse> Decrypt(DecryptRequest req)
        {
             JsonResponseModel<DecryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Decrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the imported key material. It is only valid for EXTERNAL CMKs. Specifically, it puts a CMK into `PendingImport` status instead of deleting the CMK, so that the CMK can be used again after key material is reimported. To delete the CMK completely, please call the `ScheduleKeyDeletion` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
        public async Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest req)
        {
             JsonResponseModel<DeleteImportedKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImportedKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImportedKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于禁用一个主密钥，处于禁用状态的Key无法用于加密、解密操作。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
        public async Task<DisableKeyResponse> DisableKey(DisableKeyRequest req)
        {
             JsonResponseModel<DisableKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对指定的CMK禁止密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
        public async Task<DisableKeyRotationResponse> DisableKeyRotation(DisableKeyRotationRequest req)
        {
             JsonResponseModel<DisableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量禁止CMK的使用。
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
        public async Task<DisableKeysResponse> DisableKeys(DisableKeysRequest req)
        {
             JsonResponseModel<DisableKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于启用一个指定的CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
        public async Task<EnableKeyResponse> EnableKey(EnableKeyRequest req)
        {
             JsonResponseModel<EnableKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对指定的CMK开启密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
        public async Task<EnableKeyRotationResponse> EnableKeyRotation(EnableKeyRotationRequest req)
        {
             JsonResponseModel<EnableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量启用CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
        public async Task<EnableKeysResponse> EnableKeys(EnableKeysRequest req)
        {
             JsonResponseModel<EnableKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
        public async Task<EncryptResponse> Encrypt(EncryptRequest req)
        {
             JsonResponseModel<EncryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Encrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口生成一个数据密钥，您可以用这个密钥进行本地数据的加密。
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
        public async Task<GenerateDataKeyResponse> GenerateDataKey(GenerateDataKeyRequest req)
        {
             JsonResponseModel<GenerateDataKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateDataKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateDataKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate a random number.
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
        public async Task<GenerateRandomResponse> GenerateRandom(GenerateRandomRequest req)
        {
             JsonResponseModel<GenerateRandomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateRandom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateRandomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定的CMK是否开启了密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
        public async Task<GetKeyRotationStatusResponse> GetKeyRotationStatus(GetKeyRotationStatusRequest req)
        {
             JsonResponseModel<GetKeyRotationStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetKeyRotationStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetKeyRotationStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the parameters of the material to be imported into a CMK. The returned `Token` is used as one of the parameters to execute `ImportKeyMaterial`, and the returned `PublicKey` is used to encrypt the key material. The `Token` and `PublicKey` are valid for 24 hours. If they are expired, you will need to call the API again to get a new `Token` and `PublicKey`.
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
        public async Task<GetParametersForImportResponse> GetParametersForImport(GetParametersForImportRequest req)
        {
             JsonResponseModel<GetParametersForImportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetParametersForImport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetParametersForImportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询该用户是否已开通KMS服务
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
        /// This API is used to import key material into an EXTERNAL CMK. The key obtained through the `GetParametersForImport` API is used to encrypt the key material. You can only reimport the same key material into the specified CMK and set a new expiration time. After the CMK key material is imported, it cannot be replaced. After the key material is expired or deleted, the CMK will remain unavailable until the same key material is reimported. CMKs are independent, which means that the same key material can be imported into different CMKs, but data encrypted by one CMK cannot be decrypted by another one.
        /// Key material can only be imported into CMKs in `Enabled` and `PendingImport` status.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterial(ImportKeyMaterialRequest req)
        {
             JsonResponseModel<ImportKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定Offset和Limit获取主密钥列表详情。
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
        public async Task<ListKeyDetailResponse> ListKeyDetail(ListKeyDetailRequest req)
        {
             JsonResponseModel<ListKeyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListKeyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the KeyIds of CMKs in `Enabled`, `Disabled`, and `PendingImport` status under the account.
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
        public async Task<ListKeysResponse> ListKeys(ListKeysRequest req)
        {
             JsonResponseModel<ListKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用指定CMK对密文重新加密。
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
        public async Task<ReEncryptResponse> ReEncrypt(ReEncryptRequest req)
        {
             JsonResponseModel<ReEncryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReEncrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReEncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CMK计划删除接口，用于指定CMK删除的时间，可选时间区间为[7,30]天
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
        public async Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletion(ScheduleKeyDeletionRequest req)
        {
             JsonResponseModel<ScheduleKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScheduleKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScheduleKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the alias of a CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public async Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the description of the specified CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescription(UpdateKeyDescriptionRequest req)
        {
             JsonResponseModel<UpdateKeyDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateKeyDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateKeyDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
