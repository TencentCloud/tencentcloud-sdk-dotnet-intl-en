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
       private const string sdkVersion = "SDK_NET_3.0.997";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public KmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to archive keys. The archived keys can only be used for decryption but not encryption.
        /// </summary>
        /// <param name="req"><see cref="ArchiveKeyRequest"/></param>
        /// <returns><see cref="ArchiveKeyResponse"/></returns>
        public Task<ArchiveKeyResponse> ArchiveKey(ArchiveKeyRequest req)
        {
            return InternalRequestAsync<ArchiveKeyResponse>(req, "ArchiveKey");
        }

        /// <summary>
        /// This API is used to archive keys. The archived keys can only be used for decryption but not encryption.
        /// </summary>
        /// <param name="req"><see cref="ArchiveKeyRequest"/></param>
        /// <returns><see cref="ArchiveKeyResponse"/></returns>
        public ArchiveKeyResponse ArchiveKeySync(ArchiveKeyRequest req)
        {
            return InternalRequestAsync<ArchiveKeyResponse>(req, "ArchiveKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with RSA asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public Task<AsymmetricRsaDecryptResponse> AsymmetricRsaDecrypt(AsymmetricRsaDecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricRsaDecryptResponse>(req, "AsymmetricRsaDecrypt");
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with RSA asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public AsymmetricRsaDecryptResponse AsymmetricRsaDecryptSync(AsymmetricRsaDecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricRsaDecryptResponse>(req, "AsymmetricRsaDecrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with SM2 asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption. The length of the ciphertext passed in cannot exceed 256 bytes.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public Task<AsymmetricSm2DecryptResponse> AsymmetricSm2Decrypt(AsymmetricSm2DecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricSm2DecryptResponse>(req, "AsymmetricSm2Decrypt");
        }

        /// <summary>
        /// This API is used to decrypt data with the specified private key that is encrypted with SM2 asymmetric cryptographic algorithm. The ciphertext must be encrypted with the corresponding public key. The asymmetric key must be in `Enabled` state for decryption. The length of the ciphertext passed in cannot exceed 256 bytes.
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public AsymmetricSm2DecryptResponse AsymmetricSm2DecryptSync(AsymmetricSm2DecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricSm2DecryptResponse>(req, "AsymmetricSm2Decrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a key with a Tencent Cloud resource. If the key has been set to be expired automatically, the setting will be canceled to ensure that the key will not be invalid automatically. If the key and the resource has already been bound, the call will still be successful.
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public Task<BindCloudResourceResponse> BindCloudResource(BindCloudResourceRequest req)
        {
            return InternalRequestAsync<BindCloudResourceResponse>(req, "BindCloudResource");
        }

        /// <summary>
        /// This API is used to bind a key with a Tencent Cloud resource. If the key has been set to be expired automatically, the setting will be canceled to ensure that the key will not be invalid automatically. If the key and the resource has already been bound, the call will still be successful.
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public BindCloudResourceResponse BindCloudResourceSync(BindCloudResourceRequest req)
        {
            return InternalRequestAsync<BindCloudResourceResponse>(req, "BindCloudResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unarchive keys. If a key is unarchived, its status will be `Enabled`.
        /// </summary>
        /// <param name="req"><see cref="CancelKeyArchiveRequest"/></param>
        /// <returns><see cref="CancelKeyArchiveResponse"/></returns>
        public Task<CancelKeyArchiveResponse> CancelKeyArchive(CancelKeyArchiveRequest req)
        {
            return InternalRequestAsync<CancelKeyArchiveResponse>(req, "CancelKeyArchive");
        }

        /// <summary>
        /// This API is used to unarchive keys. If a key is unarchived, its status will be `Enabled`.
        /// </summary>
        /// <param name="req"><see cref="CancelKeyArchiveRequest"/></param>
        /// <returns><see cref="CancelKeyArchiveResponse"/></returns>
        public CancelKeyArchiveResponse CancelKeyArchiveSync(CancelKeyArchiveRequest req)
        {
            return InternalRequestAsync<CancelKeyArchiveResponse>(req, "CancelKeyArchive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cancel the scheduled deletion of CMK
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
        public Task<CancelKeyDeletionResponse> CancelKeyDeletion(CancelKeyDeletionRequest req)
        {
            return InternalRequestAsync<CancelKeyDeletionResponse>(req, "CancelKeyDeletion");
        }

        /// <summary>
        /// Cancel the scheduled deletion of CMK
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
        public CancelKeyDeletionResponse CancelKeyDeletionSync(CancelKeyDeletionRequest req)
        {
            return InternalRequestAsync<CancelKeyDeletionResponse>(req, "CancelKeyDeletion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a master key CMK (Custom Master Key) for user management data keys
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
        public Task<CreateKeyResponse> CreateKey(CreateKeyRequest req)
        {
            return InternalRequestAsync<CreateKeyResponse>(req, "CreateKey");
        }

        /// <summary>
        /// Create a master key CMK (Custom Master Key) for user management data keys
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
        public CreateKeyResponse CreateKeySync(CreateKeyRequest req)
        {
            return InternalRequestAsync<CreateKeyResponse>(req, "CreateKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a white-box key. Up to 50 ones can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public Task<CreateWhiteBoxKeyResponse> CreateWhiteBoxKey(CreateWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<CreateWhiteBoxKeyResponse>(req, "CreateWhiteBoxKey");
        }

        /// <summary>
        /// This API is used to create a white-box key. Up to 50 ones can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public CreateWhiteBoxKeyResponse CreateWhiteBoxKeySync(CreateWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<CreateWhiteBoxKeyResponse>(req, "CreateWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to decrypt the ciphertext and obtain the plaintext data.
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
        public Task<DecryptResponse> Decrypt(DecryptRequest req)
        {
            return InternalRequestAsync<DecryptResponse>(req, "Decrypt");
        }

        /// <summary>
        /// This API is used to decrypt the ciphertext and obtain the plaintext data.
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
        public DecryptResponse DecryptSync(DecryptRequest req)
        {
            return InternalRequestAsync<DecryptResponse>(req, "Decrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the imported key material. It is only valid for EXTERNAL CMKs. Specifically, it puts a CMK into `PendingImport` status instead of deleting the CMK, so that the CMK can be used again after key material is reimported. To delete the CMK completely, please call the `ScheduleKeyDeletion` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
        public Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest req)
        {
            return InternalRequestAsync<DeleteImportedKeyMaterialResponse>(req, "DeleteImportedKeyMaterial");
        }

        /// <summary>
        /// This API is used to delete the imported key material. It is only valid for EXTERNAL CMKs. Specifically, it puts a CMK into `PendingImport` status instead of deleting the CMK, so that the CMK can be used again after key material is reimported. To delete the CMK completely, please call the `ScheduleKeyDeletion` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterialSync(DeleteImportedKeyMaterialRequest req)
        {
            return InternalRequestAsync<DeleteImportedKeyMaterialResponse>(req, "DeleteImportedKeyMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a white-box key. Note: only disabled white-box keys can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public Task<DeleteWhiteBoxKeyResponse> DeleteWhiteBoxKey(DeleteWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DeleteWhiteBoxKeyResponse>(req, "DeleteWhiteBoxKey");
        }

        /// <summary>
        /// This API is used to delete a white-box key. Note: only disabled white-box keys can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public DeleteWhiteBoxKeyResponse DeleteWhiteBoxKeySync(DeleteWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DeleteWhiteBoxKeyResponse>(req, "DeleteWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the attribute details of the CMK with a specified `KeyId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
        public Task<DescribeKeyResponse> DescribeKey(DescribeKeyRequest req)
        {
            return InternalRequestAsync<DescribeKeyResponse>(req, "DescribeKey");
        }

        /// <summary>
        /// This API is used to get the attribute details of the CMK with a specified `KeyId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
        public DescribeKeyResponse DescribeKeySync(DescribeKeyRequest req)
        {
            return InternalRequestAsync<DescribeKeyResponse>(req, "DescribeKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the attribute information of CMKs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public Task<DescribeKeysResponse> DescribeKeys(DescribeKeysRequest req)
        {
            return InternalRequestAsync<DescribeKeysResponse>(req, "DescribeKeys");
        }

        /// <summary>
        /// This API is used to get the attribute information of CMKs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public DescribeKeysResponse DescribeKeysSync(DescribeKeysRequest req)
        {
            return InternalRequestAsync<DescribeKeysResponse>(req, "DescribeKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a white-box decryption key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public Task<DescribeWhiteBoxDecryptKeyResponse> DescribeWhiteBoxDecryptKey(DescribeWhiteBoxDecryptKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDecryptKeyResponse>(req, "DescribeWhiteBoxDecryptKey");
        }

        /// <summary>
        /// This API is used to get a white-box decryption key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public DescribeWhiteBoxDecryptKeyResponse DescribeWhiteBoxDecryptKeySync(DescribeWhiteBoxDecryptKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDecryptKeyResponse>(req, "DescribeWhiteBoxDecryptKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the device fingerprint list of a specified key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public Task<DescribeWhiteBoxDeviceFingerprintsResponse> DescribeWhiteBoxDeviceFingerprints(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDeviceFingerprintsResponse>(req, "DescribeWhiteBoxDeviceFingerprints");
        }

        /// <summary>
        /// This API is used to get the device fingerprint list of a specified key.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public DescribeWhiteBoxDeviceFingerprintsResponse DescribeWhiteBoxDeviceFingerprintsSync(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDeviceFingerprintsResponse>(req, "DescribeWhiteBoxDeviceFingerprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display white-box key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public Task<DescribeWhiteBoxKeyResponse> DescribeWhiteBoxKey(DescribeWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyResponse>(req, "DescribeWhiteBoxKey");
        }

        /// <summary>
        /// This API is used to display white-box key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public DescribeWhiteBoxKeyResponse DescribeWhiteBoxKeySync(DescribeWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyResponse>(req, "DescribeWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the white-box key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public Task<DescribeWhiteBoxKeyDetailsResponse> DescribeWhiteBoxKeyDetails(DescribeWhiteBoxKeyDetailsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyDetailsResponse>(req, "DescribeWhiteBoxKeyDetails");
        }

        /// <summary>
        /// This API is used to get the white-box key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public DescribeWhiteBoxKeyDetailsResponse DescribeWhiteBoxKeyDetailsSync(DescribeWhiteBoxKeyDetailsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyDetailsResponse>(req, "DescribeWhiteBoxKeyDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the white-box key service status.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public Task<DescribeWhiteBoxServiceStatusResponse> DescribeWhiteBoxServiceStatus(DescribeWhiteBoxServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxServiceStatusResponse>(req, "DescribeWhiteBoxServiceStatus");
        }

        /// <summary>
        /// This API is used to get the white-box key service status.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public DescribeWhiteBoxServiceStatusResponse DescribeWhiteBoxServiceStatusSync(DescribeWhiteBoxServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxServiceStatusResponse>(req, "DescribeWhiteBoxServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a master key. The disabled key cannot be used for encryption and decryption operations.
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
        public Task<DisableKeyResponse> DisableKey(DisableKeyRequest req)
        {
            return InternalRequestAsync<DisableKeyResponse>(req, "DisableKey");
        }

        /// <summary>
        /// This API is used to disable a master key. The disabled key cannot be used for encryption and decryption operations.
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
        public DisableKeyResponse DisableKeySync(DisableKeyRequest req)
        {
            return InternalRequestAsync<DisableKeyResponse>(req, "DisableKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disabled key rotation for the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
        public Task<DisableKeyRotationResponse> DisableKeyRotation(DisableKeyRotationRequest req)
        {
            return InternalRequestAsync<DisableKeyRotationResponse>(req, "DisableKeyRotation");
        }

        /// <summary>
        /// Disabled key rotation for the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
        public DisableKeyRotationResponse DisableKeyRotationSync(DisableKeyRotationRequest req)
        {
            return InternalRequestAsync<DisableKeyRotationResponse>(req, "DisableKeyRotation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch prohibit the use of CMK.
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
        public Task<DisableKeysResponse> DisableKeys(DisableKeysRequest req)
        {
            return InternalRequestAsync<DisableKeysResponse>(req, "DisableKeys");
        }

        /// <summary>
        /// This API is used to batch prohibit the use of CMK.
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
        public DisableKeysResponse DisableKeysSync(DisableKeysRequest req)
        {
            return InternalRequestAsync<DisableKeysResponse>(req, "DisableKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public Task<DisableWhiteBoxKeyResponse> DisableWhiteBoxKey(DisableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeyResponse>(req, "DisableWhiteBoxKey");
        }

        /// <summary>
        /// This API is used to disable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public DisableWhiteBoxKeyResponse DisableWhiteBoxKeySync(DisableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeyResponse>(req, "DisableWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public Task<DisableWhiteBoxKeysResponse> DisableWhiteBoxKeys(DisableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeysResponse>(req, "DisableWhiteBoxKeys");
        }

        /// <summary>
        /// This API is used to disable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public DisableWhiteBoxKeysResponse DisableWhiteBoxKeysSync(DisableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeysResponse>(req, "DisableWhiteBoxKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable a specified CMK.
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
        public Task<EnableKeyResponse> EnableKey(EnableKeyRequest req)
        {
            return InternalRequestAsync<EnableKeyResponse>(req, "EnableKey");
        }

        /// <summary>
        /// Enable a specified CMK.
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
        public EnableKeyResponse EnableKeySync(EnableKeyRequest req)
        {
            return InternalRequestAsync<EnableKeyResponse>(req, "EnableKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Turn on the key rotation function for the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
        public Task<EnableKeyRotationResponse> EnableKeyRotation(EnableKeyRotationRequest req)
        {
            return InternalRequestAsync<EnableKeyRotationResponse>(req, "EnableKeyRotation");
        }

        /// <summary>
        /// Turn on the key rotation function for the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
        public EnableKeyRotationResponse EnableKeyRotationSync(EnableKeyRotationRequest req)
        {
            return InternalRequestAsync<EnableKeyRotationResponse>(req, "EnableKeyRotation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable CMK in batches.
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
        public Task<EnableKeysResponse> EnableKeys(EnableKeysRequest req)
        {
            return InternalRequestAsync<EnableKeysResponse>(req, "EnableKeys");
        }

        /// <summary>
        /// This API is used to enable CMK in batches.
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
        public EnableKeysResponse EnableKeysSync(EnableKeysRequest req)
        {
            return InternalRequestAsync<EnableKeysResponse>(req, "EnableKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public Task<EnableWhiteBoxKeyResponse> EnableWhiteBoxKey(EnableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeyResponse>(req, "EnableWhiteBoxKey");
        }

        /// <summary>
        /// This API is used to enable a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public EnableWhiteBoxKeyResponse EnableWhiteBoxKeySync(EnableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeyResponse>(req, "EnableWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public Task<EnableWhiteBoxKeysResponse> EnableWhiteBoxKeys(EnableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeysResponse>(req, "EnableWhiteBoxKeys");
        }

        /// <summary>
        /// This API is used to enable white-box keys in batches.
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public EnableWhiteBoxKeysResponse EnableWhiteBoxKeysSync(EnableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeysResponse>(req, "EnableWhiteBoxKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to encrypt any data up to 4KB. It can be used to encrypt database passwords, RSA Key, or other small sensitive information. For application data encryption, use the DataKey generated by GenerateDataKey to perform local data encryption and decryption operations
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
        public Task<EncryptResponse> Encrypt(EncryptRequest req)
        {
            return InternalRequestAsync<EncryptResponse>(req, "Encrypt");
        }

        /// <summary>
        /// This API is used to encrypt any data up to 4KB. It can be used to encrypt database passwords, RSA Key, or other small sensitive information. For application data encryption, use the DataKey generated by GenerateDataKey to perform local data encryption and decryption operations
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
        public EncryptResponse EncryptSync(EncryptRequest req)
        {
            return InternalRequestAsync<EncryptResponse>(req, "Encrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to encrypt data with a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public Task<EncryptByWhiteBoxResponse> EncryptByWhiteBox(EncryptByWhiteBoxRequest req)
        {
            return InternalRequestAsync<EncryptByWhiteBoxResponse>(req, "EncryptByWhiteBox");
        }

        /// <summary>
        /// This API is used to encrypt data with a white-box key.
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public EncryptByWhiteBoxResponse EncryptByWhiteBoxSync(EncryptByWhiteBoxRequest req)
        {
            return InternalRequestAsync<EncryptByWhiteBoxResponse>(req, "EncryptByWhiteBox")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API generates a data key, which you can use to encrypt local data.
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
        public Task<GenerateDataKeyResponse> GenerateDataKey(GenerateDataKeyRequest req)
        {
            return InternalRequestAsync<GenerateDataKeyResponse>(req, "GenerateDataKey");
        }

        /// <summary>
        /// This API generates a data key, which you can use to encrypt local data.
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
        public GenerateDataKeyResponse GenerateDataKeySync(GenerateDataKeyRequest req)
        {
            return InternalRequestAsync<GenerateDataKeyResponse>(req, "GenerateDataKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a random number.
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
        public Task<GenerateRandomResponse> GenerateRandom(GenerateRandomRequest req)
        {
            return InternalRequestAsync<GenerateRandomResponse>(req, "GenerateRandom");
        }

        /// <summary>
        /// This API is used to generate a random number.
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
        public GenerateRandomResponse GenerateRandomSync(GenerateRandomRequest req)
        {
            return InternalRequestAsync<GenerateRandomResponse>(req, "GenerateRandom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query whether the specified CMK has the key rotation function.
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
        public Task<GetKeyRotationStatusResponse> GetKeyRotationStatus(GetKeyRotationStatusRequest req)
        {
            return InternalRequestAsync<GetKeyRotationStatusResponse>(req, "GetKeyRotationStatus");
        }

        /// <summary>
        /// Query whether the specified CMK has the key rotation function.
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
        public GetKeyRotationStatusResponse GetKeyRotationStatusSync(GetKeyRotationStatusRequest req)
        {
            return InternalRequestAsync<GetKeyRotationStatusResponse>(req, "GetKeyRotationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the parameters of the material to be imported into a CMK. The returned `Token` is used as one of the parameters to execute `ImportKeyMaterial`, and the returned `PublicKey` is used to encrypt the key material. The `Token` and `PublicKey` are valid for 24 hours. If they are expired, you will need to call the API again to get a new `Token` and `PublicKey`.
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
        public Task<GetParametersForImportResponse> GetParametersForImport(GetParametersForImportRequest req)
        {
            return InternalRequestAsync<GetParametersForImportResponse>(req, "GetParametersForImport");
        }

        /// <summary>
        /// This API is used to obtain the parameters of the material to be imported into a CMK. The returned `Token` is used as one of the parameters to execute `ImportKeyMaterial`, and the returned `PublicKey` is used to encrypt the key material. The `Token` and `PublicKey` are valid for 24 hours. If they are expired, you will need to call the API again to get a new `Token` and `PublicKey`.
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
        public GetParametersForImportResponse GetParametersForImportSync(GetParametersForImportRequest req)
        {
            return InternalRequestAsync<GetParametersForImportResponse>(req, "GetParametersForImport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the public key of an asymmetric KMS key (which must be enabled). With the public key, you can encrypt messages and verify signatures.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey");
        }

        /// <summary>
        /// This API is used to get the public key of an asymmetric KMS key (which must be enabled). With the public key, you can encrypt messages and verify signatures.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return all regions support KMS service.
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public Task<GetRegionsResponse> GetRegions(GetRegionsRequest req)
        {
            return InternalRequestAsync<GetRegionsResponse>(req, "GetRegions");
        }

        /// <summary>
        /// This API is used to return all regions support KMS service.
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public GetRegionsResponse GetRegionsSync(GetRegionsRequest req)
        {
            return InternalRequestAsync<GetRegionsResponse>(req, "GetRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to query whether the user has activated the KMS service.
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public Task<GetServiceStatusResponse> GetServiceStatus(GetServiceStatusRequest req)
        {
            return InternalRequestAsync<GetServiceStatusResponse>(req, "GetServiceStatus");
        }

        /// <summary>
        /// Used to query whether the user has activated the KMS service.
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public GetServiceStatusResponse GetServiceStatusSync(GetServiceStatusRequest req)
        {
            return InternalRequestAsync<GetServiceStatusResponse>(req, "GetServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import key material into an EXTERNAL CMK. The key obtained through the `GetParametersForImport` API is used to encrypt the key material. You can only reimport the same key material into the specified CMK and set a new expiration time. After the CMK key material is imported, it cannot be replaced. After the key material is expired or deleted, the CMK will remain unavailable until the same key material is reimported. CMKs are independent, which means that the same key material can be imported into different CMKs, but data encrypted by one CMK cannot be decrypted by another one.
        /// Key material can only be imported into CMKs in `Enabled` and `PendingImport` status.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
        public Task<ImportKeyMaterialResponse> ImportKeyMaterial(ImportKeyMaterialRequest req)
        {
            return InternalRequestAsync<ImportKeyMaterialResponse>(req, "ImportKeyMaterial");
        }

        /// <summary>
        /// This API is used to import key material into an EXTERNAL CMK. The key obtained through the `GetParametersForImport` API is used to encrypt the key material. You can only reimport the same key material into the specified CMK and set a new expiration time. After the CMK key material is imported, it cannot be replaced. After the key material is expired or deleted, the CMK will remain unavailable until the same key material is reimported. CMKs are independent, which means that the same key material can be imported into different CMKs, but data encrypted by one CMK cannot be decrypted by another one.
        /// Key material can only be imported into CMKs in `Enabled` and `PendingImport` status.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
        public ImportKeyMaterialResponse ImportKeyMaterialSync(ImportKeyMaterialRequest req)
        {
            return InternalRequestAsync<ImportKeyMaterialResponse>(req, "ImportKeyMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the encryption methods supported in the current region.
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public Task<ListAlgorithmsResponse> ListAlgorithms(ListAlgorithmsRequest req)
        {
            return InternalRequestAsync<ListAlgorithmsResponse>(req, "ListAlgorithms");
        }

        /// <summary>
        /// This API is used to list the encryption methods supported in the current region.
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public ListAlgorithmsResponse ListAlgorithmsSync(ListAlgorithmsRequest req)
        {
            return InternalRequestAsync<ListAlgorithmsResponse>(req, "ListAlgorithms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the master key list details according to the specified Offset and Limit.
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
        public Task<ListKeyDetailResponse> ListKeyDetail(ListKeyDetailRequest req)
        {
            return InternalRequestAsync<ListKeyDetailResponse>(req, "ListKeyDetail");
        }

        /// <summary>
        /// Get the master key list details according to the specified Offset and Limit.
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
        public ListKeyDetailResponse ListKeyDetailSync(ListKeyDetailRequest req)
        {
            return InternalRequestAsync<ListKeyDetailResponse>(req, "ListKeyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the KeyIds of CMKs in `Enabled`, `Disabled`, and `PendingImport` status under the account.
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
        public Task<ListKeysResponse> ListKeys(ListKeysRequest req)
        {
            return InternalRequestAsync<ListKeysResponse>(req, "ListKeys");
        }

        /// <summary>
        /// This API is used to list the KeyIds of CMKs in `Enabled`, `Disabled`, and `PendingImport` status under the account.
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
        public ListKeysResponse ListKeysSync(ListKeysRequest req)
        {
            return InternalRequestAsync<ListKeysResponse>(req, "ListKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to overwrite the device fingerprint information of a specified key.
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public Task<OverwriteWhiteBoxDeviceFingerprintsResponse> OverwriteWhiteBoxDeviceFingerprints(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<OverwriteWhiteBoxDeviceFingerprintsResponse>(req, "OverwriteWhiteBoxDeviceFingerprints");
        }

        /// <summary>
        /// This API is used to overwrite the device fingerprint information of a specified key.
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public OverwriteWhiteBoxDeviceFingerprintsResponse OverwriteWhiteBoxDeviceFingerprintsSync(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<OverwriteWhiteBoxDeviceFingerprintsResponse>(req, "OverwriteWhiteBoxDeviceFingerprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to decrypt ciphertext using post-quantum cryptography (PQC) algorithm, and return the plaintext.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoDecryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoDecryptResponse"/></returns>
        public Task<PostQuantumCryptoDecryptResponse> PostQuantumCryptoDecrypt(PostQuantumCryptoDecryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoDecryptResponse>(req, "PostQuantumCryptoDecrypt");
        }

        /// <summary>
        /// This API is used to decrypt ciphertext using post-quantum cryptography (PQC) algorithm, and return the plaintext.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoDecryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoDecryptResponse"/></returns>
        public PostQuantumCryptoDecryptResponse PostQuantumCryptoDecryptSync(PostQuantumCryptoDecryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoDecryptResponse>(req, "PostQuantumCryptoDecrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to encrypt using PQC. It supports up to 4 KB of data. It is applicable for encryption of database passwords, RSA keys, or other sensitive information. You can also apply `DataKey` generated by API `GenerateDataKey` to encrypt or decrypt your local data.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoEncryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoEncryptResponse"/></returns>
        public Task<PostQuantumCryptoEncryptResponse> PostQuantumCryptoEncrypt(PostQuantumCryptoEncryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoEncryptResponse>(req, "PostQuantumCryptoEncrypt");
        }

        /// <summary>
        /// This API is used to encrypt using PQC. It supports up to 4 KB of data. It is applicable for encryption of database passwords, RSA keys, or other sensitive information. You can also apply `DataKey` generated by API `GenerateDataKey` to encrypt or decrypt your local data.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoEncryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoEncryptResponse"/></returns>
        public PostQuantumCryptoEncryptResponse PostQuantumCryptoEncryptSync(PostQuantumCryptoEncryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoEncryptResponse>(req, "PostQuantumCryptoEncrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to sign using PQC.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoSignRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoSignResponse"/></returns>
        public Task<PostQuantumCryptoSignResponse> PostQuantumCryptoSign(PostQuantumCryptoSignRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoSignResponse>(req, "PostQuantumCryptoSign");
        }

        /// <summary>
        /// This API is used to sign using PQC.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoSignRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoSignResponse"/></returns>
        public PostQuantumCryptoSignResponse PostQuantumCryptoSignSync(PostQuantumCryptoSignRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoSignResponse>(req, "PostQuantumCryptoSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a signature using PQC.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoVerifyRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoVerifyResponse"/></returns>
        public Task<PostQuantumCryptoVerifyResponse> PostQuantumCryptoVerify(PostQuantumCryptoVerifyRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoVerifyResponse>(req, "PostQuantumCryptoVerify");
        }

        /// <summary>
        /// This API is used to verify a signature using PQC.
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoVerifyRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoVerifyResponse"/></returns>
        public PostQuantumCryptoVerifyResponse PostQuantumCryptoVerifySync(PostQuantumCryptoVerifyRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoVerifyResponse>(req, "PostQuantumCryptoVerify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Re-encrypt the ciphertext using the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
        public Task<ReEncryptResponse> ReEncrypt(ReEncryptRequest req)
        {
            return InternalRequestAsync<ReEncryptResponse>(req, "ReEncrypt");
        }

        /// <summary>
        /// Re-encrypt the ciphertext using the specified CMK.
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
        public ReEncryptResponse ReEncryptSync(ReEncryptRequest req)
        {
            return InternalRequestAsync<ReEncryptResponse>(req, "ReEncrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CMK planned deletion API, used to specify the time of CMK deletion, the optional time interval is [7,30] days
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
        public Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletion(ScheduleKeyDeletionRequest req)
        {
            return InternalRequestAsync<ScheduleKeyDeletionResponse>(req, "ScheduleKeyDeletion");
        }

        /// <summary>
        /// CMK planned deletion API, used to specify the time of CMK deletion, the optional time interval is [7,30] days
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletionSync(ScheduleKeyDeletionRequest req)
        {
            return InternalRequestAsync<ScheduleKeyDeletionResponse>(req, "ScheduleKeyDeletion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a signature with an asymmetric key.
        /// Note that only when KeyUsage is `ASYMMETRIC_SIGN_VERIFY_${ALGORITHM}` (e.g., `ASYMMETRIC_SIGN_VERIFY_SM2` and `ASYMMETRIC_SIGN_VERIFY_ECC`), the key can be used for signing.
        /// </summary>
        /// <param name="req"><see cref="SignByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="SignByAsymmetricKeyResponse"/></returns>
        public Task<SignByAsymmetricKeyResponse> SignByAsymmetricKey(SignByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<SignByAsymmetricKeyResponse>(req, "SignByAsymmetricKey");
        }

        /// <summary>
        /// This API is used to generate a signature with an asymmetric key.
        /// Note that only when KeyUsage is `ASYMMETRIC_SIGN_VERIFY_${ALGORITHM}` (e.g., `ASYMMETRIC_SIGN_VERIFY_SM2` and `ASYMMETRIC_SIGN_VERIFY_ECC`), the key can be used for signing.
        /// </summary>
        /// <param name="req"><see cref="SignByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="SignByAsymmetricKeyResponse"/></returns>
        public SignByAsymmetricKeyResponse SignByAsymmetricKeySync(SignByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<SignByAsymmetricKeyResponse>(req, "SignByAsymmetricKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a key with a Tencent Cloud resource, indicating that the Tencent Cloud resource will not use the key any longer.
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public Task<UnbindCloudResourceResponse> UnbindCloudResource(UnbindCloudResourceRequest req)
        {
            return InternalRequestAsync<UnbindCloudResourceResponse>(req, "UnbindCloudResource");
        }

        /// <summary>
        /// This API is used to unbind a key with a Tencent Cloud resource, indicating that the Tencent Cloud resource will not use the key any longer.
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public UnbindCloudResourceResponse UnbindCloudResourceSync(UnbindCloudResourceRequest req)
        {
            return InternalRequestAsync<UnbindCloudResourceResponse>(req, "UnbindCloudResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the alias of a CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias");
        }

        /// <summary>
        /// This API is used to modify the alias of a CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the description of the specified CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
        public Task<UpdateKeyDescriptionResponse> UpdateKeyDescription(UpdateKeyDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateKeyDescriptionResponse>(req, "UpdateKeyDescription");
        }

        /// <summary>
        /// This API is used to modify the description of the specified CMK. CMKs in `PendingDelete` status cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
        public UpdateKeyDescriptionResponse UpdateKeyDescriptionSync(UpdateKeyDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateKeyDescriptionResponse>(req, "UpdateKeyDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a signature with an asymmetric key.
        /// </summary>
        /// <param name="req"><see cref="VerifyByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="VerifyByAsymmetricKeyResponse"/></returns>
        public Task<VerifyByAsymmetricKeyResponse> VerifyByAsymmetricKey(VerifyByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<VerifyByAsymmetricKeyResponse>(req, "VerifyByAsymmetricKey");
        }

        /// <summary>
        /// This API is used to verify a signature with an asymmetric key.
        /// </summary>
        /// <param name="req"><see cref="VerifyByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="VerifyByAsymmetricKeyResponse"/></returns>
        public VerifyByAsymmetricKeyResponse VerifyByAsymmetricKeySync(VerifyByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<VerifyByAsymmetricKeyResponse>(req, "VerifyByAsymmetricKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
