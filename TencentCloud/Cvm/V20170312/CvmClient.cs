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

namespace TencentCloud.Cvm.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cvm.V20170312.Models;

   public class CvmClient : AbstractClient{

       private const string endpoint = "cvm.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CvmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CvmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create CDH instances with specified configuration.
        /// * When HostChargeType is PREPAID, the HostChargePrepaid parameter must be specified.
        /// </summary>
        /// <param name="req"><see cref="AllocateHostsRequest"/></param>
        /// <returns><see cref="AllocateHostsResponse"/></returns>
        public async Task<AllocateHostsResponse> AllocateHosts(AllocateHostsRequest req)
        {
             JsonResponseModel<AllocateHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create CDH instances with specified configuration.
        /// * When HostChargeType is PREPAID, the HostChargePrepaid parameter must be specified.
        /// </summary>
        /// <param name="req"><see cref="AllocateHostsRequest"/></param>
        /// <returns><see cref="AllocateHostsResponse"/></returns>
        public AllocateHostsResponse AllocateHostsSync(AllocateHostsRequest req)
        {
             JsonResponseModel<AllocateHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate key pairs with instances.
        /// 
        /// * If the public key of a key pair is written to the `SSH` configuration of the instance, users will be able to log in to the instance with the private key of the key pair.
        /// * If the instance is already associated with a key, the old key will become invalid.
        /// If you currently use a password to log in, you will no longer be able to do so after you associate the instance with a key.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If any instance in the request cannot be associated with a key, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public async Task<AssociateInstancesKeyPairsResponse> AssociateInstancesKeyPairs(AssociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate key pairs with instances.
        /// 
        /// * If the public key of a key pair is written to the `SSH` configuration of the instance, users will be able to log in to the instance with the private key of the key pair.
        /// * If the instance is already associated with a key, the old key will become invalid.
        /// If you currently use a password to log in, you will no longer be able to do so after you associate the instance with a key.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If any instance in the request cannot be associated with a key, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public AssociateInstancesKeyPairsResponse AssociateInstancesKeyPairsSync(AssociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate security groups with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate security groups with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a [spread placement group](https://cloud.tencent.com/document/product/213/15486). After you create one, you can specify it for an instance when you [create the instance](https://cloud.tencent.com/document/api/213/15730), 
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoverGroupRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoverGroupResponse"/></returns>
        public async Task<CreateDisasterRecoverGroupResponse> CreateDisasterRecoverGroup(CreateDisasterRecoverGroupRequest req)
        {
             JsonResponseModel<CreateDisasterRecoverGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDisasterRecoverGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisasterRecoverGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a [spread placement group](https://cloud.tencent.com/document/product/213/15486). After you create one, you can specify it for an instance when you [create the instance](https://cloud.tencent.com/document/api/213/15730), 
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoverGroupRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoverGroupResponse"/></returns>
        public CreateDisasterRecoverGroupResponse CreateDisasterRecoverGroupSync(CreateDisasterRecoverGroupRequest req)
        {
             JsonResponseModel<CreateDisasterRecoverGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDisasterRecoverGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisasterRecoverGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a new image with the system disk of an instance. The image can be used to create new instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public async Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a new image with the system disk of an instance. The image can be used to create new instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which you can use to log in to a `Linux` instance.
        /// 
        /// * You only need to specify a name, and the system will automatically create a key pair and return its `ID` and the public and private keys.
        /// * The name of the key pair must be unique.
        /// * You can save the private key to a file and use it as an authentication method for `SSH`.
        /// * Tencent Cloud does not save users’ private keys. Be sure to save it yourself.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public async Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which you can use to log in to a `Linux` instance.
        /// 
        /// * You only need to specify a name, and the system will automatically create a key pair and return its `ID` and the public and private keys.
        /// * The name of the key pair must be unique.
        /// * You can save the private key to a file and use it as an authentication method for `SSH`.
        /// * Tencent Cloud does not save users’ private keys. Be sure to save it yourself.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a [spread placement group](https://cloud.tencent.com/document/product/213/15486). Only empty placement groups can be deleted. To delete a non-empty group, you need to terminate all the CVM instances in it first. Otherwise, the deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoverGroupsResponse"/></returns>
        public async Task<DeleteDisasterRecoverGroupsResponse> DeleteDisasterRecoverGroups(DeleteDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DeleteDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a [spread placement group](https://cloud.tencent.com/document/product/213/15486). Only empty placement groups can be deleted. To delete a non-empty group, you need to terminate all the CVM instances in it first. Otherwise, the deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoverGroupsResponse"/></returns>
        public DeleteDisasterRecoverGroupsResponse DeleteDisasterRecoverGroupsSync(DeleteDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DeleteDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete images.
        /// 
        /// * If the [ImageState](https://cloud.tencent.com/document/api/213/9452#image_state) of an image is `Creating` or `In Use`, it cannot be deleted. Use [DescribeImages](https://cloud.tencent.com/document/api/213/9418) to query the image state.
        /// * You can only create up to 10 custom images in each region. If you have used up the quota, you can delete images to create new ones.
        /// * A shared image cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteImagesRequest"/></param>
        /// <returns><see cref="DeleteImagesResponse"/></returns>
        public async Task<DeleteImagesResponse> DeleteImages(DeleteImagesRequest req)
        {
             JsonResponseModel<DeleteImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete images.
        /// 
        /// * If the [ImageState](https://cloud.tencent.com/document/api/213/9452#image_state) of an image is `Creating` or `In Use`, it cannot be deleted. Use [DescribeImages](https://cloud.tencent.com/document/api/213/9418) to query the image state.
        /// * You can only create up to 10 custom images in each region. If you have used up the quota, you can delete images to create new ones.
        /// * A shared image cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteImagesRequest"/></param>
        /// <returns><see cref="DeleteImagesResponse"/></returns>
        public DeleteImagesResponse DeleteImagesSync(DeleteImagesRequest req)
        {
             JsonResponseModel<DeleteImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the key pairs hosted in Tencent Cloud.
        /// 
        /// * You can delete multiple key pairs at the same time.
        /// * A key pair used by an instance or image cannot be deleted. Therefore, you need to verify whether all the key pairs have been deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairs(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the key pairs hosted in Tencent Cloud.
        /// 
        /// * You can delete multiple key pairs at the same time.
        /// * A key pair used by an instance or image cannot be deleted. Therefore, you need to verify whether all the key pairs have been deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public DeleteKeyPairsResponse DeleteKeyPairsSync(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota of [spread placement groups](https://cloud.tencent.com/document/product/213/15486).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupQuotaRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupQuotaResponse"/></returns>
        public async Task<DescribeDisasterRecoverGroupQuotaResponse> DescribeDisasterRecoverGroupQuota(DescribeDisasterRecoverGroupQuotaRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisasterRecoverGroupQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota of [spread placement groups](https://cloud.tencent.com/document/product/213/15486).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupQuotaRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupQuotaResponse"/></returns>
        public DescribeDisasterRecoverGroupQuotaResponse DescribeDisasterRecoverGroupQuotaSync(DescribeDisasterRecoverGroupQuotaRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisasterRecoverGroupQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information on [spread placement groups](https://cloud.tencent.com/document/product/213/15486).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupsResponse"/></returns>
        public async Task<DescribeDisasterRecoverGroupsResponse> DescribeDisasterRecoverGroups(DescribeDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information on [spread placement groups](https://cloud.tencent.com/document/product/213/15486).
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupsResponse"/></returns>
        public DescribeDisasterRecoverGroupsResponse DescribeDisasterRecoverGroupsSync(DescribeDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of CDH instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public async Task<DescribeHostsResponse> DescribeHosts(DescribeHostsRequest req)
        {
             JsonResponseModel<DescribeHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of CDH instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public DescribeHostsResponse DescribeHostsSync(DescribeHostsRequest req)
        {
             JsonResponseModel<DescribeHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the image quota of an user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageQuotaRequest"/></param>
        /// <returns><see cref="DescribeImageQuotaResponse"/></returns>
        public async Task<DescribeImageQuotaResponse> DescribeImageQuota(DescribeImageQuotaRequest req)
        {
             JsonResponseModel<DescribeImageQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the image quota of an user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageQuotaRequest"/></param>
        /// <returns><see cref="DescribeImageQuotaResponse"/></returns>
        public DescribeImageQuotaResponse DescribeImageQuotaSync(DescribeImageQuotaRequest req)
        {
             JsonResponseModel<DescribeImageQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query image sharing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeImageSharePermissionResponse"/></returns>
        public async Task<DescribeImageSharePermissionResponse> DescribeImageSharePermission(DescribeImageSharePermissionRequest req)
        {
             JsonResponseModel<DescribeImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query image sharing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeImageSharePermissionResponse"/></returns>
        public DescribeImageSharePermissionResponse DescribeImageSharePermissionSync(DescribeImageSharePermissionRequest req)
        {
             JsonResponseModel<DescribeImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the list of images.
        /// 
        /// * You specify the image ID or set filters to query the details of certain images.
        /// * You can specify `Offset` and `Limit` to select a certain part of the results. By default, the information on the first 20 matching results is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the list of images.
        /// 
        /// * You specify the image ID or set filters to query the details of certain images.
        /// * You can specify `Offset` and `Limit` to select a certain part of the results. By default, the information on the first 20 matching results is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of supported operating systems of imported images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public async Task<DescribeImportImageOsResponse> DescribeImportImageOs(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of supported operating systems of imported images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public DescribeImportImageOsResponse DescribeImportImageOsSync(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a list of model families available to the current user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFamilyConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceFamilyConfigsResponse"/></returns>
        public async Task<DescribeInstanceFamilyConfigsResponse> DescribeInstanceFamilyConfigs(DescribeInstanceFamilyConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceFamilyConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceFamilyConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceFamilyConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a list of model families available to the current user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFamilyConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceFamilyConfigsResponse"/></returns>
        public DescribeInstanceFamilyConfigsResponse DescribeInstanceFamilyConfigsSync(DescribeInstanceFamilyConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceFamilyConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceFamilyConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceFamilyConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the model configuration of an instance.
        /// 
        /// * You can filter the query results with `zone` or `instance-family`. For more information on filtering conditions, see `Filter`.
        /// * If no parameter is defined, the model configuration of all the instances in the specified region will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigsResponse"/></returns>
        public async Task<DescribeInstanceTypeConfigsResponse> DescribeInstanceTypeConfigs(DescribeInstanceTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the model configuration of an instance.
        /// 
        /// * You can filter the query results with `zone` or `instance-family`. For more information on filtering conditions, see `Filter`.
        /// * If no parameter is defined, the model configuration of all the instances in the specified region will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigsResponse"/></returns>
        public DescribeInstanceTypeConfigsResponse DescribeInstanceTypeConfigsSync(DescribeInstanceTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the VNC URL of an instance.
        /// 
        /// * It does not support `STOPPED` CVMs.
        /// * A VNC URL is only valid for 15 sec. If you do not access the URL within 15 seconds, it will become invalid and you will have to query another one.
        /// * Once you access a VNC URL, it will become invalid and you will have to query another one.
        /// * If the connection breaks up, you can make up to 30 requests per minute to reestablish the connection.
        /// * After you get the value of `InstanceVncUrl`, you need to append `InstanceVncUrl=xxxx` to the end of the link <https://img.qcloud.com/qcloud/app/active_vnc/index.html?>.
        ///   - Parameter `InstanceVncUrl`: the value of `InstanceVncUrl` returned after a successful API call.
        /// 
        ///     The final URLs are in the following format:
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the VNC URL of an instance.
        /// 
        /// * It does not support `STOPPED` CVMs.
        /// * A VNC URL is only valid for 15 sec. If you do not access the URL within 15 seconds, it will become invalid and you will have to query another one.
        /// * Once you access a VNC URL, it will become invalid and you will have to query another one.
        /// * If the connection breaks up, you can make up to 30 requests per minute to reestablish the connection.
        /// * After you get the value of `InstanceVncUrl`, you need to append `InstanceVncUrl=xxxx` to the end of the link <https://img.qcloud.com/qcloud/app/active_vnc/index.html?>.
        ///   - Parameter `InstanceVncUrl`: the value of `InstanceVncUrl` returned after a successful API call.
        /// 
        ///     The final URLs are in the following format:
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of instances.
        /// 
        /// * You can filter the query results with the instance `ID`, name, or billing method. See `Filter` for more information.
        /// * If no parameter is defined, a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of instances.
        /// 
        /// * You can filter the query results with the instance `ID`, name, or billing method. See `Filter` for more information.
        /// * If no parameter is defined, a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query limitations on operations on an instance.
        /// 
        /// * Currently you can use this API to query the maximum number of times you can modify the configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesOperationLimitRequest"/></param>
        /// <returns><see cref="DescribeInstancesOperationLimitResponse"/></returns>
        public async Task<DescribeInstancesOperationLimitResponse> DescribeInstancesOperationLimit(DescribeInstancesOperationLimitRequest req)
        {
             JsonResponseModel<DescribeInstancesOperationLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesOperationLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesOperationLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query limitations on operations on an instance.
        /// 
        /// * Currently you can use this API to query the maximum number of times you can modify the configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesOperationLimitRequest"/></param>
        /// <returns><see cref="DescribeInstancesOperationLimitResponse"/></returns>
        public DescribeInstancesOperationLimitResponse DescribeInstancesOperationLimitSync(DescribeInstancesOperationLimitRequest req)
        {
             JsonResponseModel<DescribeInstancesOperationLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesOperationLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesOperationLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of instances.
        /// 
        /// * You can query the status of an instance with its `ID`.
        /// * If no parameter is defined, the status of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesStatusResponse"/></returns>
        public async Task<DescribeInstancesStatusResponse> DescribeInstancesStatus(DescribeInstancesStatusRequest req)
        {
             JsonResponseModel<DescribeInstancesStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of instances.
        /// 
        /// * You can query the status of an instance with its `ID`.
        /// * If no parameter is defined, the status of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesStatusResponse"/></returns>
        public DescribeInstancesStatusResponse DescribeInstancesStatusSync(DescribeInstancesStatusRequest req)
        {
             JsonResponseModel<DescribeInstancesStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the network billing methods.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetChargeTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInternetChargeTypeConfigsResponse"/></returns>
        public async Task<DescribeInternetChargeTypeConfigsResponse> DescribeInternetChargeTypeConfigs(DescribeInternetChargeTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInternetChargeTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternetChargeTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetChargeTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the network billing methods.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetChargeTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInternetChargeTypeConfigsResponse"/></returns>
        public DescribeInternetChargeTypeConfigsResponse DescribeInternetChargeTypeConfigsSync(DescribeInternetChargeTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInternetChargeTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternetChargeTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetChargeTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// 
        /// * A key pair is a pair of keys generated by an algorithm in which the public key is available to the public and the private key is available only to the user. You can use this API to query the public key but not the private key.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairs(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query key pairs.
        /// 
        /// * A key pair is a pair of keys generated by an algorithm in which the public key is available to the public and the private key is available only to the user. You can use this API to query the public key but not the private key.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public DescribeKeyPairsResponse DescribeKeyPairsSync(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configurations of models in an availability zone.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeZoneInstanceConfigInfosResponse"/></returns>
        public async Task<DescribeZoneInstanceConfigInfosResponse> DescribeZoneInstanceConfigInfos(DescribeZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configurations of models in an availability zone.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeZoneInstanceConfigInfosResponse"/></returns>
        public DescribeZoneInstanceConfigInfosResponse DescribeZoneInstanceConfigInfosSync(DescribeZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query availability zones.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query availability zones.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind one or more key pairs from one or more instances.
        /// 
        /// * It only supports [`STOPPED`](https://cloud.tencent.com/document/product/213/15753#InstanceStatus) Linux instances.
        /// * After a key pair is disassociated from an instance, you can log in to the instance with password.
        /// * If you did not set a password for the instance, you will not be able to log in via SSH after the unbinding. In this case, you can call [ResetInstancesPassword](https://cloud.tencent.com/document/api/213/15736) to set a login password.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If instances not available for the operation are selected, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public async Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind one or more key pairs from one or more instances.
        /// 
        /// * It only supports [`STOPPED`](https://cloud.tencent.com/document/product/213/15753#InstanceStatus) Linux instances.
        /// * After a key pair is disassociated from an instance, you can log in to the instance with password.
        /// * If you did not set a password for the instance, you will not be able to log in via SSH after the unbinding. In this case, you can call [ResetInstancesPassword](https://cloud.tencent.com/document/api/213/15736) to set a login password.
        /// * Batch operations are supported. The maximum number of instances in each request is 100. If instances not available for the operation are selected, you will get an error code.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disassociate security groups from instances.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disassociate security groups from instances.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import images. Imported images can be used to create instances. 
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public async Task<ImportImageResponse> ImportImage(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import images. Imported images can be used to create instances. 
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public ImportImageResponse ImportImageSync(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import key pairs.
        /// 
        /// * You can use this API to import key pairs to a user account, but the key pairs will not be automatically associated with any instance. You may use [AssociasteInstancesKeyPair](https://cloud.tencent.com/document/api/213/9404) to associate key pairs with instances.
        /// * You need to specify the names of the key pairs and the content of the public keys.
        /// * If you only have private keys, you can convert them to public keys with the `SSL` tool before importing them.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public async Task<ImportKeyPairResponse> ImportKeyPair(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import key pairs.
        /// 
        /// * You can use this API to import key pairs to a user account, but the key pairs will not be automatically associated with any instance. You may use [AssociasteInstancesKeyPair](https://cloud.tencent.com/document/api/213/9404) to associate key pairs with instances.
        /// * You need to specify the names of the key pairs and the content of the public keys.
        /// * If you only have private keys, you can convert them to public keys with the `SSL` tool before importing them.
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public ImportKeyPairResponse ImportKeyPairSync(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for reinstalling an instance.
        /// 
        /// * If you have specified the `ImageId` parameter, the price query is performed with the specified image. Otherwise, the image used by the current instance is used.
        /// * You can only query the price for reinstallation caused by switching between Linux and Windows OS. And the [system disk type](https://cloud.tencent.com/document/api/213/15753#SystemDisk) of the instance must be `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, this API only supports instances in Mainland China regions.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstanceResponse"/></returns>
        public async Task<InquiryPriceResetInstanceResponse> InquiryPriceResetInstance(InquiryPriceResetInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for reinstalling an instance.
        /// 
        /// * If you have specified the `ImageId` parameter, the price query is performed with the specified image. Otherwise, the image used by the current instance is used.
        /// * You can only query the price for reinstallation caused by switching between Linux and Windows OS. And the [system disk type](https://cloud.tencent.com/document/api/213/15753#SystemDisk) of the instance must be `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, this API only supports instances in Mainland China regions.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstanceResponse"/></returns>
        public InquiryPriceResetInstanceResponse InquiryPriceResetInstanceSync(InquiryPriceResetInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for upgrading the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://cloud.tencent.com/document/product/213/509).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. You can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesInternetMaxBandwidthResponse"/></returns>
        public async Task<InquiryPriceResetInstancesInternetMaxBandwidthResponse> InquiryPriceResetInstancesInternetMaxBandwidth(InquiryPriceResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for upgrading the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://cloud.tencent.com/document/product/213/509).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. You can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesInternetMaxBandwidthResponse"/></returns>
        public InquiryPriceResetInstancesInternetMaxBandwidthResponse InquiryPriceResetInstancesInternetMaxBandwidthSync(InquiryPriceResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for adjusting the instance model.
        /// 
        /// * Currently, you can only use this API to query the prices of instances whose [system disk type](https://cloud.tencent.com/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to query the prices of [CDH](https://cloud.tencent.com/document/product/416) instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesTypeRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesTypeResponse"/></returns>
        public async Task<InquiryPriceResetInstancesTypeResponse> InquiryPriceResetInstancesType(InquiryPriceResetInstancesTypeRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for adjusting the instance model.
        /// 
        /// * Currently, you can only use this API to query the prices of instances whose [system disk type](https://cloud.tencent.com/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to query the prices of [CDH](https://cloud.tencent.com/document/product/416) instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesTypeRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesTypeResponse"/></returns>
        public InquiryPriceResetInstancesTypeResponse InquiryPriceResetInstancesTypeSync(InquiryPriceResetInstancesTypeRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for expanding data disks of an instance.
        /// 
        /// * Currently, you can only use this API to query the price of non-elastic data disks whose [disk type](/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, you cannot use this API to query the price for [CDH](https://cloud.tencent.com/document/product/416) instances. *Also, you can only query the price of expanding one data disk at a time.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeInstanceDisksResponse"/></returns>
        public async Task<InquiryPriceResizeInstanceDisksResponse> InquiryPriceResizeInstanceDisks(InquiryPriceResizeInstanceDisksRequest req)
        {
             JsonResponseModel<InquiryPriceResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for expanding data disks of an instance.
        /// 
        /// * Currently, you can only use this API to query the price of non-elastic data disks whose [disk type](/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, you cannot use this API to query the price for [CDH](https://cloud.tencent.com/document/product/416) instances. *Also, you can only query the price of expanding one data disk at a time.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeInstanceDisksResponse"/></returns>
        public InquiryPriceResizeInstanceDisksResponse InquiryPriceResizeInstanceDisksSync(InquiryPriceResizeInstanceDisksRequest req)
        {
             JsonResponseModel<InquiryPriceResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of creating instances. You can only use this API for instances whose configuration is within the purchase limit. For more information, see [RunInstances](https://cloud.tencent.com/document/api/213/15730).
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceRunInstancesResponse"/></returns>
        public async Task<InquiryPriceRunInstancesResponse> InquiryPriceRunInstances(InquiryPriceRunInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceRunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of creating instances. You can only use this API for instances whose configuration is within the purchase limit. For more information, see [RunInstances](https://cloud.tencent.com/document/api/213/15730).
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceRunInstancesResponse"/></returns>
        public InquiryPriceRunInstancesResponse InquiryPriceRunInstancesSync(InquiryPriceRunInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceRunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of [spread placement groups](https://cloud.tencent.com/document/product/213/15486).
        /// </summary>
        /// <param name="req"><see cref="ModifyDisasterRecoverGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisasterRecoverGroupAttributeResponse"/></returns>
        public async Task<ModifyDisasterRecoverGroupAttributeResponse> ModifyDisasterRecoverGroupAttribute(ModifyDisasterRecoverGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisasterRecoverGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of [spread placement groups](https://cloud.tencent.com/document/product/213/15486).
        /// </summary>
        /// <param name="req"><see cref="ModifyDisasterRecoverGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisasterRecoverGroupAttributeResponse"/></returns>
        public ModifyDisasterRecoverGroupAttributeResponse ModifyDisasterRecoverGroupAttributeSync(ModifyDisasterRecoverGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisasterRecoverGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CDH instance, such as instance name and renewal flag. One of the two parameters, HostName and RenewFlag, must be set, but you cannot set both of them at the same time.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsAttributeRequest"/></param>
        /// <returns><see cref="ModifyHostsAttributeResponse"/></returns>
        public async Task<ModifyHostsAttributeResponse> ModifyHostsAttribute(ModifyHostsAttributeRequest req)
        {
             JsonResponseModel<ModifyHostsAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHostsAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CDH instance, such as instance name and renewal flag. One of the two parameters, HostName and RenewFlag, must be set, but you cannot set both of them at the same time.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsAttributeRequest"/></param>
        /// <returns><see cref="ModifyHostsAttributeResponse"/></returns>
        public ModifyHostsAttributeResponse ModifyHostsAttributeSync(ModifyHostsAttributeRequest req)
        {
             JsonResponseModel<ModifyHostsAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHostsAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify image attributes.
        /// 
        /// * Attributes of shared images cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public async Task<ModifyImageAttributeResponse> ModifyImageAttribute(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify image attributes.
        /// 
        /// * Attributes of shared images cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public ModifyImageAttributeResponse ModifyImageAttributeSync(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify image sharing information.
        /// 
        /// * The accounts with which an image is shared can use the shared image to create instances.
        /// * Each custom image can be shared with up to 50 accounts.
        /// * You can use a shared image to create instances, but you cannot change its name and description.
        /// * If an image is shared with another account, the shared image will be in the same region as the original image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns><see cref="ModifyImageSharePermissionResponse"/></returns>
        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermission(ModifyImageSharePermissionRequest req)
        {
             JsonResponseModel<ModifyImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify image sharing information.
        /// 
        /// * The accounts with which an image is shared can use the shared image to create instances.
        /// * Each custom image can be shared with up to 50 accounts.
        /// * You can use a shared image to create instances, but you cannot change its name and description.
        /// * If an image is shared with another account, the shared image will be in the same region as the original image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns><see cref="ModifyImageSharePermissionResponse"/></returns>
        public ModifyImageSharePermissionResponse ModifyImageSharePermissionSync(ModifyImageSharePermissionRequest req)
        {
             JsonResponseModel<ModifyImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an instance. Currently you can only use the API to modify the name and the associated security groups of the instance.
        /// 
        /// * Instance names are used only for users’ convenience. Tencent Cloud does not use the name for ticket submission or instance management.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * When you change the security groups associated with an instance, the original security groups will be disassociated.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public async Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an instance. Currently you can only use the API to modify the name and the associated security groups of the instance.
        /// 
        /// * Instance names are used only for users’ convenience. Tencent Cloud does not use the name for ticket submission or instance management.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// * When you change the security groups associated with an instance, the original security groups will be disassociated.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the project to which an instance belongs.
        /// 
        /// * Project is a virtual concept. Users can create multiple projects under one account, manage different resources in each project, and assign different instances to different projects. You may use [`DescribeInstances`](https://cloud.tencent.com/document/api/213/15728) to query instances and use the project ID to filter results.
        /// * You cannot modify the project of an instance which is bound to a load balancer. You need to unbind the load balancer from the instance with [`DeregisterInstancesFromLoadBalancer`](https://cloud.tencent.com/document/api/214/1258) before using this API.
        /// * If you modify the project of an instance, security groups associated with the instance will be automatically disassociated. You can use [`ModifySecurityGroupsOfInstance`](https://cloud.tencent.com/document/api/213/1367) to associate the instance with certian security groups again.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyInstancesProjectResponse"/></returns>
        public async Task<ModifyInstancesProjectResponse> ModifyInstancesProject(ModifyInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the project to which an instance belongs.
        /// 
        /// * Project is a virtual concept. Users can create multiple projects under one account, manage different resources in each project, and assign different instances to different projects. You may use [`DescribeInstances`](https://cloud.tencent.com/document/api/213/15728) to query instances and use the project ID to filter results.
        /// * You cannot modify the project of an instance which is bound to a load balancer. You need to unbind the load balancer from the instance with [`DeregisterInstancesFromLoadBalancer`](https://cloud.tencent.com/document/api/214/1258) before using this API.
        /// * If you modify the project of an instance, security groups associated with the instance will be automatically disassociated. You can use [`ModifySecurityGroupsOfInstance`](https://cloud.tencent.com/document/api/213/1367) to associate the instance with certian security groups again.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyInstancesProjectResponse"/></returns>
        public ModifyInstancesProjectResponse ModifyInstancesProjectSync(ModifyInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC attributes of an instance, such as the VPC IP address.
        /// * By default, the instances will shut down when you perform this operation and restart upon completion.
        /// * If the specified VPC ID and subnet ID (the subnet must be in the same availability zone as the instance) are different from the VPC where the specified instance resides, the instance will be migrated to a subnet of the specified VPC. Before performing this operation, make sure that the specified instance is not bound with an [ENI](https://cloud.tencent.com/document/product/576) or [CLB](https://cloud.tencent.com/document/product/214).
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesVpcAttributeResponse"/></returns>
        public async Task<ModifyInstancesVpcAttributeResponse> ModifyInstancesVpcAttribute(ModifyInstancesVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC attributes of an instance, such as the VPC IP address.
        /// * By default, the instances will shut down when you perform this operation and restart upon completion.
        /// * If the specified VPC ID and subnet ID (the subnet must be in the same availability zone as the instance) are different from the VPC where the specified instance resides, the instance will be migrated to a subnet of the specified VPC. Before performing this operation, make sure that the specified instance is not bound with an [ENI](https://cloud.tencent.com/document/product/576) or [CLB](https://cloud.tencent.com/document/product/214).
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesVpcAttributeResponse"/></returns>
        public ModifyInstancesVpcAttributeResponse ModifyInstancesVpcAttributeSync(ModifyInstancesVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of key pairs.
        /// 
        /// * This API modifies the name and description of the key pair identified by the key pair ID.
        /// * The name of the key pair must be unique.
        /// * Key pair ID is the unique identifier of a key pair and cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyKeyPairAttributeResponse"/></returns>
        public async Task<ModifyKeyPairAttributeResponse> ModifyKeyPairAttribute(ModifyKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of key pairs.
        /// 
        /// * This API modifies the name and description of the key pair identified by the key pair ID.
        /// * The name of the key pair must be unique.
        /// * Key pair ID is the unique identifier of a key pair and cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyKeyPairAttributeResponse"/></returns>
        public ModifyKeyPairAttributeResponse ModifyKeyPairAttributeSync(ModifyKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * If the API is called successfully, the instance status will become `REBOOTING`. After the instance is restarted, its status will become `RUNNING` again.
        /// * Forced restart is supported. A forced restart is similar to switching off the power of a physical computer and starting it again. It may cause data loss or file system corruption. Be sure to only force start a CVM when it cannot be restarted normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public async Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * If the API is called successfully, the instance status will become `REBOOTING`. After the instance is restarted, its status will become `RUNNING` again.
        /// * Forced restart is supported. A forced restart is similar to switching off the power of a physical computer and starting it again. It may cause data loss or file system corruption. Be sure to only force start a CVM when it cannot be restarted normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reinstall the operating system of the specified instance.
        /// 
        /// * If you specify an `ImageId`, the specified image is used. Otherwise, the image used by the current instance is used.
        /// * The system disk will be formatted and reset. Therefore, make sure that no important files are stored on the system disk.
        /// * If the operating system switches between `Linux` and `Windows`, the system disk `ID` of the instance will change, and the snapshots that are associated with the system disk can no longer be used to roll back and restore data.
        /// * If no password is specified, you will get a random password via internal message.
        /// * You can only use this API to switch the operating system between `Linux` and `Windows` for instances whose [system disk type](https://cloud.tencent.com/document/api/213/9452#SystemDisk) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, this API only supports instances in Mainland China regions.
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public async Task<ResetInstanceResponse> ResetInstance(ResetInstanceRequest req)
        {
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reinstall the operating system of the specified instance.
        /// 
        /// * If you specify an `ImageId`, the specified image is used. Otherwise, the image used by the current instance is used.
        /// * The system disk will be formatted and reset. Therefore, make sure that no important files are stored on the system disk.
        /// * If the operating system switches between `Linux` and `Windows`, the system disk `ID` of the instance will change, and the snapshots that are associated with the system disk can no longer be used to roll back and restore data.
        /// * If no password is specified, you will get a random password via internal message.
        /// * You can only use this API to switch the operating system between `Linux` and `Windows` for instances whose [system disk type](https://cloud.tencent.com/document/api/213/9452#SystemDisk) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, this API only supports instances in Mainland China regions.
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public ResetInstanceResponse ResetInstanceSync(ResetInstanceRequest req)
        {
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://cloud.tencent.com/document/product/213/509).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. Users can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesInternetMaxBandwidthResponse"/></returns>
        public async Task<ResetInstancesInternetMaxBandwidthResponse> ResetInstancesInternetMaxBandwidth(ResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the public bandwidth cap of an instance.
        /// 
        /// * The allowed bandwidth cap varies for different models. For details, see [Purchasing Network Bandwidth](https://cloud.tencent.com/document/product/213/509).
        /// * For bandwidth billed by the `TRAFFIC_POSTPAID_BY_HOUR` method, changing the bandwidth cap through this API takes effect in real time. Users can increase or reduce bandwidth within applicable limits.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesInternetMaxBandwidthResponse"/></returns>
        public ResetInstancesInternetMaxBandwidthResponse ResetInstancesInternetMaxBandwidthSync(ResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password of the instance OS to a user-specified password.
        /// 
        /// * You can only use this API to modify the password of the administrator account. The name of the administrator account varies depending on the operating system. On Windows, it is `Administrator`; `Ubuntu`, `ubuntu`; `Linux`, `root`.)
        /// * To reset the password of a running instance, you need to explicitly specify the force shutdown parameter `ForceStop`. Otherwise, you can only reset passwords of instances that have been shut down.
        /// * Batch operations are supported. You can reset the passwords of multiple instances to the same one. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public async Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password of the instance OS to a user-specified password.
        /// 
        /// * You can only use this API to modify the password of the administrator account. The name of the administrator account varies depending on the operating system. On Windows, it is `Administrator`; `Ubuntu`, `ubuntu`; `Linux`, `root`.)
        /// * To reset the password of a running instance, you need to explicitly specify the force shutdown parameter `ForceStop`. Otherwise, you can only reset passwords of instances that have been shut down.
        /// * Batch operations are supported. You can reset the passwords of multiple instances to the same one. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the model of an instance.
        /// * You can only use this API to change the models of instances whose [system disk type](/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to change the models of [CDH](https://cloud.tencent.com/document/product/416) instances.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesTypeRequest"/></param>
        /// <returns><see cref="ResetInstancesTypeResponse"/></returns>
        public async Task<ResetInstancesTypeResponse> ResetInstancesType(ResetInstancesTypeRequest req)
        {
             JsonResponseModel<ResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the model of an instance.
        /// * You can only use this API to change the models of instances whose [system disk type](/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`.
        /// * Currently, you cannot use this API to change the models of [CDH](https://cloud.tencent.com/document/product/416) instances.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesTypeRequest"/></param>
        /// <returns><see cref="ResetInstancesTypeResponse"/></returns>
        public ResetInstancesTypeResponse ResetInstancesTypeSync(ResetInstancesTypeRequest req)
        {
             JsonResponseModel<ResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResizeInstanceDisks) is used to expand the data disks of an instance.
        /// 
        /// * Currently, you can only use the API to expand non-elastic data disks whose [disk type](/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, this API does not support [CDH](https://cloud.tencent.com/document/product/416) instances.
        /// * Currently, only one data disk can be expanded at a time.
        /// </summary>
        /// <param name="req"><see cref="ResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="ResizeInstanceDisksResponse"/></returns>
        public async Task<ResizeInstanceDisksResponse> ResizeInstanceDisks(ResizeInstanceDisksRequest req)
        {
             JsonResponseModel<ResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResizeInstanceDisks) is used to expand the data disks of an instance.
        /// 
        /// * Currently, you can only use the API to expand non-elastic data disks whose [disk type](/document/api/213/9452#block_device) is `CLOUD_BASIC`, `CLOUD_PREMIUM`, or `CLOUD_SSD`. You can use [`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315) to check whether a disk is elastic. If the `Portable` field in the response is `false`, it means that the disk is non-elastic.
        /// * Currently, this API does not support [CDH](https://cloud.tencent.com/document/product/416) instances.
        /// * Currently, only one data disk can be expanded at a time.
        /// </summary>
        /// <param name="req"><see cref="ResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="ResizeInstanceDisksResponse"/></returns>
        public ResizeInstanceDisksResponse ResizeInstanceDisksSync(ResizeInstanceDisksRequest req)
        {
             JsonResponseModel<ResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more instances with a specified configuration.
        /// 
        /// * After an instance is created successfully, it will start up automatically, and the [instance state](/document/api/213/9452#instance_state) will become "Running".
        /// * If you create a pay-as-you-go instance billed on an hourly basis, an amount equivalent to the hourly rate will be frozen before the creation. Make sure your account balance is sufficient before calling this API.
        /// * The number of instances you can purchase through this API is subject to the [CVM instance purchase limit](https://cloud.tencent.com/document/product/213/2664). Both the instances created through this API and the console will be counted toward the quota.
        /// * This API is an async API. An instance `ID` list will be returned after you successfully make a creation request. However, it does not mean the creation has been completed. The state of the instance will be `Creating` during the creation. You can use [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) to query the status of the instance. If the status changes from `Creating` to `Running`, it means that the instance has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public async Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more instances with a specified configuration.
        /// 
        /// * After an instance is created successfully, it will start up automatically, and the [instance state](/document/api/213/9452#instance_state) will become "Running".
        /// * If you create a pay-as-you-go instance billed on an hourly basis, an amount equivalent to the hourly rate will be frozen before the creation. Make sure your account balance is sufficient before calling this API.
        /// * The number of instances you can purchase through this API is subject to the [CVM instance purchase limit](https://cloud.tencent.com/document/product/213/2664). Both the instances created through this API and the console will be counted toward the quota.
        /// * This API is an async API. An instance `ID` list will be returned after you successfully make a creation request. However, it does not mean the creation has been completed. The state of the instance will be `Creating` during the creation. You can use [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) to query the status of the instance. If the status changes from `Creating` to `Running`, it means that the instance has been created successfully.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start instances.
        /// 
        /// * You can only perform this operation on instances whose status is `STOPPED`.
        /// * The instance status will become `STARTING` when the API is called successfully and `RUNNING` when the instance is successfully started.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public async Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start instances.
        /// 
        /// * You can only perform this operation on instances whose status is `STOPPED`.
        /// * The instance status will become `STARTING` when the API is called successfully and `RUNNING` when the instance is successfully started.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to shut down instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `STOPPING` when the API is called successfully and `STOPPED` when the instance is successfully shut down.
        /// * Forced shutdown is supported. A forced shutdown is similar to switching off the power of a physical computer. It may cause data loss or file system corruption. Be sure to only force shut down a CVM when it cannot be sht down normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public async Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to shut down instances.
        /// 
        /// * You can only perform this operation on instances whose status is `RUNNING`.
        /// * The instance status will become `STOPPING` when the API is called successfully and `STOPPED` when the instance is successfully shut down.
        /// * Forced shutdown is supported. A forced shutdown is similar to switching off the power of a physical computer. It may cause data loss or file system corruption. Be sure to only force shut down a CVM when it cannot be sht down normally.
        /// * Batch operations are supported. The maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sync a custom image to other regions.
        /// 
        /// * Each API call syncs a single image.
        /// * This API supports syncing an image to multiple regions.
        /// * Each account can have up to 10 custom images in each region. 
        /// </summary>
        /// <param name="req"><see cref="SyncImagesRequest"/></param>
        /// <returns><see cref="SyncImagesResponse"/></returns>
        public async Task<SyncImagesResponse> SyncImages(SyncImagesRequest req)
        {
             JsonResponseModel<SyncImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sync a custom image to other regions.
        /// 
        /// * Each API call syncs a single image.
        /// * This API supports syncing an image to multiple regions.
        /// * Each account can have up to 10 custom images in each region. 
        /// </summary>
        /// <param name="req"><see cref="SyncImagesRequest"/></param>
        /// <returns><see cref="SyncImagesResponse"/></returns>
        public SyncImagesResponse SyncImagesSync(SyncImagesRequest req)
        {
             JsonResponseModel<SyncImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return instances.
        /// 
        /// * Use this API to return instances that are no longer required.
        /// * Pay-as-you-go instances can be returned directly through this API.
        /// * When this API is called for the first time, the instance will be moved to the recycle bin. When this API is called for the second time, the instance will be terminated and cannot be recovered.
        /// * Batch operations are supported. The allowed maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public async Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return instances.
        /// 
        /// * Use this API to return instances that are no longer required.
        /// * Pay-as-you-go instances can be returned directly through this API.
        /// * When this API is called for the first time, the instance will be moved to the recycle bin. When this API is called for the second time, the instance will be terminated and cannot be recovered.
        /// * Batch operations are supported. The allowed maximum number of instances in each request is 100.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
