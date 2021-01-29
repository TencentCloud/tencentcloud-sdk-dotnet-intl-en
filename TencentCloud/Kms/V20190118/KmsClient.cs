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
        /// This API is used to archive keys. The archived keys can only be used for decryption but not encryption.
        /// </summary>
        /// <param name="req"><see cref="ArchiveKeyRequest"/></param>
        /// <returns><see cref="ArchiveKeyResponse"/></returns>
        public async Task<ArchiveKeyResponse> ArchiveKey(ArchiveKeyRequest req)
        {
             JsonResponseModel<ArchiveKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ArchiveKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ArchiveKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to archive keys. The archived keys can only be used for decryption but not encryption.
        /// </summary>
        /// <param name="req"><see cref="ArchiveKeyRequest"/></param>
        /// <returns><see cref="ArchiveKeyResponse"/></returns>
        public ArchiveKeyResponse ArchiveKeySync(ArchiveKeyRequest req)
        {
             JsonResponseModel<ArchiveKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ArchiveKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ArchiveKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with RSA asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public async Task<AsymmetricRsaDecryptResponse> AsymmetricRsaDecrypt(AsymmetricRsaDecryptRequest req)
        {
             JsonResponseModel<AsymmetricRsaDecryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AsymmetricRsaDecrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricRsaDecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with RSA asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public AsymmetricRsaDecryptResponse AsymmetricRsaDecryptSync(AsymmetricRsaDecryptRequest req)
        {
             JsonResponseModel<AsymmetricRsaDecryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AsymmetricRsaDecrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricRsaDecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with SM2 asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption. The length of the ciphertext passed in cannot exceed 256 bytes.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public async Task<AsymmetricSm2DecryptResponse> AsymmetricSm2Decrypt(AsymmetricSm2DecryptRequest req)
        {
             JsonResponseModel<AsymmetricSm2DecryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AsymmetricSm2Decrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricSm2DecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with SM2 asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption. The length of the ciphertext passed in cannot exceed 256 bytes.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public AsymmetricSm2DecryptResponse AsymmetricSm2DecryptSync(AsymmetricSm2DecryptRequest req)
        {
             JsonResponseModel<AsymmetricSm2DecryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AsymmetricSm2Decrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricSm2DecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a key with a Tencent Cloud resource. If the key has been set to be expired automatically, the setting will be canceled to ensure that the key will not be invalid automatically. If the key and the resource has already been bound, the call will still be successful.
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public async Task<BindCloudResourceResponse> BindCloudResource(BindCloudResourceRequest req)
        {
             JsonResponseModel<BindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindCloudResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a key with a Tencent Cloud resource. If the key has been set to be expired automatically, the setting will be canceled to ensure that the key will not be invalid automatically. If the key and the resource has already been bound, the call will still be successful.
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public BindCloudResourceResponse BindCloudResourceSync(BindCloudResourceRequest req)
        {
             JsonResponseModel<BindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindCloudResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unarchive keys. If a key is unarchived, its status will be `Enabled`.
        /// </summary>
        /// <param name="req"><see cref="CancelKeyArchiveRequest"/></param>
        /// <returns><see cref="CancelKeyArchiveResponse"/></returns>
        public async Task<CancelKeyArchiveResponse> CancelKeyArchive(CancelKeyArchiveRequest req)
        {
             JsonResponseModel<CancelKeyArchiveResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelKeyArchive");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelKeyArchiveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unarchive keys. If a key is unarchived, its status will be `Enabled`.
        /// </summary>
        /// <param name="req"><see cref="CancelKeyArchiveRequest"/></param>
        /// <returns><see cref="CancelKeyArchiveResponse"/></returns>
        public CancelKeyArchiveResponse CancelKeyArchiveSync(CancelKeyArchiveRequest req)
        {
             JsonResponseModel<CancelKeyArchiveResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelKeyArchive");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelKeyArchiveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cancel the scheduled deletion of CMK
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
        /// Cancel the scheduled deletion of CMK
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
        public CancelKeyDeletionResponse CancelKeyDeletionSync(CancelKeyDeletionRequest req)
        {
             JsonResponseModel<CancelKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a master key CMK (Custom Master Key) for user management data keys
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
        /// Create a master key CMK (Custom Master Key) for user management data keys
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
        public CreateKeyResponse CreateKeySync(CreateKeyRequest req)
        {
             JsonResponseModel<CreateKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a white-box key. Up to 50 ones can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public async Task<CreateWhiteBoxKeyResponse> CreateWhiteBoxKey(CreateWhiteBoxKeyRequest req)
        {
             JsonResponseModel<CreateWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a white-box key. Up to 50 ones can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public CreateWhiteBoxKeyResponse CreateWhiteBoxKeySync(CreateWhiteBoxKeyRequest req)
        {
             JsonResponseModel<CreateWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to decrypt the ciphertext and obtain the plaintext data.
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
        /// This API is used to decrypt the ciphertext and obtain the plaintext data.
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
        public DecryptResponse DecryptSync(DecryptRequest req)
        {
             JsonResponseModel<DecryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Decrypt");
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
        /// This API is used to delete the imported key material. It is only valid for EXTERNAL CMKs. Specifically, it puts a CMK into `PendingImport` status instead of deleting the CMK, so that the CMK can be used again after key material is reimported. To delete the CMK completely, please call the `ScheduleKeyDeletion` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterialSync(DeleteImportedKeyMaterialRequest req)
        {
             JsonResponseModel<DeleteImportedKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImportedKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImportedKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a white-box key. Note: only disabled white-box keys can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public async Task<DeleteWhiteBoxKeyResponse> DeleteWhiteBoxKey(DeleteWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DeleteWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a white-box key. Note: only disabled white-box keys can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public DeleteWhiteBoxKeyResponse DeleteWhiteBoxKeySync(DeleteWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DeleteWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attribute details of the CMK with a specified `KeyId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
        public async Task<DescribeKeyResponse> DescribeKey(DescribeKeyRequest req)
        {
             JsonResponseModel<DescribeKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attribute details of the CMK with a specified `KeyId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
        public DescribeKeyResponse DescribeKeySync(DescribeKeyRequest req)
        {
             JsonResponseModel<DescribeKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attribute information of CMKs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public async Task<DescribeKeysResponse> DescribeKeys(DescribeKeysRequest req)
        {
             JsonResponseModel<DescribeKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attribute information of CMKs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public DescribeKeysResponse DescribeKeysSync(DescribeKeysRequest req)
        {
             JsonResponseModel<DescribeKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a white-box decryption key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public async Task<DescribeWhiteBoxDecryptKeyResponse> DescribeWhiteBoxDecryptKey(DescribeWhiteBoxDecryptKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxDecryptKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a white-box decryption key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public DescribeWhiteBoxDecryptKeyResponse DescribeWhiteBoxDecryptKeySync(DescribeWhiteBoxDecryptKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxDecryptKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the device fingerprint list of a specified key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public async Task<DescribeWhiteBoxDeviceFingerprintsResponse> DescribeWhiteBoxDeviceFingerprints(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the device fingerprint list of a specified key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public DescribeWhiteBoxDeviceFingerprintsResponse DescribeWhiteBoxDeviceFingerprintsSync(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display white-box key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public async Task<DescribeWhiteBoxKeyResponse> DescribeWhiteBoxKey(DescribeWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display white-box key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public DescribeWhiteBoxKeyResponse DescribeWhiteBoxKeySync(DescribeWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the white-box key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public async Task<DescribeWhiteBoxKeyDetailsResponse> DescribeWhiteBoxKeyDetails(DescribeWhiteBoxKeyDetailsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxKeyDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the white-box key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public DescribeWhiteBoxKeyDetailsResponse DescribeWhiteBoxKeyDetailsSync(DescribeWhiteBoxKeyDetailsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxKeyDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the white-box key service status.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public async Task<DescribeWhiteBoxServiceStatusResponse> DescribeWhiteBoxServiceStatus(DescribeWhiteBoxServiceStatusRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the white-box key service status.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public DescribeWhiteBoxServiceStatusResponse DescribeWhiteBoxServiceStatusSync(DescribeWhiteBoxServiceStatusRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a master key. The disabled key cannot be used for encryption and decryption operations.
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
        /// This API is used to disable a master key. The disabled key cannot be used for encryption and decryption operations.
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
        public DisableKeyResponse DisableKeySync(DisableKeyRequest req)
        {
             JsonResponseModel<DisableKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Disabled key rotation for the specified CMK.
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
        /// Disabled key rotation for the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
        public DisableKeyRotationResponse DisableKeyRotationSync(DisableKeyRotationRequest req)
        {
             JsonResponseModel<DisableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch prohibit the use of CMK.
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
        /// This API is used to batch prohibit the use of CMK.
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
        public DisableKeysResponse DisableKeysSync(DisableKeysRequest req)
        {
             JsonResponseModel<DisableKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public async Task<DisableWhiteBoxKeyResponse> DisableWhiteBoxKey(DisableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public DisableWhiteBoxKeyResponse DisableWhiteBoxKeySync(DisableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public async Task<DisableWhiteBoxKeysResponse> DisableWhiteBoxKeys(DisableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public DisableWhiteBoxKeysResponse DisableWhiteBoxKeysSync(DisableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Enable a specified CMK.
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
        /// Enable a specified CMK.
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
        public EnableKeyResponse EnableKeySync(EnableKeyRequest req)
        {
             JsonResponseModel<EnableKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Turn on the key rotation function for the specified CMK.
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
        /// Turn on the key rotation function for the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
        public EnableKeyRotationResponse EnableKeyRotationSync(EnableKeyRotationRequest req)
        {
             JsonResponseModel<EnableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable CMK in batches.
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
        /// This API is used to enable CMK in batches.
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
        public EnableKeysResponse EnableKeysSync(EnableKeysRequest req)
        {
             JsonResponseModel<EnableKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public async Task<EnableWhiteBoxKeyResponse> EnableWhiteBoxKey(EnableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public EnableWhiteBoxKeyResponse EnableWhiteBoxKeySync(EnableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public async Task<EnableWhiteBoxKeysResponse> EnableWhiteBoxKeys(EnableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public EnableWhiteBoxKeysResponse EnableWhiteBoxKeysSync(EnableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to encrypt any data up to 4KB. It can be used to encrypt database passwords, RSA Key, or other small sensitive information. For application data encryption, use the DataKey generated by GenerateDataKey to perform local data encryption and decryption operations
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
        /// This API is used to encrypt any data up to 4KB. It can be used to encrypt database passwords, RSA Key, or other small sensitive information. For application data encryption, use the DataKey generated by GenerateDataKey to perform local data encryption and decryption operations
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
        public EncryptResponse EncryptSync(EncryptRequest req)
        {
             JsonResponseModel<EncryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Encrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to encrypt data with a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public async Task<EncryptByWhiteBoxResponse> EncryptByWhiteBox(EncryptByWhiteBoxRequest req)
        {
             JsonResponseModel<EncryptByWhiteBoxResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EncryptByWhiteBox");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptByWhiteBoxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to encrypt data with a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public EncryptByWhiteBoxResponse EncryptByWhiteBoxSync(EncryptByWhiteBoxRequest req)
        {
             JsonResponseModel<EncryptByWhiteBoxResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EncryptByWhiteBox");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptByWhiteBoxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API generates a data key, which you can use to encrypt local data.
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
        /// This API generates a data key, which you can use to encrypt local data.
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
        public GenerateDataKeyResponse GenerateDataKeySync(GenerateDataKeyRequest req)
        {
             JsonResponseModel<GenerateDataKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateDataKey");
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
        /// This API is used to generate a random number.
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
        public GenerateRandomResponse GenerateRandomSync(GenerateRandomRequest req)
        {
             JsonResponseModel<GenerateRandomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateRandom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateRandomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query whether the specified CMK has the key rotation function.
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
        /// Query whether the specified CMK has the key rotation function.
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
        public GetKeyRotationStatusResponse GetKeyRotationStatusSync(GetKeyRotationStatusRequest req)
        {
             JsonResponseModel<GetKeyRotationStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetKeyRotationStatus");
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
        /// This API is used to obtain the parameters of the material to be imported into a CMK. The returned `Token` is used as one of the parameters to execute `ImportKeyMaterial`, and the returned `PublicKey` is used to encrypt the key material. The `Token` and `PublicKey` are valid for 24 hours. If they are expired, you will need to call the API again to get a new `Token` and `PublicKey`.
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
        public GetParametersForImportResponse GetParametersForImportSync(GetParametersForImportRequest req)
        {
             JsonResponseModel<GetParametersForImportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetParametersForImport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetParametersForImportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the public key that is encrypted with the asymmetric cryptographic algorithm and of which the `KeyUsage` is `ASYMMETRIC_DECRYPT_RSA_2048` or `ASYMMETRIC_DECRYPT_SM2`. This public key can be used to encrypt data locally, and the data encrypted with it can only be decrypted with the corresponding private key through KMS. The public key can only be obtained from the asymmetric key in `Enabled` state.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public async Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the public key that is encrypted with the asymmetric cryptographic algorithm and of which the `KeyUsage` is `ASYMMETRIC_DECRYPT_RSA_2048` or `ASYMMETRIC_DECRYPT_SM2`. This public key can be used to encrypt data locally, and the data encrypted with it can only be decrypted with the corresponding private key through KMS. The public key can only be obtained from the asymmetric key in `Enabled` state.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of supported regions.
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
        /// This API is used to obtain the list of supported regions.
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
        /// Used to query whether the user has activated the KMS service.
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
        /// Used to query whether the user has activated the KMS service.
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
        /// This API is used to import key material into an EXTERNAL CMK. The key obtained through the `GetParametersForImport` API is used to encrypt the key material. You can only reimport the same key material into the specified CMK and set a new expiration time. After the CMK key material is imported, it cannot be replaced. After the key material is expired or deleted, the CMK will remain unavailable until the same key material is reimported. CMKs are independent, which means that the same key material can be imported into different CMKs, but data encrypted by one CMK cannot be decrypted by another one.
        /// Key material can only be imported into CMKs in `Enabled` and `PendingImport` status.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
        public ImportKeyMaterialResponse ImportKeyMaterialSync(ImportKeyMaterialRequest req)
        {
             JsonResponseModel<ImportKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the encryption methods supported in the current region.
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public async Task<ListAlgorithmsResponse> ListAlgorithms(ListAlgorithmsRequest req)
        {
             JsonResponseModel<ListAlgorithmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAlgorithms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAlgorithmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the encryption methods supported in the current region.
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public ListAlgorithmsResponse ListAlgorithmsSync(ListAlgorithmsRequest req)
        {
             JsonResponseModel<ListAlgorithmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAlgorithms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAlgorithmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Get the master key list details according to the specified Offset and Limit.
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
        /// Get the master key list details according to the specified Offset and Limit.
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
        public ListKeyDetailResponse ListKeyDetailSync(ListKeyDetailRequest req)
        {
             JsonResponseModel<ListKeyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListKeyDetail");
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
        /// This API is used to list the KeyIds of CMKs in `Enabled`, `Disabled`, and `PendingImport` status under the account.
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
        public ListKeysResponse ListKeysSync(ListKeysRequest req)
        {
             JsonResponseModel<ListKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to overwrite the device fingerprint information of a specified key.
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public async Task<OverwriteWhiteBoxDeviceFingerprintsResponse> OverwriteWhiteBoxDeviceFingerprints(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OverwriteWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to overwrite the device fingerprint information of a specified key.
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public OverwriteWhiteBoxDeviceFingerprintsResponse OverwriteWhiteBoxDeviceFingerprintsSync(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OverwriteWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Re-encrypt the ciphertext using the specified CMK.
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
        /// Re-encrypt the ciphertext using the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
        public ReEncryptResponse ReEncryptSync(ReEncryptRequest req)
        {
             JsonResponseModel<ReEncryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReEncrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReEncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CMK planned deletion API, used to specify the time of CMK deletion, the optional time interval is [7,30] days
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
        /// CMK planned deletion API, used to specify the time of CMK deletion, the optional time interval is [7,30] days
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletionSync(ScheduleKeyDeletionRequest req)
        {
             JsonResponseModel<ScheduleKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScheduleKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScheduleKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate a signature with an asymmetric key.
        /// Note: only the keys with `KeyUsage= ASYMMETRIC_SIGN_VERIFY_SM2` can be used for signature generation.
        /// </summary>
        /// <param name="req"><see cref="SignByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="SignByAsymmetricKeyResponse"/></returns>
        public async Task<SignByAsymmetricKeyResponse> SignByAsymmetricKey(SignByAsymmetricKeyRequest req)
        {
             JsonResponseModel<SignByAsymmetricKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SignByAsymmetricKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignByAsymmetricKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate a signature with an asymmetric key.
        /// Note: only the keys with `KeyUsage= ASYMMETRIC_SIGN_VERIFY_SM2` can be used for signature generation.
        /// </summary>
        /// <param name="req"><see cref="SignByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="SignByAsymmetricKeyResponse"/></returns>
        public SignByAsymmetricKeyResponse SignByAsymmetricKeySync(SignByAsymmetricKeyRequest req)
        {
             JsonResponseModel<SignByAsymmetricKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SignByAsymmetricKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignByAsymmetricKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a key with a Tencent Cloud resource, indicating that the Tencent Cloud resource will not use the key any longer.
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public async Task<UnbindCloudResourceResponse> UnbindCloudResource(UnbindCloudResourceRequest req)
        {
             JsonResponseModel<UnbindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCloudResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a key with a Tencent Cloud resource, indicating that the Tencent Cloud resource will not use the key any longer.
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public UnbindCloudResourceResponse UnbindCloudResourceSync(UnbindCloudResourceRequest req)
        {
             JsonResponseModel<UnbindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCloudResourceResponse>>(strResp);
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
        /// This API is used to modify the alias of a CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlias");
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

        /// <summary>
        /// This API is used to modify the description of the specified CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
        public UpdateKeyDescriptionResponse UpdateKeyDescriptionSync(UpdateKeyDescriptionRequest req)
        {
             JsonResponseModel<UpdateKeyDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateKeyDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateKeyDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a signature with an asymmetric key.
        /// </summary>
        /// <param name="req"><see cref="VerifyByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="VerifyByAsymmetricKeyResponse"/></returns>
        public async Task<VerifyByAsymmetricKeyResponse> VerifyByAsymmetricKey(VerifyByAsymmetricKeyRequest req)
        {
             JsonResponseModel<VerifyByAsymmetricKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyByAsymmetricKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyByAsymmetricKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a signature with an asymmetric key.
        /// </summary>
        /// <param name="req"><see cref="VerifyByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="VerifyByAsymmetricKeyResponse"/></returns>
        public VerifyByAsymmetricKeyResponse VerifyByAsymmetricKeySync(VerifyByAsymmetricKeyRequest req)
        {
             JsonResponseModel<VerifyByAsymmetricKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyByAsymmetricKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyByAsymmetricKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
